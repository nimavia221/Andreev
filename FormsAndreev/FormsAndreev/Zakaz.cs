using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormsAndreev
{
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            lblWelcome.Text = $"Добро пожаловать, {user.login}";
            string sqlUser = String.Format($"SELECT Наименование FROM Изделия$");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();//подключение открыто
                SqlCommand cmd = new SqlCommand(sqlUser, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        txtProduct.Items.Add(reader.GetValue(0).ToString());
                    }
            }
        }

        private void txtProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProperty_Enter(object sender, EventArgs e)
        {
            txtProperty.Items.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlUser = String.Format($"SELECT Ширина, Длина FROM Изделия$ WHERE Наименование = '{txtProduct.Text}'");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();//подключение открыто
                SqlCommand cmd = new SqlCommand(sqlUser, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        user.Height = reader.GetValue(0).ToString();
                        user.Width = reader.GetValue(1).ToString();
                        txtProperty.Items.Add($"{user.Height} {user.Width}");

                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ar = null;
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlUser = String.Format($" SELECT Артикул FROM Изделия$ WHERE Ширина = '{user.Width}' and Длина = '{user.Height}'");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();//подключение открыто
                SqlCommand cmd = new SqlCommand(sqlUser, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                        while (reader.Read())
                        {
                        Ar = reader.GetValue(0).ToString();
                        }

            }
            sqlUser = String.Format($"insert into [Заказанные изделия]([Артикул изделия], Количество, Дата, Заказчик) values('{Ar}', {Int32.Parse(txtCount.Text)}, '{DateTime.Now}', '{user.login}') ");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();//подключение открыто
                SqlCommand cmd = new SqlCommand(sqlUser, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                
            }
        }
    }
}

