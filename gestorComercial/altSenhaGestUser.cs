using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Academia
{
    public partial class altSenhaGestUser : Form
    {
        public altSenhaGestUser()
        {
            InitializeComponent();
        }

        private void btn_altSenha_Click(object sender, EventArgs e)
        {
            string pass1 = tb_senha.Text;
            string pass2 = tb_confirme.Text;

            //MessageBox.Show(Globais.idUserLogin.ToString());
            if(pass1 != pass2)
            {
                MessageBox.Show("As senhas não conferem, por favor verifique!", "Senhas não Conferem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(pass1 == "" || pass2 == "")
            {
                MessageBox.Show("Os campos não podem ficar em branco!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string msgOK = "Senha Alterada com Sucesso!";
            string msgError = "Erro ao Alterar a Senha!";
            string vQueryUpdatePassword = string.Format(@"
                    UPDATE 
                        tb_user 
                    SET 
                        senhaUser = '{0}' 
                    WHERE idUser = {1}", pass2, Globais.idUserLogin);
            dataBase.dml(vQueryUpdatePassword, msgOK, msgError);
        }

        private void cb_view_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_view.Checked)
            {
                tb_confirme.PasswordChar = '\0';
                tb_senha.PasswordChar = '\0';
            }
            else
            {
                tb_confirme.PasswordChar = '*';
                tb_senha.PasswordChar = '*';
            }
        }
    }
}
