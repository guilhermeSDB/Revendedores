using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Data
{
    class productData
    {
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

        public DataTable ListProducts()
        {
            DataTable table = new DataTable();
            SQLiteDataReader readRows;
            string query = "SELECT * FROM rev_produtos";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conn.Close();

            return table;
        }

        public DataTable SearchProducts()
        {
            DataTable tabla = new DataTable();
            string query = "produto_nome LIKE '%{0}%'";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@search", query.Search);

            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(tabla);

            conn.Close();
            return tabla;
        }

    }
}
