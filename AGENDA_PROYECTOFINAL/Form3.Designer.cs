﻿namespace AGENDA_PROYECTOFINAL
{
    partial class CrearUsuario
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
            btnSesion = new Button();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            lblCorreo = new Label();
            lblContraseña = new Label();
            lblConfirmar = new Label();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            txtConfirmar = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSesion
            // 
            btnSesion.BackColor = Color.DarkGray;
            btnSesion.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSesion.ForeColor = Color.Black;
            btnSesion.Location = new Point(760, 387);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(115, 31);
            btnSesion.TabIndex = 0;
            btnSesion.Text = "Iniciar Sesion";
            btnSesion.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Sitka Banner", 13F, FontStyle.Italic);
            lblUsuario.ForeColor = SystemColors.ButtonFace;
            lblUsuario.Location = new Point(441, 143);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(146, 26);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Nombre De Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(633, 143);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(193, 25);
            txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(325, 40);
            label2.Name = "label2";
            label2.Size = new Size(207, 27);
            label2.TabIndex = 3;
            label2.Text = "CREAR USUARIO";
            label2.Click += label2_Click;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Sitka Banner", 13F, FontStyle.Italic);
            lblCorreo.ForeColor = SystemColors.ButtonFace;
            lblCorreo.Location = new Point(441, 200);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(139, 26);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo Electronico";
            lblCorreo.Click += label3_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Sitka Banner", 13F, FontStyle.Italic);
            lblContraseña.ForeColor = SystemColors.ButtonFace;
            lblContraseña.Location = new Point(441, 263);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(91, 26);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña";
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Font = new Font("Sitka Banner", 13.2499981F, FontStyle.Italic);
            lblConfirmar.ForeColor = SystemColors.ButtonFace;
            lblConfirmar.Location = new Point(441, 318);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(167, 26);
            lblConfirmar.TabIndex = 6;
            lblConfirmar.Text = "Confirmar Contraseña";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(633, 200);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(193, 25);
            txtCorreo.TabIndex = 7;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(633, 263);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(193, 25);
            txtContraseña.TabIndex = 8;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(633, 318);
            txtConfirmar.Multiline = true;
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(193, 25);
            txtConfirmar.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.comp;
            pictureBox1.Location = new Point(47, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 304);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(959, 509);
            Controls.Add(pictureBox1);
            Controls.Add(txtConfirmar);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(lblConfirmar);
            Controls.Add(lblContraseña);
            Controls.Add(lblCorreo);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(btnSesion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "CrearUsuario";
            Text = "CREAR USUARIO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSesion;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label label2;
        private Label lblCorreo;
        private Label lblContraseña;
        private Label lblConfirmar;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private TextBox txtConfirmar;
        private PictureBox pictureBox1;
    }
}