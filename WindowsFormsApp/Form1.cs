using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sleep1Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.Enabled = false;

            Thread.Sleep(3000);

            button.Enabled = true;
        }

        private void Sleep2Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.Enabled = false;
            var bgworker = new BackgroundWorker();
            bgworker.DoWork += (s, ev) =>
            {
                Thread.Sleep(3000);
            };
            bgworker.RunWorkerCompleted += (s, ev) =>
            {
                button.Enabled = true;
            };
            bgworker.RunWorkerAsync();
        }

        private async void Sleep3Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.Enabled = false;
            await Task.Run(() => {
                Thread.Sleep(3000);
            });
            button.Enabled = true;
        }
    }
}
