using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revendedores
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBackground.Controls.Add(childForm);
            panelBackground.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            string data;
            string hora;
            data = DateTime.Now.ToString("ddd dd/MM");
            hora = DateTime.Now.ToString("t");
            CultureInfo idioma = new CultureInfo("pt-BR");
            txtHora.Text = hora;
            txtDia.Text = data;
        }

        private void menuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRastreio_Click(object sender, EventArgs e)
        {
            openChildForm(new Rastreio());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close(); // Quando retornar para Home fecha o formulario atual
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] // Permite mover o sistema pela tela
        private extern static void ReleaseCapture();// Permite mover o sistema pela tela
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] // Permite mover o sistema pela tela
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);// Permite mover o sistema pela tela

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();// Permite mover o sistema pela tela
            SendMessage(this.Handle, 0x112, 0xf012, 0);// Permite mover o sistema pela tela
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Produtos());
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            openChildForm(new Configurações());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Vendas());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new Clientes());
        }
    }
}
