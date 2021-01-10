namespace Revendedores
{
    partial class Nova_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nova_Categoria));
            this.btnNovaCategoria = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovaCategoria
            // 
            this.btnNovaCategoria.CheckedState.Parent = this.btnNovaCategoria;
            this.btnNovaCategoria.CustomImages.Parent = this.btnNovaCategoria;
            this.btnNovaCategoria.FillColor = System.Drawing.Color.Indigo;
            this.btnNovaCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNovaCategoria.ForeColor = System.Drawing.Color.White;
            this.btnNovaCategoria.HoverState.Parent = this.btnNovaCategoria;
            this.btnNovaCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaCategoria.Image")));
            this.btnNovaCategoria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNovaCategoria.Location = new System.Drawing.Point(169, 410);
            this.btnNovaCategoria.Name = "btnNovaCategoria";
            this.btnNovaCategoria.ShadowDecoration.Parent = this.btnNovaCategoria;
            this.btnNovaCategoria.Size = new System.Drawing.Size(167, 44);
            this.btnNovaCategoria.TabIndex = 67;
            this.btnNovaCategoria.Text = "Salvar";
            this.btnNovaCategoria.Click += new System.EventHandler(this.btnNovaCategoria_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 59;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins Light", 21F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 48);
            this.label1.TabIndex = 57;
            this.label1.Text = "Categorias";
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
            this.tbNome.Location = new System.Drawing.Point(21, 143);
            this.tbNome.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbNome.Name = "tbNome";
            this.tbNome.PasswordChar = '\0';
            this.tbNome.PlaceholderText = "";
            this.tbNome.SelectedText = "";
            this.tbNome.ShadowDecoration.Parent = this.tbNome;
            this.tbNome.Size = new System.Drawing.Size(446, 36);
            this.tbNome.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 47);
            this.panel1.TabIndex = 56;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(448, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 32);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 4;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 68;
            this.label3.Text = "Descrição";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Animated = true;
            this.tbDescricao.BackColor = System.Drawing.Color.Transparent;
            this.tbDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescricao.DefaultText = "";
            this.tbDescricao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDescricao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDescricao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDescricao.DisabledState.Parent = this.tbDescricao;
            this.tbDescricao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDescricao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDescricao.FocusedState.Parent = this.tbDescricao;
            this.tbDescricao.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbDescricao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDescricao.HoverState.Parent = this.tbDescricao;
            this.tbDescricao.Location = new System.Drawing.Point(21, 226);
            this.tbDescricao.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.PasswordChar = '\0';
            this.tbDescricao.PlaceholderText = "";
            this.tbDescricao.SelectedText = "";
            this.tbDescricao.ShadowDecoration.Parent = this.tbDescricao;
            this.tbDescricao.Size = new System.Drawing.Size(446, 164);
            this.tbDescricao.TabIndex = 69;
            // 
            // Nova_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 480);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNovaCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nova_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova_Categoria";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnNovaCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbDescricao;
    }
}