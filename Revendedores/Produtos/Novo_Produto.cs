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
    public partial class Novo_Produto : Form
    {
        Produtos frm = new Produtos();
        public Novo_Produto()
        {
            InitializeComponent();
            Convert.ToString(id);            
        }

       //public bool Update = false;
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

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string id;        

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            String Name = tbNome.Text;
            String Categoria = cbCategoria.Text;
            String unidade = tbUnidade.Text;
            String precoUnitarioCompra = tbPrecoUnitCompra.Text;
            Double precoTotalCompra;
            Double precoTotalVenda;
            String precoUnitarioVenda = tbPrecoUnitVenda.Text;
            if (tbid.Text == "")
            {
           
                if (Name == "" || Categoria == "" || unidade == "" || precoUnitarioCompra == "" || precoUnitarioVenda == "")
                {
                    MessageBox.Show("Campos Vazios!");
                    return;
                }
                else
                {
                    precoTotalCompra = Convert.ToInt32(precoUnitarioCompra) * Convert.ToInt32(unidade);
                    Convert.ToString(precoTotalCompra);
                    precoTotalVenda = Convert.ToInt32(precoUnitarioVenda) * Convert.ToInt32(unidade);
                    Convert.ToString(precoTotalVenda);
                    conn.Open();
                    string query = "INSERT INTO rev_produto(prod_nome,prod_categoria,prod_units,prod_precoUnitCompra,prod_precoUnitVenda,prod_precoTotalCompra,prod_precoTotalVenda) VALUES ('" + tbNome.Text + "','" + cbCategoria.SelectedItem + "','" + tbUnidade.Text + "','" + tbPrecoUnitCompra.Text + "','"+ tbPrecoUnitVenda.Text+ "','" + precoTotalCompra + "','"+precoTotalVenda+"')";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ((Produtos)this.Owner).AtualizaDados();
                    LimpaCampos();
                }
            }
            else if (tbid.Text != "")
            {

                if (Name == "" || Categoria == "" || unidade == "" || precoUnitarioCompra == "" || precoUnitarioVenda == "")
                {
                    MessageBox.Show("Campos Vazios!");
                    return;
                }
                else
                {
                    precoTotalCompra = Convert.ToInt32(precoUnitarioCompra) * Convert.ToInt32(unidade);
                    Convert.ToString(precoTotalCompra);
                    precoTotalVenda = Convert.ToInt32(precoUnitarioVenda) * Convert.ToInt32(unidade);
                    Convert.ToString(precoTotalVenda);
                    conn.Open();
                    string query = "UPDATE rev_produto SET prod_nome='" + tbNome.Text + "',prod_categoria ='" + cbCategoria.SelectedItem + "',prod_units='" + tbUnidade.Text + "',prod_precoUnitCompra='" + tbPrecoUnitCompra.Text + "',prod_precoUnitVenda='" + tbPrecoUnitVenda.Text + "',prod_precoTotalCompra='" + precoTotalCompra + "',prod_precoTotalVenda='" + precoTotalVenda + "' WHERE prod_id='" + tbid.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Salvo com Sucesso");
                    ((Produtos)this.Owner).AtualizaDados();
                    this.Hide();                    
                }
            }
            
        }

        private void Novo_Produto_Load(object sender, EventArgs e)
        {
            LoadData();            
        }

        public void strings()
        {

        }

        string message = "Produto gravado com sucesso!! \nDeseja adicionar outro produto??";
        string title = "Adição de produto";

        public void LimpaCampos()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);                        
            if (result == DialogResult.Yes){
                tbNome.Clear();
                tbPrecoUnitCompra.Clear();
                tbUnidade.Clear();
                cbCategoria.Items.Clear();
                tbNome.Focus();
            }
            else if(result == DialogResult.No)
            {
                this.Hide();
            }
        }

        private void LoadData()
        {
            SetConnection();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT categoria_nome FROM rev_categoria";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbCategoria.Items.Add(dr["categoria_nome"].ToString());
            }
            conn.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
