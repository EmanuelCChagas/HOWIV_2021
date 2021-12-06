using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // biblioteca para MySQL

namespace Hands_On_Work_IV
{
    public partial class Farmacia_Form : Form
    {       
        public Farmacia_Form()
        {
            InitializeComponent();
            Btn_Inicio.BackColor = System.Drawing.Color.Gainsboro;
        }

        // função para fazer form filhos e abrir-los neste form
        private Form Child_Form_Utilizado; //variavel para ver qual form filho esta sendo utilizado

        private void AbrirChildForm(Form childForm)
        {
            Child_Form_Utilizado = childForm;
            childForm.TopLevel = false; // impedir que vire um form top level
            childForm.FormBorderStyle = FormBorderStyle.None; //retirar borda
            childForm.Dock = DockStyle.Fill; //preencher painel
            Painel_Forms.Controls.Add(childForm);
            Painel_Forms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Menu de Navegeação Configurações

        // click de botoes
        private void Todos_Btn_Branco()
        {
            //tornar todos os botões do menu para cor padrão branca , para deseleção
            Btn_Inicio.BackColor = System.Drawing.Color.White;
            Btn_Clientes.BackColor = System.Drawing.Color.White;
            Btn_Produtos.BackColor = System.Drawing.Color.White;
            Btn_Caixa.BackColor = System.Drawing.Color.White;
            Btn_Sobre.BackColor = System.Drawing.Color.White;
            Btn_Relat.BackColor = System.Drawing.Color.White;
        }
        private void Inicio_Click(object sender, EventArgs e)
        {
            Todos_Btn_Branco(); //deselecionar o anterior
            Btn_Inicio.BackColor = System.Drawing.Color.Gainsboro; //selecionar inicio mudando sua cor para Cinza

            if (Child_Form_Utilizado != null) //checa se o form child esta sendo utilizado
            {
                Child_Form_Utilizado.Close(); //fechar qualquer child form aberto
            }           
        }
        private void Clientes_Click(object sender, EventArgs e)
        {
            Todos_Btn_Branco(); //deselecionar o anterior
            Btn_Clientes.BackColor = System.Drawing.Color.Gainsboro; //selecionar clientes mudando sua cor para Cinza

            if(Child_Form_Utilizado == null) //checa se o form child esta sendo utilizado
            {
                AbrirChildForm(new Clientes_Form()); //se não estiver ele irá ser utilizado
            }
            else
            {
                Child_Form_Utilizado.Close(); //se tiver será fechado e aberto um novo
                AbrirChildForm(new Clientes_Form());
            }        
        }

        private void Produtos_Click(object sender, EventArgs e)
        {
            Todos_Btn_Branco(); //deselecionar o anterior
            Btn_Produtos.BackColor = System.Drawing.Color.Gainsboro; //selecionar Produtos mudando sua cor para Cinza

            if (Child_Form_Utilizado == null) //checa se o form child esta sendo utilizado
            {
                AbrirChildForm(new Produtos_Form()); //se não estiver ele irá ser utilizado
            }
            else
            {
                Child_Form_Utilizado.Close(); //se tiver será fechado e aberto um novo
                AbrirChildForm(new Produtos_Form());
            }
        }
        private void Caixa_Click(object sender, EventArgs e)
        {
            Todos_Btn_Branco(); //deselecionar o anterior
            Btn_Caixa.BackColor = System.Drawing.Color.Gainsboro; //selecionar Vendas mudando sua cor para Cinza

            if (Child_Form_Utilizado == null) //checa se o form child esta sendo utilizado
            {
                AbrirChildForm(new Caixa_Form()); //se não estiver ele irá ser utilizado
            }
            else
            {
                Child_Form_Utilizado.Close(); //se tiver será fechado e aberto um novo
                AbrirChildForm(new Caixa_Form());
            }
        }
        private void Config_Click(object sender, EventArgs e)
        {
            Todos_Btn_Branco(); //deselecionar o anterior
            Btn_Sobre.BackColor = System.Drawing.Color.Gainsboro; //selecionar Configurações mudando sua cor para Cinza
            if (Child_Form_Utilizado == null) //checa se o form child esta sendo utilizado
            {
                AbrirChildForm(new Sobre_Form()); //se não estiver ele irá ser utilizado
            }
            else
            {
                Child_Form_Utilizado.Close(); //se tiver será fechado e aberto um novo
                AbrirChildForm(new Sobre_Form());
            }
        }

        private void Btn_Relat_Click(object sender, EventArgs e)
        {
            Todos_Btn_Branco(); //deselecionar o anterior
            Btn_Relat.BackColor = System.Drawing.Color.Gainsboro; //selecionar Configurações mudando sua cor para Cinza
            if (Child_Form_Utilizado == null) //checa se o form child esta sendo utilizado
            {
                AbrirChildForm(new Relat_Form()); //se não estiver ele irá ser utilizado
            }
            else
            {
                Child_Form_Utilizado.Close(); //se tiver será fechado e aberto um novo
                AbrirChildForm(new Relat_Form());
            }
        }
    }
}

