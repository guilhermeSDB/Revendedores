using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Drawing;

namespace Revendedores.DAL
{
    class ClassDAL
    {
        public DataTable ReadItemsTable()
        {
            Connection conn = new Connection();

            if(ConnectionState.Closed == conn.connect.State)
            {
                conn.connect.Open();
            }
            string query = "SELECT * FROM rev_usuarios";
            SQLiteCommand cmd = new SQLiteCommand(query, conn.connect);
            try
            {
                using(SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }

        }
    }
}
