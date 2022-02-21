using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Academia
{
    public partial class cadastroUser : Form
    {
        string completeOrigin = "";
        string photo = "";
        string destinationFolder = Globais.imagePath;
        string fullDestination = "";

        public cadastroUser()
        {
            InitializeComponent();

        }

        private void Clear()
        {
            tb_name.Clear();
            tb_email.Clear();
            tb_username.Clear();
            tb_password.Clear();
            mtb_telefone.Clear();
            n_access.Value = 1;
            cb_company.SelectedIndex = -1;
            pb_photo.ImageLocation = null;
        }

        private void cadastroUser_Load(object sender, EventArgs e)
        {
            string vQueryEmp = string.Format(@"
                SELECT 
                  idEmpresa,
                  fantasiaEmp
                FROM
                    tb_empresa
            ");
            cb_company.Items.Clear();
            cb_company.DataSource = dataBase.dql(vQueryEmp);
            cb_company.DisplayMember = "fantasiaEmp";
            cb_company.ValueMember = "idEmpresa";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(fullDestination == "")
            {
                if(MessageBox.Show("Nenhuma imagem foi selecionada, deseja continuar?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            if(fullDestination != "")
            {
                System.IO.File.Copy(completeOrigin, fullDestination,true);
                if (File.Exists(fullDestination))
                {
                    pb_photo.ImageLocation = fullDestination;
                }
                else
                {
                    if (MessageBox.Show("Erro ao Localizar a imagem, deseja continuar?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            User user = new User();
            user.name = tb_name.Text;
            user.username = tb_username.Text;
            user.password = tb_password.Text;
            user.email = tb_email.Text;
            user.phone = mtb_telefone.Text;
            user.level = Convert.ToInt32(Math.Round(n_access.Value, 0));
            user.photo = fullDestination;
            user.idempresa = int.Parse(cb_company.SelectedValue.ToString());
            dataBase.newUser(user);
            Clear();
        }
            

        private void btn_add_Click_1(object sender, EventArgs e)
        {
                completeOrigin = "";
                photo = "";
                destinationFolder = Globais.imagePath;
                fullDestination = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    completeOrigin = openFileDialog1.FileName;
                    photo = openFileDialog1.SafeFileName;
                    fullDestination = destinationFolder + photo;
                }
                if (File.Exists(fullDestination))
                {
                    if (MessageBox.Show("Imagem existente, deseja substituir?", "Substituir?", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                pb_photo.ImageLocation = completeOrigin;
            
        }

     
    }
}
