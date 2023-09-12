namespace WinFormsApp1
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
            buttonPTTPush = new Button();
            buttonPTTRelease = new Button();
            buttonRead = new Button();
            textBoxRead = new TextBox();
            buttonInitialize = new Button();
            SuspendLayout();
            // 
            // buttonPTTPush
            // 
            buttonPTTPush.Enabled = false;
            buttonPTTPush.Location = new Point(92, 41);
            buttonPTTPush.Name = "buttonPTTPush";
            buttonPTTPush.Size = new Size(75, 23);
            buttonPTTPush.TabIndex = 0;
            buttonPTTPush.Text = "Push";
            buttonPTTPush.UseVisualStyleBackColor = true;
            buttonPTTPush.Click += buttonPTTPush_Click;
            // 
            // buttonPTTRelease
            // 
            buttonPTTRelease.Enabled = false;
            buttonPTTRelease.Location = new Point(92, 70);
            buttonPTTRelease.Name = "buttonPTTRelease";
            buttonPTTRelease.Size = new Size(75, 23);
            buttonPTTRelease.TabIndex = 1;
            buttonPTTRelease.Text = "Release";
            buttonPTTRelease.UseVisualStyleBackColor = true;
            buttonPTTRelease.Click += buttonPTTRelease_Click;
            // 
            // buttonRead
            // 
            buttonRead.Enabled = false;
            buttonRead.Location = new Point(92, 99);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(75, 23);
            buttonRead.TabIndex = 2;
            buttonRead.Text = "Read";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // textBoxRead
            // 
            textBoxRead.Location = new Point(31, 128);
            textBoxRead.Name = "textBoxRead";
            textBoxRead.Size = new Size(197, 23);
            textBoxRead.TabIndex = 3;
            // 
            // buttonInitialize
            // 
            buttonInitialize.Location = new Point(92, 12);
            buttonInitialize.Name = "buttonInitialize";
            buttonInitialize.Size = new Size(75, 23);
            buttonInitialize.TabIndex = 5;
            buttonInitialize.Text = "Initialize";
            buttonInitialize.UseVisualStyleBackColor = true;
            buttonInitialize.Click += buttonInitialize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 158);
            Controls.Add(buttonInitialize);
            Controls.Add(textBoxRead);
            Controls.Add(buttonRead);
            Controls.Add(buttonPTTRelease);
            Controls.Add(buttonPTTPush);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPTTPush;
        private Button buttonPTTRelease;
        private Button buttonRead;
        private TextBox textBoxRead;
        private Button buttonEnumarate;
        private Button buttonInitialize;
    }
}