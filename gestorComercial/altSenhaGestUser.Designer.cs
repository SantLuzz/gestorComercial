namespace Academia
{
    partial class altSenhaGestUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altSenhaGestUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_confirme = new System.Windows.Forms.TextBox();
            this.btn_altSenha = new System.Windows.Forms.Button();
            this.cb_view = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_view);
            this.panel1.Controls.Add(this.btn_altSenha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_confirme);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_senha);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 219);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nova Senha";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(47, 53);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(297, 20);
            this.tb_senha.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Insira Novamente sua senha:";
            // 
            // tb_confirme
            // 
            this.tb_confirme.Location = new System.Drawing.Point(47, 117);
            this.tb_confirme.Name = "tb_confirme";
            this.tb_confirme.PasswordChar = '*';
            this.tb_confirme.Size = new System.Drawing.Size(297, 20);
            this.tb_confirme.TabIndex = 18;
            // 
            // btn_altSenha
            // 
            this.btn_altSenha.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_altSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altSenha.Location = new System.Drawing.Point(129, 175);
            this.btn_altSenha.Name = "btn_altSenha";
            this.btn_altSenha.Size = new System.Drawing.Size(117, 32);
            this.btn_altSenha.TabIndex = 20;
            this.btn_altSenha.Text = "Alterar Senha";
            this.btn_altSenha.UseVisualStyleBackColor = false;
            this.btn_altSenha.Click += new System.EventHandler(this.btn_altSenha_Click);
            // 
            // cb_view
            // 
            this.cb_view.AutoSize = true;
            this.cb_view.Location = new System.Drawing.Point(329, 143);
            this.cb_view.Name = "cb_view";
            this.cb_view.Size = new System.Drawing.Size(15, 14);
            this.cb_view.TabIndex = 21;
            this.cb_view.UseVisualStyleBackColor = true;
            this.cb_view.CheckedChanged += new System.EventHandler(this.cb_view_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Visualizar Senha?";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // altSenhaGestUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(433, 246);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "altSenhaGestUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_confirme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button btn_altSenha;
        private System.Windows.Forms.CheckBox cb_view;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}