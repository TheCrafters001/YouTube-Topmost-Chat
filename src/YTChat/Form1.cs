using System;
using System.Windows.Forms;

namespace YTChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate("https://www.youtube.com/live_chat?is_popout=1&v=" + textBox1.Text);
            }
        }
    }
}
