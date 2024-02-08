namespace WinFormsApp
{
    partial class Form1
    {

        /// <summary>
        ///  Designer code for the form and controls
        ///  Required designer variables.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button SelectFileButton; // Add button control


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
            ResultTextBox = new TextBox();
            SelectFileButton = new Button();
            SuspendLayout();
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(50, 50);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(200, 23);
            ResultTextBox.TabIndex = 0;
            // 
            // SelectFileButton
            // 
            SelectFileButton.Location = new Point(50, 100);
            SelectFileButton.Name = "SelectFileButton";
            SelectFileButton.Size = new Size(200, 30);
            SelectFileButton.TabIndex = 1;
            SelectFileButton.Text = "Select CSV File";
            SelectFileButton.Click += SelectFileButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 258);
            Controls.Add(ResultTextBox);
            Controls.Add(SelectFileButton);
            Name = "CSV Sum Calculator";
            Text = "CSV Sum Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
