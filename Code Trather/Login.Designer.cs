namespace Code_Trather
{
    partial class Login
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
            nameTextBox = new TextBox();
            nameLabel = new Label();
            CWIDLabel = new Label();
            testIDtextBox = new TextBox();
            testIDLabel = new Label();
            startUT = new Button();
            startNoUT = new Button();
            cwidInputBox = new NumericUpDown();
            warningLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)cwidInputBox).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(294, 164);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(176, 27);
            nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(294, 141);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // CWIDLabel
            // 
            CWIDLabel.AutoSize = true;
            CWIDLabel.Location = new Point(294, 197);
            CWIDLabel.Name = "CWIDLabel";
            CWIDLabel.Size = new Size(50, 20);
            CWIDLabel.TabIndex = 3;
            CWIDLabel.Text = "CWID:";
            // 
            // testIDtextBox
            // 
            testIDtextBox.Location = new Point(294, 272);
            testIDtextBox.Name = "testIDtextBox";
            testIDtextBox.Size = new Size(176, 27);
            testIDtextBox.TabIndex = 4;
            // 
            // testIDLabel
            // 
            testIDLabel.AutoSize = true;
            testIDLabel.Location = new Point(294, 249);
            testIDLabel.Name = "testIDLabel";
            testIDLabel.Size = new Size(57, 20);
            testIDLabel.TabIndex = 5;
            testIDLabel.Text = "Test ID:";
            // 
            // startUT
            // 
            startUT.Location = new Point(201, 334);
            startUT.Name = "startUT";
            startUT.Size = new Size(95, 55);
            startUT.TabIndex = 6;
            startUT.Text = "Start with Unit Test";
            startUT.UseVisualStyleBackColor = true;
            startUT.Click += startUT_Click;
            // 
            // startNoUT
            // 
            startNoUT.Location = new Point(458, 334);
            startNoUT.Name = "startNoUT";
            startNoUT.Size = new Size(95, 55);
            startNoUT.TabIndex = 7;
            startNoUT.Text = "Start No Unit Test";
            startNoUT.UseVisualStyleBackColor = true;
            startNoUT.Click += startNoUT_Click;
            // 
            // cwidInputBox
            // 
            cwidInputBox.Location = new Point(294, 220);
            cwidInputBox.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            cwidInputBox.Name = "cwidInputBox";
            cwidInputBox.Size = new Size(176, 27);
            cwidInputBox.TabIndex = 8;
            cwidInputBox.ValueChanged += cwidInputBox_ValueChanged;
            // 
            // warningLabel
            // 
            warningLabel.AutoSize = true;
            warningLabel.ForeColor = Color.Red;
            warningLabel.Location = new Point(296, 109);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(0, 20);
            warningLabel.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(warningLabel);
            Controls.Add(cwidInputBox);
            Controls.Add(startNoUT);
            Controls.Add(startUT);
            Controls.Add(testIDLabel);
            Controls.Add(testIDtextBox);
            Controls.Add(CWIDLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)cwidInputBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label nameLabel;
        private Label CWIDLabel;
        private TextBox testIDtextBox;
        private Label testIDLabel;
        private Button startUT;
        private Button startNoUT;
        private NumericUpDown cwidInputBox;
        private Label warningLabel;
    }
}