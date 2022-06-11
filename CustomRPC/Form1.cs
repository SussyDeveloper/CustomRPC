using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomRPC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            DiscordRPC.update(FirstLineTextBox.Text, secondline.Text, false);
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            DiscordRPC.startRPC(clientid.Text);
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            DiscordRPC.stop();
        }
    }
}
