using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace LumionParser
{
    public partial class LumionParserDxdiag : Form
    {
        public bool frenchisclicked = false;
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
            if (Path.GetExtension(files[files.Length - 1]) != ".txt" && frenchisclicked == false)
                MessageBox.Show("Wrong extension file\nOnly accept .txt file", "Error : Wrong extension", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else if (Path.GetExtension(files[files.Length - 1]) != ".txt" && frenchisclicked == true)
                MessageBox.Show("Mauvaise extension de fichier\nseulement fichier .txt accepté", "Erreur : Mauvaise extension", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
                parserhandler(File.ReadAllText(files[files.Length - 1]));
        }

        void parserhandler(string text)
        {
            List<string> first = text.Split('\n').ToList();
            List<string> second = getgoodlines(first);
            List<string> englishtext = cleanlines(second);
            List<string> frenchtext = frenchconversion(englishtext);
            if (frenchisclicked == true)
            {
                foreach (string lines in frenchtext)
                    richTextBoxdisplay.AppendText(lines);
            }
            else
            {
                foreach (string lines in englishtext)
                    richTextBoxdisplay.AppendText(lines);
            }
        }

        List<string> cleanlines(List<string> fulldatas)
        {
            var good = new List<string>();
            foreach (string data in fulldatas)
                good.Add("  " + data.Trim() + '\n');
            return good;
        }

        List<string> frenchconversion(List<string> datas)
        {
            var end = new List<string>();
            StringComparison comp = StringComparison.OrdinalIgnoreCase;

            foreach (string line in datas)
            {
                if (line.Contains("𝐎𝐩𝐞𝐫𝐚𝐭𝐢𝐧𝐠 𝐒𝐲𝐬𝐭𝐞𝐦", comp) == true)
                    end.Add(line.Replace("𝐎𝐩𝐞𝐫𝐚𝐭𝐢𝐧𝐠 𝐒𝐲𝐬𝐭𝐞𝐦", "𝐎𝐩𝐞𝐫𝐚𝐭𝐞𝐮𝐫 𝐬𝐲𝐬𝐭𝐞𝐦𝐞"));
                else if (line.Contains("𝐏𝐫𝐨𝐜𝐞𝐬𝐬𝐨𝐫", comp) == true)
                    end.Add(line.Replace("𝐏𝐫𝐨𝐜𝐞𝐬𝐬𝐨𝐫", "𝐏𝐫𝐨𝐜𝐞𝐬𝐬𝐞𝐮𝐫"));
                else if (line.Contains("𝐂𝐚𝐫𝐝 𝐧𝐚𝐦𝐞", comp) == true)
                    end.Add(line.Replace("𝐂𝐚𝐫𝐝 𝐧𝐚𝐦𝐞", "𝐂𝐚𝐫𝐭𝐞 𝐆𝐫𝐚𝐩𝐡𝐢𝐪𝐮𝐞"));
                else if (line.Contains("𝐌𝐞𝐦𝐨𝐫𝐲", comp) == true)
                    end.Add(line.Replace("𝐌𝐞𝐦𝐨𝐫𝐲", "𝐌𝐞𝐦𝐨𝐢𝐫𝐞 𝐑𝐀𝐌"));
                else if (line.Contains("𝐃𝐫𝐢𝐯𝐞𝐫 𝐃𝐚𝐭𝐞/𝐒𝐢𝐳𝐞", comp) == true)
                    end.Add(line.Replace("𝐃𝐫𝐢𝐯𝐞𝐫 𝐃𝐚𝐭𝐞/𝐒𝐢𝐳𝐞", "𝐃𝐫𝐢𝐯𝐞𝐫 𝐃𝐚𝐭𝐞/𝐭𝐚𝐢𝐥𝐥𝐞"));
                else if (line.Contains("𝐏𝐚𝐠𝐞 𝐅𝐢𝐥𝐞", comp) == true)
                    end.Add(line.Replace("𝐏𝐚𝐠𝐞 𝐅𝐢𝐥𝐞", "𝐌𝐞𝐦𝐨𝐢𝐫𝐞 𝐯𝐢𝐫𝐭𝐮𝐞𝐥𝐥𝐞"));
                else if (line.Contains("𝐅𝐫𝐞𝐞 𝐒𝐩𝐚𝐜𝐞", comp) == true)
                    end.Add(line.Replace("𝐅𝐫𝐞𝐞 𝐒𝐩𝐚𝐜𝐞", "𝐄𝐬𝐩𝐚𝐜𝐞 𝐥𝐢𝐛𝐫𝐞"));
            }
            return end;
        }

        private void buttonfrench_Click(object sender, EventArgs e)
        {
            labeldragdrop.Text = "Glissez votre DxDiag ici !";
            Englishbutton.Text = "Anglais";
            buttonfrench.Text = "Français";
            labelresults.Text = "Résultats obtenus :";
            frenchisclicked = true;
        }

        private void buttonenglish_Click(object sender, EventArgs e)
        {
            labeldragdrop.Text = "Slide your DxDiag here !";
            buttonfrench.Text = "French";
            Englishbutton.Text = "English";
            labelresults.Text = "Results obtained :";
            frenchisclicked = false;
        }

        List<string> getgoodlines(List<string> fulldatas)
        {
            var gooddatas = new List<string>();
            StringComparison comp = StringComparison.OrdinalIgnoreCase;
            foreach (string data in fulldatas)
            {
                if (data.Contains("Operating System", comp) == true)
                    gooddatas.Add(data.Replace("Operating System", "𝐎𝐩𝐞𝐫𝐚𝐭𝐢𝐧𝐠 𝐒𝐲𝐬𝐭𝐞𝐦"));
                else if (data.Contains("  Processor", comp) == true)
                    gooddatas.Add(data.Replace("  Processor", "𝐏𝐫𝐨𝐜𝐞𝐬𝐬𝐨𝐫"));
                else if (data.Contains("Card name", comp) == true)
                    gooddatas.Add(data.Replace("Card name", "𝐂𝐚𝐫𝐝 𝐧𝐚𝐦𝐞"));
                else if (data.Contains("  Memory", comp) == true)
                    gooddatas.Add(data.Replace("  Memory", "𝐌𝐞𝐦𝐨𝐫𝐲"));
                else if (data.Contains("Driver Date/Size", comp) == true)
                    gooddatas.Add(data.Replace("Driver Date/Size", "𝐃𝐫𝐢𝐯𝐞𝐫 𝐃𝐚𝐭𝐞/𝐒𝐢𝐳𝐞"));
                else if (data.Contains("Page File", comp) == true)
                    gooddatas.Add(data.Replace("Page File", "𝐏𝐚𝐠𝐞 𝐅𝐢𝐥𝐞"));
                else if (data.Contains("Free Space", comp) == true)
                    gooddatas.Add(data.Replace("Free Space", "𝐅𝐫𝐞𝐞 𝐒𝐩𝐚𝐜𝐞"));
            }
            return gooddatas;
        }

        private void labeldragdrop_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxdisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonfrench_Click_1(object sender, EventArgs e)
        {

        }

        private void Englishbutton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LumionParserDxdiag_Load(object sender, EventArgs e)
        {

        }
    }
}
