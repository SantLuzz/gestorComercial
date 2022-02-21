namespace Academia
{
    partial class companyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(companyUser));
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.cb_isento = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_configMail = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtb_phone = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_fantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_razao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_proprietario = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_ie = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Informações";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Inscrição Estadual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "CNPJ";
            // 
            // mtb_cnpj
            // 
            this.mtb_cnpj.Location = new System.Drawing.Point(16, 51);
            this.mtb_cnpj.Mask = "99\\.999\\.999\\/9999\\-99";
            this.mtb_cnpj.Name = "mtb_cnpj";
            this.mtb_cnpj.Size = new System.Drawing.Size(209, 20);
            this.mtb_cnpj.TabIndex = 4;
            // 
            // cb_isento
            // 
            this.cb_isento.AutoSize = true;
            this.cb_isento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_isento.Location = new System.Drawing.Point(267, 77);
            this.cb_isento.Name = "cb_isento";
            this.cb_isento.Size = new System.Drawing.Size(79, 17);
            this.cb_isento.TabIndex = 36;
            this.cb_isento.TabStop = false;
            this.cb_isento.Text = "ISENTO?";
            this.cb_isento.UseVisualStyleBackColor = true;
            this.cb_isento.CheckedChanged += new System.EventHandler(this.cb_isento_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_ie);
            this.panel1.Controls.Add(this.cb_isento);
            this.panel1.Controls.Add(this.mtb_cnpj);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 107);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_email);
            this.panel2.Controls.Add(this.mtb_phone);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_configMail);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 148);
            this.panel2.TabIndex = 36;
            // 
            // btn_configMail
            // 
            this.btn_configMail.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_configMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_configMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configMail.Location = new System.Drawing.Point(358, 43);
            this.btn_configMail.Name = "btn_configMail";
            this.btn_configMail.Size = new System.Drawing.Size(117, 30);
            this.btn_configMail.TabIndex = 7;
            this.btn_configMail.Text = "Configurações";
            this.btn_configMail.UseVisualStyleBackColor = false;
            this.btn_configMail.Click += new System.EventHandler(this.btn_configMail_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Contato";
            // 
            // mtb_phone
            // 
            this.mtb_phone.Location = new System.Drawing.Point(16, 107);
            this.mtb_phone.Mask = "(99) 99999-9999";
            this.mtb_phone.Name = "mtb_phone";
            this.mtb_phone.Size = new System.Drawing.Size(209, 20);
            this.mtb_phone.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Telefone";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tb_proprietario);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_fantasia);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tb_razao);
            this.panel3.Location = new System.Drawing.Point(12, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 195);
            this.panel3.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fantasia";
            // 
            // tb_fantasia
            // 
            this.tb_fantasia.Location = new System.Drawing.Point(15, 100);
            this.tb_fantasia.Name = "tb_fantasia";
            this.tb_fantasia.Size = new System.Drawing.Size(460, 20);
            this.tb_fantasia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Razão Social";
            // 
            // tb_razao
            // 
            this.tb_razao.Location = new System.Drawing.Point(15, 37);
            this.tb_razao.Name = "tb_razao";
            this.tb_razao.Size = new System.Drawing.Size(460, 20);
            this.tb_razao.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Proprietário";
            // 
            // tb_proprietario
            // 
            this.tb_proprietario.Location = new System.Drawing.Point(15, 159);
            this.tb_proprietario.Name = "tb_proprietario";
            this.tb_proprietario.Size = new System.Drawing.Size(460, 20);
            this.tb_proprietario.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_close);
            this.panel4.Controls.Add(this.btn_save);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 567);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(523, 53);
            this.panel4.TabIndex = 40;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(263, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(117, 32);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "Fechar";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(121, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(117, 32);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_ie
            // 
            this.tb_ie.Location = new System.Drawing.Point(267, 51);
            this.tb_ie.Name = "tb_ie";
            this.tb_ie.Size = new System.Drawing.Size(210, 20);
            this.tb_ie.TabIndex = 37;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(16, 49);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(318, 20);
            this.tb_email.TabIndex = 39;
            // 
            // companyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(523, 620);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "companyUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa Usuária";
            this.Load += new System.EventHandler(this.companyUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtb_cnpj;
        private System.Windows.Forms.CheckBox cb_isento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox mtb_phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_configMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_fantasia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_razao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_proprietario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_ie;
        public System.Windows.Forms.TextBox tb_email;
    }
}