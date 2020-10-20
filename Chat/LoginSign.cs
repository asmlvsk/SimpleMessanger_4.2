using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimpleChat_Client
{
    public partial class LoginSign : Form
    {
        public LoginSign()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string con = "datasource = localhost;port = 3306; Initial Catalog = 'messenger'; username = root; password= ''";
            MySqlConnection one = new MySqlConnection(con);
            MySqlCommand res = new MySqlCommand("SELECT * from users where name='" + this.loginBox.Text + "' and pass='" + this.passBox.Text + "';", one);
            MySqlDataReader reader;
            one.Open();
            reader = res.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                Form1 f1 = new Form1(this.loginBox.Text);

                this.Hide();
                f1.Show();
                one.Close();
            }
            else
            {
                one.Close();
                MessageBox.Show("Пользователь не найден! Проверьте введенную информацию или заполните все поля!");
                loginBox.Text = "";
                passBox.Text = "";
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string loginAdd = signLoginBox.Text;
            string passAdd = signPassBox.Text;
            string emailAdd = signEmailBox.Text;

            string con = "datasource = localhost;port = 3306; Initial Catalog = 'messenger'; username = root; password= ''";
            string checkcmd = $"INSERT into users(name, pass, email) values('{loginAdd}','{passAdd}','{emailAdd}')";
            MySqlConnection two = new MySqlConnection(con);
            MySqlCommand add = new MySqlCommand(checkcmd, two);
            two.Open();
            add.Prepare();
            add.ExecuteNonQuery();
            two.Close();

            MessageBox.Show("Вы усешно зарегестрировались!");
            signLoginBox.Text = "";
            signPassBox.Text = "";
            signEmailBox.Text = "";
            panel3.Visible = false;
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
