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

namespace OpenTK.Graphics.ES11
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "TextureCubeMap" in the extension "Oes".
        /// </summary>
        public static partial class Oes
        {
            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenfvOES")]
            public static void GetTexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] float[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenfvOES")]
            public static void GetTexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] out float @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenfvOES")]
            public static unsafe void GetTexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] float* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenivOES")]
            public static void GetTexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenivOES")]
            public static void GetTexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenivOES")]
            public static unsafe void GetTexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="param">
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenfOES")]
            public static void TexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, float param)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenfvOES")]
            public static void TexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [CountAttribute(Computed = "pname")] float[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenfvOES")]
            public static void TexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [CountAttribute(Computed = "pname")] ref float @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenfvOES")]
            public static unsafe void TexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [CountAttribute(Computed = "pname")] float* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="param">
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGeniOES")]
            public static void TexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, int param)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenivOES")]
            public static void TexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenivOES")]
            public static void TexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [CountAttribute(Computed = "pname")] ref int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: OES_texture_cube_map]
            /// </summary>
            /// <param name="coord">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenivOES")]
            public static unsafe void TexGen(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(186)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetTexGenfvOES(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] float* @params);

            [Slot(187)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetTexGenivOES(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params);

            [Slot(365)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTexGenfOES(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, float param);

            [Slot(366)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glTexGenfvOES(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [CountAttribute(Computed = "pname")] float* @params);

            [Slot(367)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTexGeniOES(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, int param);

            [Slot(368)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glTexGenivOES(OpenTK.Graphics.ES11.TextureCoordName coord, OpenTK.Graphics.ES11.TextureGenParameter pname, [CountAttribute(Computed = "pname")] int* @params);
        }
    }
}