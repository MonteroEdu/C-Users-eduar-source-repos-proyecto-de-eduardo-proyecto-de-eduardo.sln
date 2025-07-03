namespace proyecto_de_eduardo
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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            opcionadmin = new ToolStripMenuItem();
            cargarProductoToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            opcionventas = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, opcionadmin, opcionventas });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(939, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inicioToolStripMenuItem.ForeColor = Color.Red;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(67, 27);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // opcionadmin
            // 
            opcionadmin.BackColor = Color.RosyBrown;
            opcionadmin.DropDownItems.AddRange(new ToolStripItem[] { cargarProductoToolStripMenuItem, agregarUsuariosToolStripMenuItem });
            opcionadmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            opcionadmin.ForeColor = Color.Red;
            opcionadmin.Name = "opcionadmin";
            opcionadmin.Size = new Size(146, 27);
            opcionadmin.Text = "Administración";
            // 
            // cargarProductoToolStripMenuItem
            // 
            cargarProductoToolStripMenuItem.AutoSize = false;
            cargarProductoToolStripMenuItem.Name = "cargarProductoToolStripMenuItem";
            cargarProductoToolStripMenuItem.Size = new Size(295, 28);
            cargarProductoToolStripMenuItem.Text = "Bienvenido ";
            cargarProductoToolStripMenuItem.Click += cargarProductoToolStripMenuItem_Click;
            // 
            // agregarUsuariosToolStripMenuItem
            // 
            agregarUsuariosToolStripMenuItem.Name = "agregarUsuariosToolStripMenuItem";
            agregarUsuariosToolStripMenuItem.Size = new Size(230, 28);
            agregarUsuariosToolStripMenuItem.Text = "Agregar usuarios";
            agregarUsuariosToolStripMenuItem.Click += agregarUsuariosToolStripMenuItem_Click;
            // 
            // opcionventas
            // 
            opcionventas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            opcionventas.ForeColor = Color.Red;
            opcionventas.Name = "opcionventas";
            opcionventas.Size = new Size(76, 27);
            opcionventas.Text = "Ventas";
            opcionventas.Click += ventasToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 118);
            label1.Name = "label1";
            label1.Size = new Size(829, 80);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido a la maquia expendedora";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(939, 436);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem opcionadmin;
        private ToolStripMenuItem cargarProductoToolStripMenuItem;
        private ToolStripMenuItem opcionventas;
        private ToolStripMenuItem agregarUsuariosToolStripMenuItem;
        private Label label1;
    }
}
