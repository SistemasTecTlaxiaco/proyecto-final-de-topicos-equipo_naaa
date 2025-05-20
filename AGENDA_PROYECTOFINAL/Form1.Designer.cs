namespace AGENDA_PROYECTOFINAL
{
    partial class FormAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcceso));
            btnAcceder = new Button();
            TextBoxUsuario = new TextBox();
            TextBoxContraseña = new TextBox();
            recuperarcontraseña = new Label();
            creausuario = new Label();
            pictureBox1 = new PictureBox();
            lblLongitud = new Label();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(1039, 434);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(94, 37);
            btnAcceder.TabIndex = 0;
            btnAcceder.Text = "Aceptar";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // TextBoxUsuario
            // 
            TextBoxUsuario.BackColor = SystemColors.ButtonFace;
            TextBoxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxUsuario.Location = new Point(899, 192);
            TextBoxUsuario.Multiline = true;
            TextBoxUsuario.Name = "TextBoxUsuario";
            TextBoxUsuario.Size = new Size(234, 40);
            TextBoxUsuario.TabIndex = 3;
            TextBoxUsuario.TextAlign = HorizontalAlignment.Center;
            TextBoxUsuario.TextChanged += textBox1_TextChanged;
            // 
            // TextBoxContraseña
            // 
            TextBoxContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxContraseña.BackColor = SystemColors.ButtonFace;
            TextBoxContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxContraseña.Location = new Point(899, 318);
            TextBoxContraseña.Multiline = true;
            TextBoxContraseña.Name = "TextBoxContraseña";
            TextBoxContraseña.Size = new Size(234, 37);
            TextBoxContraseña.TabIndex = 4;
            TextBoxContraseña.TextAlign = HorizontalAlignment.Center;
            TextBoxContraseña.TextChanged += textContraseña_TextChanged;
            // 
            // recuperarcontraseña
            // 
            recuperarcontraseña.AutoSize = true;
            recuperarcontraseña.ForeColor = Color.IndianRed;
            recuperarcontraseña.Location = new Point(899, 389);
            recuperarcontraseña.Name = "recuperarcontraseña";
            recuperarcontraseña.Size = new Size(163, 20);
            recuperarcontraseña.TabIndex = 5;
            recuperarcontraseña.Text = "¿Olvidò su Contraseña?";
            recuperarcontraseña.Click += label2_Click;
            // 
            // creausuario
            // 
            creausuario.AutoEllipsis = true;
            creausuario.AutoSize = true;
            creausuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            creausuario.ForeColor = Color.IndianRed;
            creausuario.Location = new Point(899, 473);
            creausuario.Name = "creausuario";
            creausuario.Size = new Size(120, 23);
            creausuario.TabIndex = 6;
            creausuario.Text = "Crear Usuario\r\n";
            creausuario.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(587, 712);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Location = new Point(736, 275);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(0, 20);
            lblLongitud.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(775, 327);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 8;
            label1.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(798, 204);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 9;
            label4.Text = "Usuario";
            // 
            // FormAcceso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1207, 756);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lblLongitud);
            Controls.Add(creausuario);
            Controls.Add(recuperarcontraseña);
            Controls.Add(TextBoxContraseña);
            Controls.Add(TextBoxUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(btnAcceder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FormAcceso";
            Text = "ACCESO AGENDA";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcceder;
        private TextBox TextBoxUsuario;
        private TextBox TextBoxContraseña;
        private Label recuperarcontraseña;
        private Label creausuario;
        private PictureBox pictureBox1;
        private Label lblLongitud;
        private Label label1;
        private Label label4;
    }
}
