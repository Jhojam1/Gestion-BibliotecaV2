namespace sistemaInventarioNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSalir = new Button();
            btnConfiguracion = new Button();
            btnReporte = new Button();
            btnBodega = new Button();
            btnInventario = new Button();
            btnProducto = new Button();
            btnDashboard = new Button();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnCerrar = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 58, 71);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnConfiguracion);
            panel1.Controls.Add(btnReporte);
            panel1.Controls.Add(btnBodega);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 450);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = Properties.Resources.logout2_16;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 427);
            btnSalir.Name = "btnSalir";
            btnSalir.RightToLeft = RightToLeft.No;
            btnSalir.Size = new Size(176, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.ForeColor = Color.White;
            btnConfiguracion.Image = Properties.Resources.settings_16;
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(0, 252);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.RightToLeft = RightToLeft.No;
            btnConfiguracion.Size = new Size(176, 23);
            btnConfiguracion.TabIndex = 7;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            btnReporte.Dock = DockStyle.Top;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.ForeColor = Color.White;
            btnReporte.Image = Properties.Resources.printing_16;
            btnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporte.Location = new Point(0, 229);
            btnReporte.Name = "btnReporte";
            btnReporte.RightToLeft = RightToLeft.No;
            btnReporte.Size = new Size(176, 23);
            btnReporte.TabIndex = 6;
            btnReporte.Text = "Reportes";
            btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnBodega
            // 
            btnBodega.Dock = DockStyle.Top;
            btnBodega.FlatAppearance.BorderSize = 0;
            btnBodega.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnBodega.FlatStyle = FlatStyle.Flat;
            btnBodega.ForeColor = Color.White;
            btnBodega.Image = Properties.Resources.product2_16;
            btnBodega.ImageAlign = ContentAlignment.MiddleLeft;
            btnBodega.Location = new Point(0, 206);
            btnBodega.Name = "btnBodega";
            btnBodega.RightToLeft = RightToLeft.No;
            btnBodega.Size = new Size(176, 23);
            btnBodega.TabIndex = 5;
            btnBodega.Text = "Bodega";
            btnBodega.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = Properties.Resources.pie_chart_16;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 183);
            btnInventario.Name = "btnInventario";
            btnInventario.RightToLeft = RightToLeft.No;
            btnInventario.Size = new Size(176, 23);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            btnProducto.Dock = DockStyle.Top;
            btnProducto.FlatAppearance.BorderSize = 0;
            btnProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.ForeColor = Color.White;
            btnProducto.Image = Properties.Resources.product_16;
            btnProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducto.Location = new Point(0, 160);
            btnProducto.Name = "btnProducto";
            btnProducto.RightToLeft = RightToLeft.No;
            btnProducto.Size = new Size(176, 23);
            btnProducto.TabIndex = 3;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboard_16;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 137);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.RightToLeft = RightToLeft.No;
            btnDashboard.Size = new Size(176, 23);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 37);
            panel5.Name = "panel5";
            panel5.Size = new Size(176, 100);
            panel5.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(50, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(109, 33, 79);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 37);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(179, 55, 113);
            panel3.Controls.Add(btnCerrar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(176, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(624, 37);
            panel3.TabIndex = 1;
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(580, 8);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(32, 23);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(176, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(624, 413);
            panel4.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnCerrar;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Button btnDashboard;
        private Button btnConfiguracion;
        private Button btnReporte;
        private Button btnBodega;
        private Button btnInventario;
        private Button btnProducto;
        private Button btnSalir;
    }
}
