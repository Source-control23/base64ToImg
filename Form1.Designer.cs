namespace base64ToImg
{
    partial class Form1
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
            btnConvertBase64 = new Button();
            richTextBox1 = new RichTextBox();
            lblBase64 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConvertBase64
            // 
            btnConvertBase64.Location = new Point(28, 286);
            btnConvertBase64.Name = "btnConvertBase64";
            btnConvertBase64.Size = new Size(320, 34);
            btnConvertBase64.TabIndex = 0;
            btnConvertBase64.Text = "Convert To Image";
            btnConvertBase64.UseVisualStyleBackColor = true;
            btnConvertBase64.Click += btnConvertBase64_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(28, 108);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(320, 172);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // lblBase64
            // 
            lblBase64.AutoSize = true;
            lblBase64.Location = new Point(27, 60);
            lblBase64.Name = "lblBase64";
            lblBase64.Size = new Size(169, 25);
            lblBase64.TabIndex = 2;
            lblBase64.Text = "Enter Base 64 String";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(443, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(807, 596);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 763);
            Controls.Add(pictureBox1);
            Controls.Add(lblBase64);
            Controls.Add(richTextBox1);
            Controls.Add(btnConvertBase64);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertBase64;
        private RichTextBox richTextBox1;
        private Label lblBase64;
        private PictureBox pictureBox1;
    }
}
