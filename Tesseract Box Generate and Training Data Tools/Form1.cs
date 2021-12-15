using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Tesseract_Box_Generate_and_Training_Data_Tools
{
    public partial class Form1 : Form
    {
        public static string ProgramName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        public static string BrowseFilePath;
        public static string BrowseFilePath_;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TessEXE_Textbox.Text = @"C:\Program Files (x86)\Tesseract-OCR";


            toolTip1.AutoPopDelay = 20000;
            toolTip1.SetToolTip(Psm_Combox, "0.Orientation and script detection (OSD) only.\n" +
                "1.Automatic page segmentation with OSD.\n" +
                "2.Automatic page segmentation, but no OSD, or OCR.\n" +
                "3.Fully automatic page segmentation, but no OSD. (Default)\n" +
                "4.Assume a single column of text of variable sizes.\n" +
                "5.Assume a single uniform block of vertically aligned text.\n" +
                "6.Assume a single uniform block of text.\n" +
                "7.Treat the image as a single text line.\n" +
                "8.Treat the image as a single word.\n" +
                "9.Treat the image as a single word in a circle.\n" +
                "10.Treat the image as a single character.\n" +
                "11.Sparse text.Find as much text as possible in no particular order.\n" +
                "12.Sparse text with OSD.\n" +
                "13.Raw line.Treat the image as a single text line, bypassing hacks that are Tesseract - specific.");

            toolTip1.SetToolTip(Train_psm_Combox, "0.Orientation and script detection (OSD) only.\n" +
                "1.Automatic page segmentation with OSD.\n" +
                "2.Automatic page segmentation, but no OSD, or OCR.\n" +
                "3.Fully automatic page segmentation, but no OSD. (Default)\n" +
                "4.Assume a single column of text of variable sizes.\n" +
                "5.Assume a single uniform block of vertically aligned text.\n" +
                "6.Assume a single uniform block of text.\n" +
                "7.Treat the image as a single text line.\n" +
                "8.Treat the image as a single word.\n" +
                "9.Treat the image as a single word in a circle.\n" +
                "10.Treat the image as a single character.\n" +
                "11.Sparse text.Find as much text as possible in no particular order.\n" +
                "12.Sparse text with OSD.\n" +
                "13.Raw line.Treat the image as a single text line, bypassing hacks that are Tesseract - specific.");
            Psm_Combox.Text = "7";
            Train_psm_Combox.Text = "7";
        }

        private void Browsetif_but_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "tif files (*.tif)|*.tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Box_TifPath_Textbox.Text = ofd.FileName;
            }
        }

        private void GenBox_But_Click(object sender, EventArgs e)
        {
            if (Box_TifPath_Textbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid .tif path!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (OutputPath_Textbox.Text == string.Empty)
            {
                MessageBox.Show("Please select Output Directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (fontname_Textbox.Text == string.Empty)
            {
                MessageBox.Show("Please insert Font name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                File.Copy(Box_TifPath_Textbox.Text, OutputPath_Textbox.Text + @"\" + fontname_Textbox.Text + ".tif", true);
                sb.AppendLine(@"cd /d " + TessEXE_Textbox.Text + "\n");
                sb.AppendLine("echo Make Box File\n");
                sb.AppendLine("tesseract " + '"' + Box_TifPath_Textbox.Text + '"' + " " + '"' + OutputPath_Textbox.Text + @"\" + fontname_Textbox.Text + '"' + " --psm " + Psm_Combox.Text + " makebox");


                File.WriteAllText(OutputPath_Textbox.Text + @"\Makebox.bat", sb.ToString());

                try
                {
                    string batDir = OutputPath_Textbox.Text;
                    Process process = Process.Start(new ProcessStartInfo(batDir + @"\Makebox.bat")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                    });
                    string output = process.StandardOutput.ReadToEnd();
                    Log_Textbox.Text += output;
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //File.Delete(OutputPath_Textbox.Text + @"\Makebox.bat");
                Log_Textbox.SelectionStart = Log_Textbox.Text.Length;
                Log_Textbox.ScrollToCaret(); // Auto Scroll to end of textbox
                MessageBox.Show("Generate Box Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void BrowseOutput_but_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OutputPath_Textbox.Text = ofd.SelectedPath;

            }
        }

        private void Train_Browsetif_but_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "box files (*.box)|*.box";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Train_TifPath_Textbox.Text = ofd.FileName;
                Train_Fontname_Textbox.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                BrowseFilePath = '"' + Path.GetDirectoryName(ofd.FileName) + '"';
                BrowseFilePath_ = Path.GetDirectoryName(ofd.FileName);
            }
        }

        private void Train_But_Click(object sender, EventArgs e)
        {
            if (Train_TifPath_Textbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid .tif path!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string FontName = Train_Fontname_Textbox.Text;
                string TessPath = '"' + TessEXE_Textbox.Text;

                StringBuilder sb = new StringBuilder();

                sb.AppendLine(@"cd /d " + BrowseFilePath);
                sb.AppendLine(TessPath + @"\tesseract" + '"' + " " + FontName + ".tif " + FontName + " --psm " + Train_psm_Combox.Text + " box.train\n");
                sb.AppendLine("echo Compute the Character Set..");

                sb.AppendLine(TessPath + @"\unicharset_extractor.exe" + '"' + " " + FontName + ".box");
                sb.AppendLine(TessPath + @"\set_unicharset_properties" + '"' + " " + "-U unicharset -O unicharset --script_dir=%~dp0");
                sb.AppendLine(TessPath + @"\shapeclustering" + '"' + " " + "-F " + TessPath + @"\font_properties" + '"' + " " + "-U unicharset -O " + FontName + ".unicharset " + FontName + ".tr");
                sb.AppendLine(TessPath + @"\mftraining" + '"' + " " + "-F " + TessPath + @"\font_properties" + '"' + " " + "-U unicharset -O " + FontName + ".unicharset " + FontName + ".tr\n");

                sb.AppendLine("echo Clustering.. ");
                sb.AppendLine(TessPath + @"\cntraining.exe" + '"' + " " + FontName + ".tr\n");

                sb.AppendLine("echo Delete Existing Files..");
                sb.AppendLine("del " + FontName + ".normproto");
                sb.AppendLine("del " + FontName + ".inttemp");
                sb.AppendLine("del " + FontName + ".pffmtable");
                sb.AppendLine("del " + FontName + ".shapetable\n");

                sb.AppendLine("echo Rename Files..");
                sb.AppendLine("rename normproto " + FontName + ".normproto");
                sb.AppendLine("rename inttemp " + FontName + ".inttemp");
                sb.AppendLine("rename pffmtable " + FontName + ".pffmtable");
                sb.AppendLine("rename shapetable " + FontName + ".shapetable\n");

                sb.AppendLine("echo Create Tessdata..");
                sb.AppendLine(TessPath + @"\combine_tessdata.exe" + '"' + " " + FontName + ".");

                File.WriteAllText(OutputPath_Textbox.Text + @"\Train.bat", sb.ToString());
                try
                {
                    string batDir = BrowseFilePath_;
                    Process process = Process.Start(new ProcessStartInfo(batDir + @"\Train.bat")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });
                    string output = process.StandardOutput.ReadToEnd();
                    Log_Textbox.Text += output;
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //File.Delete(batDir + @"\Train.bat");
                Log_Textbox.SelectionStart = Log_Textbox.Text.Length;
                Log_Textbox.ScrollToCaret(); // Auto Scroll to end of textbox
                MessageBox.Show("Training Data Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Log_Textbox.Text = e.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TessEXE_Textbox.Text = ofd.SelectedPath;
            }
        }
    }
}
