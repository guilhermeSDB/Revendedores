using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Revendedores.Login_Forms
{
    public partial class Criar_conta : Form
    {
        public Criar_conta()
        {
            InitializeComponent();
        }

        private SQLiteConnection conn;

        private void SetConnection()
        {
            conn = new SQLiteConnection
                ("Data Source=C:\\Projetos\\Revendedores\\Banco\\bd_revendedores.db;Version=3;New=False;Compress=True;");
        }


        private void Criar_conta_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            String User = tbUser.Text;
            String Email = tbEmail.Text;
            String senha = tbPassword.Text;
            String resenha = tbRetypePassword.Text;
            if (User == "" || Email == "" || senha == "" || resenha == "")
            {
                MessageBox.Show("Campos Vazios!");
                return;
            }
            else
            {
                tabcontrol.SelectedTab = perfil;
                cbPerfil.Checked = true;
            }                       
            
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedTab = login;
            cbPerfil.Checked = false;
        }

        private void btnProximo2_Click(object sender, EventArgs e)
        {
            String nome = tbNome.Text;
            String sobrenome = tbSobrenome.Text;
            String telefone = tbTelefone.Text;
            String DDD = tbDDD.Text;
            String cep = tbCep.Text;
            String bairro = tbBairro.Text;
            String rua = tbRua.Text;
            String nº = tbNº.Text;

            if (nome == "" || sobrenome == "" || telefone == "" || DDD == "" || cep == "" || bairro == "" || rua == "" || nº == "")
            {
                MessageBox.Show("Campos Vazios!");
                return;
            }
            else
            {
                SetConnection();
                conn.Open();
                tabcontrol.SelectedTab = finish;
                cbTerminar.Checked = true;
                string query = "INSERT INTO rev_usuarios(user_usuario,user_email,user_senha,user_nome,user_sobrenome,user_cep,user_bairro,user_rua,user_nº) VALUES ('" + tbUser.Text + "','" + tbEmail.Text + "','" + tbPassword.Text + "','" + tbNome.Text + "','" + tbSobrenome.Text + "','" + tbCep + "','" + tbBairro + "','"+tbRua.Text+"','"+tbNº+"')";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
                String imageLocation = "";
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files(*.png)|*png| All Files(*.*)|*.*";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;

                        guna2CirclePictureBox1.ImageLocation = imageLocation;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        
    }
}
