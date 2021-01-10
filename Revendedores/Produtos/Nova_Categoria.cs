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

namespace Revendedores
{
    public partial class Nova_Categoria : Form
    {
        public Nova_Categoria()
        {
            InitializeComponent();
        }
        private void SetConnection()
        {
            conn = new SQLiteConnection
                ("Data Source=C:\\Projetos\\Revendedores\\Banco\\bd_revendedores.db;Version=3;New=False;Compress=True;");
        }

        private SQLiteConnection conn;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DA;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private SQLiteDataReader da;

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            String Name = tbNome.Text;
            String descricao = tbDescricao.Text;
            if (Name == "" || descricao == "")
            {
                MessageBox.Show("Campos Vazios!");
                return;
            }
            else
            {
                SetConnection();
                conn.Open();
                string query = "INSERT INTO rev_categoria(categoria_nome,categoria_descricao) VALUES ('" + tbNome.Text + "','" + tbDescricao.Text + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Gravado com Sucesso");
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
