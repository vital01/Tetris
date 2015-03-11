using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class ResourceLoader
    {
        private static PrivateFontCollection FontCollection { get; set; }
        private const string FontPath = "Tetris.Resources.Font.HalfBoldPixel7.ttf";

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern bool RemoveFontMemResourceEx(IntPtr fh);

        public static PrivateFontCollection LoadFont()
        {
            FontCollection = new PrivateFontCollection();
            using (Stream stream = MainForm.Instance.GetType().Assembly.GetManifestResourceStream(FontPath))
            {
                byte[] fontData = new byte[stream.Length];
                stream.Read(fontData, 0, (int)stream.Length);
                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                FontCollection.AddMemoryFont(fontPtr, fontData.Length);
                uint dummy = 0;
                IntPtr fontHandle = AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
                Marshal.FreeCoTaskMem(fontPtr);
                AppDomain.CurrentDomain.ProcessExit += new EventHandler((_sender, _e) => { RemoveFontMemResourceEx(fontHandle); });
            }
            return FontCollection;
        }
    }
}
