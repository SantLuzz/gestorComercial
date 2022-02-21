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
    public partial class Form1 : Form
    {
        Login login;
        public Form1(Login l)
        {
            InitializeComponent();
            login = l;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* using (Login login = new Login(this))
            {
                login.ShowDialog();
            }*/
            lb_version.Text = Globais.version;
            this.WindowState = FormWindowState.Maximized;

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            string vQueryCompany = (@"
                SELECT 
                   idEmpresa,
                   fantasiaEmp
                FROM 
                   tb_empresa
            ");

            dt = dataBase.dql(vQueryCompany);
            if(dt.Rows.Count > 0)
            {
                Globais.userCompany = dt.Rows[0].Field<string>("fantasiaEmp");
                lb_empresa.Text = Globais.userCompany;
            }
            else
            {
                lb_empresa.Text = "---";
            }
            lb_nivel.Text = Globais.level.ToString();
            lb_username.Text = Globais.userName;
        }

        private void openForm(int level,Form f)
        {
            if (Globais.logado == true)
            {
                if(Globais.level >= level)
                {
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Não é possível acessar sem login!");
                Login login = new Login();
                login.Show();
            }
        }

        private void lb_username_DoubleClick(object sender, EventArgs e)
        {
           
            lb_username.Text = "---";
            lb_empresa.Text = "---";
            Globais.level = 0;
            Globais.userName = "";
            Globais.idUserLogin = 0;
            Globais.logado = false;
            this.Hide();
            using (Login login = new Login())
            {
                login.ShowDialog();
            }
            
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadastroUser CadastroUser = new cadastroUser();
            openForm(2, CadastroUser);
        }

        private void empresaUsuáriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            companyUser CompanyUser = new companyUser();
            openForm(2, CompanyUser);
        }

        private void pb_aluno_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void gestãoUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestaoUser GestaoUser = new gestaoUser();
            openForm(2, GestaoUser);
        }
    }
}

