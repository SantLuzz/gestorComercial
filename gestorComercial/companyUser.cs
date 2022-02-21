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
    public partial class companyUser : Form
    {
        string isento = "ISENTO";
        int mod = 0; //0 = new, 1 = edtion
        int idEmp = 0;

        public companyUser()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void companyUser_Load(object sender, EventArgs e)
        {
            string vQueryInfo = string.Format(@"
                SELECT 
                    idEmpresa,
                    razaoEmp,
                    fantasiaEmp,
                    respEmp,
                    cnpjEmp,
                    inscEstadual,
                    phoneEmp
                FROM
                    tb_empresa
            ");

            string vQueryEmail = string.Format(@"
                SELECT 
                    email 
                FROM 
                    tb_emailEmp
            ");

            DataTable dt = dataBase.dql(vQueryInfo);
            DataTable dtEmail = dataBase.dql(vQueryEmail);

            if(dt.Rows.Count > 0)
            {
                mod = 1;
                idEmp = Convert.ToInt32(dt.Rows[0].Field<Int64>("idEmpresa").ToString());
                tb_razao.Text = dt.Rows[0].Field<string>("razaoEmp");
                tb_fantasia.Text = dt.Rows[0].Field<string>("fantasiaEmp");
                tb_proprietario.Text = dt.Rows[0].Field<string>("respEmp");
                mtb_cnpj.Text = dt.Rows[0].Field<string>("cnpjEmp");
                tb_ie.Text = dt.Rows[0].Field<string>("inscEstadual");
                mtb_phone.Text = dt.Rows[0].Field<string>("phoneEmp");
                tb_email.Text = dtEmail.Rows[0].Field<string>("email");
                Globais.userCompany =  dt.Rows[0].Field<string>("fantasiaEmp");
                if (tb_ie.Text == isento)
                {
                    cb_isento.Checked = true;
                }
               
            }
        }
        private void cb_isento_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_isento.Checked)
            {
                tb_ie.Text = isento;
            }
            else
            {
                tb_ie.Text = "";
            }       
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string vQueryEmp = "";
            string msgOK = "";
            string msgError = "";

            if(mod == 1)
            {
                msgOK = "Empresa Atualizada com Sucesso!";
                msgError = "Erro ao Atualizar a Empresa!";

                vQueryEmp = string.Format(@"
                    UPDATE
                        tb_empresa
                    SET
                        razaoEmp = '{0}',
                        fantasiaEmp = '{1}',
                        respEmp = '{2}',
                        cnpjEmp = '{3}',
                        inscEstadual = '{4}',
                        phoneEmp = '{5}'
                    WHERE
                        idEmpresa = {6}", tb_razao.Text,tb_fantasia.Text,tb_proprietario.Text,mtb_cnpj.Text,tb_ie.Text,mtb_phone.Text,idEmp);
            }
            else
            {
                msgOK = "Empresa Cadastrada com Sucesso!";
                msgError = "Erro ao Cadastrar a Empresa!";
                

                vQueryEmp = String.Format(@"
                    INSERT INTO
                        tb_empresa
                        (razaoEmp,fantasiaEmp,respEmp,cnpjEmp,inscEstadual,phoneEmp)
                    VALUES
                        ('{0}','{1}','{2}','{3}','{4}','{5}')
                ", tb_razao.Text, tb_fantasia.Text, tb_proprietario.Text, mtb_cnpj.Text, tb_ie.Text, mtb_phone.Text);
                
            }
            dataBase.dml(vQueryEmp,msgOK,msgError);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_configMail_Click(object sender, EventArgs e)
        {
            emailEmp EmailEmp = new emailEmp(this);
            EmailEmp.ShowDialog();
        }
    }
}
