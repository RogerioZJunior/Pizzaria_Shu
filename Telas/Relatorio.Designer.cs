namespace Pizza_Shu
{
    partial class Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            this.panelTotalPedidos = new System.Windows.Forms.Panel();
            this.labelnNumeroTotalPedidos = new System.Windows.Forms.Label();
            this.panelPedidoEntregues = new System.Windows.Forms.Panel();
            this.labelNumeroPedidoEntregue = new System.Windows.Forms.Label();
            this.panelFaturamento = new System.Windows.Forms.Panel();
            this.labelNumeroFaturamento = new System.Windows.Forms.Label();
            this.panelPedidosCancelados = new System.Windows.Forms.Panel();
            this.labelNumeroPedidoCancelado = new System.Windows.Forms.Label();
            this.buttonSairRelatorio = new System.Windows.Forms.Button();
            this.panelOrcamentoTotal = new System.Windows.Forms.Panel();
            this.labelNumeroTotalDeOrcamento = new System.Windows.Forms.Label();
            this.panelEventosConcluidos = new System.Windows.Forms.Panel();
            this.labelEventoConcluido = new System.Windows.Forms.Label();
            this.panelEventosTotais = new System.Windows.Forms.Panel();
            this.labelTotalEvento = new System.Windows.Forms.Label();
            this.panelEventoCancelado = new System.Windows.Forms.Panel();
            this.labelNumeroEventosCancelado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTotalPedidos.SuspendLayout();
            this.panelPedidoEntregues.SuspendLayout();
            this.panelFaturamento.SuspendLayout();
            this.panelPedidosCancelados.SuspendLayout();
            this.panelOrcamentoTotal.SuspendLayout();
            this.panelEventosConcluidos.SuspendLayout();
            this.panelEventosTotais.SuspendLayout();
            this.panelEventoCancelado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTotalPedidos
            // 
            this.panelTotalPedidos.BackColor = System.Drawing.Color.Transparent;
            this.panelTotalPedidos.Controls.Add(this.labelnNumeroTotalPedidos);
            this.panelTotalPedidos.ForeColor = System.Drawing.Color.Black;
            this.panelTotalPedidos.Location = new System.Drawing.Point(157, 151);
            this.panelTotalPedidos.Name = "panelTotalPedidos";
            this.panelTotalPedidos.Size = new System.Drawing.Size(225, 226);
            this.panelTotalPedidos.TabIndex = 5;
            this.panelTotalPedidos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTotalPedidos_Paint);
            // 
            // labelnNumeroTotalPedidos
            // 
            this.labelnNumeroTotalPedidos.AutoSize = true;
            this.labelnNumeroTotalPedidos.BackColor = System.Drawing.Color.Transparent;
            this.labelnNumeroTotalPedidos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnNumeroTotalPedidos.Location = new System.Drawing.Point(100, 104);
            this.labelnNumeroTotalPedidos.Name = "labelnNumeroTotalPedidos";
            this.labelnNumeroTotalPedidos.Size = new System.Drawing.Size(21, 23);
            this.labelnNumeroTotalPedidos.TabIndex = 3;
            this.labelnNumeroTotalPedidos.Text = "0";
            this.labelnNumeroTotalPedidos.Click += new System.EventHandler(this.labelnNumeroTotalPedidos_Click);
            // 
            // panelPedidoEntregues
            // 
            this.panelPedidoEntregues.BackColor = System.Drawing.Color.Transparent;
            this.panelPedidoEntregues.Controls.Add(this.labelNumeroPedidoEntregue);
            this.panelPedidoEntregues.ForeColor = System.Drawing.Color.Black;
            this.panelPedidoEntregues.Location = new System.Drawing.Point(413, 151);
            this.panelPedidoEntregues.Name = "panelPedidoEntregues";
            this.panelPedidoEntregues.Size = new System.Drawing.Size(225, 226);
            this.panelPedidoEntregues.TabIndex = 6;
            this.panelPedidoEntregues.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPedidoEntregues_Paint);
            // 
            // labelNumeroPedidoEntregue
            // 
            this.labelNumeroPedidoEntregue.AutoSize = true;
            this.labelNumeroPedidoEntregue.BackColor = System.Drawing.Color.Transparent;
            this.labelNumeroPedidoEntregue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroPedidoEntregue.Location = new System.Drawing.Point(86, 104);
            this.labelNumeroPedidoEntregue.Name = "labelNumeroPedidoEntregue";
            this.labelNumeroPedidoEntregue.Size = new System.Drawing.Size(21, 23);
            this.labelNumeroPedidoEntregue.TabIndex = 3;
            this.labelNumeroPedidoEntregue.Text = "0";
            this.labelNumeroPedidoEntregue.Click += new System.EventHandler(this.labelNumeroPedidoEntregue_Click);
            // 
            // panelFaturamento
            // 
            this.panelFaturamento.BackColor = System.Drawing.Color.Transparent;
            this.panelFaturamento.Controls.Add(this.labelNumeroFaturamento);
            this.panelFaturamento.ForeColor = System.Drawing.Color.Black;
            this.panelFaturamento.Location = new System.Drawing.Point(413, 407);
            this.panelFaturamento.Name = "panelFaturamento";
            this.panelFaturamento.Size = new System.Drawing.Size(225, 214);
            this.panelFaturamento.TabIndex = 7;
            this.panelFaturamento.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFaturamento_Paint);
            // 
            // labelNumeroFaturamento
            // 
            this.labelNumeroFaturamento.AutoSize = true;
            this.labelNumeroFaturamento.BackColor = System.Drawing.Color.Transparent;
            this.labelNumeroFaturamento.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroFaturamento.Location = new System.Drawing.Point(66, 62);
            this.labelNumeroFaturamento.Name = "labelNumeroFaturamento";
            this.labelNumeroFaturamento.Size = new System.Drawing.Size(21, 23);
            this.labelNumeroFaturamento.TabIndex = 3;
            this.labelNumeroFaturamento.Text = "0";
            this.labelNumeroFaturamento.Click += new System.EventHandler(this.labelNumeroFaturamento_Click);
            // 
            // panelPedidosCancelados
            // 
            this.panelPedidosCancelados.BackColor = System.Drawing.Color.Transparent;
            this.panelPedidosCancelados.Controls.Add(this.labelNumeroPedidoCancelado);
            this.panelPedidosCancelados.ForeColor = System.Drawing.Color.Black;
            this.panelPedidosCancelados.Location = new System.Drawing.Point(157, 407);
            this.panelPedidosCancelados.Name = "panelPedidosCancelados";
            this.panelPedidosCancelados.Size = new System.Drawing.Size(225, 214);
            this.panelPedidosCancelados.TabIndex = 8;
            this.panelPedidosCancelados.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPedidosCancelados_Paint);
            // 
            // labelNumeroPedidoCancelado
            // 
            this.labelNumeroPedidoCancelado.AutoSize = true;
            this.labelNumeroPedidoCancelado.BackColor = System.Drawing.Color.Transparent;
            this.labelNumeroPedidoCancelado.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroPedidoCancelado.Location = new System.Drawing.Point(100, 76);
            this.labelNumeroPedidoCancelado.Name = "labelNumeroPedidoCancelado";
            this.labelNumeroPedidoCancelado.Size = new System.Drawing.Size(21, 23);
            this.labelNumeroPedidoCancelado.TabIndex = 3;
            this.labelNumeroPedidoCancelado.Text = "0";
            this.labelNumeroPedidoCancelado.Click += new System.EventHandler(this.labelNumeroPedidoCancelado_Click);
            // 
            // buttonSairRelatorio
            // 
            this.buttonSairRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSairRelatorio.BackColor = System.Drawing.Color.Ivory;
            this.buttonSairRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSairRelatorio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairRelatorio.ForeColor = System.Drawing.Color.Purple;
            this.buttonSairRelatorio.Location = new System.Drawing.Point(1243, 692);
            this.buttonSairRelatorio.Name = "buttonSairRelatorio";
            this.buttonSairRelatorio.Size = new System.Drawing.Size(115, 45);
            this.buttonSairRelatorio.TabIndex = 9;
            this.buttonSairRelatorio.Text = "Voltar➡️";
            this.buttonSairRelatorio.UseVisualStyleBackColor = false;
            this.buttonSairRelatorio.Click += new System.EventHandler(this.buttonSairRelatorio_Click_1);
            // 
            // panelOrcamentoTotal
            // 
            this.panelOrcamentoTotal.BackColor = System.Drawing.Color.Transparent;
            this.panelOrcamentoTotal.Controls.Add(this.labelNumeroTotalDeOrcamento);
            this.panelOrcamentoTotal.ForeColor = System.Drawing.Color.Black;
            this.panelOrcamentoTotal.Location = new System.Drawing.Point(891, 407);
            this.panelOrcamentoTotal.Name = "panelOrcamentoTotal";
            this.panelOrcamentoTotal.Size = new System.Drawing.Size(208, 214);
            this.panelOrcamentoTotal.TabIndex = 8;
            this.panelOrcamentoTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOrcamentoTotal_Paint);
            // 
            // labelNumeroTotalDeOrcamento
            // 
            this.labelNumeroTotalDeOrcamento.AutoSize = true;
            this.labelNumeroTotalDeOrcamento.BackColor = System.Drawing.Color.Transparent;
            this.labelNumeroTotalDeOrcamento.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroTotalDeOrcamento.Location = new System.Drawing.Point(45, 76);
            this.labelNumeroTotalDeOrcamento.Name = "labelNumeroTotalDeOrcamento";
            this.labelNumeroTotalDeOrcamento.Size = new System.Drawing.Size(21, 23);
            this.labelNumeroTotalDeOrcamento.TabIndex = 3;
            this.labelNumeroTotalDeOrcamento.Text = "0";
            this.labelNumeroTotalDeOrcamento.Click += new System.EventHandler(this.labelNumeroTotalDeOrcamento_Click);
            // 
            // panelEventosConcluidos
            // 
            this.panelEventosConcluidos.BackColor = System.Drawing.Color.Transparent;
            this.panelEventosConcluidos.Controls.Add(this.labelEventoConcluido);
            this.panelEventosConcluidos.ForeColor = System.Drawing.Color.Black;
            this.panelEventosConcluidos.Location = new System.Drawing.Point(891, 151);
            this.panelEventosConcluidos.Name = "panelEventosConcluidos";
            this.panelEventosConcluidos.Size = new System.Drawing.Size(208, 226);
            this.panelEventosConcluidos.TabIndex = 7;
            this.panelEventosConcluidos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEventosConcluidos_Paint);
            // 
            // labelEventoConcluido
            // 
            this.labelEventoConcluido.AutoSize = true;
            this.labelEventoConcluido.BackColor = System.Drawing.Color.Transparent;
            this.labelEventoConcluido.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventoConcluido.Location = new System.Drawing.Point(89, 104);
            this.labelEventoConcluido.Name = "labelEventoConcluido";
            this.labelEventoConcluido.Size = new System.Drawing.Size(21, 23);
            this.labelEventoConcluido.TabIndex = 3;
            this.labelEventoConcluido.Text = "0";
            this.labelEventoConcluido.Click += new System.EventHandler(this.labelEventoConcluido_Click);
            // 
            // panelEventosTotais
            // 
            this.panelEventosTotais.BackColor = System.Drawing.Color.Transparent;
            this.panelEventosTotais.Controls.Add(this.labelTotalEvento);
            this.panelEventosTotais.ForeColor = System.Drawing.Color.Black;
            this.panelEventosTotais.Location = new System.Drawing.Point(666, 151);
            this.panelEventosTotais.Name = "panelEventosTotais";
            this.panelEventosTotais.Size = new System.Drawing.Size(194, 226);
            this.panelEventosTotais.TabIndex = 8;
            this.panelEventosTotais.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEventosTotais_Paint);
            // 
            // labelTotalEvento
            // 
            this.labelTotalEvento.AutoSize = true;
            this.labelTotalEvento.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalEvento.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEvento.Location = new System.Drawing.Point(89, 104);
            this.labelTotalEvento.Name = "labelTotalEvento";
            this.labelTotalEvento.Size = new System.Drawing.Size(21, 23);
            this.labelTotalEvento.TabIndex = 3;
            this.labelTotalEvento.Text = "0";
            this.labelTotalEvento.Click += new System.EventHandler(this.labelTotalEvento_Click);
            // 
            // panelEventoCancelado
            // 
            this.panelEventoCancelado.BackColor = System.Drawing.Color.Transparent;
            this.panelEventoCancelado.Controls.Add(this.labelNumeroEventosCancelado);
            this.panelEventoCancelado.ForeColor = System.Drawing.Color.Black;
            this.panelEventoCancelado.Location = new System.Drawing.Point(666, 407);
            this.panelEventoCancelado.Name = "panelEventoCancelado";
            this.panelEventoCancelado.Size = new System.Drawing.Size(194, 214);
            this.panelEventoCancelado.TabIndex = 9;
            this.panelEventoCancelado.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEventoCancelado_Paint);
            // 
            // labelNumeroEventosCancelado
            // 
            this.labelNumeroEventosCancelado.AutoSize = true;
            this.labelNumeroEventosCancelado.BackColor = System.Drawing.Color.Transparent;
            this.labelNumeroEventosCancelado.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroEventosCancelado.Location = new System.Drawing.Point(89, 76);
            this.labelNumeroEventosCancelado.Name = "labelNumeroEventosCancelado";
            this.labelNumeroEventosCancelado.Size = new System.Drawing.Size(21, 23);
            this.labelNumeroEventosCancelado.TabIndex = 3;
            this.labelNumeroEventosCancelado.Text = "0";
            this.labelNumeroEventosCancelado.Click += new System.EventHandler(this.labelNumeroEventosCancelado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Pizza_Shu.Properties.Resources.cartaozinho_feito_com_amor;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1119, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 308);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Shu.Properties.Resources.pizza_shu_relatorios_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelEventoCancelado);
            this.Controls.Add(this.panelEventosTotais);
            this.Controls.Add(this.panelEventosConcluidos);
            this.Controls.Add(this.panelOrcamentoTotal);
            this.Controls.Add(this.buttonSairRelatorio);
            this.Controls.Add(this.panelPedidosCancelados);
            this.Controls.Add(this.panelFaturamento);
            this.Controls.Add(this.panelPedidoEntregues);
            this.Controls.Add(this.panelTotalPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio";
            this.Text = "Relatórios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.panelTotalPedidos.ResumeLayout(false);
            this.panelTotalPedidos.PerformLayout();
            this.panelPedidoEntregues.ResumeLayout(false);
            this.panelPedidoEntregues.PerformLayout();
            this.panelFaturamento.ResumeLayout(false);
            this.panelFaturamento.PerformLayout();
            this.panelPedidosCancelados.ResumeLayout(false);
            this.panelPedidosCancelados.PerformLayout();
            this.panelOrcamentoTotal.ResumeLayout(false);
            this.panelOrcamentoTotal.PerformLayout();
            this.panelEventosConcluidos.ResumeLayout(false);
            this.panelEventosConcluidos.PerformLayout();
            this.panelEventosTotais.ResumeLayout(false);
            this.panelEventosTotais.PerformLayout();
            this.panelEventoCancelado.ResumeLayout(false);
            this.panelEventoCancelado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTotalPedidos;
        private System.Windows.Forms.Label labelnNumeroTotalPedidos;
        private System.Windows.Forms.Panel panelPedidoEntregues;
        private System.Windows.Forms.Label labelNumeroPedidoEntregue;
        private System.Windows.Forms.Panel panelFaturamento;
        private System.Windows.Forms.Label labelNumeroFaturamento;
        private System.Windows.Forms.Panel panelPedidosCancelados;
        private System.Windows.Forms.Label labelNumeroPedidoCancelado;
        private System.Windows.Forms.Button buttonSairRelatorio;
        private System.Windows.Forms.Panel panelOrcamentoTotal;
        private System.Windows.Forms.Label labelNumeroTotalDeOrcamento;
        private System.Windows.Forms.Panel panelEventosConcluidos;
        private System.Windows.Forms.Label labelEventoConcluido;
        private System.Windows.Forms.Panel panelEventosTotais;
        private System.Windows.Forms.Label labelTotalEvento;
        private System.Windows.Forms.Panel panelEventoCancelado;
        private System.Windows.Forms.Label labelNumeroEventosCancelado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}