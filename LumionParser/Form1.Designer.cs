
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonfrench
            // 
            this.buttonfrench.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonfrench.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.buttonfrench.ForeColor = System.Drawing.Color.White;
            this.buttonfrench.Location = new System.Drawing.Point(12, 342);
            this.buttonfrench.Name = "buttonfrench";
            this.buttonfrench.Size = new System.Drawing.Size(117, 51);
            this.buttonfrench.TabIndex = 2;
            this.buttonfrench.Text = "French";
            this.buttonfrench.UseVisualStyleBackColor = false;
            // 
            // Englishbutton
            // 
            this.Englishbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Englishbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.Englishbutton.ForeColor = System.Drawing.Color.White;
            this.Englishbutton.Location = new System.Drawing.Point(12, 269);
            this.Englishbutton.Name = "Englishbutton";
            this.Englishbutton.Size = new System.Drawing.Size(122, 51);
            this.Englishbutton.TabIndex = 1;
            this.Englishbutton.Text = "English";
            this.Englishbutton.UseVisualStyleBackColor = false;
            // 
            // labeldragdrop
            // 
            this.labeldragdrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldragdrop.ForeColor = System.Drawing.Color.White;
            this.labeldragdrop.Location = new System.Drawing.Point(668, 66);
            this.labeldragdrop.Name = "labeldragdrop";
            this.labeldragdrop.Size = new System.Drawing.Size(450, 54);
            this.labeldragdrop.TabIndex = 3;
            this.labeldragdrop.Text = "Slide your DxDiag here !";
            this.labeldragdrop.Click += new System.EventHandler(this.labeldragdrop_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Location = new System.Drawing.Point(349, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1114, 291);
            this.listBox1.TabIndex = 4;
            // 
            // richTextBoxdisplay
            // 
            this.richTextBoxdisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxdisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.richTextBoxdisplay.ForeColor = System.Drawing.Color.White;
            this.richTextBoxdisplay.Location = new System.Drawing.Point(201, 439);
            this.richTextBoxdisplay.Name = "richTextBoxdisplay";
            this.richTextBoxdisplay.Size = new System.Drawing.Size(1340, 644);
            this.richTextBoxdisplay.TabIndex = 0;
            this.richTextBoxdisplay.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 231);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LumionParserDxdiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1568, 1112);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Englishbutton;
        private System.Windows.Forms.Label labeldragdrop;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonfrench;
        private System.Windows.Forms.RichTextBox richTextBoxdisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

