namespace Trabalho
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            richTextBox1 = new RichTextBox();
            txtNome = new TextBox();
            cmbCategoria = new ComboBox();
            cmbFornecedor = new ComboBox();
            txtCodigo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnNovo = new Button();
            btnExcluir = new Button();
            groupBox2 = new GroupBox();
            nudPrecoVenda = new NumericUpDown();
            nudStockMinimo = new NumericUpDown();
            nudStockInicial = new NumericUpDown();
            txtMargem = new TextBox();
            nudPrecoCusto = new NumericUpDown();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            chkProduto = new CheckBox();
            dtpDatacadastro = new DateTimePicker();
            label13 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecoVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecoCusto).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            panel1.Location = new Point(-2, -3);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1305, 80);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 51);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(80, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produtos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(cmbFornecedor);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(894, 195);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Principais";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(192, 64, 0);
            label16.Location = new Point(727, 37);
            label16.Name = "label16";
            label16.Size = new Size(12, 13);
            label16.TabIndex = 14;
            label16.Text = "*";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(192, 64, 0);
            label15.Location = new Point(330, 37);
            label15.Name = "label15";
            label15.Size = new Size(12, 13);
            label15.TabIndex = 13;
            label15.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(192, 64, 0);
            label14.Location = new Point(81, 100);
            label14.Name = "label14";
            label14.Size = new Size(12, 13);
            label14.TabIndex = 12;
            label14.Text = "*";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(254, 116);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBox1.Size = new Size(314, 79);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(205, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(419, 26);
            txtNome.TabIndex = 10;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(653, 61);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(221, 20);
            cmbCategoria.TabIndex = 9;
            cmbCategoria.Text = "Selecione...";
            // 
            // cmbFornecedor
            // 
            cmbFornecedor.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFornecedor.FormattingEnabled = true;
            cmbFornecedor.Location = new Point(6, 120);
            cmbFornecedor.Name = "cmbFornecedor";
            cmbFornecedor.Size = new Size(198, 20);
            cmbFornecedor.TabIndex = 8;
            cmbFornecedor.Text = "Selecione...";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.ScrollBar;
            txtCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(6, 56);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(180, 27);
            txtCodigo.TabIndex = 7;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(4, 37);
            label8.Name = "label8";
            label8.Size = new Size(48, 13);
            label8.TabIndex = 6;
            label8.Text = "Código:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(256, 96);
            label7.Name = "label7";
            label7.Size = new Size(59, 13);
            label7.TabIndex = 5;
            label7.Text = "Descrição:";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 100);
            label4.Name = "label4";
            label4.Size = new Size(69, 13);
            label4.TabIndex = 2;
            label4.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(653, 41);
            label3.Name = "label3";
            label3.Size = new Size(60, 13);
            label3.TabIndex = 1;
            label3.Text = "Categoria:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 37);
            label2.Name = "label2";
            label2.Size = new Size(103, 13);
            label2.TabIndex = 0;
            label2.Text = "Nome Do Produto:";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(356, 454);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(124, 47);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpar.Location = new Point(499, 455);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(116, 46);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += button2_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.Location = new Point(224, 454);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(117, 47);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(633, 454);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(107, 47);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nudPrecoVenda);
            groupBox2.Controls.Add(nudStockMinimo);
            groupBox2.Controls.Add(nudStockInicial);
            groupBox2.Controls.Add(txtMargem);
            groupBox2.Controls.Add(nudPrecoCusto);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(590, 169);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Precificação e Estoque";
            // 
            // nudPrecoVenda
            // 
            nudPrecoVenda.DecimalPlaces = 2;
            nudPrecoVenda.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPrecoVenda.Location = new Point(476, 31);
            nudPrecoVenda.Margin = new Padding(5);
            nudPrecoVenda.Name = "nudPrecoVenda";
            nudPrecoVenda.Size = new Size(92, 21);
            nudPrecoVenda.TabIndex = 13;
            // 
            // nudStockMinimo
            // 
            nudStockMinimo.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudStockMinimo.Location = new Point(408, 120);
            nudStockMinimo.Margin = new Padding(5);
            nudStockMinimo.Name = "nudStockMinimo";
            nudStockMinimo.Size = new Size(97, 21);
            nudStockMinimo.TabIndex = 12;
            // 
            // nudStockInicial
            // 
            nudStockInicial.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudStockInicial.Location = new Point(96, 120);
            nudStockInicial.Margin = new Padding(5);
            nudStockInicial.Name = "nudStockInicial";
            nudStockInicial.Size = new Size(83, 21);
            nudStockInicial.TabIndex = 11;
            // 
            // txtMargem
            // 
            txtMargem.BackColor = SystemColors.ScrollBar;
            txtMargem.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMargem.Location = new Point(112, 74);
            txtMargem.Name = "txtMargem";
            txtMargem.Size = new Size(112, 21);
            txtMargem.TabIndex = 10;
            txtMargem.Text = "0,00";
            // 
            // nudPrecoCusto
            // 
            nudPrecoCusto.DecimalPlaces = 2;
            nudPrecoCusto.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPrecoCusto.Location = new Point(141, 31);
            nudPrecoCusto.Margin = new Padding(5);
            nudPrecoCusto.Name = "nudPrecoCusto";
            nudPrecoCusto.Size = new Size(103, 21);
            nudPrecoCusto.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(6, 124);
            label12.Name = "label12";
            label12.Size = new Size(74, 13);
            label12.TabIndex = 8;
            label12.Text = "Stock Inicial: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 35);
            label11.Name = "label11";
            label11.Size = new Size(109, 13);
            label11.TabIndex = 7;
            label11.Text = "Preço de Custo (R$):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(418, 105);
            label10.Name = "label10";
            label10.Size = new Size(0, 13);
            label10.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(334, 35);
            label9.Name = "label9";
            label9.Size = new Size(114, 13);
            label9.TabIndex = 5;
            label9.Text = "Preço de Venda (R$): ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 77);
            label5.Name = "label5";
            label5.Size = new Size(74, 13);
            label5.TabIndex = 3;
            label5.Text = "Margem (R$):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(297, 124);
            label6.Name = "label6";
            label6.Size = new Size(80, 13);
            label6.TabIndex = 4;
            label6.Text = "Stock Mínimo:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkProduto);
            groupBox3.Controls.Add(dtpDatacadastro);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(608, 277);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(298, 169);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Situação / Detalhes";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // chkProduto
            // 
            chkProduto.AutoSize = true;
            chkProduto.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkProduto.Location = new Point(6, 37);
            chkProduto.Name = "chkProduto";
            chkProduto.Size = new Size(97, 17);
            chkProduto.TabIndex = 11;
            chkProduto.Text = "Produto Ativo";
            chkProduto.UseVisualStyleBackColor = true;
            // 
            // dtpDatacadastro
            // 
            dtpDatacadastro.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDatacadastro.Format = DateTimePickerFormat.Short;
            dtpDatacadastro.Location = new Point(6, 105);
            dtpDatacadastro.Name = "dtpDatacadastro";
            dtpDatacadastro.Size = new Size(204, 21);
            dtpDatacadastro.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(6, 82);
            label13.Name = "label13";
            label13.Size = new Size(102, 13);
            label13.TabIndex = 9;
            label13.Text = "Data de Cadastro: ";
            label13.Click += label13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 526);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Cadastro de Produtos";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecoVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecoCusto).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnNovo;
        private Button btnExcluir;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label13;
        private TextBox txtNome;
        private ComboBox cmbCategoria;
        private ComboBox cmbFornecedor;
        private TextBox txtCodigo;
        private NumericUpDown nudPrecoVenda;
        private NumericUpDown nudStockMinimo;
        private NumericUpDown nudStockInicial;
        private TextBox txtMargem;
        private NumericUpDown nudPrecoCusto;
        private RichTextBox richTextBox1;
        private CheckBox chkProduto;
        private DateTimePicker dtpDatacadastro;
        private Label label16;
        private Label label15;
        private Label label14;
    }
}
