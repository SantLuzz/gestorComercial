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
    public partial class AltPassword : Form
    {
        DataTable dt = new DataTable();
        Login login;
        int idSelect = 0;
        public AltPassword(Login l)
        {
            InitializeComponent();
            login = l;
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string senha = tb_senha.Text;
            string newSenha = tb_newSenha.Text;

            if(username == "" || senha == "" || newSenha == "")
            {
                MessageBox.Show("Preencha todos os Campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string vQueryLogin = string.Format(@"
                SELECT 
                   *
                FROM
                    tb_user
                WHERE
                    username='{0}'
                AND
                    senhaUser = '{1}'
            ", username, senha);
            dt = dataBase.dql(vQueryLogin);
            if (dt.Rows.Count == 1)
            {
                idSelect = int.Parse(dt.Rows[0].Field<Int64>("idUser").ToString());
                Globais.userName = dt.Rows[0].Field<string>("nameUser").ToString();
                Globais.level = int.Parse(dt.Rows[0].Field<Int64>("lvlUser").ToString());
                Globais.logado = true;
                string vQueryUpdatePass = string.Format(@"
                    UPDATE
                        tb_user
                    SET
                        senhaUser = '{0}'
                    WHERE
                        idUser= {1}
                ",newSenha, idSelect);
                dataBase.dml(vQueryUpdatePass);
                if(Globais.logado == true)
                {
                    Form1 form1 = new Form1(null);
                    form1.Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
    }
}
