namespace proyecto_de_eduardo
{
    partial class usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tusuario = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(799, 119);
            label1.TabIndex = 0;
            label1.Text = "Catalogo de usuarios";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 205);
            label2.Name = "label2";
            label2.Size = new Size(198, 37);
            label2.TabIndex = 1;
            label2.Text = "Ingresar usuario";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tusuario
            // 
            tusuario.BackColor = Color.Black;
            tusuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tusuario.ForeColor = Color.White;
            tusuario.Location = new Point(278, 213);
            tusuario.Name = "tusuario";
            tusuario.Size = new Size(182, 34);
            tusuario.TabIndex = 2;
            tusuario.TextAlign = HorizontalAlignment.Center;
            tusuario.TextChanged += tusuario_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(197, 302);
            button1.Name = "button1";
            button1.Size = new Size(137, 41);
            button1.TabIndex = 3;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(399, 302);
            button2.Name = "button2";
            button2.Size = new Size(137, 41);
            button2.TabIndex = 4;
            button2.Text = "Reporte";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "usuarios";
            Text = "usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tusuario;
        private Button button1;
        private Button button2;
    }
}