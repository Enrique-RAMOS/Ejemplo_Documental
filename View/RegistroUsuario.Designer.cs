namespace Lebra
{
    partial class RegistroUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombre_ApellidoLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label usuaLabel;
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombre_ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usuaTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            nombre_ApellidoLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            usuaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(Lebra.Entidades.Usuarios);
            // 
            // nombre_ApellidoLabel
            // 
            nombre_ApellidoLabel.AutoSize = true;
            nombre_ApellidoLabel.ForeColor = System.Drawing.Color.White;
            nombre_ApellidoLabel.Location = new System.Drawing.Point(271, 143);
            nombre_ApellidoLabel.Name = "nombre_ApellidoLabel";
            nombre_ApellidoLabel.Size = new System.Drawing.Size(87, 13);
            nombre_ApellidoLabel.TabIndex = 59;
            nombre_ApellidoLabel.Text = "Nombre Apellido:";
            // 
            // nombre_ApellidoTextBox
            // 
            this.nombre_ApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nombre_Apellido", true));
            this.nombre_ApellidoTextBox.Location = new System.Drawing.Point(365, 141);
            this.nombre_ApellidoTextBox.Name = "nombre_ApellidoTextBox";
            this.nombre_ApellidoTextBox.Size = new System.Drawing.Size(237, 20);
            this.nombre_ApellidoTextBox.TabIndex = 60;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = System.Drawing.Color.White;
            passwordLabel.Location = new System.Drawing.Point(271, 244);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 61;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(365, 237);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(237, 20);
            this.passwordTextBox.TabIndex = 62;
            // 
            // usuaLabel
            // 
            usuaLabel.AutoSize = true;
            usuaLabel.ForeColor = System.Drawing.Color.White;
            usuaLabel.Location = new System.Drawing.Point(271, 195);
            usuaLabel.Name = "usuaLabel";
            usuaLabel.Size = new System.Drawing.Size(43, 13);
            usuaLabel.TabIndex = 63;
            usuaLabel.Text = "Usuario";
            // 
            // usuaTextBox
            // 
            this.usuaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Usua", true));
            this.usuaTextBox.Location = new System.Drawing.Point(365, 188);
            this.usuaTextBox.Name = "usuaTextBox";
            this.usuaTextBox.Size = new System.Drawing.Size(237, 20);
            this.usuaTextBox.TabIndex = 64;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 34);
            this.button2.TabIndex = 58;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
           
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 57;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(nombre_ApellidoLabel);
            this.Controls.Add(this.nombre_ApellidoTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(usuaLabel);
            this.Controls.Add(this.usuaTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroUsuario";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.TextBox nombre_ApellidoTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usuaTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}