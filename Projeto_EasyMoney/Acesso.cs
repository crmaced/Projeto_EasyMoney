using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_EasyMoney
{
    public partial class Acesso : Form
    {
            
        public Acesso()
        {
            InitializeComponent();
        }
        
        SqlConnection conexao1 = new SqlConnection(Properties.Settings.Default.conexao);

        private void button_entrar_Click(object sender, EventArgs e)
        {
            string login = "SELECT [USUARIO], [SENHA] FROM [TB_ACESSO] WHERE [USUARIO] ='"+textBox_usuario.Text+"' AND [SENHA] = '"+textBox_senha.Text+"'";
            SqlCommand comando = new SqlCommand(login, conexao1);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader;

            try
            {
                conexao1.Open();
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string usuario = reader[0].ToString();
                    string senha = reader[1].ToString();
                    conexao1.Close();

                    if (usuario == textBox_usuario.Text || senha == textBox_senha.Text)
                    {
                        Cadastro cadastro = new Cadastro();
                        cadastro.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
            }
        }
          


        private void Acesso_Load(object sender, EventArgs e)
        {

        }
    }
}
