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
    public partial class Clientes_Form : Form
    {
        public Clientes_Form()
        {
            InitializeComponent();
            Verificar_Clientes(); //abrir form verificando clientes 
        }


        private void Limpar_Campos_Clientes() //função para limpar campos dos clientes
        {
            Id_clientes_TextBox.Clear();
            Nome_clientes_TextBox.Clear();
            Email_clientes_TextBox.Clear();
            Idade_clientes_TextBox.Clear();
            Telefone_clientes_TextBox.Clear();
            Endereço_clientes_TextBox.Clear();
            CPF_clientes_TextBox.Clear();
        }

        public void Inserir_Clientes() //função para inserção de clientes
        {
            Cliente Inserção = new Cliente(); //criação de objeto

            //atribuir variaveis para objeto
            Inserção.nome_cliente = Nome_clientes_TextBox.Text;
            Inserção.Email_cliente = Email_clientes_TextBox.Text;
            Inserção.idade_cliente = Convert.ToUInt32(Idade_clientes_TextBox.Text);
            Inserção.Telefone_cliente = Telefone_clientes_TextBox.Text;
            Inserção.endereço_cliente = Endereço_clientes_TextBox.Text;
            Inserção.cpf_cliente = Convert.ToUInt64(CPF_clientes_TextBox.Text);
            Inserção.Criar_Cliente(); //usar o metodo para criar clientes
            Limpar_Campos_Clientes();
            Verificar_Clientes();


        }

        public void Verificar_Clientes()
        {
            Cliente Leitura = new Cliente();
            Leitura.Ler_Cliente(Data_CRUD); // o Datagridview Data_Crud é utilizado dentro do metodo 

        }

        public void Alterar_Clientes()
        {
            Cliente Alteração = new Cliente();
            //atribuir variaveis para objeto
            Alteração.id_cliente = Convert.ToInt32(Id_clientes_TextBox.Text);
            Alteração.nome_cliente = Nome_clientes_TextBox.Text;
            Alteração.Email_cliente = Email_clientes_TextBox.Text;
            Alteração.idade_cliente = Convert.ToUInt32(Idade_clientes_TextBox.Text);
            Alteração.Telefone_cliente = Telefone_clientes_TextBox.Text;
            Alteração.endereço_cliente = Endereço_clientes_TextBox.Text;
            Alteração.cpf_cliente = Convert.ToUInt64(CPF_clientes_TextBox.Text);
            Alteração.Update_Cliente();
            Limpar_Campos_Clientes();
            Verificar_Clientes();
        }

        public void Deletar_Clientes()
        {
            Cliente Deletar = new Cliente();
            Deletar.id_cliente = Convert.ToInt32(Id_clientes_TextBox.Text);
            Deletar.Delete_Cliente();
            Limpar_Campos_Clientes();
            Verificar_Clientes();
        }


        // Ações ao clicar nos Botões em clientes
        private void Btn_Inserir_Clientes_Click(object sender, EventArgs e) //ao clicar em inserir, a funçao abaixo será executada
        {
            if(Checar_Campos()== false) //verifica se há algum campo que não foi preenchido
            {
                MessageBox.Show("É Necessário que todos os campos sejam preenchidos para a inserção.");
            }
            else
            {
                Inserir_Clientes();
            }

        }
        private void Btn_Alterar_Clientes_Click(object sender, EventArgs e)
        {
            if (Checar_Campos() == false) //verifica se há algum campo que não foi preenchido
            {
                MessageBox.Show("É Necessário que todos os campos sejam preenchidos para a Alteração.");
            }
            else
            {
                Alterar_Clientes();
            }
        }

        private void Btn_Limpar_Clientes_Click(object sender, EventArgs e)
        {
            Limpar_Campos_Clientes();
        }

        private void Btn_Deletar_Clientes_Click(object sender, EventArgs e)
        {
            if (Id_clientes_TextBox.Text =="") //se nada for selecionado
            {
                MessageBox.Show("É Necessário que algum cliente seja selecionado");
            }
            else {
                Deletar_Clientes();
            }
        }

        public void Selecionar_DataGridView() //funçao para pegar a informação que o usuário irá clicar no DataGridView
        {
            try
            {
                if (Data_CRUD.CurrentRow.Index != -1)
                {
                    //passar a celula em forma de text para o textbox
                    Id_clientes_TextBox.Text = Data_CRUD.CurrentRow.Cells[0].Value.ToString();
                    Nome_clientes_TextBox.Text = Data_CRUD.CurrentRow.Cells[1].Value.ToString();
                    Email_clientes_TextBox.Text = Data_CRUD.CurrentRow.Cells[2].Value.ToString();
                    Idade_clientes_TextBox.Text = Data_CRUD.CurrentRow.Cells[3].Value.ToString();
                    Telefone_clientes_TextBox.Text = Data_CRUD.CurrentRow.Cells[4].Value.ToString();
                    Endereço_clientes_TextBox.Text= Data_CRUD.CurrentRow.Cells[5].Value.ToString();
                    CPF_clientes_TextBox.Text = Data_CRUD.CurrentRow.Cells[6].Value.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Data_CRUD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecionar_DataGridView(); //ao clicar no datagridview executa função
        }

        public bool Checar_Campos() //função para checar se algum campo não foi digitado
        {
            ///criar um array com os valores dos TextBox
            string[] Campos = { 
                Nome_clientes_TextBox.Text,
                Email_clientes_TextBox.Text,
                Idade_clientes_TextBox.Text ,
                Telefone_clientes_TextBox.Text,
                Endereço_clientes_TextBox.Text,
                CPF_clientes_TextBox.Text
            };


            bool Campo_Preenchido = true; //variavel para verificar o campo

            for (int contagem = 0; contagem < Campos.Length; contagem++)  //for loop para checagem
            {
                if(Campos[contagem]== "")  
                {
                    //se algum campo for negativo  a variavel ficara false
                    Campo_Preenchido = false;
                }
            }

            if(Campo_Preenchido == false){ //se campo preenchido não estiver como verdadeiro, ira retornar falso

                return false;
            }
            else //se estiver verdadeiro ira retornar verdadeiro
            {
                return true;
            }
        }
    }
}
