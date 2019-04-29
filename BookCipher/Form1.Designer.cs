namespace BookCipher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.decodeBtn = new System.Windows.Forms.Button();
            this.encodeBtn = new System.Windows.Forms.Button();
            this.decodedText = new System.Windows.Forms.TextBox();
            this.encodedText = new System.Windows.Forms.TextBox();
            this.plainText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(55, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Decrypted text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(55, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Encrypted text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(55, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Plain text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(297, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "BookCipher";
            // 
            // decodeBtn
            // 
            this.decodeBtn.BackColor = System.Drawing.Color.DarkRed;
            this.decodeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decodeBtn.Location = new System.Drawing.Point(624, 315);
            this.decodeBtn.Name = "decodeBtn";
            this.decodeBtn.Size = new System.Drawing.Size(122, 62);
            this.decodeBtn.TabIndex = 13;
            this.decodeBtn.Text = "Decrypt";
            this.decodeBtn.UseVisualStyleBackColor = false;
            this.decodeBtn.Click += new System.EventHandler(this.decodeBtn_Click);
            // 
            // encodeBtn
            // 
            this.encodeBtn.BackColor = System.Drawing.Color.DarkRed;
            this.encodeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.encodeBtn.Location = new System.Drawing.Point(624, 188);
            this.encodeBtn.Name = "encodeBtn";
            this.encodeBtn.Size = new System.Drawing.Size(122, 64);
            this.encodeBtn.TabIndex = 12;
            this.encodeBtn.Text = "Encrypt";
            this.encodeBtn.UseVisualStyleBackColor = false;
            this.encodeBtn.Click += new System.EventHandler(this.encodeBtn_Click);
            // 
            // decodedText
            // 
            this.decodedText.Location = new System.Drawing.Point(58, 398);
            this.decodedText.Name = "decodedText";
            this.decodedText.Size = new System.Drawing.Size(688, 22);
            this.decodedText.TabIndex = 11;
            // 
            // encodedText
            // 
            this.encodedText.Location = new System.Drawing.Point(58, 273);
            this.encodedText.Name = "encodedText";
            this.encodedText.Size = new System.Drawing.Size(688, 22);
            this.encodedText.TabIndex = 10;
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(58, 144);
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(688, 22);
            this.plainText.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decodeBtn);
            this.Controls.Add(this.encodeBtn);
            this.Controls.Add(this.decodedText);
            this.Controls.Add(this.encodedText);
            this.Controls.Add(this.plainText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decodeBtn;
        private System.Windows.Forms.Button encodeBtn;
        private System.Windows.Forms.TextBox decodedText;
        private System.Windows.Forms.TextBox encodedText;
        private System.Windows.Forms.TextBox plainText;
    }
}

