using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Academia
{
    internal class dataBase
    {
        public static SQLiteConnection conect;
        

        private static SQLiteConnection conectDB()
        {
            conect = new SQLiteConnection("Data Source="+Globais.basePath+Globais.nameBase);
            conect.Open();
            return conect;
        }

        //Company
        /*
        public static DataTable Company()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;
            try
            {
                var vCon = conectDB();
                var cmd = vCon.CreateCommand();
                cmd.CommandText = String.Format(@"
                SELECT 
                   idEmpresa,
                   fantasiaEmp
                FROM 
                   tb_empresa
                ");
                da = new SQLiteDataAdapter(cmd.CommandText, vCon);
                cmd.ExecuteNonQuery();
                vCon.Close();
                return dt;
            }catch(Exception ex)
            {
                throw ex;
            }

        }
        */
        //New User
        public static void newUser(User user)
        {

            if (existsUsername(user) == true)
            {
                MessageBox.Show("Usuário já Cadastrado!", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                
                var vCon = conectDB();
                var cmd = vCon.CreateCommand();
                cmd.CommandText = String.Format(@"
                INSERT INTO
                    tb_user
                    (username,senhaUser,nameUser,lvlUser,emailUser,telefoneUser,photo)
                VALUES
                    ('{0}','{1}','{2}',{3},'{4}','{5}','{6}')
                ", user.username,user.password,user.name,user.level,user.email,user.phone,user.photo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário Cadastrado!");
                vCon.Close();
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Erro ao gravar usuário: " + ex);
                throw ex;
            }
           

        }

        //Data Language
        public static DataTable dql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vCon = conectDB();
                var cmd = vCon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vCon);
                da.Fill(dt);
                vCon.Close();
                return dt;

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string sql, string msgOK = null, string msgError = null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vCon = conectDB();
                var cmd = vCon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vCon);
                cmd.ExecuteNonQuery();
                vCon.Close();
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                if(msgError != null)
                {
                    MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                throw ex;
            }

        }

        //general routines
        public static bool existsUsername(User user)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vCon = conectDB();
            var cmd = vCon.CreateCommand();
            cmd.CommandText = String.Format(@"
                SELECT 
                    username 
                FROM 
                    tb_user
                WHERE
                    username = '{0}'
            ",user);
            da = new SQLiteDataAdapter(cmd.CommandText, vCon);
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
