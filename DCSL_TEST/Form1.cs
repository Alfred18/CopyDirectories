using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DCSL_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {   
            ChooseFolder();
        }
       
        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        public void ProcessDirectory(DirectoryInfo source, DirectoryInfo target)
        {
            
            foreach (FileInfo file in source.GetFiles())
            {
                file.CopyTo(Path.Combine(target.FullName, file.Name));
            }
            foreach (DirectoryInfo dir in source.GetDirectories())
            {
                ProcessDirectory(dir,
                target.CreateSubdirectory(dir.Name));
            }
        }      

        private void button2_Click(object sender, EventArgs e)
        {
      
            string strDestination = textBox2.Text + "\\" + new DirectoryInfo(textBox1.Text).Name;
            try
            {
                if (!Directory.Exists(strDestination))
                {
                    Directory.CreateDirectory(strDestination);
                }
                DirectoryInfo directorySource = new DirectoryInfo(textBox1.Text);
                DirectoryInfo directoryDest = new DirectoryInfo(strDestination);

                ProcessDirectory(directorySource, directoryDest);
                MessageBox.Show("Successful");
            }
            catch (Exception ex){
                MessageBox.Show("Exception :" + ex.Message);
            }
          
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }
       
    }
}
