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
    public partial class Adicionar_Clientes_Caixa : Form
    {
        public Adicionar_Clientes_Caixa()
        {
            InitializeComponent();
        }

        private Caixa_Form mainForm = null; //conexao a Form

        public Adicionar_Clientes_Caixa(Form callingForm)
        {
            mainForm = callingForm as Caixa_Form;
            InitializeComponent();
        }

        public void Pesquisa_Prod()
        {
            Cliente Cliente_Pesquisa = new Cliente();

            if (CPF_TextBox.Text == "") //se cpf nao for inserido
            {
                Cliente_Pesquisa.Procurar_Clientes(Data_CRUD, Nome_Cliente_TextBox.Text, 0);
            }
            else
            {
                Cliente_Pesquisa.Procurar_Clientes(Data_CRUD, Nome_Cliente_TextBox.Text, Convert.ToInt64(CPF_TextBox.Text));
            }


        }

        public void Adicionar_clientes_form()
        {
            this.mainForm.id_cliente_chamado = Convert.ToInt32(Id_Clientes_TextBox.Text); //conexao a Form 

        }

        public void Selecionar_DataGridView() //funçao para pegar a informação que o usuário irá clicar no DataGridView
        {
            try
            {
                if (Data_CRUD.CurrentRow.Index != -1)
                {
                    //passar a celula em forma de text para o textbox
                    Id_Clientes_TextBox.Text = Data_CRUD.CurrentRow.Cells[0].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Inserir_Produtos_Click(object sender, EventArgs e)
        {
            if (Id_Clientes_TextBox.Text == "")
            {
                MessageBox.Show("É Necessário que um Cliente seja selecionado");
            }
            else
            {
                Adicionar_clientes_form();
                this.Close();
            }

        }

        private void Btn_Pesquisa_Click(object sender, EventArgs e)
        {
            if (Nome_Cliente_TextBox.Text == "" && CPF_TextBox.Text == "")
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

