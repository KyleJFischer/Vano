using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vano
{
    public partial class Results : Form
    {
        string fileLocation1 = "";
        string fileLocation2 = "";


        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {

        }

        public void LoadBox(ScanResult scanResults)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            scanResults.files1.ForEach(m => listBox1.Items.Add(m));
            scanResults.files2.ForEach(m => listBox2.Items.Add(m));
            this.fileLocation1 = scanResults.fileLocation1;
            this.fileLocation2 = scanResults.fileLocation2;
            this.label1.Text = this.fileLocation1;
            this.label2.Text = this.fileLocation2;
        }

        private void copyToRight_Click(object sender, EventArgs e)
        {
            var newLocation = this.fileLocation2 + listBox1.SelectedItem;
            var firstLocation = this.fileLocation1 + listBox1.SelectedItem;

            File.Copy(firstLocation, newLocation);
            var result = ScanResult.ScanFolder(this.fileLocation1, this.fileLocation2);
            LoadBox(result);
        }

        private void copyToLeft_Click(object sender, EventArgs e)
        {
            var newLocation = this.fileLocation1 + listBox2.SelectedItem;
            var firstLocation = this.fileLocation2 + listBox2.SelectedItem;

            File.Copy(firstLocation, newLocation);
            var result = ScanResult.ScanFolder(this.fileLocation1, this.fileLocation2);
            LoadBox(result);
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(this.fileLocation1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(this.fileLocation2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = ScanResult.ScanFolder(this.fileLocation1, this.fileLocation2);
            LoadBox(result);
        }

        private void copyAsString_Click(object sender, EventArgs e)
        {
            var clipboardString = this.fileLocation1 + " Is Missing: " + Environment.NewLine;

            foreach (var item in listBox1.Items)
            {
                clipboardString += item + Environment.NewLine;
            }
            clipboardString += this.fileLocation2 + " Is Missing: " + Environment.NewLine;
            foreach (var item in listBox2.Items)
            {
                clipboardString += item + Environment.NewLine;
            }

            Clipboard.SetText(clipboardString);
        }
    }
}
