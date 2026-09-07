namespace Pizza_Shu.Telas
{
    partial class excluirProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(excluirProduto));
            this.buttonEXCVoltar = new System.Windows.Forms.Button();
            this.textBoxEXCCodigo = new System.Windows.Forms.TextBox();
            this.buttonEXCExcluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEXCVoltar
            // 
            this.buttonEXCVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEXCVoltar.BackColor = System.Drawing.Color.Ivory;
            this.buttonEXCVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEXCVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEXCVoltar.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.buttonEXCVoltar.ForeColor = System.Drawing.Color.OliveDrab;
            this.buttonEXCVoltar.Location = new System.Drawing.Point(659, 427);
            this.buttonEXCVoltar.Name = "buttonEXCVoltar";
            this.buttonEXCVoltar.Size = new System.Drawing.Size(145, 55);
            this.buttonEXCVoltar.TabIndex = 39;
            this.buttonEXCVoltar.Text = "Voltar➡️";
            this.buttonEXCVoltar.UseVisualStyleBackColor = false;
            this.buttonEXCVoltar.Click += new System.EventHandler(this.buttonEXCVoltar_Click);
            // 
            // textBoxEXCCodigo
            // 
            this.textBoxEXCCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEXCCodigo.BackColor = System.Drawing.Color.Ivory;
            this.textBoxEXCCodigo.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.textBoxEXCCodigo.Location = new System.Drawing.Point(531, 306);
            this.textBoxEXCCodigo.Name = "textBoxEXCCodigo";
            this.textBoxEXCCodigo.Size = new System.Drawing.Size(394, 44);
            this.textBoxEXCCodigo.TabIndex = 36;
            this.textBoxEXCCodigo.TextChanged += new System.EventHandler(this.textBoxEXCCodigo_TextChanged);
            // 
            // buttonEXCExcluir
            // 
            this.buttonEXCExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEXCExcluir.BackColor = System.Drawing.Color.Ivory;
            this.buttonEXCExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEXCExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEXCExcluir.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.buttonEXCExcluir.ForeColor = System.Drawing.Color.OliveDrab;
            this.buttonEXCExcluir.Location = new System.Drawing.Point(931, 302);
            this.buttonEXCExcluir.Name = "buttonEXCExcluir";
            this.buttonEXCExcluir.Size = new System.Drawing.Size(145, 55);
            this.buttonEXCExcluir.TabIndex = 38;
            this.buttonEXCExcluir.Text = "🗑️Excluir";
            this.buttonEXCExcluir.UseVisualStyleBackColor = false;
            this.buttonEXCExcluir.Click += new System.EventHandler(this.buttonEXCExcluir_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label7.Location = new System.Drawing.Point(394, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 31);
            this.label7.TabIndex = 37;
            this.label7.Text = "🪪Código:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.label1.Location = new System.Drawing.Point(634, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "Excluir Produto";
            // 
            // excluirProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Shu.Properties.Resources.pizza_shu_sem_nada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.buttonEXCVoltar);
            this.Controls.Add(this.textBoxEXCCodigo);
            this.Controls.Add(this.buttonEXCExcluir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "excluirProduto";
            this.Text = "Excluir Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.excluirProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEXCVoltar;
        private System.Windows.Forms.TextBox textBoxEXCCodigo;
        private System.Windows.Forms.Button buttonEXCExcluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}