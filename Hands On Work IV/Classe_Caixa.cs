using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient; // biblioteca para MySQL

namespace Hands_On_Work_IV
{
    public class Caixa
    {
        //atributos
        public int id_cliente_caixa;
        public string nome_produtos_caixa;
        public string pagamento__caixa;
        public string Valor_Total_caixa;
        private int venda_id_criado;

        //metodos

        public void Selecionar_Itens(DataGridView DataGridView_Utilizado, int id_produto_linha, int quantidade_selecionada) //funcao para passar informações do produto para a linha do caixa 
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;convert zero datetime=True"; //dados do Banco de Dados
            string query = "SELECT * from produtos WHERE ativo_produtos = 1 AND produtos_id = " + id_produto_linha + "; "; //encontra na base de dados, os dados do produto escolhido

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                //coloca os dados encontrados do produto na DataGridView
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                myReader.Read();
                DataGridViewRow row = (DataGridViewRow)DataGridView_Utilizado.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                row.Cells[0].Value = myReader.GetString("produtos_id");
                row.Cells[1].Value = myReader.GetString("Nome_produtos");
                row.Cells[2].Value = myReader.GetString("Codigo_De_Barras");
                row.Cells[3].Value = myReader.GetString("Preço_Produtos");
                row.Cells[4].Value = quantidade_selecionada;
                DataGridView_Utilizado.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                myReader.Close();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }
        }
        public void Criar_Venda()
        {
            //conexao
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;convert zero datetime=True"; //dados do Banco de Dados
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string query = "INSERT INTO vendas(`Valor_total`,`Pagamento_Forma`, `cliente_venda_id`) VALUES ('" + Valor_Total_caixa + "','" + pagamento__caixa + "'," + id_cliente_caixa + ");";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();     
                MessageBox.Show("Venda Concluida com Sucesso.");
                databaseConnection.Close();
                venda_id_criado = Convert.ToInt32(commandDatabase.LastInsertedId); //passar id inserido para variavel
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }
        }

        public void Criar_Venda_Detalhes(int produto_especifico_id, string Valor_especifico_unitario, int quantidade_especifica) {

            //conexao
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;convert zero datetime=True"; //dados do Banco de Dados
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string query = "INSERT INTO vendas_info(`cliente_venda_info_id`,`produtos_venda_info_id`, `valor_unit`,`quantidade`,`venda_total_id`) VALUES ('" + id_cliente_caixa + "','" + produto_especifico_id + "','" + Valor_especifico_unitario + "','" + quantidade_especifica + "'," + venda_id_criado + ");";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
                try
                {
                databaseConnection.Open();
                  MySqlDataReader myReader = commandDatabase.ExecuteReader();
    
                databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Mostrar Mensagem De Erro
                    MessageBox.Show(ex.Message);
                }

        }
        public void Ler_Venda(DataGridView DataGridView_Utilizado)
        {
            // Conexão ao banco de dados para verificar
            MySqlConnection mysqlCon = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;convert zero datetime=True");
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            // abaixo a string da tabela sendo procurada
            string sqlSelectAll = "select venda_id AS 'ID de Venda'," +
                "cliente_venda_info_id AS 'Cliente ID', Nome AS 'Nome do Cliente'," +
                " Pagamento_Forma AS 'Forma de Pagamento', DATE_FORMAT(venda_data,'%d/%m/%Y') AS 'Data'," +
                "venda_info_id AS 'ID venda individual',produtos_venda_info_id AS 'ID dos Produtos', " +
                "Nome_produtos AS 'Nomes dos Produtos',quantidade AS 'Quantidade',valor_unit AS 'Valor Unitário', " +
                "Valor_total AS 'Valor Total da Venda' from vendas,vendas_info,clientes," +
                "produtos WHERE venda_id=venda_total_id AND cliente_venda_info_id=cliente_id AND produtos_venda_info_id=produtos_id group by venda_info_id order by venda_id desc,venda_info_id desc  ;"; 
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            DataGridView_Utilizado.DataSource = bSource;
        }


    }
}
