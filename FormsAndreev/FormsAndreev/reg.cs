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
            string login = textBox1.Text;
            string pass = textBox2.Text;
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
                string name = textBox3.Text;
                sqlUser = String.Format($"insert into Пользователь(Логин, Пароль, Роль, Наименование) values({login}, {pass}, 'Заказчик', {name}) ");
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
