//
// GameWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using OpenTK.Core;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    /// The <see cref="GameWindow"/> class contains cross-platform methods to create and render on an OpenGL
    /// window, handle input and load resources.
    /// </summary>
    /// <remarks>
    /// <see cref="GameWindow"/> contains several events you can hook or override to add your custom logic:
    /// <list>
    /// <item>
    /// <see cref="OnLoad"/>: Occurs after creating the OpenGL context, but before entering the main loop.
    /// Override to load resources.
    /// </item>
    /// <item>
    /// <see cref="OnUnload"/>: Occurs after exiting the main loop, but before deleting the OpenGL context.
    /// Override to unload resources.
    /// </item>
    /// <item>
    /// <see cref="NativeWindow.OnResize"/>: Occurs whenever GameWindow is resized. You should update the OpenGL Viewport
    /// and Projection Matrix here.
    /// </item>
    /// <item>
    /// <see cref="OnUpdateFrame"/>: Occurs at the specified logic update rate. Override to add your game
    /// logic.
    /// </item>
    /// <item>
    /// <see cref="OnRenderFrame"/>: Occurs at the specified frame render rate. Override to add your
    /// rendering code.
    /// </item>
    /// </list>
    /// </remarks>
    public class GameWindow : NativeWindow
    {
        /// <summary>
        /// Occurs before the window is displayed for the first time.
        /// </summary>
        public event Action Load;

        /// <summary>
        /// Occurs before the window is destroyed.
        /// </summary>
        public event Action Unload;

        /// <summary>
        /// Occurs when it is time to update a frame.
        /// </summary>
        public event Action<FrameEventArgs> UpdateFrame;

        /// <summary>
        /// If game window is configured to run with a dedicated update thread (by passing isSingleThreaded = false in the
        /// constructor),
        /// occurs when the update thread has started. This would be a good place to initialize thread specific stuff (like
        /// setting a synchronization context).
        /// </summary>
        [Obsolete("There is no longer a separate render thread.")]
        public event Action RenderThreadStarted;

        /// <summary>
        /// Occurs when it is time to render a frame.
        /// </summary>
        [Obsolete("Use UpdateFrame instead. We no longer separate UpdateFrame and RenderFrame.")]
        public event Action<FrameEventArgs> RenderFrame;

        /// <summary>
        /// Frequency cap for Update/RenderFrame events.
        /// </summary>
        private const double MaxFrequency = 500.0;

        [Obsolete]
        private readonly Stopwatch _watchRender = new Stopwatch();

        private readonly Stopwatch _watchUpdate = new Stopwatch();

        /// <summary>
        /// Gets a value indicating whether or not UpdatePeriod has consistently failed to reach TargetUpdatePeriod.
        /// This can be used to do things such as decreasing visual quality if the user's computer isn't powerful enough
        /// to handle the application.
        /// </summary>
        protected bool IsRunningSlowly { get; private set; }

        private double _updateEpsilon; // quantization error for UpdateFrame events

        private double _updateFrequency;

        /// <summary>
        /// Gets a value indicating whether or not the GameWindow should use a separate thread for rendering.
        /// </summary>
        /// <remarks>
        ///   <para>
        ///     If this is true, render frames will be processed in a separate thread.
        ///     Do not enable this unless your code is thread safe.
        ///   </para>
        /// </remarks>
        [Obsolete("There is not one size fits all multithreading solution, especially for OpenGL. This feature has been removed and will not work.", true)]
        public bool IsMultiThreaded { get; }

        /// <summary>
        /// Gets or sets a double representing the render frequency, in hertz.
        /// </summary>
        /// <remarks>
        ///  <para>
        /// A value of 0.0 indicates that RenderFrame events are generated at the maximum possible frequency (i.e. only
        /// limited by the hardware's capabilities).
        ///  </para>
        ///  <para>Values lower than 1.0Hz are clamped to 0.0. Values higher than 500.0Hz are clamped to 500.0Hz.</para>
        /// </remarks>
        [Obsolete("Use UpdateFrame instead. We no longer separate UpdateFrame and RenderFrame.", true)]
        public double RenderFrequency
        {
            get => throw new Exception($"This property is obsolete. Use UpdateFrame instead.");
            set => throw new Exception($"This property is obsolete. Use UpdateFrame instead.");
        }

        /// <summary>
        /// Gets a double representing the time spent in the RenderFrame function, in seconds.
        /// </summary>
        [Obsolete("Use UpdateTime instead. We no longer separate UpdateFrame and RenderFrame.", true)]
        public double RenderTime { get; protected set; }

        /// <summary>
        /// Gets a double representing the time spent in the UpdateFrame function, in seconds.
        /// </summary>
        public double UpdateTime { get; protected set; }

        /// <summary>
        /// Gets or sets a double representing the update frequency, in hertz.
        /// </summary>
        /// <remarks>
        ///  <para>
        /// A value of 0.0 indicates that UpdateFrame events are generated at the maximum possible frequency (i.e. only
        /// limited by the hardware's capabilities).
        ///  </para>
        ///  <para>Values lower than 1.0Hz are clamped to 0.0. Values higher than 500.0Hz are clamped to 500.0Hz.</para>
        /// </remarks>
        public double UpdateFrequency
        {
            get => _updateFrequency;

            set
            {
                if (value < 1.0)
                {
                    _updateFrequency = 0.0;
                }
                else if (value <= MaxFrequency)
                {
                    _updateFrequency = value;
                }
                else
                {
                    Debug.Print("Target render frequency clamped to {0}Hz.", MaxFrequency);
                    _updateFrequency = MaxFrequency;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameWindow"/> class with sensible default attributes.
        /// </summary>
        /// <param name="gameWindowSettings">The <see cref="GameWindow"/> related settings.</param>
        /// <param name="nativeWindowSettings">The <see cref="NativeWindow"/> related settings.</param>
        /// <remarks>
        /// <para>
        /// Use GameWindowSettings.Default and NativeWindowSettings.Default to get some sensible default attributes.
        /// </para>
        /// </remarks>
        public GameWindow(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings)
            : base(nativeWindowSettings)
        {
            UpdateFrequency = gameWindowSettings.UpdateFrequency;
        }

        #region Win32 Function for timing

        [DllImport("kernel32", SetLastError = true)]
        private static extern IntPtr SetThreadAffinityMask(IntPtr hThread, IntPtr dwThreadAffinityMask);

        [DllImport("kernel32")]
        private static extern IntPtr GetCurrentThread();

        [DllImport("winmm")]
        private static extern uint timeBeginPeriod(uint uPeriod);

        [DllImport("winmm")]
        private static extern uint timeEndPeriod(uint uPeriod);

        #endregion

        // Counter for how many updates in Run() where slow.
        private int _slowUpdates = 0;

        /// <summary>
        /// Initialize the update thread (if using a multi-threaded context, and enter the game loop of the GameWindow).
        /// </summary>
        public virtual unsafe void Run()
        {
            // We do this before OnLoad so that users have some way to affect these settings in OnLoad if they need to.
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                SetThreadAffinityMask(GetCurrentThread(), new IntPtr(1));

                // Make Thread.Sleep more accurate.
                // FIXME: We probably only care about this if we are not event driven.
                timeBeginPeriod(1);
            }

            // Make sure that the gl contexts is current for OnLoad and the initial OnResize
            Context?.MakeCurrent();

            // Send the OnLoad event, to load all user code.
            OnLoad();

            // Send a dummy OnResize event, to make sure any listening user code has the correct values.
            OnResize(new ResizeEventArgs(Size));

            Debug.Print("Entering main loop.");

            Utils.SleepTimings runSleepTimings = new Utils.SleepTimings(2);

            // Bias used when comparing elapsed time.
            const double BIAS = 0 / 1000.0;

            _watchUpdate.Start();
            while (GLFW.WindowShouldClose(WindowPtr) == false)
            {
                double updatePeriod = UpdateFrequency == 0 ? 0 : 1 / UpdateFrequency;

                double elapsed = _watchUpdate.Elapsed.TotalSeconds;
                if (elapsed > updatePeriod)
                {
                    _watchUpdate.Restart();

                    // Update input state for next frame
                    ProcessInputEvents();

                    // Handle events for this frame
                    ProcessWindowEvents(IsEventDriven);

                    OnUpdateFrame(new FrameEventArgs(elapsed));
                    OnRenderFrame(new FrameEventArgs(elapsed));

                    const int MaxSlowUpdates = 80;
                    const int SlowUpdatesThreshold = 45;

                    double time = _watchUpdate.Elapsed.TotalSeconds;
                    if (updatePeriod - BIAS < time)
                    {
                        _slowUpdates++;
                        if (_slowUpdates > MaxSlowUpdates)
                        {
                            _slowUpdates = MaxSlowUpdates;
                        }
                    }
                    else
                    {
                        _slowUpdates--;
                        if (_slowUpdates < 0)
                        {
                            _slowUpdates = 0;
                        }
                    }

                    IsRunningSlowly = _slowUpdates > SlowUpdatesThreshold;

                    if (API != ContextAPI.NoAPI)
                    {
                        if (VSync == VSyncMode.Adaptive)
                        {
                            GLFW.SwapInterval(IsRunningSlowly ? 0 : 1);
                        }
                    }
                }

                // The time we have left to the next update.
                double timeToNextUpdate = updatePeriod - _watchUpdate.Elapsed.TotalSeconds;

                if (timeToNextUpdate - BIAS > 0)
                {
                    runSleepTimings.PreciseSleep(timeToNextUpdate);
                }
            }

            OnUnload();
        }

        /// <summary>
        /// Swaps the front and back buffers of the current GraphicsContext, presenting the rendered scene to the user.
        /// </summary>
        public virtual void SwapBuffers()
        {
            if (Context == null)
            {
                throw new InvalidOperationException("Cannot use SwapBuffers when running with ContextAPI.NoAPI.");
            }

            Context.SwapBuffers();
        }

        /// <inheritdoc />
        public override void Close()
        {
            base.Close();
        }

        /// <summary>
        /// Run when the update thread is started. This will never run if you set IsSingleThreaded to true.
        /// </summary>
        protected virtual void OnRenderThreadStarted()
        {
            RenderThreadStarted?.Invoke();
        }

        /// <summary>
        /// Run immediately after Run() is called.
        /// </summary>
        protected virtual void OnLoad()
        {
            Load?.Invoke();
        }

        /// <summary>
        /// Run when the window is about to close.
        /// </summary>
        protected virtual void OnUnload()
        {
            Unload?.Invoke();
        }

        /// <summary>
        /// Run when the window is ready to update.
        /// </summary>
        /// <param name="args">The event arguments for this frame.</param>
        protected virtual void OnUpdateFrame(FrameEventArgs args)
        {
            UpdateFrame?.Invoke(args);
        }

        /// <summary>
        /// Run when the window is ready to update.
        /// </summary>
        /// <param name="args">The event arguments for this frame.</param>
        [Obsolete("Use OnUpdateFrame instead. We no longer separate UpdateFrame and RenderFrame.")]
        protected virtual void OnRenderFrame(FrameEventArgs args)
        {
            RenderFrame?.Invoke(args);
        }
    }
}
