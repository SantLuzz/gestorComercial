namespace Academia
{
    partial class emailEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emailEmp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.cb_view = new System.Windows.Forms.CheckBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_host = new System.Windows.Forms.TextBox();
            this.tb_porta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cripto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_cripto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_porta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.cb_view);
            this.panel1.Controls.Add(this.tb_pass);
            this.panel1.Controls.Add(this.tb_mail);
            this.panel1.Controls.Add(this.tb_host);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 256);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Host:";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(160, 212);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(117, 32);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cb_view
            // 
            this.cb_view.AutoSize = true;
            this.cb_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cb_view.Location = new System.Drawing.Point(88, 179);
            this.cb_view.Name = "cb_view";
            this.cb_view.Size = new System.Drawing.Size(104, 17);
            this.cb_view.TabIndex = 4;
            this.cb_view.Text = "Vizualizar Senha";
            this.cb_view.UseVisualStyleBackColor = true;
            this.cb_view.CheckedChanged += new System.EventHandler(this.cb_view_CheckedChanged);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(88, 153);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(306, 20);
            this.tb_pass.TabIndex = 3;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(88, 110);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(306, 20);
            this.tb_mail.TabIndex = 2;
            // 
            // tb_host
            // 
            this.tb_host.Location = new System.Drawing.Point(88, 28);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(306, 20);
            this.tb_host.TabIndex = 1;
            // 
            // tb_porta
            // 
            this.tb_porta.Location = new System.Drawing.Point(88, 68);
            this.tb_porta.Name = "tb_porta";
            this.tb_porta.Size = new System.Drawing.Size(94, 20);
            this.tb_porta.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Porta:";
            // 
            // tb_cripto
            // 
            this.tb_cripto.Location = new System.Drawing.Point(283, 68);
            this.tb_cripto.Name = "tb_cripto";
            this.tb_cripto.Size = new System.Drawing.Size(111, 20);
            this.tb_cripto.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Criptografia:";
            // 
            // emailEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(465, 280);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "emailEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.Load += new System.EventHandler(this.emailEmp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_view;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cripto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_porta;
    }
}