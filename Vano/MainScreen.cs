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
using static System.Net.WebRequestMethods;

namespace Vano
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void firstBrowseButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                firstFileBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SecondBrowseButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                secondFileBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var scanResult = ScanResult.ScanFolder(firstFileBox.Text, secondFileBox.Text);
            var scanResultForm = new Results();
            scanResultForm.LoadBox(scanResult);
            scanResultForm.Show();
        }
    }
}
