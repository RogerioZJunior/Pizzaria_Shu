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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogs = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEXCProduto = new System.Windows.Forms.Button();
            this.buttonATUProduto = new System.Windows.Forms.Button();
            this.buttonConProduto = new System.Windows.Forms.Button();
            this.buttonCADProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // buttonCAD
            // 
            this.buttonCAD.BackColor = System.Drawing.Color.Ivory;
            this.buttonCAD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCAD.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCAD.Location = new System.Drawing.Point(37, 280);
            this.buttonCAD.Name = "buttonCAD";
            this.buttonCAD.Size = new System.Drawing.Size(145, 55);
            this.buttonCAD.TabIndex = 3;
            this.buttonCAD.Text = "👤Cadastrar";
            this.buttonCAD.UseVisualStyleBackColor = false;
            this.buttonCAD.Click += new System.EventHandler(this.buttonCAD_Click);
            // 
            // buttonCON
            // 
            this.buttonCON.BackColor = System.Drawing.Color.Ivory;
            this.buttonCON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCON.Location = new System.Drawing.Point(37, 338);
            this.buttonCON.Name = "buttonCON";
            this.buttonCON.Size = new System.Drawing.Size(145, 55);
            this.buttonCON.TabIndex = 4;
            this.buttonCON.Text = "🪪Consultar";
            this.buttonCON.UseVisualStyleBackColor = false;
            this.buttonCON.Click += new System.EventHandler(this.buttonCON_Click);
            // 
            // buttonATU
            // 
            this.buttonATU.BackColor = System.Drawing.Color.Ivory;
            this.buttonATU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonATU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonATU.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonATU.Location = new System.Drawing.Point(37, 398);
            this.buttonATU.Name = "buttonATU";
            this.buttonATU.Size = new System.Drawing.Size(145, 55);
            this.buttonATU.TabIndex = 5;
            this.buttonATU.Text = "🔄️Atualizar";
            this.buttonATU.UseVisualStyleBackColor = false;
            this.buttonATU.Click += new System.EventHandler(this.buttonATU_Click);
            // 
            // buttonEXC
            // 
            this.buttonEXC.BackColor = System.Drawing.Color.Ivory;
            this.buttonEXC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEXC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEXC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXC.Location = new System.Drawing.Point(37, 459);
            this.buttonEXC.Name = "buttonEXC";
            this.buttonEXC.Size = new System.Drawing.Size(145, 55);
            this.buttonEXC.TabIndex = 6;
            this.buttonEXC.Text = "🗑️Excluir";
            this.buttonEXC.UseVisualStyleBackColor = false;
            this.buttonEXC.Click += new System.EventHandler(this.buttonEXC_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.BackColor = System.Drawing.Color.Ivory;
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(1241, 693);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(113, 40);
            this.buttonSair.TabIndex = 14;
            this.buttonSair.Text = "Sair➡️";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Menu de Gerenciamento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ver Pedidos";
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.BackColor = System.Drawing.Color.Ivory;
            this.buttonPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPedidos.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.buttonPedidos.Location = new System.Drawing.Point(391, 280);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(145, 55);
            this.buttonPedidos.TabIndex = 11;
            this.buttonPedidos.Text = "📜Pedidos";
            this.buttonPedidos.UseVisualStyleBackColor = false;
            this.buttonPedidos.Click += new System.EventHandler(this.buttonPedidos_Click);
            // 
            // buttonEventos
            // 
            this.buttonEventos.BackColor = System.Drawing.Color.Ivory;
            this.buttonEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEventos.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.buttonEventos.Location = new System.Drawing.Point(558, 280);
            this.buttonEventos.Name = "buttonEventos";
            this.buttonEventos.Size = new System.Drawing.Size(145, 55);
            this.buttonEventos.TabIndex = 12;
            this.buttonEventos.Text = "🎉Eventos";
            this.buttonEventos.UseVisualStyleBackColor = false;
            this.buttonEventos.Click += new System.EventHandler(this.buttonEventos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ver Eventos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuário";
            // 
            // buttonLogs
            // 
            this.buttonLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogs.BackColor = System.Drawing.Color.Ivory;
            this.buttonLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogs.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.buttonLogs.Location = new System.Drawing.Point(1241, 637);
            this.buttonLogs.Name = "buttonLogs";
            this.buttonLogs.Size = new System.Drawing.Size(113, 40);
            this.buttonLogs.TabIndex = 13;
            this.buttonLogs.Text = "📄Logs";
            this.buttonLogs.UseVisualStyleBackColor = false;
            this.buttonLogs.Click += new System.EventHandler(this.buttonLogs_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 27);
            this.label5.TabIndex = 62;
            this.label5.Text = "Produto";
            // 
            // buttonEXCProduto
            // 
            this.buttonEXCProduto.BackColor = System.Drawing.Color.Ivory;
            this.buttonEXCProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEXCProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEXCProduto.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXCProduto.Location = new System.Drawing.Point(222, 459);
            this.buttonEXCProduto.Name = "buttonEXCProduto";
            this.buttonEXCProduto.Size = new System.Drawing.Size(145, 55);
            this.buttonEXCProduto.TabIndex = 10;
            this.buttonEXCProduto.Text = "🗑️Excluir";
            this.buttonEXCProduto.UseVisualStyleBackColor = false;
            this.buttonEXCProduto.Click += new System.EventHandler(this.buttonEXCProduto_Click);
            // 
            // buttonATUProduto
            // 
            this.buttonATUProduto.BackColor = System.Drawing.Color.Ivory;
            this.buttonATUProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonATUProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonATUProduto.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonATUProduto.Location = new System.Drawing.Point(222, 398);
            this.buttonATUProduto.Name = "buttonATUProduto";
            this.buttonATUProduto.Size = new System.Drawing.Size(145, 55);
            this.buttonATUProduto.TabIndex = 9;
            this.buttonATUProduto.Text = "🔄️Atualizar";
            this.buttonATUProduto.UseVisualStyleBackColor = false;
            this.buttonATUProduto.Click += new System.EventHandler(this.buttonATUProduto_Click);
            // 
            // buttonConProduto
            // 
            this.buttonConProduto.BackColor = System.Drawing.Color.Ivory;
            this.buttonConProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConProduto.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConProduto.Location = new System.Drawing.Point(222, 338);
            this.buttonConProduto.Name = "buttonConProduto";
            this.buttonConProduto.Size = new System.Drawing.Size(145, 55);
            this.buttonConProduto.TabIndex = 8;
            this.buttonConProduto.Text = "🔎Consultar";
            this.buttonConProduto.UseVisualStyleBackColor = false;
            this.buttonConProduto.Click += new System.EventHandler(this.buttonConProduto_Click);
            // 
            // buttonCADProduto
            // 
            this.buttonCADProduto.BackColor = System.Drawing.Color.Ivory;
            this.buttonCADProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCADProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCADProduto.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCADProduto.Location = new System.Drawing.Point(222, 280);
            this.buttonCADProduto.Name = "buttonCADProduto";
            this.buttonCADProduto.Size = new System.Drawing.Size(145, 55);
            this.buttonCADProduto.TabIndex = 7;
            this.buttonCADProduto.Text = "🍕Cadastrar";
            this.buttonCADProduto.UseVisualStyleBackColor = false;
            this.buttonCADProduto.Click += new System.EventHandler(this.buttonCADProduto_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Shu.Properties.Resources.Fundo_Oficial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEXCProduto);
            this.Controls.Add(this.buttonATUProduto);
            this.Controls.Add(this.buttonConProduto);
            this.Controls.Add(this.buttonCADProduto);
            this.Controls.Add(this.buttonLogs);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEXCProduto;
        private System.Windows.Forms.Button buttonATUProduto;
        private System.Windows.Forms.Button buttonConProduto;
        private System.Windows.Forms.Button buttonCADProduto;
    }
}

