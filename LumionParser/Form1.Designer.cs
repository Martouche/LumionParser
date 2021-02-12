
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonfrench = new System.Windows.Forms.Button();
            this.Englishbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBoxdisplay = new System.Windows.Forms.RichTextBox();
            this.labeldragdrop = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonfrench);
            this.panel1.Controls.Add(this.Englishbutton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 893);
            this.panel1.TabIndex = 0;
            // 
            // buttonfrench
            // 
            this.buttonfrench.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.buttonfrench.ForeColor = System.Drawing.Color.White;
            this.buttonfrench.Location = new System.Drawing.Point(0, 323);
            this.buttonfrench.Name = "buttonfrench";
            this.buttonfrench.Size = new System.Drawing.Size(178, 69);
            this.buttonfrench.TabIndex = 2;
            this.buttonfrench.Text = "French";
            this.buttonfrench.UseVisualStyleBackColor = false;
            // 
            // Englishbutton
            // 
            this.Englishbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.Englishbutton.ForeColor = System.Drawing.Color.White;
            this.Englishbutton.Location = new System.Drawing.Point(0, 248);
            this.Englishbutton.Name = "Englishbutton";
            this.Englishbutton.Size = new System.Drawing.Size(178, 69);
            this.Englishbutton.TabIndex = 1;
            this.Englishbutton.Text = "English";
            this.Englishbutton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 229);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBoxdisplay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(178, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1538, 497);
            this.panel3.TabIndex = 1;
            // 
            // richTextBoxdisplay
            // 
            this.richTextBoxdisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.richTextBoxdisplay.ForeColor = System.Drawing.Color.White;
            this.richTextBoxdisplay.Location = new System.Drawing.Point(30, 38);
            this.richTextBoxdisplay.Name = "richTextBoxdisplay";
            this.richTextBoxdisplay.Size = new System.Drawing.Size(1483, 436);
            this.richTextBoxdisplay.TabIndex = 0;
            this.richTextBoxdisplay.Text = "";
            // 
            // labeldragdrop
            // 
            this.labeldragdrop.AutoSize = true;
            this.labeldragdrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldragdrop.ForeColor = System.Drawing.Color.White;
            this.labeldragdrop.Location = new System.Drawing.Point(730, 73);
            this.labeldragdrop.Name = "labeldragdrop";
            this.labeldragdrop.Size = new System.Drawing.Size(450, 54);
            this.labeldragdrop.TabIndex = 3;
            this.labeldragdrop.Text = "Slide your DxDiag here !";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Location = new System.Drawing.Point(328, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1260, 250);
            this.listBox1.TabIndex = 4;
            // 
            // LumionParserDxdiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1716, 893);
            this.Controls.Add(this.labeldragdrop);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LumionParserDxdiag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LumionDxDiagParser";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Englishbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBoxdisplay;
        private System.Windows.Forms.Label labeldragdrop;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonfrench;
    }
}

