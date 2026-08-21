namespace Pizza_Shu
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCAD = new System.Windows.Forms.Button();
            this.buttonCON = new System.Windows.Forms.Button();
            this.buttonATU = new System.Windows.Forms.Button();
            this.buttonEXC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(61, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(61, -12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 130);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerenciar Funcionários";
            // 
            // buttonCAD
            // 
            this.buttonCAD.BackColor = System.Drawing.Color.Ivory;
            this.buttonCAD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCAD.Location = new System.Drawing.Point(12, 170);
            this.buttonCAD.Name = "buttonCAD";
            this.buttonCAD.Size = new System.Drawing.Size(96, 38);
            this.buttonCAD.TabIndex = 3;
            this.buttonCAD.Text = "Cadastrar";
            this.buttonCAD.UseVisualStyleBackColor = false;
            this.buttonCAD.Click += new System.EventHandler(this.buttonCAD_Click);
            // 
            // buttonCON
            // 
            this.buttonCON.BackColor = System.Drawing.Color.Ivory;
            this.buttonCON.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCON.Location = new System.Drawing.Point(12, 214);
            this.buttonCON.Name = "buttonCON";
            this.buttonCON.Size = new System.Drawing.Size(96, 38);
            this.buttonCON.TabIndex = 4;
            this.buttonCON.Text = "Consultar";
            this.buttonCON.UseVisualStyleBackColor = false;
            this.buttonCON.Click += new System.EventHandler(this.buttonCON_Click);
            // 
            // buttonATU
            // 
            this.buttonATU.BackColor = System.Drawing.Color.Ivory;
            this.buttonATU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonATU.Location = new System.Drawing.Point(12, 258);
            this.buttonATU.Name = "buttonATU";
            this.buttonATU.Size = new System.Drawing.Size(96, 38);
            this.buttonATU.TabIndex = 5;
            this.buttonATU.Text = "Atualizar";
            this.buttonATU.UseVisualStyleBackColor = false;
            this.buttonATU.Click += new System.EventHandler(this.buttonATU_Click);
            // 
            // buttonEXC
            // 
            this.buttonEXC.BackColor = System.Drawing.Color.Ivory;
            this.buttonEXC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXC.Location = new System.Drawing.Point(12, 302);
            this.buttonEXC.Name = "buttonEXC";
            this.buttonEXC.Size = new System.Drawing.Size(96, 38);
            this.buttonEXC.TabIndex = 6;
            this.buttonEXC.Text = "Excluir";
            this.buttonEXC.UseVisualStyleBackColor = false;
            this.buttonEXC.Click += new System.EventHandler(this.buttonEXC_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Shu.Properties.Resources.fundo_do_orçamento;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEXC);
            this.Controls.Add(this.buttonATU);
            this.Controls.Add(this.buttonCON);
            this.Controls.Add(this.buttonCAD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "n";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCAD;
        private System.Windows.Forms.Button buttonCON;
        private System.Windows.Forms.Button buttonATU;
        private System.Windows.Forms.Button buttonEXC;
    }
}

