using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TESTPICTURE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string fileloc;
        int i;

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.microfoldergrpbx.Hide();
            this.gamegrpbx.Hide();
            this.startgrpbx.Hide();
            this.restartgrpbx.Hide();
            groupBox2.Hide();
            pictureBox14.Hide();
            folder1namelbl.Hide();
            label16.Hide();
            filenametxtbx.Hide();
            button4.Hide();
            label17.Hide();
            foldernametxtbx.Hide();
            button5.Hide();
            button6.Hide();
            fileloc = @"\Desktop\test";
            label22.Text = i.ToString();
            pictureBox15.Hide();
            pictureBox16.Hide();
            foldername2lbl.Hide();
            folder3namelbl.Hide();
            pictureBox11.Hide();
            groupBox1.Hide();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
    
            this.startgrpbx.Show();
        }


        private void pictureBox12_Click(object sender, EventArgs e)
        {   
            this.restartgrpbx.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            microfoldergrpbx.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            gamegrpbx.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            microfoldergrpbx.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gamegrpbx.Hide();
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            restartgrpbx.Show();
            pictureBox12.Hide();
            pictureBox11.Show();
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            restartgrpbx.Hide();
            pictureBox12.Show();
            pictureBox11.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            startgrpbx.Hide();
            restartgrpbx.Hide();
            label16.Hide();
            filenametxtbx.Hide();
            button4.Hide();
            label17.Hide();
            foldernametxtbx.Hide();
            button5.Hide();
            label19.ForeColor = Color.White;
            label14.ForeColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start(@"mspaint.exe");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office\Microsoft Office Word 2007");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office\Microsoft Office Excel 2007");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office\Microsoft Office PowerPoint 2007");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft Games\Chess\Chess.exe");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft Games\Mahjong\Mahjong.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = false;
            psi.Arguments = string.Format(@" -r -t 10");
            psi.UseShellExecute = false;

            Process process = Process.Start(psi);
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
            button6.Show();
            MessageBox.Show("Computer will Shutdowm in 10 sec.Press Abort Button to Cancel Shutdown", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button6.Show();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown";
            psi.RedirectStandardInput = false;
            psi.RedirectStandardOutput = true;
            psi.Arguments = string.Format(@"-s -t 10");
            psi.UseShellExecute = false;

            Process process = Process.Start(psi);
            string output;
            output = process.StandardOutput.ReadToEnd();
            MessageBox.Show("Computer will Shutdowm in 10 sec.Pree Abort To Cancel ShutDown", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start(@"chrome");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start(@"calc.exe");
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Blue;
            groupBox2.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(fileloc + "\\" + filenametxtbx.Text))
                {
                    File.Create(fileloc + "\\" + filenametxtbx.Text);
                    MessageBox.Show("File Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("File Exist Already.", "Error Creating File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error Creating file.", "Cannot Access Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            filenametxtbx.Hide();
            filenametxtbx.Clear();
            label19.ForeColor = Color.White;
            label16.Hide();
            button4.Hide();
        }


        

        private void button5_Click(object sender, EventArgs e)
        {
           
            try
            {              
                if (i == 1)
                {
                    if (!Directory.Exists(fileloc + "\\" + foldernametxtbx.Text))
                    {
                        folder1namelbl.Text = foldernametxtbx.Text;
                        Directory.CreateDirectory(fileloc + "\\" + folder1namelbl.Text);
                        MessageBox.Show("Folder Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        folder1namelbl.Show();
                        pictureBox14.Show();

                    }
                    else
                    {
                        MessageBox.Show("Folder Exist Already", "Error creating Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    
                }
                else if (i == 2 && foldername2lbl.Text == "")
                {                  
                        foldername2lbl.Text = foldernametxtbx.Text;
                        Directory.CreateDirectory(fileloc + "\\" + foldername2lbl.Text);
                        MessageBox.Show("Folder Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foldername2lbl.Show();
                        pictureBox15.Show();                   
                   
                }

                else if (i == 3 && folder3namelbl.Text == "")
                {
                    
                        folder3namelbl.Text = foldernametxtbx.Text;
                        Directory.CreateDirectory(fileloc + "\\" + folder3namelbl.Text);
                        MessageBox.Show("Folder Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        folder3namelbl.Show();
                        pictureBox16.Show();                 
                }
                else
                {
                    MessageBox.Show("Error creating File.", "Cannot Access Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                label17.Hide();
                button5.Hide();
                foldernametxtbx.Hide();

            }
            catch (Exception)
            {

                MessageBox.Show("Error reating Folder.","Cannot Access Location",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(fileloc + "\\" + folder1namelbl.Text); 
            }
            catch (Win32Exception)
            {
                MessageBox.Show("This Folder Has Been Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
                 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(fileloc + "\\" + textBox1.Text);
                MessageBox.Show("Delete Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {

                MessageBox.Show("Error", "UnauthorizedAccessException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {

                MessageBox.Show("Error", "UnauthorizedAccessException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(fileloc + "\\" + textBox2.Text);
                MessageBox.Show("Delete Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {

                MessageBox.Show("Error UnauthorizedAccessException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {

                MessageBox.Show("Error UnauthorizedAccessException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {

                MessageBox.Show("Error UnauthorizedAccessException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
             
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox2.Hide();
            label14.ForeColor = Color.White;
        }

        private void label19_Click(object sender, EventArgs e)
        {
                label16.Show();
                filenametxtbx.Show();
                button4.Show();
                label19.ForeColor = Color.Blue;
      
        }



        private void Form2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            i++;
            label22.Text = i.ToString();
            if (i == 1 || i == 2 || i == 3)
            {
                label17.Show();
                foldernametxtbx.Show();
                button5.Show();
                
            }
            else
            {
                foldernametxtbx.Show();
                button5.Show();
            }

            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.Hide();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = false;
            psi.Arguments = string.Format(@"/a");
            psi.UseShellExecute = false;

            Process process = Process.Start(psi);
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
            
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            try 
	        {	        
		
            Process.Start(fileloc + "\\" + foldername2lbl.Text);  
            }
            catch (Win32Exception)
            {
                MessageBox.Show("This Folder Has Been Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            try 
	        {	                
            Process.Start(fileloc + "\\" + folder3namelbl.Text);  
            }
            catch (Win32Exception)
            {
                MessageBox.Show("This Folder Has Been Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start(fileloc);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:mm:");
            lblsecond.Text = DateTime.Now.ToString("ss");
            lbldate.Text = DateTime.Now.ToString("MMM-dd-yyyy");
            lblday.Text = DateTime.Now.ToString("dddd");
            
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.ChessMCE3;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.ChessMCE;
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.Mahjong2;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.Mahjong;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.received_959434687538839_2_;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.received_959434687538839;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.received_959435040872137_2_;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.received_959435040872137;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.received_959435060872135_2_;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.received_959435060872135;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.received_959434380872203_2_;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.received_959434380872203;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.received_959434250872216_2_;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.received_959434250872216;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.received_959434740872167_2_;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.received_959434740872167;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.received_959434780872163_2_;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.received_959434780872163;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.received_959434300872211_2_;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.received_959434300872211;
        }

        private void dollarpictureBox_MouseEnter(object sender, EventArgs e)
        {
            dollarpictureBox.Image = Properties.Resources.received_959424720873169_2_;
        }

        private void dollarpictureBox_MouseLeave(object sender, EventArgs e)
        {
            dollarpictureBox.Image = Properties.Resources.received_959424720873169;
        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblday_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void lblsecond_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Process.Start(fileloc);
        }

        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox14.Image = Properties.Resources.received_1481848428602909_2_;
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Image = Properties.Resources.received_1481848428602909;
        }

        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.Image = Properties.Resources.received_1481848428602909_2_;
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Image = Properties.Resources.received_1481848428602909;
        }
        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox16.Image = Properties.Resources.received_1481848428602909_2_;
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Image = Properties.Resources.received_1481848428602909;
        }

        private void pictureBox17_MouseEnter(object sender, EventArgs e)
        {
            pictureBox17.Image = Properties.Resources.received_1481848428602909_2_;
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Image = Properties.Resources.received_1481848428602909;
        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.Image = Properties.Resources.haha12_2_;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Image = Properties.Resources.haha12;
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.haha12_2_;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.haha12;
        }

        private void pictureBox12_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.haha11_2_;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.haha11;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.newexit_2_;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.newexit;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackgroundImage = Properties.Resources.received_972525769563064_2_;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackgroundImage = Properties.Resources.received_972525769563064;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.newlogout_2_;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.newlogout;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.newrestart_2_;           
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.newrestart;   
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.received_972525766229731_2_;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.received_972525766229731;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Hide();
            label38.ForeColor = Color.White;
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            label38.ForeColor = Color.Blue;
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }




      
    }
}
