
namespace Hands_On_Work_IV
{
    partial class Cartao_Pagamento
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cartao_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cvv_TextBox = new System.Windows.Forms.TextBox();
            this.Validade_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_Inserir_Produtos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 29);
            this.label3.TabIndex = 81;
            this.label3.Text = "Bandeira de Cartão de Crédito";
            this.label3.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(366, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(123, 32);
            this.textBox1.TabIndex = 82;
            this.textBox1.Text = "MasterCard";
            this.textBox1.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 29);
            this.label5.TabIndex = 84;
            this.label5.Text = "Número do Cartão";
            this.label5.UseWaitCursor = true;
            // 
            // Cartao_TextBox
            // 
            this.Cartao_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartao_TextBox.Location = new System.Drawing.Point(239, 115);
            this.Cartao_TextBox.MaxLength = 20;
            this.Cartao_TextBox.Name = "Cartao_TextBox";
            this.Cartao_TextBox.Size = new System.Drawing.Size(375, 32);
            this.Cartao_TextBox.TabIndex = 85;
            this.Cartao_TextBox.UseWaitCursor = true;
            this.Cartao_TextBox.Leave += new System.EventHandler(this.Cartao_TextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.TabIndex = 86;
            this.label4.Text = "Data de Validade";
            this.label4.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 29);
            this.label6.TabIndex = 87;
            this.label6.Text = "Código Segurança (CVV)";
            this.label6.UseWaitCursor = true;
            // 
            // Cvv_TextBox
            // 
            this.Cvv_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cvv_TextBox.Location = new System.Drawing.Point(327, 302);
            this.Cvv_TextBox.MaxLength = 3;
            this.Cvv_TextBox.Name = "Cvv_TextBox";
            this.Cvv_TextBox.Size = new System.Drawing.Size(122, 32);
            this.Cvv_TextBox.TabIndex = 89;
            this.Cvv_TextBox.UseWaitCursor = true;
            this.Cvv_TextBox.Leave += new System.EventHandler(this.Cvv_TextBox_Leave);
            // 
            // Validade_DatePicker
            // 
            this.Validade_DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validade_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Validade_DatePicker.Location = new System.Drawing.Point(239, 219);
            this.Validade_DatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.Validade_DatePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.Validade_DatePicker.Name = "Validade_DatePicker";
            this.Validade_DatePicker.Size = new System.Drawing.Size(131, 32);
            this.Validade_DatePicker.TabIndex = 90;
            this.Validade_DatePicker.UseWaitCursor = true;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.Btn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(701, 287);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(87, 64);
            this.Btn_Voltar.TabIndex = 99;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // Btn_Inserir_Produtos
            // 
            this.Btn_Inserir_Produtos.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.Btn_Inserir_Produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Inserir_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Inserir_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inserir_Produtos.Location = new System.Drawing.Point(701, 374);
            this.Btn_Inserir_Produtos.Name = "Btn_Inserir_Produtos";
            this.Btn_Inserir_Produtos.Size = new System.Drawing.Size(87, 64);
            this.Btn_Inserir_Produtos.TabIndex = 98;
            this.Btn_Inserir_Produtos.Text = "Validar";
            this.Btn_Inserir_Produtos.UseVisualStyleBackColor = false;
            this.Btn_Inserir_Produtos.Click += new System.EventHandler(this.Validar_button_Click);
            // 
            // Cartao_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Inserir_Produtos);
            this.Controls.Add(this.Validade_DatePicker);
            this.Controls.Add(this.Cvv_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cartao_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "Cartao_Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checar Cartao";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cartao_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Cvv_TextBox;
        private System.Windows.Forms.DateTimePicker Validade_DatePicker;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Button Btn_Inserir_Produtos;
    }
}