﻿using System;
using System.Text.RegularExpressions;
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
            ///            foreach (string file in files) {
            ///                MessageBox.Show(file, "form test", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ///            }
            if (Path.GetExtension(files[files.Length - 1]) != ".txt" && frenchisclicked == false)
                MessageBox.Show("Wrong extension file \nOnly accept .txt file", "Error : Wrong extension", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else if (Path.GetExtension(files[files.Length - 1]) != ".txt" && frenchisclicked == true)
                MessageBox.Show("Mauvaise extension de fichier\nseulement fichier .txt accepté", "Erreur : Mauvaise extension", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            {
                parserhandler(File.ReadAllText(files[files.Length - 1]));
            }
        }

        void parserhandler(string text)
        {
            string readText = text;
            List<string> first = readText.Split('\n').ToList();
            List<string> second = getgoodlines(first);
            List<string> third = cleanlines(second);
            foreach (string lines in third)
                richTextBoxdisplay.AppendText(lines);

        }

        List<string> cleanlines(List<string> fulldatas)
        {
            var good = new List<string>();
            foreach (string data in fulldatas)
            {
                good.Add(data.Trim() + '\n');
            }
            return good;
        }

        List<string> getgoodlines(List<string> fulldatas)
        {
            var gooddatas = new List<string>();
            StringComparison comp = StringComparison.OrdinalIgnoreCase;
            foreach (string data in fulldatas) {
                if (data.Contains("Operating System", comp) == true)
                    gooddatas.Add(data);
                else if (data.Contains("Card name", comp) == true)
                    gooddatas.Add(data);
                else if (data.Contains("  Memory", comp) == true)
                    gooddatas.Add(data);
                else if (data.Contains("Driver Date/size", comp) == true)
                    gooddatas.Add(data);
                else if (data.Contains("Page File", comp) == true)
                    gooddatas.Add(data);
                else if (data.Contains("Free Space", comp) == true)
                    gooddatas.Add(data);
            }
            return gooddatas;
        }

        private void buttonfrench_Click(object sender, EventArgs e)
        {
            labeldragdrop.Text = "Glissez votre DxDiag ici !";
            Englishbutton.Text = "Anglais";
            buttonfrench.Text = "Français";
            frenchisclicked = true;
        }

        private void buttonenglish_Click(object sender, EventArgs e)
        {
            labeldragdrop.Text = "Slide your DxDiag here !";
            buttonfrench.Text = "French";
            Englishbutton.Text = "English";
            frenchisclicked = false;
        }
    }
}
