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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
            LoadData();
            HideWidthColumns();
            AtualizaDados();
        }

        private SQLiteConnection conn;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DA;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private SQLiteDataReader da;

        private void SetConnection()
        {
            conn = new SQLiteConnection
               ("Data Source=C:\\Projetos\\Revendedores\\Banco\\bd_revendedores.db;Version=3;New=False;Compress=True;");
        }

        public void HideWidthColumns()
        {
            gridv1.Columns[0].Width = 80; // Espaço do EDITAR
            gridv1.Columns[1].Width = 50; // Espaço do DELETAR
            gridv1.Columns[2].Width = 100;// Espaço entre COD >> Nome
            gridv1.Columns[3].Width = 200;//Espaço entre Nome >> CATEGORIA
            gridv1.Columns[4].Width = 210;//Espaço entre CATEGORIA >> UNIDADE 
            gridv1.Columns[5].Width = 200;//Espaço entre PRECO UNITARIO >> TOTAL
            gridv1.Columns[6].Width = 250; //Espaço entre codigo de TOTAL >> e o resto

            gridv1.Columns[0].DisplayIndex = 7;
            gridv1.Columns[1].DisplayIndex = 7;

        }

        public void AtualizaDados() //Atualiza a grid de dados quando foi feito alteraçao no Cadastro de Funcionarios
        {
            gridv1.DataSource = ListProducts();
            CountRows();
            Soma();
        }

        private void Rastreio_Load(object sender, EventArgs e)
        {
           
        }
        public void CountRows()//Conta o numero de Linhas de uma Tabela
        {
            SetConnection();
            string query = "SELECT count(prod_id) FROM rev_produto";
            string query2 = "SELECT count(categoria_id) FROM rev_categoria";
            SQLiteCommand cmd;
            SQLiteCommand cmd2;
            try
            {
                conn.Open();
                cmd = new SQLiteCommand(query, conn);
                cmd2 = new SQLiteCommand(query2, conn);
                Int32 rows_count_Produtos = Convert.ToInt32(cmd.ExecuteScalar());
                Int32 rows_count_Categoria = Convert.ToInt32(cmd2.ExecuteScalar());
                cmd.Dispose();
                conn.Close();
                txtNumeroProdutos.Text = rows_count_Produtos.ToString();
                txtNumeroCategorias.Text = rows_count_Categoria.ToString();
            }
            catch
            {

            }
        }

        public void Soma() //Faz as soma de campos do Banco de dados
        {
            SetConnection();
            string query = "SELECT sum(prod_precoTotalCompra) FROM rev_produto";
            string query2 = "SELECT sum(prod_precoTotalVenda) FROM rev_produto";
            SQLiteCommand cmd;
            SQLiteCommand cmd2;
            try
            {
                conn.Open();
                cmd = new SQLiteCommand(query, conn);
                cmd2 = new SQLiteCommand(query2, conn);
                Int32 rows_soma_ProdutosVenda = Convert.ToInt32(cmd2.ExecuteScalar());
                Int32 rows_soma_ProdutosCompra = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                conn.Close();
                txtValorTotalCompra.Text = "R$: "+ rows_soma_ProdutosCompra.ToString();
                txtTotalCompra.Text = "R$: " + rows_soma_ProdutosCompra.ToString();
                txtTotalVenda.Text = "R$: " + rows_soma_ProdutosVenda.ToString();

                double lucros = rows_soma_ProdutosVenda - rows_soma_ProdutosCompra;
                txtLucros.Text = Convert.ToString("R$: "+lucros);
            }
            catch
            {

            }
        }

        public void LoadData() // Carrega os dados do Banco
        {            
            SetConnection();
            conn.Open();
            DA = new SQLiteDataAdapter("SELECT prod_id,prod_nome,prod_categoria,prod_units,prod_precoUnitCompra,prod_precoUnitVenda FROM rev_produto", conn);
            DA.Fill(DT);
            gridv1.DataSource = DT;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            Novo_Produto NP = new Novo_Produto();
            NP.Owner = this; //Atualiza o FORM quando receber alterações
            NP.ShowDialog();
        }

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            Nova_Categoria NC = new Nova_Categoria();
            NC.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)// Recarrega a Soma e a Lista de Pordutos
        {
            gridv1.DataSource = ListProducts();
            Soma();
        }

        public void DeletarProduto()
        {
            
        }

        public void PesquisarProdutos() // Pesquisa pelo nome do Produto
        {
            SetConnection();
            string query = "SELECT prod_id,prod_nome,prod_categoria,prod_units,prod_precoUnitCompra,prod_precoUnitVenda FROM rev_produto WHERE prod_nome LIKE '%" + tbPesquisar.Text + "%'";
            DA = new SQLiteDataAdapter(query, conn);
            DT = new DataTable();
            DA.Fill(DT);
            gridv1.DataSource = DT;
            conn.Close();


            //DataTable table = new DataTable();
            //SQLiteCommand cmd = new SQLiteCommand(query, conn);
            // cmd.CommandType = CommandType.StoredProcedure;
            //conn.Open();
            //SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            // da.Fill(table);
            //conn.Close();
        }


        string sqlCon = @"Data Source=C:\\Projetos\\Revendedores\\Banco\\bd_revendedores.db;Version=3;New=False;Compress=True;";
        string sqlSelect = @"select prod_id,prod_nome,prod_categoria,prod_units,prod_precoUnitCompra,prod_precoUnitVenda from rev_produto";

        private DataTable BindSource()
        {
            
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            using (SQLiteConnection conn = new SQLiteConnection(sqlCon))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sqlSelect, conn))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(ds);
                        dt = ds.Tables[0];
                        conn.Close();
                    }
                }
            }
            return dt;
        }

        int i = 0;

        private void gridv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "Quer mesmo excluir o produto?";
            string title = "Exclusao do produto";

            if (gridv1.Rows[e.RowIndex].Cells["eliminar"].Selected)//Quando clickar no icone de Eliminar 
            {
                using (SQLiteConnection conn = new SQLiteConnection(sqlCon))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(this.gridv1.Rows[e.RowIndex].Cells[2].Value);
                            cmd.CommandText = @"DELETE FROM rev_produto WHERE prod_id=" + id;
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            MessageBox.Show("Deletado com Sucesso!");
                            Soma();
                        }
                        
                    }
                }
            }
            else if (gridv1.Rows[e.RowIndex].Cells["editar"].Selected)//Quando clickar no icone de Editar 
            {
                
                Novo_Produto np = new Novo_Produto();
                np.tbid.Text = gridv1.Rows[e.RowIndex].Cells["prod_id"].Value.ToString();
                np.tbNome.Text = gridv1.Rows[e.RowIndex].Cells["prod_nome"].Value.ToString();
                np.tbUnidade.Text = gridv1.Rows[e.RowIndex].Cells["prod_units"].Value.ToString();
                np.tbPrecoUnitCompra.Text = gridv1.Rows[e.RowIndex].Cells["prod_precoUnitCompra"].Value.ToString();
                np.tbPrecoUnitVenda.Text = gridv1.Rows[e.RowIndex].Cells["prod_precoUnitVenda"].Value.ToString();
                np.cbCategoria.Text = gridv1.Rows[e.RowIndex].Cells["prod_categoria"].Value.ToString();
                np.ShowDialog();
            }
            gridv1.DataSource = BindSource();
            i++;          
            
        }           
        
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        public DataTable ListProducts() // Lista os produtos na grid
        {
            SetConnection();
            DataTable table = new DataTable();
            SQLiteDataReader readRows;
            string query = "SELECT prod_id,prod_nome,prod_categoria,prod_units,prod_precoUnitCompra,prod_precoUnitVenda FROM rev_produto";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);
            readRows.Close();
            conn.Close();

            return table;            
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        //------------------Tudo abaixo daqui server pra Ordernar pelos botoes------------------//

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (gridv1.SortOrder == SortOrder.Ascending)
            {
                gridv1.Sort(gridv1.Columns[2], ListSortDirection.Descending);
            }
            else
            {
                gridv1.Sort(gridv1.Columns[2], ListSortDirection.Ascending);
            }
            
        }

        private void btnSortNome_Click(object sender, EventArgs e)
        {
            if (gridv1.SortOrder == SortOrder.Ascending)
            {
                gridv1.Sort(gridv1.Columns[3], ListSortDirection.Descending);
            }
            else
            {
                gridv1.Sort(gridv1.Columns[3], ListSortDirection.Ascending);
            }

        }

        private void btnSortCategoria_Click(object sender, EventArgs e)
        {
            if (gridv1.SortOrder == SortOrder.Ascending)
            {
                gridv1.Sort(gridv1.Columns[4], ListSortDirection.Descending);
            }
            else
            {
                gridv1.Sort(gridv1.Columns[4], ListSortDirection.Ascending);
            }
        }

        private void btnSortUnidade_Click(object sender, EventArgs e)
        {
            if (gridv1.SortOrder == SortOrder.Ascending)
            {
                gridv1.Sort(gridv1.Columns[5], ListSortDirection.Descending);
            }
            else
            {
                gridv1.Sort(gridv1.Columns[5], ListSortDirection.Ascending);
            }
        }

        private void btnSortUnidadeCompra_Click(object sender, EventArgs e)
        {
            if (gridv1.SortOrder == SortOrder.Ascending)
            {
                gridv1.Sort(gridv1.Columns[6], ListSortDirection.Descending);
            }
            else
            {
                gridv1.Sort(gridv1.Columns[6], ListSortDirection.Ascending);
            }
        }

        private void btnSortUnidadeVenda_Click(object sender, EventArgs e)
        {
            if (gridv1.SortOrder == SortOrder.Ascending)
            {
                gridv1.Sort(gridv1.Columns[7], ListSortDirection.Descending);
            }
            else
            {
                gridv1.Sort(gridv1.Columns[7], ListSortDirection.Ascending);
            }
        }

        private void txtTotalVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (panelAjuda.Width == 1)
            {
                panelAjuda.Visible = false;
                panelAjuda.Width = 500;
                bunifuTransition1.ShowSync(panelAjuda);
            }
            
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            if(panelAjuda.Width == 500)
            {
                panelAjuda.Visible = false;
                panelAjuda.Width = 1;
                bunifuTransition2.ShowSync(panelAjuda);
            }
        }
    }
}
