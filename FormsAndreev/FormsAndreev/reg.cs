using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FormsAndreev
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int len = 0;
            bool num = false;
            bool pass_char = false;
            bool chr = false;
            string login = txtLogin.Text;
            string pass = txtPass.Text;
            
            foreach(char a in pass)
            {
                var res = 0;
                len++;
                if(Int32.TryParse(a.ToString(), out res))
                {
                    num = true;
                }
                if(a == '!' || a == '@' || a == '#' || a == '$' || a == '%' || a == '^' )
                {
                    pass_char = true;
                }
                if(((int)a >= 224 && (int)a <= 255) || ((int)a>=97 && (int)a <= 122)){
                    chr = true;
                }
            }

            if (len < 6 || num == false || pass_char == false || chr == false)
            {
                MessageBox.Show("Неверный тип пароля");
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                string Login = null;
                string sqlUser = String.Format($"SELECT Логин, Пароль FROM Пользователь ");
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();//подключение открыто
                    SqlCommand cmd = new SqlCommand(sqlUser, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        while (reader.Read())
                        {

                            Login = reader.GetValue(0).ToString();

                            if (login == Login)
                                i++;
                        }



                }


                if (i == 0)
                {
                    string name = txtFIO.Text;
                    sqlUser = String.Format($"insert into Пользователь(Логин, Пароль, Роль, Наименование) values('{login.ToString()}', '{pass.ToString()}', 'Заказчик', '{name.ToString()}') ");
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();//подключение открыто
                        SqlCommand cmd = new SqlCommand(sqlUser, conn);
                        SqlDataReader reader = cmd.ExecuteReader();

                    }
                }
                else
                {
                    MessageBox.Show("Данные существуют");
                }
            }
                
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
