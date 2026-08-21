namespace Pizza_Shu.Telas
{
    partial class excluirUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(excluirUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEXCCodigo = new System.Windows.Forms.TextBox();
            this.buttonEXCExcluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEXCVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(307, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excluir Usuário";
            // 
            // textBoxEXCCodigo
            // 
            this.textBoxEXCCodigo.BackColor = System.Drawing.Color.Ivory;
            this.textBoxEXCCodigo.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.textBoxEXCCodigo.Location = new System.Drawing.Point(261, 112);
            this.textBoxEXCCodigo.Name = "textBoxEXCCodigo";
            this.textBoxEXCCodigo.Size = new System.Drawing.Size(238, 32);
            this.textBoxEXCCodigo.TabIndex = 32;
            this.textBoxEXCCodigo.TextChanged += new System.EventHandler(this.textBoxEXCCodigo_TextChanged);
            // 
            // buttonEXCExcluir
            // 
            this.buttonEXCExcluir.BackColor = System.Drawing.Color.Ivory;
            this.buttonEXCExcluir.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonEXCExcluir.Location = new System.Drawing.Point(518, 106);
            this.buttonEXCExcluir.Name = "buttonEXCExcluir";
            this.buttonEXCExcluir.Size = new System.Drawing.Size(96, 38);
            this.buttonEXCExcluir.TabIndex = 33;
            this.buttonEXCExcluir.Text = "Excluir";
            this.buttonEXCExcluir.UseVisualStyleBackColor = false;
            this.buttonEXCExcluir.Click += new System.EventHandler(this.buttonEXCExcluir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(183, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Código:";
            // 
            // buttonEXCVoltar
            // 
            this.buttonEXCVoltar.BackColor = System.Drawing.Color.Ivory;
            this.buttonEXCVoltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXCVoltar.Location = new System.Drawing.Point(341, 217);
            this.buttonEXCVoltar.Name = "buttonEXCVoltar";
            this.buttonEXCVoltar.Size = new System.Drawing.Size(96, 38);
            this.buttonEXCVoltar.TabIndex = 34;
            this.buttonEXCVoltar.Text = "Voltar";
            this.buttonEXCVoltar.UseVisualStyleBackColor = false;
            this.buttonEXCVoltar.Click += new System.EventHandler(this.buttonEXCVoltar_Click);
            // 
            // excluirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Shu.Properties.Resources.fundo_do_orçamento;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEXCVoltar);
            this.Controls.Add(this.textBoxEXCCodigo);
            this.Controls.Add(this.buttonEXCExcluir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "excluirUsuario";
            this.Text = "Excluir Usuario";
            this.Load += new System.EventHandler(this.excluirUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEXCCodigo;
        private System.Windows.Forms.Button buttonEXCExcluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEXCVoltar;
    }
}