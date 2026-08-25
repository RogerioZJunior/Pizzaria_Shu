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
            this.buttonSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPedidos = new System.Windows.Forms.Button();
            this.buttonEventos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.pictureBox2.Location = new System.Drawing.Point(113, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(435, 197);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuários";
            // 
            // buttonCAD
            // 
            this.buttonCAD.BackColor = System.Drawing.Color.Ivory;
            this.buttonCAD.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCAD.Location = new System.Drawing.Point(12, 261);
            this.buttonCAD.Name = "buttonCAD";
            this.buttonCAD.Size = new System.Drawing.Size(139, 49);
            this.buttonCAD.TabIndex = 3;
            this.buttonCAD.Text = "Cadastrar";
            this.buttonCAD.UseVisualStyleBackColor = false;
            this.buttonCAD.Click += new System.EventHandler(this.buttonCAD_Click);
            // 
            // buttonCON
            // 
            this.buttonCON.BackColor = System.Drawing.Color.Ivory;
            this.buttonCON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCON.Location = new System.Drawing.Point(12, 316);
            this.buttonCON.Name = "buttonCON";
            this.buttonCON.Size = new System.Drawing.Size(139, 49);
            this.buttonCON.TabIndex = 4;
            this.buttonCON.Text = "Consultar";
            this.buttonCON.UseVisualStyleBackColor = false;
            this.buttonCON.Click += new System.EventHandler(this.buttonCON_Click);
            // 
            // buttonATU
            // 
            this.buttonATU.BackColor = System.Drawing.Color.Ivory;
            this.buttonATU.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonATU.Location = new System.Drawing.Point(12, 369);
            this.buttonATU.Name = "buttonATU";
            this.buttonATU.Size = new System.Drawing.Size(139, 49);
            this.buttonATU.TabIndex = 5;
            this.buttonATU.Text = "Atualizar";
            this.buttonATU.UseVisualStyleBackColor = false;
            this.buttonATU.Click += new System.EventHandler(this.buttonATU_Click);
            // 
            // buttonEXC
            // 
            this.buttonEXC.BackColor = System.Drawing.Color.Ivory;
            this.buttonEXC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXC.Location = new System.Drawing.Point(12, 425);
            this.buttonEXC.Name = "buttonEXC";
            this.buttonEXC.Size = new System.Drawing.Size(139, 49);
            this.buttonEXC.TabIndex = 6;
            this.buttonEXC.Text = "Excluir";
            this.buttonEXC.UseVisualStyleBackColor = false;
            this.buttonEXC.Click += new System.EventHandler(this.buttonEXC_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.BackColor = System.Drawing.Color.Ivory;
            this.buttonSair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(1241, 693);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(113, 40);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Menu de Gerenciamento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label3.Location = new System.Drawing.Point(239, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ver Pedidos";
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.BackColor = System.Drawing.Color.Ivory;
            this.buttonPedidos.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.buttonPedidos.Location = new System.Drawing.Point(221, 261);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(139, 49);
            this.buttonPedidos.TabIndex = 10;
            this.buttonPedidos.Text = "Pedidos";
            this.buttonPedidos.UseVisualStyleBackColor = false;
            this.buttonPedidos.Click += new System.EventHandler(this.buttonPedidos_Click);
            // 
            // buttonEventos
            // 
            this.buttonEventos.BackColor = System.Drawing.Color.Ivory;
            this.buttonEventos.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.buttonEventos.Location = new System.Drawing.Point(430, 261);
            this.buttonEventos.Name = "buttonEventos";
            this.buttonEventos.Size = new System.Drawing.Size(139, 49);
            this.buttonEventos.TabIndex = 12;
            this.buttonEventos.Text = "Eventos";
            this.buttonEventos.UseVisualStyleBackColor = false;
            this.buttonEventos.Click += new System.EventHandler(this.buttonEventos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.Location = new System.Drawing.Point(446, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ver Eventos";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Shu.Properties.Resources.fundo_do_orçamento;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.buttonEventos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPedidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonEXC);
            this.Controls.Add(this.buttonATU);
            this.Controls.Add(this.buttonCON);
            this.Controls.Add(this.buttonCAD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPedidos;
        private System.Windows.Forms.Button buttonEventos;
        private System.Windows.Forms.Label label4;
    }
}

