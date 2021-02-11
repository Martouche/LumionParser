using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumionParser
{
    public partial class LumionParserDxdiag : Form
    {
        public LumionParserDxdiag()
        {
            InitializeComponent();
            buttonfrench.Click += buttonfrench_Click;
            Englishbutton.Click += buttonenglish_Click;
            listBox1.AllowDrop = true;
            listBox1.DragEnter += new DragEventHandler(Form1_DragEnter);
            listBox1.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            richTextBoxdisplay.Clear();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) {
                MessageBox.Show(file, "form test", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            string readText = File.ReadAllText(files[files.Length - 1]);
            List<string> result = readText.Split('\n').ToList();
            getgoodlines(result);
        }

        void getgoodlines(List<string> fulldatas)
        {
            var gooddatas = new List<string>();
            StringComparison comp = StringComparison.OrdinalIgnoreCase;
            foreach (string data in fulldatas) {
                if (data.Contains("Operating System", comp) == true)
                    richTextBoxdisplay.AppendText(data);
                else if (data.Contains("Card name", comp) == true)
                    richTextBoxdisplay.AppendText(data);
                else if (data.Contains("  Memory", comp) == true)
                    richTextBoxdisplay.AppendText(data);
                else if (data.Contains("Driver Date/size", comp) == true)
                    richTextBoxdisplay.AppendText(data);
                else if (data.Contains("Page File", comp) == true)
                    richTextBoxdisplay.AppendText(data);
                else if (data.Contains("Free Space", comp) == true)
                    richTextBoxdisplay.AppendText(data);
            }
        }

        private void buttonfrench_Click(object sender, EventArgs e)
        {
            labeldragdrop.Text = "Glissez votre DxDiag ici !";
            Englishbutton.Text = "Anglais";
            buttonfrench.Text = "Français";
        }

        private void buttonenglish_Click(object sender, EventArgs e)
        {
            labeldragdrop.Text = "Slide your DxDiag here !";
            buttonfrench.Text = "French";
            Englishbutton.Text = "English";
        }
    }
}
