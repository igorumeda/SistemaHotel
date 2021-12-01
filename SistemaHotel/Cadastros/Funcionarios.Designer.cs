
namespace SistemaHotel.Cadastros
{
    partial class FrmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.EdtBuscaNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EdtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EdtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EdtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EdtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboxCargo = new System.Windows.Forms.ComboBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.radioNome = new System.Windows.Forms.RadioButton();
            this.radioCPF = new System.Windows.Forms.RadioButton();
            this.EdtBuscaCPF = new System.Windows.Forms.MaskedTextBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.btnBuscaCargo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar funcionário";
            // 
            // EdtBuscaNome
            // 
            this.EdtBuscaNome.Location = new System.Drawing.Point(222, 154);
            this.EdtBuscaNome.Name = "EdtBuscaNome";
            this.EdtBuscaNome.Size = new System.Drawing.Size(269, 20);
            this.EdtBuscaNome.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // EdtNome
            // 
            this.EdtNome.Enabled = false;
            this.EdtNome.Location = new System.Drawing.Point(24, 38);
            this.EdtNome.Name = "EdtNome";
            this.EdtNome.Size = new System.Drawing.Size(209, 20);
            this.EdtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPF";
            // 
            // EdtCPF
            // 
            this.EdtCPF.Enabled = false;
            this.EdtCPF.Location = new System.Drawing.Point(24, 77);
            this.EdtCPF.Mask = "000,000,000-00";
            this.EdtCPF.Name = "EdtCPF";
            this.EdtCPF.Size = new System.Drawing.Size(209, 20);
            this.EdtCPF.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Endereço";
            // 
            // EdtEndereco
            // 
            this.EdtEndereco.Enabled = false;
            this.EdtEndereco.Location = new System.Drawing.Point(24, 116);
            this.EdtEndereco.Name = "EdtEndereco";
            this.EdtEndereco.Size = new System.Drawing.Size(467, 20);
            this.EdtEndereco.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefone";
            // 
            // EdtTelefone
            // 
            this.EdtTelefone.Enabled = false;
            this.EdtTelefone.Location = new System.Drawing.Point(282, 38);
            this.EdtTelefone.Mask = "(00) 00000-0000";
            this.EdtTelefone.Name = "EdtTelefone";
            this.EdtTelefone.Size = new System.Drawing.Size(209, 20);
            this.EdtTelefone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cargo";
            // 
            // CboxCargo
            // 
            this.CboxCargo.Enabled = false;
            this.CboxCargo.FormattingEnabled = true;
            this.CboxCargo.ItemHeight = 13;
            this.CboxCargo.Items.AddRange(new object[] {
            "Camareira",
            "Garçom",
            "Gerente"});
            this.CboxCargo.Location = new System.Drawing.Point(282, 77);
            this.CboxCargo.Name = "CboxCargo";
            this.CboxCargo.Size = new System.Drawing.Size(185, 21);
            this.CboxCargo.TabIndex = 5;
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(24, 217);
            this.Grid.Name = "Grid";
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(467, 190);
            this.Grid.TabIndex = 51;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // radioNome
            // 
            this.radioNome.AutoSize = true;
            this.radioNome.Checked = true;
            this.radioNome.Location = new System.Drawing.Point(24, 177);
            this.radioNome.Name = "radioNome";
            this.radioNome.Size = new System.Drawing.Size(70, 17);
            this.radioNome.TabIndex = 52;
            this.radioNome.TabStop = true;
            this.radioNome.Text = "Por nome";
            this.radioNome.UseVisualStyleBackColor = true;
            this.radioNome.CheckedChanged += new System.EventHandler(this.radioNome_CheckedChanged);
            // 
            // radioCPF
            // 
            this.radioCPF.AutoSize = true;
            this.radioCPF.Location = new System.Drawing.Point(115, 177);
            this.radioCPF.Name = "radioCPF";
            this.radioCPF.Size = new System.Drawing.Size(69, 17);
            this.radioCPF.TabIndex = 52;
            this.radioCPF.Text = "Pelo CPF";
            this.radioCPF.UseVisualStyleBackColor = true;
            this.radioCPF.CheckedChanged += new System.EventHandler(this.radioCPF_CheckedChanged);
            // 
            // EdtBuscaCPF
            // 
            this.EdtBuscaCPF.Location = new System.Drawing.Point(222, 175);
            this.EdtBuscaCPF.Mask = "000,000,000-00";
            this.EdtBuscaCPF.Name = "EdtBuscaCPF";
            this.EdtBuscaCPF.Size = new System.Drawing.Size(92, 20);
            this.EdtBuscaCPF.TabIndex = 2;
            this.EdtBuscaCPF.Visible = false;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.FlatAppearance.BorderSize = 0;
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNovo.Image")));
            this.BtnNovo.Location = new System.Drawing.Point(25, 415);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 75);
            this.BtnNovo.TabIndex = 53;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.Location = new System.Drawing.Point(109, 415);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 75);
            this.BtnSalvar.TabIndex = 53;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.Enabled = false;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(193, 415);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 75);
            this.BtnEditar.TabIndex = 53;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeletar.Enabled = false;
            this.BtnDeletar.FlatAppearance.BorderSize = 0;
            this.BtnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeletar.Image")));
            this.BtnDeletar.Location = new System.Drawing.Point(277, 415);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(75, 75);
            this.BtnDeletar.TabIndex = 53;
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // btnBuscaCargo
            // 
            this.btnBuscaCargo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCargo.Image")));
            this.btnBuscaCargo.Location = new System.Drawing.Point(468, 76);
            this.btnBuscaCargo.Name = "btnBuscaCargo";
            this.btnBuscaCargo.Size = new System.Drawing.Size(23, 23);
            this.btnBuscaCargo.TabIndex = 54;
            this.btnBuscaCargo.UseVisualStyleBackColor = true;
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 504);
            this.Controls.Add(this.btnBuscaCargo);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.radioCPF);
            this.Controls.Add(this.radioNome);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.CboxCargo);
            this.Controls.Add(this.EdtTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EdtCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EdtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EdtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EdtBuscaNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EdtBuscaCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.FrmFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EdtBuscaNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox EdtCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EdtEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox EdtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.RadioButton radioNome;
        private System.Windows.Forms.RadioButton radioCPF;
        private System.Windows.Forms.MaskedTextBox EdtBuscaCPF;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.ComboBox CboxCargo;
        private System.Windows.Forms.Button btnBuscaCargo;
    }
}