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
    public partial class Login : Form
    {
        DataTable dt = new DataTable();
        string senha = "";
        public Login()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            senha = tb_senha.Text;
            
           
            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário ou senha inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_username.Focus();
                return;
            }

            string vQueryLogin = string.Format(@"
                SELECT 
                    idUser,
                    nameUser,
                    idEmpresa,
                    lvlUser,
                    username,
                    senhaUser
                FROM
                    tb_user
                WHERE
                    username='{0}'
                AND
                    senhaUser = '{1}'
            ", username, senha);
            dt = dataBase.dql(vQueryLogin);
           /* string user = dt.Rows[0].Field<string>("username");
            string pass = dt.Rows[0].Field<string>("senhaUser");
            Crypto.encode(pass);*/
            if (dt.Rows.Count == 1)
            {
                Globais.userName = dt.Rows[0].Field<string>("nameUser");
                Globais.level = int.Parse(dt.Rows[0].Field<Int64>("lvlUser").ToString());
                Globais.logado = true;
                Globais.idUserLogin = int.Parse(dt.Rows[0].Field<Int64>("idUser").ToString());
                if (Globais.logado == true)
                {
                    Form1 form1 = new Form1(this);
                    form1.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_altSenha_Click(object sender, EventArgs e)
        {
            AltPassword altPassword = new AltPassword(this);
            altPassword.ShowDialog();
            if(Globais.logado == true)
            {
                this.Hide();
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {
           /* if (senha != "")
            {
                btn_logar.Enabled = true;
            }*/
        }
    }
}
