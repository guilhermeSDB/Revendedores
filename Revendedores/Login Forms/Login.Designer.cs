namespace Revendedores
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.botaoFechar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnContinuarSemLogin = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.imageUser = new System.Windows.Forms.PictureBox();
            this.imageKey = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageCheck = new System.Windows.Forms.PictureBox();
            this.btnCriarConta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbLembrarme = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnPerdiMinhaSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoFechar
            // 
            this.botaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFechar.Image = ((System.Drawing.Image)(resources.GetObject("botaoFechar.Image")));
            this.botaoFechar.Location = new System.Drawing.Point(410, 12);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(41, 37);
            this.botaoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botaoFechar.TabIndex = 9;
            this.botaoFechar.TabStop = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.label4.Location = new System.Drawing.Point(37, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nao possui uma conta?";
            // 
            // btnContinuarSemLogin
            // 
            this.btnContinuarSemLogin.AutoSize = true;
            this.btnContinuarSemLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuarSemLogin.Font = new System.Drawing.Font("Roboto Cn", 15F);
            this.btnContinuarSemLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnContinuarSemLogin.Location = new System.Drawing.Point(146, 537);
            this.btnContinuarSemLogin.Name = "btnContinuarSemLogin";
            this.btnContinuarSemLogin.Size = new System.Drawing.Size(167, 24);
            this.btnContinuarSemLogin.TabIndex = 14;
            this.btnContinuarSemLogin.TabStop = true;
            this.btnContinuarSemLogin.Text = "Continua sem Login";
            this.btnContinuarSemLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnContinuarSemLogin_LinkClicked);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(42, 383);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(365, 42);
            this.btnEntrar.TabIndex = 19;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // imageUser
            // 
            this.imageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageUser.Image = ((System.Drawing.Image)(resources.GetObject("imageUser.Image")));
            this.imageUser.Location = new System.Drawing.Point(41, 189);
            this.imageUser.Name = "imageUser";
            this.imageUser.Size = new System.Drawing.Size(41, 37);
            this.imageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageUser.TabIndex = 20;
            this.imageUser.TabStop = false;
            this.imageUser.Click += new System.EventHandler(this.imageUser_Click);
            // 
            // imageKey
            // 
            this.imageKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageKey.Image = ((System.Drawing.Image)(resources.GetObject("imageKey.Image")));
            this.imageKey.Location = new System.Drawing.Point(42, 275);
            this.imageKey.Name = "imageKey";
            this.imageKey.Size = new System.Drawing.Size(41, 37);
            this.imageKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageKey.TabIndex = 21;
            this.imageKey.TabStop = false;
            this.imageKey.Click += new System.EventHandler(this.imageKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 45F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(92, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login in";
            // 
            // imageCheck
            // 
            this.imageCheck.Location = new System.Drawing.Point(411, 187);
            this.imageCheck.Name = "imageCheck";
            this.imageCheck.Size = new System.Drawing.Size(37, 34);
            this.imageCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageCheck.TabIndex = 22;
            this.imageCheck.TabStop = false;
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.AutoSize = true;
            this.btnCriarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarConta.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.btnCriarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnCriarConta.Location = new System.Drawing.Point(270, 438);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(137, 25);
            this.btnCriarConta.TabIndex = 23;
            this.btnCriarConta.Text = "Crie uma conta ja";
            this.btnCriarConta.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(41, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 1);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(41, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 1);
            this.panel2.TabIndex = 25;
            // 
            // tbNome
            // 
            this.tbNome.BorderThickness = 0;
            this.tbNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNome.DefaultText = "";
            this.tbNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNome.DisabledState.Parent = this.tbNome;
            this.tbNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNome.FocusedState.Parent = this.tbNome;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNome.HoverState.Parent = this.tbNome;
            this.tbNome.Location = new System.Drawing.Point(83, 189);
            this.tbNome.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbNome.Name = "tbNome";
            this.tbNome.PasswordChar = '\0';
            this.tbNome.PlaceholderText = "";
            this.tbNome.SelectedText = "";
            this.tbNome.ShadowDecoration.Parent = this.tbNome;
            this.tbNome.Size = new System.Drawing.Size(323, 33);
            this.tbNome.TabIndex = 27;
            this.tbNome.MouseLeave += new System.EventHandler(this.tbNome_MouseLeave_1);
            // 
            // tbSenha
            // 
            this.tbSenha.BorderThickness = 0;
            this.tbSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSenha.DefaultText = "";
            this.tbSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSenha.DisabledState.Parent = this.tbSenha;
            this.tbSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSenha.FocusedState.Parent = this.tbSenha;
            this.tbSenha.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSenha.HoverState.Parent = this.tbSenha;
            this.tbSenha.Location = new System.Drawing.Point(83, 273);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '\0';
            this.tbSenha.PlaceholderText = "";
            this.tbSenha.SelectedText = "";
            this.tbSenha.ShadowDecoration.Parent = this.tbSenha;
            this.tbSenha.Size = new System.Drawing.Size(323, 40);
            this.tbSenha.TabIndex = 28;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // cbLembrarme
            // 
            this.cbLembrarme.AutoSize = true;
            this.cbLembrarme.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLembrarme.CheckedState.BorderRadius = 0;
            this.cbLembrarme.CheckedState.BorderThickness = 0;
            this.cbLembrarme.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLembrarme.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.cbLembrarme.Location = new System.Drawing.Point(42, 322);
            this.cbLembrarme.Name = "cbLembrarme";
            this.cbLembrarme.Size = new System.Drawing.Size(132, 32);
            this.cbLembrarme.TabIndex = 29;
            this.cbLembrarme.Text = "Lembrar-me";
            this.cbLembrarme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbLembrarme.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbLembrarme.UncheckedState.BorderRadius = 0;
            this.cbLembrarme.UncheckedState.BorderThickness = 0;
            this.cbLembrarme.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // btnPerdiMinhaSenha
            // 
            this.btnPerdiMinhaSenha.AutoSize = true;
            this.btnPerdiMinhaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerdiMinhaSenha.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.btnPerdiMinhaSenha.ForeColor = System.Drawing.Color.Red;
            this.btnPerdiMinhaSenha.Location = new System.Drawing.Point(247, 324);
            this.btnPerdiMinhaSenha.Name = "btnPerdiMinhaSenha";
            this.btnPerdiMinhaSenha.Size = new System.Drawing.Size(160, 28);
            this.btnPerdiMinhaSenha.TabIndex = 30;
            this.btnPerdiMinhaSenha.Text = "Perdi minha senha";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 618);
            this.Controls.Add(this.btnPerdiMinhaSenha);
            this.Controls.Add(this.cbLembrarme);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.imageCheck);
            this.Controls.Add(this.imageKey);
            this.Controls.Add(this.imageUser);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnContinuarSemLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botaoFechar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox botaoFechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel btnContinuarSemLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox imageUser;
        private System.Windows.Forms.PictureBox imageKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imageCheck;
        private System.Windows.Forms.Label btnCriarConta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox tbNome;
        private Guna.UI2.WinForms.Guna2TextBox tbSenha;
        private Guna.UI2.WinForms.Guna2CheckBox cbLembrarme;
        private System.Windows.Forms.Label btnPerdiMinhaSenha;
    }
}

