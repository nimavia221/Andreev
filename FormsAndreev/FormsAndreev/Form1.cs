﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//модуль для работы с SQL
using System.Configuration;


namespace FormsAndreev
{
    public partial class Form1 : Form
    {
        // вызов строки подключения из файла конфигурации
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        DataSet ds; // набор данных
        string sql = "SELECT * FROM Пользователь"; // запрос для формирования набора данных

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            reg r = new FormsAndreev.reg();
            f.Hide();
            r.Show();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string Login = txtLogin.Text;
            string Pass = txtPass.Text;
            string sqlUser = String.Format($"SELECT Логин, Пароль, Роль FROM Пользователь  WHERE Логин='{Login}' AND Пароль={Pass}");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();//подключение открыто
                SqlCommand cmd = new SqlCommand(sqlUser, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        MessageBox.Show("Добро пожаловать" + reader.GetValue(0) + reader.GetValue(1));
                        string Role = reader.GetValue(2).ToString();
                        switch (Role)
                        {
                            case "Менеджер":
                                MessageBox.Show("Менеджер");
                                Form1 f = new Form1();
                                manager r = new manager();
                                f.Hide();
                                r.Show();
                                break;
                            case "Кладовщик":
                                MessageBox.Show("Кладовщик");
                                break;
                            case "Заказчик":
                                MessageBox.Show("Заказчик");
                                break;
                            case "Руководитель":
                                MessageBox.Show("Руководитель");
                                break;

                        }
                    }
                       
                else
                    MessageBox.Show("Некорректный ввод");
            }
        }
    }

}
