using Farmwait.View;

namespace Farmwait
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FormLogin login = new FormLogin();

            // 2. Panggil ShowDialog dari OBJEK 'login' (bukan Class 'FormLogin')
            if (login.ShowDialog() == DialogResult.OK)
            {
                // Jika login sukses (return OK), buka HalUtama
                Application.Run(new HalUtama());
            }
            else
            {
                // Jika login di-close (tanda silang), matikan aplikasi
                Application.Exit();
            }

            //test commit

        }
    
    }
}