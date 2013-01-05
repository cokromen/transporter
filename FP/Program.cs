using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FP
{
     
    static class Program
    {
        public static void displayBlobImage(byte[] blob, string namaFile)
        {
            try
            {
                FileStream FS = new FileStream(namaFile, FileMode.Create, FileAccess.Write);
                FS.Write(blob, 0, blob.Length);
                FS.Close();
                FS.Dispose();
                FS = null;
            }
            catch (Exception)
            {
                // Error diabaikan saja
            }
        }

        public static byte[] getBlobImage(string filePath)
        {
            // Ambil berkas filePath, jadikan dia sebuah blob
            FileStream FS = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] blob = new byte[FS.Length];
            FS.Read(blob, 0, Convert.ToInt32(FS.Length));
            FS.Close();
            FS = null;

            return blob;
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formLogin());
        }


        public static koneksi conn = new koneksi();
       /// public static byte[] getBlobImage(string filePath);
        ///public static void displayBlobImage(byte[] blob, string namaFile);
    }
}

