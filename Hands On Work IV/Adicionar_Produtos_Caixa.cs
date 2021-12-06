using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hands_On_Work_IV
{
    public partial class Adicionar_Produtos_Caixa : Form
    {
        public Adicionar_Produtos_Caixa()
        {
            InitializeComponent();
        }

        private Caixa_Form mainForm = null; //conexao a Form

        public Adicionar_Produtos_Caixa(Form callingForm)
        {
            mainForm = callingForm as Caixa_Form;
            InitializeComponent();
        }
        public void Pesquisa_Prod()
        {
                Produtos Selecionar_produtos = new Produtos();
                Selecionar_produtos.Procurar_Produtos(Data_CRUD, Nome_Produtos_TextBox.Text, Convert.ToInt64(CodBarras_NumUpDown.Value));
            
            
        }  

        public void Adicionar_produtos_form()
        {
            this.mainForm.id_produto_chamado = Convert.ToInt32(Id_Produtos_TextBox.Text); //conexao a Form 
            this.mainForm.quantidade_chamado = Convert.ToInt32(Quantidade_NumUpDown.Value);

        }
        
        public void Selecionar_DataGridView() //funçao para pegar a informação que o usuário irá clicar no DataGridView
        {
            try
            {
                if (Data_CRUD.CurrentRow.Index != -1)
                {
                    //passar a celula em forma de text para o textbox
                    Id_Produtos_TextBox.Text = Data_CRUD.CurrentRow.Cells[0].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Inserir_Produtos_Click(object sender, EventArgs e)
        {
            if(Id_Produtos_TextBox.Text == "")
            {
                MessageBox.Show("É Necessário que um produto seja selecionado");
            }
            else
            {
                                Adicionar_produtos_form();
                this.Close();
            }

        }

        private void Btn_Pesquisa_Click(object sender, EventArgs e)
        {
            if (Nome_Produtos_TextBox.Text == "" && CodBarras_NumUpDown.Value==0)
            {
                MessageBox.Show("É Necessário que algo seja escrito.");
            }
            else
            {
                Pesquisa_Prod();
            }
        }


        private void Data_CRUD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecionar_DataGridView();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
