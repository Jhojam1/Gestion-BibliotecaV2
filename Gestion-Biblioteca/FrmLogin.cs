using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaInventarioNet
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtUsuario.Text;
            String password = txtContraseña.Text;
            if (username == "admin" && password == "admin")
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                condicion.Text = "Usuario Y/O Contraseña Incorrecta";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
