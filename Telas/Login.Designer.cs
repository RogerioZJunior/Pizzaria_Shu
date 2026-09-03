namespace Pizza_Shu.Telas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLoginEmail = new System.Windows.Forms.TextBox();
            this.textBoxLoginSenha = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonLoginSair = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pizza_Shu.Properties.Resources.logo_pizza_do_shu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(476, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label2.Location = new System.Drawing.Point(400, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "📧Email:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label3.Location = new System.Drawing.Point(397, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "🔑Senha:";
            // 
            // textBoxLoginEmail
            // 
            this.textBoxLoginEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxLoginEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLoginEmail.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.textBoxLoginEmail.Location = new System.Drawing.Point(522, 343);
            this.textBoxLoginEmail.Name = "textBoxLoginEmail";
            this.textBoxLoginEmail.Size = new System.Drawing.Size(394, 44);
            this.textBoxLoginEmail.TabIndex = 4;
            this.textBoxLoginEmail.TextChanged += new System.EventHandler(this.textBoxLoginEmail_TextChanged);
            // 
            // textBoxLoginSenha
            // 
            this.textBoxLoginSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxLoginSenha.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLoginSenha.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.textBoxLoginSenha.Location = new System.Drawing.Point(522, 422);
            this.textBoxLoginSenha.Name = "textBoxLoginSenha";
            this.textBoxLoginSenha.Size = new System.Drawing.Size(394, 44);
            this.textBoxLoginSenha.TabIndex = 5;
            this.textBoxLoginSenha.UseSystemPasswordChar = true;
            this.textBoxLoginSenha.TextChanged += new System.EventHandler(this.textBoxLoginSenha_TextChanged);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEntrar.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.buttonEntrar.Location = new System.Drawing.Point(636, 502);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(145, 55);
            this.buttonEntrar.TabIndex = 6;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonLoginSair
            // 
            this.buttonLoginSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLoginSair.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLoginSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLoginSair.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.buttonLoginSair.Location = new System.Drawing.Point(636, 633);
            this.buttonLoginSair.Name = "buttonLoginSair";
            this.buttonLoginSair.Size = new System.Drawing.Size(145, 55);
            this.buttonLoginSair.TabIndex = 8;
            this.buttonLoginSair.Text = "Sair➡️";
            this.buttonLoginSair.UseVisualStyleBackColor = false;
            this.buttonLoginSair.Click += new System.EventHandler(this.buttonLoginSair_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Pizza_Shu.Properties.Resources.logo_bem_vindo_de_volta_pra_colocar_no_login;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(546, 154);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(310, 178);
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Shu.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonLoginSair);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.textBoxLoginSenha);
            this.Controls.Add(this.textBoxLoginEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLoginEmail;
        private System.Windows.Forms.TextBox textBoxLoginSenha;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button buttonLoginSair;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}