using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using Chat;
using System.Security.Cryptography;

namespace SimpleChat_Client
{
    public partial class Form1 : Form
    {
        private delegate void ChatEvent(string content, string clr);
        private ChatEvent _addMessage;
        private Socket _serverSocket;
        private Thread listenThread;
        private string _host = "127.0.0.1";
        private int _port = 8888;

        private string login;

        public Form1(string login)
        {
            InitializeComponent();

            _addMessage = new ChatEvent(AddMessage);
            userMenu = new ContextMenuStrip();
            ToolStripMenuItem PrivateMessageItem = new ToolStripMenuItem();
            PrivateMessageItem.Text = "Личное сообщение";
            PrivateMessageItem.Click += delegate
            {
                if (userList.SelectedItems.Count > 0)
                {
                    msgBox.Text = $"\"{userList.SelectedItem} ";
                }
            };
            userMenu.Items.Add(PrivateMessageItem);
            ToolStripMenuItem SendFileItem = new ToolStripMenuItem()
            {
                Text = "Отправить файл"
            };
            SendFileItem.Click += delegate
            {
                if (userList.SelectedItems.Count == 0)
                {
                    return;
                }
                OpenFileDialog ofp = new OpenFileDialog();
                ofp.ShowDialog();
                if (!File.Exists(ofp.FileName))
                {
                    MessageBox.Show($"Файл {ofp.FileName} не найден!");
                    return;
                }
                FileInfo fi = new FileInfo(ofp.FileName);
                byte[] buffer = File.ReadAllBytes(ofp.FileName);
                Send($"#sendfileto|{userList.SelectedItem}|{buffer.Length}|{fi.Name}");//g
                SendText(buffer);
            };
            userMenu.Items.Add(SendFileItem);
            userList.ContextMenuStrip = userMenu;

            this.login = login;
        }

        //static byte[] EncryptString(string clearText, string EncryptionKey = "123")
        //{
        //    byte[] clearBytes = Encoding.UTF8.GetBytes(clearText);
        //    byte[] encrypted;
        //    using (var encryptor = Aes.Create())
        //    {
        //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey,
        //            new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(clearBytes, 0, clearBytes.Length);
        //                cs.Close();
        //            }
        //            encrypted = ms.ToArray();
        //        }
        //    }
        //    return encrypted;
        //}

        //static string DecryptBytes(byte[] encryptBytes, string EncryptionKey = "123")
        //{
        //    string cipherText = "";
        //    var encryptText = Encoding.UTF8.GetString(encryptBytes);
        //    using (var encryptor = Aes.Create())
        //    {
        //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey,
        //            new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(encryptBytes, 0, encryptBytes.Length);
        //                cs.Close();
        //            }
        //            cipherText = Encoding.UTF8.GetString(ms.ToArray());
        //        }
        //    }
        //    return cipherText;
        //}



        private void AddMessage(string Content, string Color = "Black")
        {
            if (InvokeRequired)
            {
                Invoke(_addMessage, Content, Color);
                return;
            }
            chatBox.SelectionStart = chatBox.TextLength;
            chatBox.SelectionLength = Content.Length;
            chatBox.SelectionColor = getColor(Color);
            chatBox.AppendText(Content + Environment.NewLine);
        }

        private Color getColor(string text)
        {
            if (Color.Red.Name.Contains(text))
                return Color.Red;
            return Color.Black;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serverSocket.Connected)
                Send("#endsession");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPAddress temp = IPAddress.Parse(_host);
            _serverSocket = new Socket(temp.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Connect(new IPEndPoint(temp, _port));
            if (_serverSocket.Connected)
            {
                AddMessage("Связь с сервером установлена.");
                listenThread = new Thread(listner);
                listenThread.IsBackground = true;
                listenThread.Start();

            }
            else
                AddMessage("Связь с сервером не установлена.");

            string nickName = login;
            if (string.IsNullOrEmpty(nickName))
                return;
            Send($"#setname|{nickName}");

            label1.Text = login;

        }

