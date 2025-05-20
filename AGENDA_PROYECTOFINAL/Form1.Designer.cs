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
            btnAceptar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textusuario = new TextBox();
            textContraseña = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(905, 461);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 37);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(540, 382);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(587, 712);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textusuario
            // 
            textusuario.BackColor = SystemColors.ButtonFace;
            textusuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textusuario.Location = new Point(733, 192);
            textusuario.Multiline = true;
            textusuario.Name = "textusuario";
            textusuario.Size = new Size(234, 40);
            textusuario.TabIndex = 3;
            textusuario.Text = "Usuario";
            textusuario.TextAlign = HorizontalAlignment.Center;
            textusuario.TextChanged += textBox1_TextChanged;
            // 
            // textContraseña
            // 
            textContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textContraseña.BackColor = SystemColors.ButtonFace;
            textContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textContraseña.Location = new Point(733, 322);
            textContraseña.Multiline = true;
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(234, 40);
            textContraseña.TabIndex = 4;
            textContraseña.Text = "Contraseña";
            textContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(760, 382);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 5;
            label2.Text = "¿Olvidò su Contraseña?";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(722, 506);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 6;
            label3.Text = "Crear Usuario\r\n";
            label3.Click += label3_Click;
            // 
            // FormAcceso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1041, 759);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textContraseña);
            Controls.Add(textusuario);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
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

        private Button btnAceptar;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textusuario;
        private TextBox textContraseña;
        private Label label2;
        private Label label3;
    }
}
