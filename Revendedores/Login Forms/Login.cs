using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Revendedores.Login_Forms;

namespace Revendedores
{
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
        }
        private void botaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imageKey_Click(object sender, EventArgs e)
        {
            tbSenha.Focus();
        }

        private void imageUser_Click(object sender, EventArgs e)
        {
            tbNome.Focus();
        }


        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void tbNome_MouseLeave_1(object sender, EventArgs e)
        {
            if (tbNome.Text == "Guilherme")
            {
                imageCheck.ImageLocation = string.Format(@"Image\check.ico");
            }
            else if (tbNome.Text == "")
            {

            }
            else
            {
                imageCheck.ImageLocation = string.Format(@"Image\erro.ico");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Criar_conta criar_Conta = new Criar_conta();
            criar_Conta.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text == "Guilherme" && tbSenha.Text == "145753")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        
        }

        private void btnContinuarSemLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();// Permite mover o sistema pela tela
            SendMessage(this.Handle, 0x112, 0xf012, 0);// Permite mover o sistema pela tela
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] // Permite mover o sistema pela tela
        private extern static void ReleaseCapture();// Permite mover o sistema pela tela
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] // Permite mover o sistema pela tela
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);// Permite mover o sistema pela tela

    }
}
