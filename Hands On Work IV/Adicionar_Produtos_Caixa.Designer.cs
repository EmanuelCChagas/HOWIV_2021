
namespace Hands_On_Work_IV
{
    partial class Adicionar_Produtos_Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar_Produtos_Caixa));
            this.Data_CRUD = new System.Windows.Forms.DataGridView();
            this.Id_Produtos_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nome_Produtos_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Inserir_Produtos = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Quantidade_NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.Btn_Pesquisa = new System.Windows.Forms.Button();
            this.CodBarras_NumUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Data_CRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade_NumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodBarras_NumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_CRUD
            // 
            this.Data_CRUD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_CRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_CRUD.Location = new System.Drawing.Point(28, 88);
            this.Data_CRUD.Name = "Data_CRUD";
            this.Data_CRUD.Size = new System.Drawing.Size(629, 301);
            this.Data_CRUD.TabIndex = 75;
            this.Data_CRUD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CRUD_CellClick);
            // 
            // Id_Produtos_TextBox
            // 
            this.Id_Produtos_TextBox.Enabled = false;
            this.Id_Produtos_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Produtos_TextBox.Location = new System.Drawing.Point(59, 407);
            this.Id_Produtos_TextBox.Name = "Id_Produtos_TextBox";
            this.Id_Produtos_TextBox.ReadOnly = true;
            this.Id_Produtos_TextBox.Size = new System.Drawing.Size(47, 26);
            this.Id_Produtos_TextBox.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "ID";
            // 
            // Nome_Produtos_TextBox
            // 
            this.Nome_Produtos_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Produtos_TextBox.Location = new System.Drawing.Point(166, 6);
            this.Nome_Produtos_TextBox.Name = "Nome_Produtos_TextBox";
            this.Nome_Produtos_TextBox.Size = new System.Drawing.Size(491, 26);
            this.Nome_Produtos_TextBox.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 76;
            this.label8.Text = "Nome Do Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Código De Barras (EAN13)";
            // 
            // Btn_Inserir_Produtos
            // 
            this.Btn_Inserir_Produtos.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.Btn_Inserir_Produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Inserir_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Inserir_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inserir_Produtos.Location = new System.Drawing.Point(701, 376);
            this.Btn_Inserir_Produtos.Name = "Btn_Inserir_Produtos";
            this.Btn_Inserir_Produtos.Size = new System.Drawing.Size(87, 64);
            this.Btn_Inserir_Produtos.TabIndex = 93;
            this.Btn_Inserir_Produtos.Text = "Inserir";
            this.Btn_Inserir_Produtos.UseVisualStyleBackColor = false;
            this.Btn_Inserir_Produtos.Click += new System.EventHandler(this.Btn_Inserir_Produtos_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.Btn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(701, 286);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(87, 64);
            this.Btn_Voltar.TabIndex = 94;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Quantidade";
            // 
            // Quantidade_NumUpDown
            // 
            this.Quantidade_NumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantidade_NumUpDown.Location = new System.Drawing.Point(557, 407);
            this.Quantidade_NumUpDown.Name = "Quantidade_NumUpDown";
            this.Quantidade_NumUpDown.Size = new System.Drawing.Size(52, 26);
            this.Quantidade_NumUpDown.TabIndex = 96;
            this.Quantidade_NumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Btn_Pesquisa
            // 
            this.Btn_Pesquisa.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.Btn_Pesquisa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Pesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pesquisa.Location = new System.Drawing.Point(701, 186);
            this.Btn_Pesquisa.Name = "Btn_Pesquisa";
            this.Btn_Pesquisa.Size = new System.Drawing.Size(87, 67);
            this.Btn_Pesquisa.TabIndex = 97;
            this.Btn_Pesquisa.Text = "Pesquisar";
            this.Btn_Pesquisa.UseVisualStyleBackColor = false;
            this.Btn_Pesquisa.Click += new System.EventHandler(this.Btn_Pesquisa_Click);
            // 
            // CodBarras_NumUpDown
            // 
            this.CodBarras_NumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodBarras_NumUpDown.Location = new System.Drawing.Point(249, 48);
            this.CodBarras_NumUpDown.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.CodBarras_NumUpDown.Name = "CodBarras_NumUpDown";
            this.CodBarras_NumUpDown.Size = new System.Drawing.Size(408, 26);
            this.CodBarras_NumUpDown.TabIndex = 98;
            // 
            // Adicionar_Produtos_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CodBarras_NumUpDown);
            this.Controls.Add(this.Btn_Pesquisa);
            this.Controls.Add(this.Quantidade_NumUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Inserir_Produtos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id_Produtos_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nome_Produtos_TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Data_CRUD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adicionar_Produtos_Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.Data_CRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade_NumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodBarras_NumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_CRUD;
        private System.Windows.Forms.TextBox Id_Produtos_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nome_Produtos_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Inserir_Produtos;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Quantidade_NumUpDown;
        private System.Windows.Forms.Button Btn_Pesquisa;
        private System.Windows.Forms.NumericUpDown CodBarras_NumUpDown;
    }
}