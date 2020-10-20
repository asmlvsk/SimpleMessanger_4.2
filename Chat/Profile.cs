using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Profile : Form
    {
        private string login;
        public Profile(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 120, 120);
            Region rgn = new Region(path);
            pictureBox3.Region = rgn;
            pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;

            UserLabel.Text = login;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    pictureBox3.Image = new Bitmap(open_dialog.FileName);
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string con = "datasource = localhost;port = 3306; Initial Catalog = 'messenger'; username = clientbd; password= '12345'";
            string checkcmd = $"UPDATE users SET pass = '{pPassBox.Text}', email = '{pEmailBox.Text}' WHERE name = '{UserLabel.Text}'";
            MySqlConnection two = new MySqlConnection(con);
            MySqlCommand add = new MySqlCommand(checkcmd, two);
            two.Open();
            add.Prepare();
            add.ExecuteNonQuery();
            two.Close();

            MessageBox.Show("Данные изменены! Пожалуйста, перезайдите в приложения для активизации новых данных");
            pPassBox.Text = "";
            pEmailBox.Text = "";
        }

    }
}
