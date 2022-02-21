using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Globais
    {
        public static string version = "1.0";
        public static bool logado = false;
        public static int level = 0; /*Levels = 1 - usuário comum, 2 - usuário Master, 3 - Editor do sistema*/
        public static string exePath = System.Environment.CurrentDirectory;
        //public static string exePath = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nameBase = "ACD2022BD.db";
        public static string basePath = exePath+@"\base\";
        public static string imagePath = exePath + @"\images\";
        public static string userCompany = "";
        public static string userName = "";
        public static int idUserLogin = 0;
    }
}
