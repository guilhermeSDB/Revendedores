using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revendedores
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        private string _nome;
        private string _email;


        [Category("Custom Props")]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; txtNome.Text = value; }
        }

        [Category("Custom Props")]
        public string Email
        {
            get { return _email; }
            set { _email = value; txtEmail.Text = value; }
        }
    }
}
