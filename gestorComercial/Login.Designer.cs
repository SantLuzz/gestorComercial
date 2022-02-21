namespace Academia
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_altSenha = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_logar = new System.Windows.Forms.Button();
            this.tb_empresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_altSenha);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_logar);
            this.panel1.Controls.Add(this.tb_empresa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_senha);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 198);
            this.panel1.TabIndex = 9;
            // 
            // btn_altSenha
            // 
            this.btn_altSenha.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_altSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altSenha.Location = new System.Drawing.Point(358, 141);
            this.btn_altSenha.Name = "btn_altSenha";
            this.btn_altSenha.Size = new System.Drawing.Size(117, 32);
            this.btn_altSenha.TabIndex = 21;
            this.btn_altSenha.Text = "Alterar Senha";
            this.btn_altSenha.UseVisualStyleBackColor = false;
            this.btn_altSenha.Click += new System.EventHandler(this.btn_altSenha_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(358, 94);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(117, 32);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_logar
            // 
            this.btn_logar.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logar.Location = new System.Drawing.Point(358, 43);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(117, 32);
            this.btn_logar.TabIndex = 19;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = false;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // tb_empresa
            // 
            this.tb_empresa.Location = new System.Drawing.Point(44, 148);
            this.tb_empresa.Name = "tb_empresa";
            this.tb_empresa.ReadOnly = true;
            this.tb_empresa.Size = new System.Drawing.Size(297, 20);
            this.tb_empresa.TabIndex = 18;
            this.tb_empresa.TabStop = false;
            this.tb_empresa.Text = "NOME DA EMPRESA USUÁRIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuário";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(44, 101);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(297, 20);
            this.tb_senha.TabIndex = 12;
            this.tb_senha.TextChanged += new System.EventHandler(this.tb_senha_TextChanged);
            // 
            // tb_username
            // 
            this.tb_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_username.Location = new System.Drawing.Point(44, 49);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(297, 20);
            this.tb_username.TabIndex = 11;
            this.tb_username.Text = "WHOAMI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Desenvolvido por Luiz Felipe Silva Santos - 2022";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Academia.Properties.Resources.incial;
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(523, 227);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_empresa;
        private System.Windows.Forms.Button btn_altSenha;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_logar;
    }
}