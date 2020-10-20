using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class bubble : UserControl
    {
        public bubble()
        {
            InitializeComponent();
        }

        public bubble(string message, string time, msgType messageType)
        {
            InitializeComponent();
            label2.Text = time;
            label1.Text = message;

            if (messageType.ToString() == "In")
            {
                // Входящее сообщение
                this.BackColor = Color.FromArgb(234, 62, 0);
            }
            else
            {
                // Выходящее сообщение
                this.BackColor = Color.Gray;
            }

            SetHeight();

        }


        void SetHeight()
        {
            Size maxSize = new Size(495, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(label1.Text, label1.Font, label1.Width);

            label1.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
            label1.Top = label1.Bottom;
            this.Height = label2.Bottom + 10;
        }

        private void bubble_AutoSizeChanged(object sender, EventArgs e)
        {
            SetHeight();
        }

        public enum msgType
        {
            In,
            Out
        }

    }
}
