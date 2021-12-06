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
    public class Cliente //criação da classe Cliente
    {
        //atributos
        public int id_cliente;
        public string nome_cliente;
        public string Email_cliente;
        public uint idade_cliente;
        public string Telefone_cliente;
        public string endereço_cliente;
        public ulong cpf_cliente;

        //metodos
        public void Criar_Cliente()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;"; //dados do Banco de Dados
            string query = "INSERT INTO clientes(`Nome`,`Email`,`Idade`,`Telefone`,`Endereço`,`CPF`) VALUES ('" + nome_cliente + "','" + Email_cliente + "','" + idade_cliente + "','" + Telefone_cliente + "','" + endereço_cliente + "','" + cpf_cliente + "')";
            //conexão do banco de dados
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Cliente Registrado com Sucesso.");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }
        }
        public void Ler_Cliente(DataGridView DataGridView_Utilizado) //parametros é o nome do datagridview
        {
            //função para atualizar o datagridview e fazer o READ
            MySqlConnection mysqlCon = new

            MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;convert zero datetime=True");
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT cliente_id AS 'ID', Nome, Email, Idade, Telefone, Endereço, CPF, Data_Criação_Usuario AS 'Criado em' FROM clientes WHERE ativo_cliente = 1; ";

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

        public void Update_Cliente()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;";
            // abaixo a string da tabela sendo modificada
            string query = "UPDATE clientes SET  Nome = '" + nome_cliente + "', Email = '" + Email_cliente + "',Idade = " + idade_cliente + ", Telefone = '" + Telefone_cliente + "', Endereço='" + endereço_cliente + "', CPF=" + cpf_cliente + " WHERE cliente_id = " + id_cliente + " ";
            // o id do cliente é o id que o usuário irá selecionar no DatagridView
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Cliente Atualizado com Sucesso.");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }
        }
        public void Delete_Cliente()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;"; //dados do Banco de Dados
            // da Update Onde o Ativo do cliente fica 0 e ele fica desativo no Banco de Dados
            string query = "UPDATE clientes SET ativo_cliente = 0 WHERE cliente_id = " + id_cliente + "; ";
            // o id do cliente é o id que o usuário irá selecionar no DatagridView
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Cliente Deletado com Sucesso.");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }
        }
        public string Retornar_Clientes(int id_cliente_seleção)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;convert zero datetime=True"; //dados do Banco de Dados
            string query = "SELECT Nome from Clientes WHERE ativo_cliente = 1 AND cliente_id = " + id_cliente_seleção + "; "; //encontra na base de dados, os dados do cliente escolhido

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                //coloca os dados encontrados do produto na DataGridView
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                myReader.Read();
                return myReader.GetString(0);
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                return ex.Message;
            }
        }

        public void Procurar_Clientes(DataGridView DataGridView_Utilizado_procura, string nome_clinte_procura, long cpf_procura)
        {
            MySqlConnection mysqlCon = new

            MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia_db;SslMode=None;convert zero datetime=True");
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            if (nome_clinte_procura == "") //caso não seja inserido nome
            {
                string sqlSelectAll = "SELECT cliente_id AS 'ID', Nome, Email, Idade, Telefone, Endereço, CPF, Data_Criação_Usuario AS 'Criado em' FROM clientes WHERE ativo_cliente = 1 " +
                    "and CPF LIKE '%" + cpf_procura + "%';";

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
                if (cpf_procura == 0)//caso não seja inserido cod de barras
                {
                    string sqlSelectAll = "SELECT cliente_id AS 'ID', Nome, Email, Idade, Telefone, Endereço, CPF, Data_Criação_Usuario AS 'Criado em' FROM clientes WHERE ativo_cliente = 1  " +
                    "and Nome LIKE '%" + nome_clinte_procura + "%';";

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
                    string sqlSelectAll = " SELECT cliente_id AS 'ID', Nome, Email, Idade, Telefone, Endereço, CPF, Data_Criação_Usuario AS 'Criado em' FROM clientes WHERE ativo_cliente = 1  " +
                    "and Nome LIKE '%" + nome_clinte_procura + "%' and CPF LIKE '%" + cpf_procura + "%';";

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
