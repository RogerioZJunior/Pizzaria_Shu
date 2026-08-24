namespace Pizza_Shu.Telas
{
    partial class atualizarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(atualizarUsuario));
            this.maskedTextBoxATUTelefone = new System.Windows.Forms.MaskedTextBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.checkBoxATUADM = new System.Windows.Forms.CheckBox();
            this.textBoxATUSenha = new System.Windows.Forms.TextBox();
            this.textBoxATUEmail = new System.Windows.Forms.TextBox();
            this.textBoxATUEndereco = new System.Windows.Forms.TextBox();
            this.textBoxATUNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.buttonATUVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBoxATUTelefone
            // 
            this.maskedTextBoxATUTelefone.BackColor = System.Drawing.Color.Ivory;
            this.maskedTextBoxATUTelefone.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.maskedTextBoxATUTelefone.Location = new System.Drawing.Point(106, 278);
            this.maskedTextBoxATUTelefone.Mask = "(99) 00000-0000";
            this.maskedTextBoxATUTelefone.Name = "maskedTextBoxATUTelefone";
            this.maskedTextBoxATUTelefone.Size = new System.Drawing.Size(238, 35);
            this.maskedTextBoxATUTelefone.TabIndex = 23;
            this.maskedTextBoxATUTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxATUTelefone_MaskInputRejected);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.Color.Ivory;
            this.buttonAtualizar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(153, 567);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(139, 49);
            this.buttonAtualizar.TabIndex = 28;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // checkBoxATUADM
            // 
            this.checkBoxATUADM.AutoSize = true;
            this.checkBoxATUADM.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxATUADM.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxATUADM.Location = new System.Drawing.Point(106, 500);
            this.checkBoxATUADM.Name = "checkBoxATUADM";
            this.checkBoxATUADM.Size = new System.Drawing.Size(149, 27);
            this.checkBoxATUADM.TabIndex = 27;
            this.checkBoxATUADM.Text = "Administrador";
            this.checkBoxATUADM.UseVisualStyleBackColor = false;
            this.checkBoxATUADM.CheckedChanged += new System.EventHandler(this.checkBoxATUADM_CheckedChanged);
            // 
            // textBoxATUSenha
            // 
            this.textBoxATUSenha.BackColor = System.Drawing.Color.Ivory;
            this.textBoxATUSenha.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.textBoxATUSenha.Location = new System.Drawing.Point(105, 444);
            this.textBoxATUSenha.Name = "textBoxATUSenha";
            this.textBoxATUSenha.Size = new System.Drawing.Size(238, 35);
            this.textBoxATUSenha.TabIndex = 26;
            this.textBoxATUSenha.TextChanged += new System.EventHandler(this.textBoxATUSenha_TextChanged);
            // 
            // textBoxATUEmail
            // 
            this.textBoxATUEmail.BackColor = System.Drawing.Color.Ivory;
            this.textBoxATUEmail.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.textBoxATUEmail.Location = new System.Drawing.Point(105, 395);
            this.textBoxATUEmail.Name = "textBoxATUEmail";
            this.textBoxATUEmail.Size = new System.Drawing.Size(238, 35);
            this.textBoxATUEmail.TabIndex = 25;
            this.textBoxATUEmail.TextChanged += new System.EventHandler(this.textBoxATUEmail_TextChanged);
            // 
            // textBoxATUEndereco
            // 
            this.textBoxATUEndereco.BackColor = System.Drawing.Color.Ivory;
            this.textBoxATUEndereco.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.textBoxATUEndereco.Location = new System.Drawing.Point(105, 319);
            this.textBoxATUEndereco.Name = "textBoxATUEndereco";
            this.textBoxATUEndereco.Size = new System.Drawing.Size(238, 35);
            this.textBoxATUEndereco.TabIndex = 24;
            this.textBoxATUEndereco.TextChanged += new System.EventHandler(this.textBoxATUEndereco_TextChanged);
            // 
            // textBoxATUNome
            // 
            this.textBoxATUNome.BackColor = System.Drawing.Color.Ivory;
            this.textBoxATUNome.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.textBoxATUNome.Location = new System.Drawing.Point(106, 237);
            this.textBoxATUNome.Name = "textBoxATUNome";
            this.textBoxATUNome.Size = new System.Drawing.Size(238, 35);
            this.textBoxATUNome.TabIndex = 22;
            this.textBoxATUNome.TextChanged += new System.EventHandler(this.textBoxATUNome_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Atualizar Usuário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Código:";
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.BackColor = System.Drawing.Color.Ivory;
            this.buttonProcurar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcurar.Location = new System.Drawing.Point(368, 157);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(113, 40);
            this.buttonProcurar.TabIndex = 21;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = false;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.Color.Ivory;
            this.textBoxCodigo.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.textBoxCodigo.Location = new System.Drawing.Point(105, 162);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(238, 35);
            this.textBoxCodigo.TabIndex = 30;
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            // 
            // buttonATUVoltar
            // 
            this.buttonATUVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonATUVoltar.BackColor = System.Drawing.Color.Ivory;
            this.buttonATUVoltar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonATUVoltar.Location = new System.Drawing.Point(1377, 754);
            this.buttonATUVoltar.Name = "buttonATUVoltar";
            this.buttonATUVoltar.Size = new System.Drawing.Size(113, 40);
            this.buttonATUVoltar.TabIndex = 31;
            this.buttonATUVoltar.Text = "Voltar";
            this.buttonATUVoltar.UseVisualStyleBackColor = false;
            this.buttonATUVoltar.Click += new System.EventHandler(this.buttonATUVoltar_Click);
            // 
            // atualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Shu.Properties.Resources.fundo_do_orçamento;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1502, 806);
            this.Controls.Add(this.buttonATUVoltar);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.buttonProcurar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBoxATUTelefone);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.checkBoxATUADM);
            this.Controls.Add(this.textBoxATUSenha);
            this.Controls.Add(this.textBoxATUEmail);
            this.Controls.Add(this.textBoxATUEndereco);
            this.Controls.Add(this.textBoxATUNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "atualizarUsuario";
            this.Text = "Consultar Usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.atualizarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxATUTelefone;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.CheckBox checkBoxATUADM;
        private System.Windows.Forms.TextBox textBoxATUSenha;
        private System.Windows.Forms.TextBox textBoxATUEmail;
        private System.Windows.Forms.TextBox textBoxATUEndereco;
        private System.Windows.Forms.TextBox textBoxATUNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Button buttonATUVoltar;
    }
}