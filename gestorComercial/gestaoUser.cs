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
    public partial class gestaoUser : Form
    {
        DataTable dt = new DataTable();
        string completeOrigin = "";
        string photo = "";
        string destinationFolder = Globais.imagePath;
        string fullDestination = "";
        string oldPhoto = "";
        int vId = 0;
        string vQueryDataIdUser = "";
        int row = 0;

        public gestaoUser()
        {
            InitializeComponent();
        }

        private void gestaoUser_Load(object sender, EventArgs e)
        {
            
            string vQueryGetIdUser = string.Format(@"
                SELECT 
                    idUser as 'Id Usuário',
                    nameUser as 'Nome',
                    username as 'Usuário'
                FROM 
                   tb_user 
            ");
            dgv_user.DataSource = dataBase.dql(vQueryGetIdUser);
            dgv_user.Columns[0].Width = 80;
            dgv_user.Columns[1].Width = 160;
            dgv_user.Columns[2].Width = 80;
            
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            cadastroUser CadastroUser = new cadastroUser();
            this.Close();
            CadastroUser.ShowDialog();
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_user_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int countRows = dgv.SelectedRows.Count;

            if(countRows > 0)
            {
                vId = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
                vQueryDataIdUser = string.Format(@"
                   SELECT 
                        username,
                        nameUser,
                        emailUser,
                        lvlUser,
                        telefoneUser,
                        photo
                   FROM
                        tb_user
                   WHERE
                        idUser = {0}
                ", vId);
                dt = dataBase.dql(vQueryDataIdUser);
                tb_name.Text = dt.Rows[0].Field<string>("username");
                tb_username.Text = dt.Rows[0].Field<string>("nameUser");
                tb_email.Text = dt.Rows[0].Field<string>("emailUser");
                mtb_telefone.Text = dt.Rows[0].Field<string>("telefoneUser");
                pb_photo.ImageLocation = dt.Rows[0].Field<string>("photo");
                oldPhoto = dt.Rows[0].Field<string>("photo");
                n_access.Value = dt.Rows[0].Field<Int64>("lvlUser");
                cb_company.Text = Globais.userCompany;
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (fullDestination == "")
            {
                if (MessageBox.Show("Nenhuma imagem foi selecionada, deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            if (fullDestination != "")
            {
                System.IO.File.Copy(completeOrigin, fullDestination, true);
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
            User u = new User();
            u.name = tb_name.Text;
            u.username = tb_username.Text;
            u.email = tb_email.Text;
            u.phone = mtb_telefone.Text;
            u.level = Convert.ToInt32(Math.Round(n_access.Value, 0));
            u.photo = fullDestination;
            row = dgv_user.SelectedRows[0].Index;
            string vQueryUpdateUser = string.Format(@"
                UPDATE 
                    tb_user
                SET
                    username = '{0}',
                    nameUser = '{1}',
                    emailUser = '{2}',
                    lvlUser = {3},
                    telefoneUser = '{4}',
                    photo = '{5}'
                WHERE
                    idUser = {6}
            ",u.username,u.name,u.email,u.level,u.photo,u.photo,vId);
            string msgOk = "Usuário Atualizado com sucesso!";
            string msgError = "Usuário não Atualizado!";
            dataBase.dml(vQueryUpdateUser,msgOk,msgError);

            if (File.Exists(oldPhoto))
            {
                File.Delete(oldPhoto);
            }
            dgv_user[1, row].Value = tb_name.Text;
            dgv_user[2, row].Value = tb_username.Text;
        }

        private void btn_altFoto_Click(object sender, EventArgs e)
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do usuário?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (File.Exists(pb_photo.ImageLocation))
                {
                    File.Delete(pb_photo.ImageLocation);
                }
                string vQueryDelete = string.Format(@"
                    DELETE FROM
                        tb_user
                    WHERE
                       idUser = {0} 
                ", vId);
                dataBase.dml(vQueryDelete);
                dgv_user.Rows.Remove(dgv_user.CurrentRow);
            }
        }

        private void btn_altSenha_Click(object sender, EventArgs e)
        {
            altSenhaGestUser AltSenhaGestUser = new altSenhaGestUser();
            AltSenhaGestUser.ShowDialog();
        }
    }
}
