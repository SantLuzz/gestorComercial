namespace Academia
{
    partial class cadastroUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.n_access = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_company = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_access)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 55);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(567, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(136, 32);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Fechar";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(379, 11);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(136, 32);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(26, 11);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(136, 32);
            this.btn_new.TabIndex = 11;
            this.btn_new.Text = "Novo";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(201, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(136, 32);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(14, 51);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(460, 20);
            this.tb_name.TabIndex = 15;
            // 
            // tb_username
            // 
            this.tb_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_username.Location = new System.Drawing.Point(14, 120);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(206, 20);
            this.tb_username.TabIndex = 16;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(268, 120);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(206, 20);
            this.tb_password.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Senha";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|JPEG(*.jpeg)|*.jpeg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Dados Usuário";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tb_name);
            this.panel3.Controls.Add(this.tb_username);
            this.panel3.Controls.Add(this.tb_password);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(26, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 161);
            this.panel3.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.mtb_telefone);
            this.panel2.Controls.Add(this.tb_email);
            this.panel2.Location = new System.Drawing.Point(26, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 144);
            this.panel2.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "E-Mail";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(16, 95);
            this.mtb_telefone.Mask = "(99)\\ 99999\\-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(206, 20);
            this.mtb_telefone.TabIndex = 26;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(16, 43);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(460, 20);
            this.tb_email.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Contato";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.n_access);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cb_company);
            this.panel4.Location = new System.Drawing.Point(26, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 100);
            this.panel4.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Acesso";
            // 
            // n_access
            // 
            this.n_access.Location = new System.Drawing.Point(265, 53);
            this.n_access.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.n_access.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_access.Name = "n_access";
            this.n_access.Size = new System.Drawing.Size(206, 20);
            this.n_access.TabIndex = 31;
            this.n_access.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Empresa";
            // 
            // cb_company
            // 
            this.cb_company.FormattingEnabled = true;
            this.cb_company.Location = new System.Drawing.Point(20, 52);
            this.cb_company.Name = "cb_company";
            this.cb_company.Size = new System.Drawing.Size(206, 21);
            this.cb_company.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Informações";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btn_add);
            this.panel5.Controls.Add(this.pb_photo);
            this.panel5.Location = new System.Drawing.Point(530, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 251);
            this.panel5.TabIndex = 46;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(26, 198);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(136, 32);
            this.btn_add.TabIndex = 30;
            this.btn_add.Text = "Adicionar Foto";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // pb_photo
            // 
            this.pb_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_photo.Location = new System.Drawing.Point(26, 26);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(136, 158);
            this.pb_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_photo.TabIndex = 31;
            this.pb_photo.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(547, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Foto Usuário";
            // 
            // cadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(730, 582);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastroUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.cadastroUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_access)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown n_access;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_company;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pb_photo;
        private System.Windows.Forms.Label label11;
    }
}