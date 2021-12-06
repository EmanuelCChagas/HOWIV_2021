
namespace Hands_On_Work_IV
{
    partial class Caixa_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Data_CRUD = new System.Windows.Forms.DataGridView();
            this.ID_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço_Total_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Remover_Produtos = new System.Windows.Forms.Button();
            this.Btn_Alterar_Pagamento = new System.Windows.Forms.Button();
            this.Cliente_Caixa_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Adicionar_Produtos = new System.Windows.Forms.Button();
            this.Btn_Adicionar_Clientes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pagamento_Caixa_TextBox = new System.Windows.Forms.TextBox();
            this.Valor_Total_Num = new System.Windows.Forms.NumericUpDown();
            this.Btn_Finalizar_Venda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_CRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Valor_Total_Num)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_CRUD
            // 
            this.Data_CRUD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_CRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Data_CRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_CRUD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_column,
            this.Nome_column,
            this.Cod_Column,
            this.Preço_Column,
            this.Quantidade_Column,
            this.Preço_Total_Column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_CRUD.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data_CRUD.Location = new System.Drawing.Point(23, 72);
            this.Data_CRUD.Name = "Data_CRUD";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_CRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Data_CRUD.Size = new System.Drawing.Size(768, 371);
            this.Data_CRUD.TabIndex = 96;
            // 
            // ID_column
            // 
            this.ID_column.HeaderText = "ID";
            this.ID_column.Name = "ID_column";
            // 
            // Nome_column
            // 
            this.Nome_column.HeaderText = "Nome";
            this.Nome_column.Name = "Nome_column";
            // 
            // Cod_Column
            // 
            this.Cod_Column.HeaderText = "Código de Barras";
            this.Cod_Column.Name = "Cod_Column";
            // 
            // Preço_Column
            // 
            this.Preço_Column.HeaderText = "Preço Unit";
            this.Preço_Column.Name = "Preço_Column";
            // 
            // Quantidade_Column
            // 
            this.Quantidade_Column.HeaderText = "Quantidade";
            this.Quantidade_Column.Name = "Quantidade_Column";
            // 
            // Preço_Total_Column
            // 
            this.Preço_Total_Column.HeaderText = "Preço Total";
            this.Preço_Total_Column.Name = "Preço_Total_Column";
            // 
            // Btn_Remover_Produtos
            // 
            this.Btn_Remover_Produtos.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.Btn_Remover_Produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Remover_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Remover_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remover_Produtos.Location = new System.Drawing.Point(803, 355);
            this.Btn_Remover_Produtos.Name = "Btn_Remover_Produtos";
            this.Btn_Remover_Produtos.Size = new System.Drawing.Size(104, 88);
            this.Btn_Remover_Produtos.TabIndex = 99;
            this.Btn_Remover_Produtos.Text = "Remover Produtos";
            this.Btn_Remover_Produtos.UseVisualStyleBackColor = false;
            this.Btn_Remover_Produtos.Click += new System.EventHandler(this.Btn_Remover_Produtos_Click);
            // 
            // Btn_Alterar_Pagamento
            // 
            this.Btn_Alterar_Pagamento.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.Btn_Alterar_Pagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Alterar_Pagamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Alterar_Pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Alterar_Pagamento.Location = new System.Drawing.Point(803, 261);
            this.Btn_Alterar_Pagamento.Name = "Btn_Alterar_Pagamento";
            this.Btn_Alterar_Pagamento.Size = new System.Drawing.Size(104, 88);
            this.Btn_Alterar_Pagamento.TabIndex = 98;
            this.Btn_Alterar_Pagamento.Text = "Alterar Forma De Pagamento";
            this.Btn_Alterar_Pagamento.UseVisualStyleBackColor = false;
            this.Btn_Alterar_Pagamento.Click += new System.EventHandler(this.Btn_AlterarPagamento_Produtos_Click);
            // 
            // Cliente_Caixa_TextBox
            // 
            this.Cliente_Caixa_TextBox.Enabled = false;
            this.Cliente_Caixa_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_Caixa_TextBox.Location = new System.Drawing.Point(99, 461);
            this.Cliente_Caixa_TextBox.Name = "Cliente_Caixa_TextBox";
            this.Cliente_Caixa_TextBox.ReadOnly = true;
            this.Cliente_Caixa_TextBox.Size = new System.Drawing.Size(202, 29);
            this.Cliente_Caixa_TextBox.TabIndex = 94;
            this.Cliente_Caixa_TextBox.Text = " Não Cadastrado";
            this.Cliente_Caixa_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 93;
            this.label5.Text = "Cliente";
            // 
            // Btn_Adicionar_Produtos
            // 
            this.Btn_Adicionar_Produtos.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.Btn_Adicionar_Produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Adicionar_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Adicionar_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Adicionar_Produtos.Location = new System.Drawing.Point(803, 72);
            this.Btn_Adicionar_Produtos.Name = "Btn_Adicionar_Produtos";
            this.Btn_Adicionar_Produtos.Size = new System.Drawing.Size(104, 88);
            this.Btn_Adicionar_Produtos.TabIndex = 97;
            this.Btn_Adicionar_Produtos.Text = "Adicionar Produtos";
            this.Btn_Adicionar_Produtos.UseVisualStyleBackColor = false;
            this.Btn_Adicionar_Produtos.Click += new System.EventHandler(this.Btn_Adicionar_Produtos_Click);
            // 
            // Btn_Adicionar_Clientes
            // 
            this.Btn_Adicionar_Clientes.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.Btn_Adicionar_Clientes.BackColor = System.Drawing.Color.PaleGreen;
            this.Btn_Adicionar_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Adicionar_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Adicionar_Clientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Adicionar_Clientes.Location = new System.Drawing.Point(803, 167);
            this.Btn_Adicionar_Clientes.Name = "Btn_Adicionar_Clientes";
            this.Btn_Adicionar_Clientes.Size = new System.Drawing.Size(104, 88);
            this.Btn_Adicionar_Clientes.TabIndex = 100;
            this.Btn_Adicionar_Clientes.Text = "Adicionar Clientes";
            this.Btn_Adicionar_Clientes.UseVisualStyleBackColor = false;
            this.Btn_Adicionar_Clientes.Click += new System.EventHandler(this.Btn_Adicionar_Clientes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 33);
            this.label3.TabIndex = 91;
            this.label3.Text = "Caixa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 101;
            this.label1.Text = "Forma De Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 103;
            this.label2.Text = "Valor Total";
            // 
            // Pagamento_Caixa_TextBox
            // 
            this.Pagamento_Caixa_TextBox.Enabled = false;
            this.Pagamento_Caixa_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pagamento_Caixa_TextBox.Location = new System.Drawing.Point(532, 461);
            this.Pagamento_Caixa_TextBox.Name = "Pagamento_Caixa_TextBox";
            this.Pagamento_Caixa_TextBox.ReadOnly = true;
            this.Pagamento_Caixa_TextBox.Size = new System.Drawing.Size(202, 29);
            this.Pagamento_Caixa_TextBox.TabIndex = 105;
            this.Pagamento_Caixa_TextBox.Text = "Dinheiro";
            this.Pagamento_Caixa_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Valor_Total_Num
            // 
            this.Valor_Total_Num.DecimalPlaces = 2;
            this.Valor_Total_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_Total_Num.InterceptArrowKeys = false;
            this.Valor_Total_Num.Location = new System.Drawing.Point(532, 499);
            this.Valor_Total_Num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Valor_Total_Num.Name = "Valor_Total_Num";
            this.Valor_Total_Num.ReadOnly = true;
            this.Valor_Total_Num.Size = new System.Drawing.Size(202, 29);
            this.Valor_Total_Num.TabIndex = 107;
            this.Valor_Total_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Finalizar_Venda
            // 
            this.Btn_Finalizar_Venda.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.Btn_Finalizar_Venda.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_Finalizar_Venda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Finalizar_Venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Finalizar_Venda.Location = new System.Drawing.Point(800, 499);
            this.Btn_Finalizar_Venda.Name = "Btn_Finalizar_Venda";
            this.Btn_Finalizar_Venda.Size = new System.Drawing.Size(107, 65);
            this.Btn_Finalizar_Venda.TabIndex = 108;
            this.Btn_Finalizar_Venda.Text = "Finalizar Venda";
            this.Btn_Finalizar_Venda.UseVisualStyleBackColor = false;
            this.Btn_Finalizar_Venda.Click += new System.EventHandler(this.Btn_Finazar_Venda_Click);
            // 
            // Caixa_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 574);
            this.Controls.Add(this.Btn_Finalizar_Venda);
            this.Controls.Add(this.Valor_Total_Num);
            this.Controls.Add(this.Pagamento_Caixa_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_CRUD);
            this.Controls.Add(this.Btn_Remover_Produtos);
            this.Controls.Add(this.Btn_Alterar_Pagamento);
            this.Controls.Add(this.Cliente_Caixa_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Adicionar_Produtos);
            this.Controls.Add(this.Btn_Adicionar_Clientes);
            this.Controls.Add(this.label3);
            this.Name = "Caixa_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.Data_CRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Valor_Total_Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Data_CRUD;
        private System.Windows.Forms.Button Btn_Remover_Produtos;
        private System.Windows.Forms.Button Btn_Alterar_Pagamento;
        private System.Windows.Forms.TextBox Cliente_Caixa_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Adicionar_Produtos;
        private System.Windows.Forms.Button Btn_Adicionar_Clientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pagamento_Caixa_TextBox;
        private System.Windows.Forms.NumericUpDown Valor_Total_Num;
        private System.Windows.Forms.Button Btn_Finalizar_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço_Total_Column;
    }
}