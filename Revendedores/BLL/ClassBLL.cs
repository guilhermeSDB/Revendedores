using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using Revendedores.DAL;

namespace Revendedores.BLL
{
    class ClassBLL
    {
        public DataTable GetItems()
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadItemsTable();
            }
            catch(Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
                

            
        }
    }
}
