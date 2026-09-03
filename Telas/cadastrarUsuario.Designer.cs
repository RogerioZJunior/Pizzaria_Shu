namespace Pizza_Shu.Telas
{
    partial class cadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrarUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.checkBoxADM = new System.Windows.Forms.CheckBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonCADVoltar = new System.Windows.Forms.Button();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Usuário";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "👤Nome:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label3.Location = new System.Drawing.Point(370, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "📞Telefone:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label4.Location = new System.Drawing.Point(363, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "🗺️Endereço:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label5.Location = new System.Drawing.Point(399, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "📧Email:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label6.Location = new System.Drawing.Point(397, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "🔑Senha:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNome.BackColor = System.Drawing.Color.Ivory;
            this.textBoxNome.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(522, 188);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(394, 44);
            this.textBoxNome.TabIndex = 6;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEndereco.BackColor = System.Drawing.Color.Ivory;
            this.textBoxEndereco.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.textBoxEndereco.Location = new System.Drawing.Point(525, 288);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(391, 44);
            this.textBoxEndereco.TabIndex = 8;
            this.textBoxEndereco.TextChanged += new System.EventHandler(this.textBoxEndereco_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.BackColor = System.Drawing.Color.Ivory;
            this.textBoxEmail.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.textBoxEmail.Location = new System.Drawing.Point(525, 371);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(391, 44);
            this.textBoxEmail.TabIndex = 9;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSenha.BackColor = System.Drawing.Color.Ivory;
            this.textBoxSenha.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.textBoxSenha.Location = new System.Drawing.Point(525, 421);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(391, 44);
            this.textBoxSenha.TabIndex = 10;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // checkBoxADM
            // 
            this.checkBoxADM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxADM.AutoSize = true;
            this.checkBoxADM.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxADM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxADM.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.checkBoxADM.Location = new System.Drawing.Point(626, 471);
            this.checkBoxADM.Name = "checkBoxADM";
            this.checkBoxADM.Size = new System.Drawing.Size(190, 35);
            this.checkBoxADM.TabIndex = 11;
            this.checkBoxADM.Text = "Administrador";
            this.checkBoxADM.UseVisualStyleBackColor = false;
            this.checkBoxADM.CheckedChanged += new System.EventHandler(this.checkBoxADM_CheckedChanged);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCadastrar.BackColor = System.Drawing.Color.Ivory;
            this.buttonCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(649, 541);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(145, 55);
            this.buttonCadastrar.TabIndex = 12;
            this.buttonCadastrar.Text = "👤Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonCADVoltar
            // 
            this.buttonCADVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCADVoltar.BackColor = System.Drawing.Color.Ivory;
            this.buttonCADVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCADVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCADVoltar.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.buttonCADVoltar.Location = new System.Drawing.Point(1213, 682);
            this.buttonCADVoltar.Name = "buttonCADVoltar";
            this.buttonCADVoltar.Size = new System.Drawing.Size(145, 55);
            this.buttonCADVoltar.TabIndex = 13;
            this.buttonCADVoltar.Text = "Voltar➡️";
            this.buttonCADVoltar.UseVisualStyleBackColor = false;
            this.buttonCADVoltar.Click += new System.EventHandler(this.buttonCADVoltar_Click);
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxTelefone.BackColor = System.Drawing.Color.Ivory;
            this.maskedTextBoxTelefone.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(525, 238);
            this.maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(391, 44);
            this.maskedTextBoxTelefone.TabIndex = 7;
            this.maskedTextBoxTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxTelefone_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pizza_Shu.Properties.Resources.cartaozinho_feito_com_amor2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(971, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 285);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // cadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Shu.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.buttonCADVoltar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.checkBoxADM);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastrarUsuario";
            this.Text = "Cadastrar Usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cadastrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.CheckBox checkBoxADM;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonCADVoltar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}