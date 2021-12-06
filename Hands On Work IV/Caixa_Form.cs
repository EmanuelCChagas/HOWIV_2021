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
    public partial class Caixa_Form : Form
    {
        public Caixa_Form()
        {
            InitializeComponent();
            Valor_Total_Num.Controls[0].Visible = false; //deixar setas invisiveis para o usuário
        }




        public int id_produto_chamado { get; set; }
        public int quantidade_chamado { get; set; }

        public string pagamento_chamado { get; set; }

        public  int id_cliente_chamado { get; set; }


        string valor_decimal_virgula;

        public void Inserir_Produtos_Grid() //pegar dados do produto e atualizar o datagridview
        {
            if (id_produto_chamado != 0) //caso um produto tenha sido inserido
            {
                Caixa Inserir_Grid_Caixa = new Caixa();

                Inserir_Grid_Caixa.Selecionar_Itens(Data_CRUD, id_produto_chamado, quantidade_chamado);
                id_produto_chamado = 0; //zera o valor de informaçoes do produto para nova inserção
                Valor_Total_Calculo();
            }
        }
        public void Alterar_Pagamentos() //altera o pagamento para cartão
        {

            if (pagamento_chamado == "Cartão")
            {
                Pagamento_Caixa_TextBox.Text = "Cartão";
            }
        }


        private void Valor_Total_Calculo()
        {
            if (Data_CRUD.Rows.Count > 1)
            {
                try
                {
                    //pegando numero de row na conta
                    int Num_Row = Data_CRUD.Rows.Count;
                    Num_Row = Num_Row - 1;

                    //passar valor unitario para valor total
                    for (int contagem_valor = 0; contagem_valor < Num_Row; contagem_valor++)
                    {
                        decimal soma_valor_un = Convert.ToDecimal(Data_CRUD.Rows[contagem_valor].Cells[3].Value);
                        decimal soma_quant = Convert.ToDecimal(Data_CRUD.Rows[contagem_valor].Cells[4].Value);
                        decimal soma_valor_total = soma_valor_un * soma_quant;
                        Data_CRUD.Rows[contagem_valor].Cells[5].Value = soma_valor_total;
                    }

                    //criando array para pegar os valores do row
                    string[] array_soma = new string[Num_Row];
                    for (int somando = 0; somando < Num_Row; somando++)
                    {
                        string valor_soma = Convert.ToString(Data_CRUD.Rows[somando].Cells[5].Value);
                        array_soma[somando] = valor_soma;
                    }
                    //fazer um array para transformar esses valores em decimal
                    decimal[] array_itens = new decimal[array_soma.Length];
                    for (int i = 0; i < array_soma.Length; i++)
                    {
                        array_itens[i] = Convert.ToDecimal(array_soma[i]);
                    }
                    //somar valores
                    decimal soma_decimal_valor = 0;
                    for (int soma_total = 0; soma_total < array_soma.Length; soma_total++)
                    {
                        soma_decimal_valor += array_itens[soma_total];
                    }

                    //passar para caixa de texto
                         //Valor_Total_Num.Text = Convert.ToString(soma_decimal_valor);
                     Valor_Total_Num.Value = soma_decimal_valor;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        public string Mudar_Virgula()
        {
            //trocar virgula por ponto para inserção na base de dados
            try
            {
                valor_decimal_virgula = string.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:#,##0.00}", double.Parse(Valor_Total_Num.Text));
                valor_decimal_virgula = (valor_decimal_virgula).Replace(",", ".");
                return valor_decimal_virgula;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public void InserirCliente() 
        {


            if (id_cliente_chamado != 0) //caso um cliente tenha sido inserido
            {
                //mostrar o nome do cliente na interface
                Cliente Selecionar123 = new Cliente();
                Cliente_Caixa_TextBox.Text = Selecionar123.Retornar_Clientes(id_cliente_chamado);

            }

        }
        public void Finalizar_Venda()
        {
            Caixa Inserção_Venda = new Caixa();
            Inserção_Venda.id_cliente_caixa = id_cliente_chamado;
            Inserção_Venda.pagamento__caixa = Pagamento_Caixa_TextBox.Text;
            Inserção_Venda.Valor_Total_caixa = Mudar_Virgula();
            Inserção_Venda.Criar_Venda();
            //inserir informações da venda na tabela vendas_info
            int Num_Row = Data_CRUD.Rows.Count;
            Num_Row = Num_Row - 1;
            try
            {
                for (int contagem_inserção = 0; contagem_inserção < Num_Row; contagem_inserção++)
                {
                    //faz um loop pra inserir os detalhes dos produtos na tabela detalhes
                    Inserção_Venda.Criar_Venda_Detalhes(Convert.ToInt32(Data_CRUD.Rows[contagem_inserção].Cells[0].Value), Data_CRUD.Rows[contagem_inserção].Cells[3].Value.ToString(), Convert.ToInt32(Data_CRUD.Rows[contagem_inserção].Cells[4].Value));
                }

                limpar_campos_caixa();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void limpar_campos_caixa()
        {
            Data_CRUD.Rows.Clear();
            Cliente_Caixa_TextBox.Text = " Não Cadastrado";
            Pagamento_Caixa_TextBox.Text = "Dinheiro";
            Valor_Total_Num.Value = 0;
        }



        private void Btn_Adicionar_Produtos_Click(object sender, EventArgs e)
        {
            Adicionar_Produtos_Caixa Adicionar_Caixa = new Adicionar_Produtos_Caixa(this);
            Adicionar_Caixa.ShowDialog();
            Inserir_Produtos_Grid();
        }

        private void Btn_Adicionar_Clientes_Click(object sender, EventArgs e)
        {

            Adicionar_Clientes_Caixa Adicionar_Clientes_CX = new Adicionar_Clientes_Caixa(this);
            Adicionar_Clientes_CX.ShowDialog();
            InserirCliente();
        }


        private void Btn_AlterarPagamento_Produtos_Click(object sender, EventArgs e)
        {
            Cartao_Pagamento Alterar_pag = new Cartao_Pagamento(this);
            Alterar_pag.ShowDialog();
            Alterar_Pagamentos();
        }


        private void Btn_Remover_Produtos_Click(object sender, EventArgs e)
        {
            if (Data_CRUD.Rows.Count > 0)
            {
                foreach (DataGridViewCell oneCell in Data_CRUD.SelectedCells)
                {
                    if (oneCell.Selected)
                        try
                        {

                            Data_CRUD.Rows.RemoveAt(oneCell.RowIndex);
                            Valor_Total_Calculo();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                }
            }
        }


        private void Btn_Finazar_Venda_Click(object sender, EventArgs e)
        {
            if(id_cliente_chamado==0)
            {
                MessageBox.Show("O Cliente precisa estar cadastrado");
                Console.WriteLine(Data_CRUD.Rows.Count);
            }
            else
            {
                if (Data_CRUD.Rows.Count < 2 )
                {
                    MessageBox.Show("É Preciso Inserir Algum Item");
                }
                else
                {
                    Finalizar_Venda();
                }
            }
         
        }

    }
}
