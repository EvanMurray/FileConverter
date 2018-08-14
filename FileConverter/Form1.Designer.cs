namespace FileConverter
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputFileBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(12, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 107);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputFileBox
            // 
            this.inputFileBox.Location = new System.Drawing.Point(12, 12);
            this.inputFileBox.Name = "inputFileBox";
            this.inputFileBox.Size = new System.Drawing.Size(290, 22);
            this.inputFileBox.TabIndex = 1;
            this.inputFileBox.TextChanged += new System.EventHandler(this.inputFileBox_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(308, 7);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(102, 33);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 58);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(290, 22);
            this.outputTextBox.TabIndex = 3;
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(308, 53);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(102, 32);
            this.outputButton.TabIndex = 4;
            this.outputButton.Text = "Output";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(413, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.inputFileBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Image Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputFileBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

