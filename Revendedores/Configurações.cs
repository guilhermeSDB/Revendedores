using Revendedores.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revendedores
{
    public partial class Configurações : Form
    {
        public Configurações()
        {
            InitializeComponent();
            GenerateDynamicUserControl();
        }

        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            ClassBLL objbll = new ClassBLL();

            DataTable dt = objbll.GetItems();

            if(dt != null)
            {
                MyUserControl[] listItems = new MyUserControl[dt.Rows.Count];
                if (dt.Rows.Count > 0)
                {                   

                    for(int i = 0; i < 1; i++)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            listItems[i] = new MyUserControl()
                                ;
                            listItems[i].Nome = row["user_nome"].ToString();
                            listItems[i].Email = row["user_email"].ToString();


                            flowLayoutPanel1.Controls.Add(listItems[i]);
                        }
                        
                    }
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
