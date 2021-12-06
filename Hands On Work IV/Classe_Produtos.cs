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
    public class Produtos
    {
        //atributos
        public int id_produtos;
        public string nome_produtos;
        public long codigo_de_barras_produtos;
        public decimal preço_produto;

        //metodos
        public void Criar_Produtos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;"; //dados do Banco de Dados
            string query = "INSERT INTO produtos(`Nome_produtos`,`Codigo_De_Barras`,`Preço_Produtos`) VALUES ('" + nome_produtos + "','" + codigo_de_barras_produtos + "','" + preço_produto + "')";
            //conexão do banco de dados
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Produto Registrado com Sucesso.");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);

            }
        }
        public void Ler_Produtos(DataGridView DataGridView_Utilizado)
        {

            //função para atualizar o datagridview e fazer o READ
            MySqlConnection mysqlCon = new

            MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;convert zero datetime=True");
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT produtos_id AS 'ID', Nome_produtos AS 'Nome', Codigo_De_Barras AS 'Código De Barras',Preço_Produtos AS 'Preço',Data_Criação_Produtos AS 'Criado em' FROM produtos WHERE ativo_produtos = 1; ";

            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);
            try
            {
                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                DataGridView_Utilizado.DataSource = bSource;
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }
        }
        public void Update_Produtos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;";
            // abaixo a string da tabela sendo modificada
            string query = "UPDATE produtos SET  Nome_produtos = '" + nome_produtos + "', Codigo_De_Barras = '" + codigo_de_barras_produtos + "',Preço_Produtos='" + preço_produto + "' WHERE produtos_id = " + id_produtos + " ;";
            // o id do produto é o id que o usuário irá selecionar no DatagridView
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Produto Atualizado com Sucesso.");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }
        }
        public void Delete_Produtos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;"; //dados do Banco de Dados
            // da Update Onde o Ativo do Produto fica 0 e ele fica desativo no Banco de Dados
            string query = "UPDATE produtos SET ativo_produtos = 0 WHERE produtos_id = " + id_produtos + "; ";
            // o id do cliente é o id que o usuário irá selecionar no DatagridView
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Produto Deletado com Sucesso.");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }
        }

        public void Procurar_Produtos(DataGridView DataGridView_Utilizado_procura, string nome_produto_procura, long codigo_de_barras_procura)
        {
            MySqlConnection mysqlCon = new

            MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;convert zero datetime=True");
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            if (nome_produto_procura == "") //caso não seja inserido nome
            {
                string sqlSelectAll = "SELECT produtos_id AS 'ID', Nome_produtos AS 'Nome', Codigo_De_Barras AS 'Código De Barras',Preço_Produtos AS 'Preço',Data_Criação_Produtos AS 'Criado em' FROM produtos WHERE ativo_produtos = 1 " +
                    "and Codigo_De_Barras LIKE '%" + codigo_de_barras_procura + "%';";

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);
                try
                {
                    DataTable table = new DataTable();
                    MyDA.Fill(table);

                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = table;


                    DataGridView_Utilizado_procura.DataSource = bSource;
                }
                catch (Exception ex)
                {
                    // Mostrar Mensagem De Erro
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (codigo_de_barras_procura == 0)//caso não seja inserido cod de barras
                {
                    string sqlSelectAll = "SELECT produtos_id AS 'ID', Nome_produtos AS 'Nome', Codigo_De_Barras AS 'Código De Barras',Preço_Produtos AS 'Preço',Data_Criação_Produtos AS 'Criado em' FROM produtos WHERE ativo_produtos = 1 " +
                    "and Nome_produtos LIKE '%" + nome_produto_procura + "%';";

                    MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);
                    try
                    {
                        DataTable table = new DataTable();
                        MyDA.Fill(table);

                        BindingSource bSource = new BindingSource();
                        bSource.DataSource = table;


                        DataGridView_Utilizado_procura.DataSource = bSource;
                    }
                    catch (Exception ex)
                    {
                        // Mostrar Mensagem De Erro
                        MessageBox.Show(ex.Message);
                    }
                   

                }
                else //caso  seja inserido nome e codigo de barras
                {
                    string sqlSelectAll = "SELECT produtos_id AS 'ID', Nome_produtos AS 'Nome', Codigo_De_Barras AS 'Código De Barras',Preço_Produtos AS 'Preço',Data_Criação_Produtos AS 'Criado em' FROM produtos WHERE ativo_produtos = 1 " +
                    "and Nome_produtos LIKE '%" + nome_produto_procura + "%' and Codigo_De_Barras LIKE '%" + codigo_de_barras_procura + "%';";

                    MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);
                    try
                    {
                        DataTable table = new DataTable();
                        MyDA.Fill(table);

                        BindingSource bSource = new BindingSource();
                        bSource.DataSource = table;

                        DataGridView_Utilizado_procura.DataSource = bSource;
                    }
                    catch (Exception ex)
                    {
                        // Mostrar Mensagem De Erro
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            }
     }  
}
