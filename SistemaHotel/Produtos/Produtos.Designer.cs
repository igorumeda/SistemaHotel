
namespace SistemaHotel.Produtos
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.CboxFornecedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EdtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EdtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EdtBuscaNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EdtDescricao = new System.Windows.Forms.TextBox();
            this.EdtEstoque = new System.Windows.Forms.TextBox();
            this.BtnImgAnexa = new System.Windows.Forms.Button();
            this.BtnImgRemove = new System.Windows.Forms.Button();
            this.ImgProduto = new System.Windows.Forms.PictureBox();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(21, 217);
            this.Grid.Name = "Grid";
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(467, 224);
            this.Grid.TabIndex = 68;
            // 
            // CboxFornecedor
            // 
            this.CboxFornecedor.Enabled = false;
            this.CboxFornecedor.FormattingEnabled = true;
            this.CboxFornecedor.ItemHeight = 13;
            this.CboxFornecedor.Items.AddRange(new object[] {
            "Camareira",
            "Garçom",
            "Gerente"});
            this.CboxFornecedor.Location = new System.Drawing.Point(22, 119);
            this.CboxFornecedor.Name = "CboxFornecedor";
            this.CboxFornecedor.Size = new System.Drawing.Size(343, 21);
            this.CboxFornecedor.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Fornecedor";
            // 
            // EdtValor
            // 
            this.EdtValor.Enabled = false;
            this.EdtValor.Location = new System.Drawing.Point(22, 76);
            this.EdtValor.Name = "EdtValor";
            this.EdtValor.Size = new System.Drawing.Size(173, 20);
            this.EdtValor.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Valor";
            // 
            // EdtNome
            // 
            this.EdtNome.Enabled = false;
            this.EdtNome.Location = new System.Drawing.Point(21, 36);
            this.EdtNome.Name = "EdtNome";
            this.EdtNome.Size = new System.Drawing.Size(344, 20);
            this.EdtNome.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nome";
            // 
            // EdtBuscaNome
            // 
            this.EdtBuscaNome.Location = new System.Drawing.Point(65, 191);
            this.EdtBuscaNome.Name = "EdtBuscaNome";
            this.EdtBuscaNome.Size = new System.Drawing.Size(423, 20);
            this.EdtBuscaNome.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Buscar";
            // 
            // EdtDescricao
            // 
            this.EdtDescricao.Enabled = false;
            this.EdtDescricao.Location = new System.Drawing.Point(21, 165);
            this.EdtDescricao.Name = "EdtDescricao";
            this.EdtDescricao.Size = new System.Drawing.Size(467, 20);
            this.EdtDescricao.TabIndex = 61;
            // 
            // EdtEstoque
            // 
            this.EdtEstoque.Enabled = false;
            this.EdtEstoque.Location = new System.Drawing.Point(201, 76);
            this.EdtEstoque.Name = "EdtEstoque";
            this.EdtEstoque.Size = new System.Drawing.Size(164, 20);
            this.EdtEstoque.TabIndex = 61;
            // 
            // BtnImgAnexa
            // 
            this.BtnImgAnexa.Enabled = false;
            this.BtnImgAnexa.Location = new System.Drawing.Point(378, 132);
            this.BtnImgAnexa.Name = "BtnImgAnexa";
            this.BtnImgAnexa.Size = new System.Drawing.Size(110, 23);
            this.BtnImgAnexa.TabIndex = 76;
            this.BtnImgAnexa.Text = "Anexar Imagem";
            this.BtnImgAnexa.UseVisualStyleBackColor = true;
            this.BtnImgAnexa.Click += new System.EventHandler(this.BtnImgAnexa_Click);
            // 
            // BtnImgRemove
            // 
            this.BtnImgRemove.BackColor = System.Drawing.Color.Transparent;
            this.BtnImgRemove.Enabled = false;
            this.BtnImgRemove.FlatAppearance.BorderSize = 0;
            this.BtnImgRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImgRemove.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImgRemove.Location = new System.Drawing.Point(465, 15);
            this.BtnImgRemove.Name = "BtnImgRemove";
            this.BtnImgRemove.Size = new System.Drawing.Size(23, 25);
            this.BtnImgRemove.TabIndex = 77;
            this.BtnImgRemove.Text = "X";
            this.BtnImgRemove.UseVisualStyleBackColor = false;
            // 
            // ImgProduto
            // 
            this.ImgProduto.Location = new System.Drawing.Point(378, 15);
            this.ImgProduto.Name = "ImgProduto";
            this.ImgProduto.Size = new System.Drawing.Size(110, 111);
            this.ImgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgProduto.TabIndex = 75;
            this.ImgProduto.TabStop = false;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeletar.Enabled = false;
            this.BtnDeletar.FlatAppearance.BorderSize = 0;
            this.BtnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeletar.Image")));
            this.BtnDeletar.Location = new System.Drawing.Point(274, 449);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(75, 75);
            this.BtnDeletar.TabIndex = 74;
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.Enabled = false;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(190, 449);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 75);
            this.BtnEditar.TabIndex = 73;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.Location = new System.Drawing.Point(106, 449);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 75);
            this.BtnSalvar.TabIndex = 72;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.FlatAppearance.BorderSize = 0;
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNovo.Image")));
            this.BtnNovo.Location = new System.Drawing.Point(22, 449);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 75);
            this.BtnNovo.TabIndex = 71;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 543);
            this.Controls.Add(this.BtnImgRemove);
            this.Controls.Add(this.BtnImgAnexa);
            this.Controls.Add(this.ImgProduto);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.CboxFornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EdtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EdtEstoque);
            this.Controls.Add(this.EdtDescricao);
            this.Controls.Add(this.EdtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EdtBuscaNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.ComboBox CboxFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EdtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EdtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdtBuscaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EdtDescricao;
        private System.Windows.Forms.TextBox EdtEstoque;
        private System.Windows.Forms.PictureBox ImgProduto;
        private System.Windows.Forms.Button BtnImgAnexa;
        private System.Windows.Forms.Button BtnImgRemove;
    }
}