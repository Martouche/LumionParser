
namespace LumionParser
{
    partial class LumionParserDxdiag
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LumionParserDxdiag));
            this.buttonfrench = new System.Windows.Forms.Button();
            this.Englishbutton = new System.Windows.Forms.Button();
            this.labeldragdrop = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBoxdisplay = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelresults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonfrench
            // 
            this.buttonfrench.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonfrench.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.buttonfrench.ForeColor = System.Drawing.Color.White;
            this.buttonfrench.Location = new System.Drawing.Point(30, 499);
            this.buttonfrench.Name = "buttonfrench";
            this.buttonfrench.Size = new System.Drawing.Size(183, 65);
            this.buttonfrench.TabIndex = 2;
            this.buttonfrench.Text = "French";
            this.buttonfrench.UseVisualStyleBackColor = false;
            this.buttonfrench.Click += new System.EventHandler(this.buttonfrench_Click_1);
            // 
            // Englishbutton
            // 
            this.Englishbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Englishbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.Englishbutton.ForeColor = System.Drawing.Color.White;
            this.Englishbutton.Location = new System.Drawing.Point(29, 419);
            this.Englishbutton.Name = "Englishbutton";
            this.Englishbutton.Size = new System.Drawing.Size(184, 63);
            this.Englishbutton.TabIndex = 1;
            this.Englishbutton.Text = "English";
            this.Englishbutton.UseVisualStyleBackColor = false;
            this.Englishbutton.Click += new System.EventHandler(this.Englishbutton_Click);
            // 
            // labeldragdrop
            // 
            this.labeldragdrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeldragdrop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldragdrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labeldragdrop.Location = new System.Drawing.Point(539, 70);
            this.labeldragdrop.Name = "labeldragdrop";
            this.labeldragdrop.Size = new System.Drawing.Size(697, 89);
            this.labeldragdrop.TabIndex = 3;
            this.labeldragdrop.Text = "Slide your DxDiag here !";
            this.labeldragdrop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labeldragdrop.Click += new System.EventHandler(this.labeldragdrop_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Location = new System.Drawing.Point(249, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1268, 250);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBoxdisplay
            // 
            this.richTextBoxdisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxdisplay.BackColor = System.Drawing.Color.White;
            this.richTextBoxdisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.richTextBoxdisplay.Location = new System.Drawing.Point(249, 419);
            this.richTextBoxdisplay.Name = "richTextBoxdisplay";
            this.richTextBoxdisplay.Size = new System.Drawing.Size(1268, 664);
            this.richTextBoxdisplay.TabIndex = 0;
            this.richTextBoxdisplay.Text = "";
            this.richTextBoxdisplay.TextChanged += new System.EventHandler(this.richTextBoxdisplay_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LumionParser.Properties.Resources.lumion_3d_logo;
            this.pictureBox1.Location = new System.Drawing.Point(28, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelresults
            // 
            this.labelresults.AutoSize = true;
            this.labelresults.Location = new System.Drawing.Point(260, 363);
            this.labelresults.Name = "labelresults";
            this.labelresults.Size = new System.Drawing.Size(253, 41);
            this.labelresults.TabIndex = 6;
            this.labelresults.Text = "Results obtained :";
            this.labelresults.Click += new System.EventHandler(this.label1_Click);
            // 
            // LumionParserDxdiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1568, 1112);
            this.Controls.Add(this.labelresults);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Englishbutton);
            this.Controls.Add(this.buttonfrench);
            this.Controls.Add(this.richTextBoxdisplay);
            this.Controls.Add(this.labeldragdrop);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LumionParserDxdiag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LumionDxDiagParser";
            this.Load += new System.EventHandler(this.LumionParserDxdiag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Englishbutton;
        private System.Windows.Forms.Label labeldragdrop;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonfrench;
        private System.Windows.Forms.RichTextBox richTextBoxdisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelresults;
    }
}