        public void SendText(byte[] buffer)
        {
            try
            {
                _serverSocket.Send(buffer);
            }
            catch { }
        }
        public void Send(string Buffer)
        {
            try
            {
                _serverSocket.Send(Encoding.Unicode.GetBytes(Buffer));
            }
            catch { }
        }


        public void handleCommand(string cmd)
        {

            string[] commands = cmd.Split('#');
            int countCommands = commands.Length;
            for (int i = 0; i < countCommands; i++)
            {
                try
                {
                    string currentCommand = commands[i];
                    if (string.IsNullOrEmpty(currentCommand))
                        continue;
                    if (currentCommand.Contains("setnamesuccess"))
                    {


                        //Из-за того что программа пыталась получить доступ к контролам из другого потока вылетал эксепщен и поля не разблокировались

                        Invoke((MethodInvoker)delegate
                        {
                            AddMessage($"Добро пожаловать, {login}");
                        });
                        continue;
                    }
                    if (currentCommand.Contains("setnamefailed"))
                    {
                        AddMessage("Неверный ник!");
                        continue;
                    }
                    if (currentCommand.Contains("msg"))
                    {
                        string[] Arguments = currentCommand.Split('|');
                        AddMessage(Arguments[1], Arguments[2]);
                        continue;
                    }

                    if (currentCommand.Contains("userlist"))
                    {
                        string[] Users = currentCommand.Split('|')[1].Split(',');
                        int countUsers = Users.Length;
                        userList.Invoke((MethodInvoker)delegate { userList.Items.Clear(); });
                        for (int j = 0; j < countUsers; j++)
                        {
                            userList.Invoke((MethodInvoker)delegate { userList.Items.Add(Users[j]); });
                        }
                        continue;

                    }
                    if (currentCommand.Contains("gfile"))
                    {
                        string[] Arguments = currentCommand.Split('|');
                        string fileName = Arguments[1];
                        string FromName = Arguments[2];
                        string FileSize = Arguments[3];
                        string idFile = Arguments[4];
                        DialogResult Result = MessageBox.Show($"Вы хотите принять файл {fileName} размером {FileSize} от {FromName} ?", "Файл", MessageBoxButtons.YesNo);
                        if (Result == DialogResult.Yes)
                        {
                            Thread.Sleep(1000);
                            Send("#yy|" + idFile);
                            byte[] fileBuffer = new byte[int.Parse(FileSize)];
                            _serverSocket.Receive(fileBuffer);
                            File.WriteAllBytes(fileName, fileBuffer);
                            MessageBox.Show($"Файл {fileName} принят.");
                        }
                        else
                            Send("nn");
                        continue;
                    }

                }
                catch (Exception exp) { Console.WriteLine("Error with handleCommand: " + exp.Message); }

            }


        }
        public void listner()
        {
            try
            {
                while (_serverSocket.Connected)
                {
                    byte[] buffer = new byte[2048];
                    int bytesReceive = _serverSocket.Receive(buffer);
                    handleCommand(Encoding.Unicode.GetString(buffer, 0, bytesReceive));
                }
            }
            catch
            {
                MessageBox.Show("Связь с сервером прервана");
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string msgData = msgBox.Text;
            if (string.IsNullOrEmpty(msgData))
                return;
            if (msgData[0] == '"')
            {
                string temp = msgData.Split(' ')[0];
                string content = msgData.Substring(temp.Length + 1);
                temp = temp.Replace("\"", string.Empty);
                Send($"#private|{temp}|{content}");
            }
            else
                Send($"#message|{msgData}");
            msgBox.Text = string.Empty;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Profile pr = new Profile(this.label1.Text);
            pr.Show();
        }

        private void pAvatar_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    pAvatar.Image = new Bitmap(open_dialog.FileName);
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
