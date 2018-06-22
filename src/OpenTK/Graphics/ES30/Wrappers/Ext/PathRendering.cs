//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.ES30
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "PathRendering" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="left">
            /// </param>
            /// <param name="right">
            /// </param>
            /// <param name="bottom">
            /// </param>
            /// <param name="top">
            /// </param>
            /// <param name="zNear">
            /// </param>
            /// <param name="zFar">
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixFrustumEXT")]
            public static void MatrixFrustum(OpenTK.Graphics.ES30.MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoadIdentityEXT")]
            public static void MatrixLoadIdentity(OpenTK.Graphics.ES30.MatrixMode mode)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoadTransposedEXT")]
            public static void MatrixLoadTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double[] m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoadTransposedEXT")]
            public static void MatrixLoadTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] ref double m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoadTransposedEXT")]
            public static unsafe void MatrixLoadTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double* m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoadTransposefEXT")]
            public static void MatrixLoadTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float[] m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoadTransposefEXT")]
            public static void MatrixLoadTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] ref float m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoadTransposefEXT")]
            public static unsafe void MatrixLoadTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float* m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoaddEXT")]
            public static void MatrixLoad(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double[] m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoaddEXT")]
            public static void MatrixLoad(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] ref double m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoaddEXT")]
            public static unsafe void MatrixLoad(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double* m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoadfEXT")]
            public static void MatrixLoad(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float[] m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoadfEXT")]
            public static void MatrixLoad(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] ref float m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixLoadfEXT")]
            public static unsafe void MatrixLoad(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float* m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultTransposedEXT")]
            public static void MatrixMultTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double[] m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultTransposedEXT")]
            public static void MatrixMultTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] ref double m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultTransposedEXT")]
            public static unsafe void MatrixMultTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double* m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultTransposefEXT")]
            public static void MatrixMultTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float[] m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultTransposefEXT")]
            public static void MatrixMultTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] ref float m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultTransposefEXT")]
            public static unsafe void MatrixMultTranspose(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float* m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultdEXT")]
            public static void MatrixMult(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double[] m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultdEXT")]
            public static void MatrixMult(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] ref double m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultdEXT")]
            public static unsafe void MatrixMult(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double* m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultfEXT")]
            public static void MatrixMult(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float[] m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultfEXT")]
            public static void MatrixMult(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] ref float m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="m">
            /// [length: 16]
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixMultfEXT")]
            public static unsafe void MatrixMult(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float* m)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="left">
            /// </param>
            /// <param name="right">
            /// </param>
            /// <param name="bottom">
            /// </param>
            /// <param name="top">
            /// </param>
            /// <param name="zNear">
            /// </param>
            /// <param name="zFar">
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixOrthoEXT")]
            public static void MatrixOrtho(OpenTK.Graphics.ES30.MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixPopEXT")]
            public static void MatrixPop(OpenTK.Graphics.ES30.MatrixMode mode)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixPushEXT")]
            public static void MatrixPush(OpenTK.Graphics.ES30.MatrixMode mode)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="angle">
            /// </param>
            /// <param name="x">
            /// </param>
            /// <param name="y">
            /// </param>
            /// <param name="z">
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixRotatedEXT")]
            public static void MatrixRotate(OpenTK.Graphics.ES30.MatrixMode mode, double angle, double x, double y, double z)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="angle">
            /// </param>
            /// <param name="x">
            /// </param>
            /// <param name="y">
            /// </param>
            /// <param name="z">
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixRotatefEXT")]
            public static void MatrixRotate(OpenTK.Graphics.ES30.MatrixMode mode, float angle, float x, float y, float z)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="x">
            /// </param>
            /// <param name="y">
            /// </param>
            /// <param name="z">
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixScaledEXT")]
            public static void MatrixScale(OpenTK.Graphics.ES30.MatrixMode mode, double x, double y, double z)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="x">
            /// </param>
            /// <param name="y">
            /// </param>
            /// <param name="z">
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixScalefEXT")]
            public static void MatrixScale(OpenTK.Graphics.ES30.MatrixMode mode, float x, float y, float z)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="x">
            /// </param>
            /// <param name="y">
            /// </param>
            /// <param name="z">
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixTranslatedEXT")]
            public static void MatrixTranslate(OpenTK.Graphics.ES30.MatrixMode mode, double x, double y, double z)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_path_rendering]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="x">
            /// </param>
            /// <param name="y">
            /// </param>
            /// <param name="z">
            /// </param>
            [AutoGenerated(Category = "NV_path_rendering", Version = "", EntryPoint = "glMatrixTranslatefEXT")]
            public static void MatrixTranslate(OpenTK.Graphics.ES30.MatrixMode mode, float x, float y, float z)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(426)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMatrixFrustumEXT(OpenTK.Graphics.ES30.MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar);

            [Slot(431)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMatrixLoadIdentityEXT(OpenTK.Graphics.ES30.MatrixMode mode);

            [Slot(433)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMatrixLoadTransposedEXT(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double* m);

            [Slot(434)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMatrixLoadTransposefEXT(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float* m);

            [Slot(429)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMatrixLoaddEXT(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double* m);

            [Slot(430)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMatrixLoadfEXT(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float* m);

            [Slot(440)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMatrixMultTransposedEXT(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double* m);

            [Slot(441)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMatrixMultTransposefEXT(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float* m);

            [Slot(437)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMatrixMultdEXT(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] double* m);

            [Slot(438)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMatrixMultfEXT(OpenTK.Graphics.ES30.MatrixMode mode, [CountAttribute(Count = 16)] float* m);

            [Slot(442)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMatrixOrthoEXT(OpenTK.Graphics.ES30.MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar);

            [Slot(443)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMatrixPopEXT(OpenTK.Graphics.ES30.MatrixMode mode);

            [Slot(444)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMatrixPushEXT(OpenTK.Graphics.ES30.MatrixMode mode);

            [Slot(445)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMatrixRotatedEXT(OpenTK.Graphics.ES30.MatrixMode mode, double angle, double x, double y, double z);

            [Slot(446)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMatrixRotatefEXT(OpenTK.Graphics.ES30.MatrixMode mode, float angle, float x, float y, float z);

            [Slot(447)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMatrixScaledEXT(OpenTK.Graphics.ES30.MatrixMode mode, double x, double y, double z);

            [Slot(448)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMatrixScalefEXT(OpenTK.Graphics.ES30.MatrixMode mode, float x, float y, float z);

            [Slot(449)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMatrixTranslatedEXT(OpenTK.Graphics.ES30.MatrixMode mode, double x, double y, double z);

            [Slot(450)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMatrixTranslatefEXT(OpenTK.Graphics.ES30.MatrixMode mode, float x, float y, float z);
        }
    }
}