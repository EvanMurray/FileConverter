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
            this.convertButton = new System.Windows.Forms.Button();
            this.inputFileBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.PictureBox();
            this.formatMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.convertButton.Location = new System.Drawing.Point(12, 366);
            this.convertButton.Name = "button1";
            this.convertButton.Size = new System.Drawing.Size(290, 107);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert Image";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // inputFileBox
            // 
            this.inputFileBox.Location = new System.Drawing.Point(12, 12);
            this.inputFileBox.Name = "inputFileBox";
            this.inputFileBox.Size = new System.Drawing.Size(290, 22);
            this.inputFileBox.TabIndex = 1;
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
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(413, 7);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(429, 492);
            this.displayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayBox.TabIndex = 5;
            this.displayBox.TabStop = false;
            // 
            // formatMenu
            // 
            this.formatMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatMenu.FormattingEnabled = true;
            this.formatMenu.Items.AddRange(new object[] {
            "JPG",
            "PNG",
            "BMP"});
            this.formatMenu.Location = new System.Drawing.Point(70, 136);
            this.formatMenu.Name = "comboBox1";
            this.formatMenu.Size = new System.Drawing.Size(150, 24);
            this.formatMenu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Format";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formatMenu);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.inputFileBox);
            this.Controls.Add(this.convertButton);
            this.Name = "Form1";
            this.Text = "Image Converter";
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox inputFileBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.ComboBox formatMenu;
        private System.Windows.Forms.Label label1;
    }
}

