using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class emailEmp : Form
    {
        int mod = 0; //0 = new, 1 = update
        int idEmail = 0;

        companyUser company = new companyUser();
        public emailEmp(companyUser e)
        {
            InitializeComponent();
            company = e;
        }

        private void emailEmp_Load(object sender, EventArgs e)
        {
            string vQueryEmail = String.Format(@"
                SELECT * FROM tb_emailEmp");
            DataTable dt = dataBase.dql(vQueryEmail);
            if (dt.Rows.Count > 0)
            {
                mod = 1;
                idEmail = Convert.ToInt32(dt.Rows[0].Field<Int64>("idEmail").ToString());
                tb_host.Text = dt.Rows[0].Field<string>("hostEmail");
                tb_mail.Text = dt.Rows[0].Field<string>("email");
                tb_porta.Text = dt.Rows[0].Field<Int64>("portEmail").ToString();
                tb_cripto.Text = dt.Rows[0].Field<string>("criptoEmail");
                tb_pass.Text = dt.Rows[0].Field<string>("passEmail");
            }
        }

        private void cb_view_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_view.Checked)
            {
                tb_pass.PasswordChar = '\0';
            }
            else
            {
                tb_pass.PasswordChar = '*';
            }
        }

        private void emailEmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string vQueryEmail = "";
            string msgOK = "";
            string msgError = "";

            if(mod == 1)
            {
                msgOK = "E-mail Atualizado com Sucesso!";
                msgError = "Erro ao Atualizar E-mail!";

                vQueryEmail = string.Format(@"
                    UPDATE
                        tb_emailEmp
                    SET 
                        hostEmail = '{0}',
                        email = '{1}',
                        portEmail = {2},
                        criptoEmail = '{3}',
                        passEmail = '{4}'
                    WHERE
                        idEmail = {5}
                ", tb_host.Text,tb_mail.Text,int.Parse(tb_porta.Text),tb_cripto.Text,tb_pass.Text,idEmail);
            }
            else
            {
                msgOK = "E-mail Cadastrado com Sucesso!";
                msgError = "Erro ao Cadastrar E-mail!";

                vQueryEmail = String.Format(@"
                    INSERT INTO
                        tb_emailEmp
                        (hostEmail,email,portEmail,criptoEmail,passEmail)
                    VALUES
                        ('{0}','{1}',{2},'{3}','{4}')     
                ", tb_host.Text, tb_mail.Text, int.Parse(tb_porta.Text), tb_cripto.Text, tb_pass.Text);
            }

            dataBase.dml(vQueryEmail, msgOK, msgError);
            company.tb_email.Text = tb_mail.Text;
        }
    }
}
