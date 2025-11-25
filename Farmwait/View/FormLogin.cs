using Farmwait.View;

namespace Farmwait
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Masukkan logika login di sini
            // Contoh validasi sederhana:
            if (true) // Ganti dengan logika cek username/password kamu nanti
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void linkLabelDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Sembunyikan Login dulu

            FormRegister formReg = new FormRegister();

            // Tampung hasil dari Register (apakah OK atau Batal?)
            DialogResult hasil = formReg.ShowDialog();

            if (hasil == DialogResult.OK)
            {
                // KONDISI 1: User Berhasil Daftar
                // Login ikut ngirim sinyal OK ke Program.cs, lalu tutup diri selamanya.
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // KONDISI 2: User Batal/Close silang di Register
                // Login muncul lagi biar bisa login biasa
                this.Show();
            }
        }

    }
}

