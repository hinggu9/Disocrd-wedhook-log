using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Discordhook
{
    public partial class Form1 : Form
    {
        private string UserName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserName = Environment.UserName;
            sendwebhook("https://discord.com/api/webhooks/880074343512698882/BrvK2F2yj4x2pLIgBm71D-QIX0slkWcdOzBFG4ECjYJvc1rEJ0aUE4gCNvA8nRFGm3Ym", "``ran the program.``", UserName);
        }

        public static void sendwebhook(string url, string msg, string username)
        {
            Http.Post(url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    username
                },
                {
                    "content",
                    msg
                }
            });
        }
    }
}
