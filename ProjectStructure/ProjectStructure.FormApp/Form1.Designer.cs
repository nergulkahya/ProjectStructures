namespace ProjectStructure.FormApp
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
            btnConvertToText = new Button();
            rTxtFile = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnConvertToText
            // 
            btnConvertToText.Location = new Point(26, 12);
            btnConvertToText.Name = "btnConvertToText";
            btnConvertToText.Size = new Size(280, 39);
            btnConvertToText.TabIndex = 0;
            btnConvertToText.Text = "Convert To Text";
            btnConvertToText.UseVisualStyleBackColor = true;
            btnConvertToText.Click += btnConvertToText_Click;
            // 
            // rTxtFile
            // 
            rTxtFile.Location = new Point(26, 57);
            rTxtFile.Name = "rTxtFile";
            rTxtFile.Size = new Size(280, 216);
            rTxtFile.TabIndex = 1;
            rTxtFile.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rTxtFile);
            Controls.Add(btnConvertToText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnConvertToText;
        private RichTextBox rTxtFile;
        private OpenFileDialog openFileDialog1;
    }
}