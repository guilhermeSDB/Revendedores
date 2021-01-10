using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Revendedores.DAL
{
    class Connection
    {
        public SQLiteConnection connect = new SQLiteConnection("Data Source=C:\\Projetos\\Revendedores\\Banco\\bd_revendedores.db;Version=3;New=False;Compress=True;");

    }
}
