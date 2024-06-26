using sistemaInventarioNet.App;

namespace sistemaInventarioNet
{
    public partial class Form1 : Form
    {
        private bool draggable;
        private int mouseX;
        private int mouseY;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                draggable = true;
                mouseX = Cursor.Position.X - this.Left;
                mouseY = Cursor.Position.Y - this.Top;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.TopLevel = false;
            panel4.Controls.Add(frmDashboard);
            frmDashboard.BringToFront();
            frmDashboard.Show();

        }
    }
}
