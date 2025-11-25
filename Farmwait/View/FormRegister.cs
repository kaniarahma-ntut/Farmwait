using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Cukup bilang: "Oke bos, tugas saya selesai!"
            this.DialogResult = DialogResult.OK;

            // "Saya pamit undur diri"
            this.Close();


        }
    }
}
