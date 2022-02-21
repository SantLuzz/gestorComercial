namespace Academia
{
    partial class AltPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_newSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_logar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_newSenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_senha);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 247);
            this.panel1.TabIndex = 0;
            // 
            // btn_logar
            // 
            this.btn_logar.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logar.Location = new System.Drawing.Point(120, 194);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(117, 32);
            this.btn_logar.TabIndex = 22;
            this.btn_logar.Text = "Logar e Alterar";
            this.btn_logar.UseVisualStyleBackColor = false;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nova Senha";
            // 
            // tb_newSenha
            // 
            this.tb_newSenha.Location = new System.Drawing.Point(32, 153);
            this.tb_newSenha.Name = "tb_newSenha";
            this.tb_newSenha.PasswordChar = '*';
            this.tb_newSenha.Size = new System.Drawing.Size(297, 20);
            this.tb_newSenha.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Senha";
            // 
            // tb_username
            // 
            this.tb_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_username.Location = new System.Drawing.Point(32, 47);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(297, 20);
            this.tb_username.TabIndex = 16;
            this.tb_username.Text = "WHOAMI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuário";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(32, 99);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(297, 20);
            this.tb_senha.TabIndex = 17;
            this.tb_senha.Text = "6331365";
            // 
            // AltPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(380, 271);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_newSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button btn_logar;
    }
}