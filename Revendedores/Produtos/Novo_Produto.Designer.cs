namespace Revendedores
{
    partial class Novo_Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Novo_Produto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUnidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrecoUnitCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrecoUnitVenda = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbid = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(748, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 32);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 4;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins Light", 21F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 42;
            this.label1.Text = "Produtos";
            // 
            // tbNome
            // 
            this.tbNome.Animated = true;
            this.tbNome.AutoRoundedCorners = true;
            this.tbNome.BackColor = System.Drawing.Color.Transparent;
            this.tbNome.BorderRadius = 17;
            this.tbNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNome.DefaultText = "";
            this.tbNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNome.DisabledState.Parent = this.tbNome;
            this.tbNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNome.FocusedState.Parent = this.tbNome;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNome.HoverState.Parent = this.tbNome;
            this.tbNome.Location = new System.Drawing.Point(28, 127);
            this.tbNome.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbNome.Name = "tbNome";
            this.tbNome.PasswordChar = '\0';
            this.tbNome.PlaceholderText = "";
            this.tbNome.SelectedText = "";
            this.tbNome.ShadowDecoration.Parent = this.tbNome;
            this.tbNome.Size = new System.Drawing.Size(372, 36);
            this.tbNome.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(453, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Animated = true;
            this.cbCategoria.AutoRoundedCorners = true;
            this.cbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cbCategoria.BorderRadius = 17;
            this.cbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategoria.FocusedState.Parent = this.cbCategoria;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategoria.HoverState.Parent = this.cbCategoria;
            this.cbCategoria.ItemHeight = 30;
            this.cbCategoria.ItemsAppearance.Parent = this.cbCategoria;
            this.cbCategoria.Location = new System.Drawing.Point(446, 127);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.ShadowDecoration.Parent = this.cbCategoria;
            this.cbCategoria.Size = new System.Drawing.Size(309, 36);
            this.cbCategoria.TabIndex = 48;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 49;
            this.label4.Text = "Unidades";
            // 
            // tbUnidade
            // 
            this.tbUnidade.Animated = true;
            this.tbUnidade.AutoRoundedCorners = true;
            this.tbUnidade.BorderRadius = 17;
            this.tbUnidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUnidade.DefaultText = "";
            this.tbUnidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUnidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUnidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUnidade.DisabledState.Parent = this.tbUnidade;
            this.tbUnidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUnidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUnidade.FocusedState.Parent = this.tbUnidade;
            this.tbUnidade.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbUnidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUnidade.HoverState.Parent = this.tbUnidade;
            this.tbUnidade.Location = new System.Drawing.Point(189, 175);
            this.tbUnidade.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbUnidade.Name = "tbUnidade";
            this.tbUnidade.PasswordChar = '\0';
            this.tbUnidade.PlaceholderText = "";
            this.tbUnidade.SelectedText = "";
            this.tbUnidade.ShadowDecoration.Parent = this.tbUnidade;
            this.tbUnidade.Size = new System.Drawing.Size(123, 36);
            this.tbUnidade.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(454, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 92);
            this.label5.TabIndex = 51;
            this.label5.Text = "*Preço de Venda:\r\nAqui voce digita o preço pelo qual o produto sera vendido.\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(453, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 26);
            this.label6.TabIndex = 53;
            this.label6.Text = "Preço Unitario (Venda)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPrecoUnitCompra
            // 
            this.tbPrecoUnitCompra.Animated = true;
            this.tbPrecoUnitCompra.AutoRoundedCorners = true;
            this.tbPrecoUnitCompra.BorderRadius = 17;
            this.tbPrecoUnitCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrecoUnitCompra.DefaultText = "";
            this.tbPrecoUnitCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrecoUnitCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrecoUnitCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrecoUnitCompra.DisabledState.Parent = this.tbPrecoUnitCompra;
            this.tbPrecoUnitCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrecoUnitCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrecoUnitCompra.FocusedState.Parent = this.tbPrecoUnitCompra;
            this.tbPrecoUnitCompra.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbPrecoUnitCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrecoUnitCompra.HoverState.Parent = this.tbPrecoUnitCompra;
            this.tbPrecoUnitCompra.Location = new System.Drawing.Point(140, 260);
            this.tbPrecoUnitCompra.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbPrecoUnitCompra.Name = "tbPrecoUnitCompra";
            this.tbPrecoUnitCompra.PasswordChar = '\0';
            this.tbPrecoUnitCompra.PlaceholderText = "";
            this.tbPrecoUnitCompra.SelectedText = "";
            this.tbPrecoUnitCompra.ShadowDecoration.Parent = this.tbPrecoUnitCompra;
            this.tbPrecoUnitCompra.Size = new System.Drawing.Size(123, 36);
            this.tbPrecoUnitCompra.TabIndex = 52;
            // 
            // btnSalvar
            // 
            this.btnSalvar.CheckedState.Parent = this.btnSalvar;
            this.btnSalvar.CustomImages.Parent = this.btnSalvar;
            this.btnSalvar.FillColor = System.Drawing.Color.Indigo;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.HoverState.Parent = this.btnSalvar;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalvar.Location = new System.Drawing.Point(310, 393);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
            this.btnSalvar.Size = new System.Drawing.Size(167, 48);
            this.btnSalvar.TabIndex = 54;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 26);
            this.label7.TabIndex = 57;
            this.label7.Text = "Preço Unitario (Compra)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPrecoUnitVenda
            // 
            this.tbPrecoUnitVenda.Animated = true;
            this.tbPrecoUnitVenda.AutoRoundedCorners = true;
            this.tbPrecoUnitVenda.BorderRadius = 17;
            this.tbPrecoUnitVenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrecoUnitVenda.DefaultText = "";
            this.tbPrecoUnitVenda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrecoUnitVenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrecoUnitVenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrecoUnitVenda.DisabledState.Parent = this.tbPrecoUnitVenda;
            this.tbPrecoUnitVenda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrecoUnitVenda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrecoUnitVenda.FocusedState.Parent = this.tbPrecoUnitVenda;
            this.tbPrecoUnitVenda.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbPrecoUnitVenda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrecoUnitVenda.HoverState.Parent = this.tbPrecoUnitVenda;
            this.tbPrecoUnitVenda.Location = new System.Drawing.Point(567, 256);
            this.tbPrecoUnitVenda.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbPrecoUnitVenda.Name = "tbPrecoUnitVenda";
            this.tbPrecoUnitVenda.PasswordChar = '\0';
            this.tbPrecoUnitVenda.PlaceholderText = "";
            this.tbPrecoUnitVenda.SelectedText = "";
            this.tbPrecoUnitVenda.ShadowDecoration.Parent = this.tbPrecoUnitVenda;
            this.tbPrecoUnitVenda.Size = new System.Drawing.Size(123, 36);
            this.tbPrecoUnitVenda.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(23, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 88);
            this.label8.TabIndex = 55;
            this.label8.Text = "*Preço de compra: \r\nAqui voce digita o preço pelo qual o produto foi comprado.\r\n\r" +
    "\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(166, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 26);
            this.label9.TabIndex = 59;
            this.label9.Text = "ID";
            // 
            // tbid
            // 
            this.tbid.Animated = true;
            this.tbid.AutoRoundedCorners = true;
            this.tbid.BackColor = System.Drawing.Color.Transparent;
            this.tbid.BorderRadius = 17;
            this.tbid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbid.DefaultText = "";
            this.tbid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbid.DisabledState.Parent = this.tbid;
            this.tbid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbid.Enabled = false;
            this.tbid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbid.FocusedState.Parent = this.tbid;
            this.tbid.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbid.HoverState.Parent = this.tbid;
            this.tbid.Location = new System.Drawing.Point(196, 56);
            this.tbid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbid.Name = "tbid";
            this.tbid.PasswordChar = '\0';
            this.tbid.PlaceholderText = "";
            this.tbid.SelectedText = "";
            this.tbid.ShadowDecoration.Parent = this.tbid;
            this.tbid.Size = new System.Drawing.Size(151, 36);
            this.tbid.TabIndex = 58;
            // 
            // Novo_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrecoUnitVenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPrecoUnitCompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUnidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Novo_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo_Produtos";
            this.Load += new System.EventHandler(this.Novo_Produto_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public Guna.UI2.WinForms.Guna2TextBox tbNome;
        public Guna.UI2.WinForms.Guna2ComboBox cbCategoria;
        public Guna.UI2.WinForms.Guna2TextBox tbUnidade;
        public Guna.UI2.WinForms.Guna2TextBox tbPrecoUnitCompra;
        public Guna.UI2.WinForms.Guna2TextBox tbPrecoUnitVenda;
        private System.Windows.Forms.Label label9;
        public Guna.UI2.WinForms.Guna2TextBox tbid;
    }
}