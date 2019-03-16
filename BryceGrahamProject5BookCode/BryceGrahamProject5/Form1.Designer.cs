namespace BryceGrahamProject5
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
            this.addBookButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bookTextBox = new System.Windows.Forms.TextBox();
            this.decodeButton = new System.Windows.Forms.Button();
            this.encodeButton = new System.Windows.Forms.Button();
            this.secretMessageTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(191, 27);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(93, 23);
            this.addBookButton.TabIndex = 0;
            this.addBookButton.Text = "Add book file";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 159);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(607, 118);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // bookTextBox
            // 
            this.bookTextBox.Location = new System.Drawing.Point(85, 29);
            this.bookTextBox.Name = "bookTextBox";
            this.bookTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookTextBox.TabIndex = 2;
            this.bookTextBox.Text = "wotw.txt";
            // 
            // decodeButton
            // 
            this.decodeButton.Enabled = false;
            this.decodeButton.Location = new System.Drawing.Point(191, 85);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(75, 23);
            this.decodeButton.TabIndex = 3;
            this.decodeButton.Text = "Decode file";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // encodeButton
            // 
            this.encodeButton.Enabled = false;
            this.encodeButton.Location = new System.Drawing.Point(191, 56);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(75, 23);
            this.encodeButton.TabIndex = 4;
            this.encodeButton.Text = "Encode file";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // secretMessageTextBox
            // 
            this.secretMessageTextBox.Location = new System.Drawing.Point(85, 88);
            this.secretMessageTextBox.Name = "secretMessageTextBox";
            this.secretMessageTextBox.Size = new System.Drawing.Size(100, 20);
            this.secretMessageTextBox.TabIndex = 5;
            this.secretMessageTextBox.Text = "secret.txt";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(85, 58);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(100, 20);
            this.messageTextBox.TabIndex = 6;
            this.messageTextBox.Text = "clear.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 289);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.secretMessageTextBox);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.bookTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.addBookButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox bookTextBox;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.TextBox secretMessageTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}

