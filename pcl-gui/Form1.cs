using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace pcl_gui
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

        private void pLYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            // Open file dialog window
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "pcd files (*.pcd)|*.pcd";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Exception handling
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            
            // Processing of input and output file names
            string in_file = openFileDialog1.FileName;
            string out_file = in_file.Replace(".pcd",".ply");
            out_file = "\"" + out_file + "\"";
            in_file = "\"" + in_file + "\"";
           
            // Executing the program pcd2ply_release.exe
            var process1 = new Process();
            process1.StartInfo.FileName = @"C:\Program Files (x86)\PCL 1.6.0\bin\pcl_pcd2ply_release.exe"; // Path to your demo application.
            process1.StartInfo.Arguments = String.Join(" ", in_file, out_file);
            process1.Start();
           
        }

        private void pLYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pCDFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file dialog window
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "pcd files (*.pcd)|*.pcd";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Exception handling
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            // Processing of input and output file names
            string in_file = openFileDialog1.FileName;
            string out_file = in_file.Replace(".pcd", ".ply");
            out_file = "\"" + out_file + "\"";
            
            // Executing the program pcd2ply_release.exe
            var process1 = new Process();
            process1.StartInfo.FileName = @"C:\Users\Windows\Desktop\Work on PCL\build\Debug\point_clipper.exe"; // Path to your demo application.
            process1.StartInfo.Arguments = String.Join(" ", in_file);
            process1.Start();
        }
    }
}
