namespace Code_Trather
{
    partial class Trather
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trather));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textInput = new ScintillaNET.Scintilla();
            this.stopBTN = new System.Windows.Forms.Button();
            this.enterInput = new System.Windows.Forms.Button();
            this.userInput = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.File = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.submitTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.Test = new System.Windows.Forms.ToolStripDropDownButton();
            this.runTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.unitTestTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.magnifyTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom100TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lang = new System.Windows.Forms.ToolStripDropDownButton();
            this.switchToPy = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToJava = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(11, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.stopBTN);
            this.splitContainer1.Panel2.Controls.Add(this.enterInput);
            this.splitContainer1.Panel2.Controls.Add(this.userInput);
            this.splitContainer1.Panel2.Controls.Add(this.textOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1335, 611);
            this.splitContainer1.SplitterDistance = 908;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // textInput
            // 
            this.textInput.AutoCMaxHeight = 9;
            this.textInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textInput.IndentationGuides = ScintillaNET.IndentView.LookBoth;
            this.textInput.Location = new System.Drawing.Point(0, 0);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(908, 611);
            this.textInput.TabIndents = true;
            this.textInput.TabIndex = 4;
            // 
            // stopBTN
            // 
            this.stopBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBTN.Location = new System.Drawing.Point(286, 519);
            this.stopBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(86, 31);
            this.stopBTN.TabIndex = 3;
            this.stopBTN.Text = "Stop";
            this.stopBTN.UseVisualStyleBackColor = true;
            this.stopBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // enterInput
            // 
            this.enterInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enterInput.Enabled = false;
            this.enterInput.Location = new System.Drawing.Point(285, 557);
            this.enterInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enterInput.Name = "enterInput";
            this.enterInput.Size = new System.Drawing.Size(86, 29);
            this.enterInput.TabIndex = 2;
            this.enterInput.Text = "Enter";
            this.enterInput.UseVisualStyleBackColor = true;
            this.enterInput.Click += new System.EventHandler(this.enterInput_Click);
            // 
            // userInput
            // 
            this.userInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInput.Location = new System.Drawing.Point(18, 541);
            this.userInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userInput.Name = "userInput";
            this.userInput.ReadOnly = true;
            this.userInput.Size = new System.Drawing.Size(236, 27);
            this.userInput.TabIndex = 1;
            // 
            // textOutput
            // 
            this.textOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textOutput.Location = new System.Drawing.Point(0, 0);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(401, 511);
            this.textOutput.TabIndex = 0;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 3000;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Test,
            this.toolsDropDown,
            this.lang});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1359, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // File
            // 
            this.File.AccessibleName = "File";
            this.File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTSM,
            this.submitTSM});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 24);
            this.File.Text = "File";
            // 
            // saveTSM
            // 
            this.saveTSM.Name = "saveTSM";
            this.saveTSM.Size = new System.Drawing.Size(224, 26);
            this.saveTSM.Text = "Save";
            this.saveTSM.Click += new System.EventHandler(this.saveTSM_Click);
            // 
            // submitTSM
            // 
            this.submitTSM.Name = "submitTSM";
            this.submitTSM.Size = new System.Drawing.Size(224, 26);
            this.submitTSM.Text = "Submit";
            this.submitTSM.Click += new System.EventHandler(this.submitTSM_Click);
            // 
            // Test
            // 
            this.Test.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Test.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runTSM,
            this.unitTestTSM});
            this.Test.Image = ((System.Drawing.Image)(resources.GetObject("Test.Image")));
            this.Test.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(49, 24);
            this.Test.Text = "Test";
            // 
            // runTSM
            // 
            this.runTSM.Name = "runTSM";
            this.runTSM.Size = new System.Drawing.Size(149, 26);
            this.runTSM.Text = "Run";
            this.runTSM.Click += new System.EventHandler(this.runTSM_Click);
            // 
            // unitTestTSM
            // 
            this.unitTestTSM.Name = "unitTestTSM";
            this.unitTestTSM.Size = new System.Drawing.Size(149, 26);
            this.unitTestTSM.Text = "Unit Test";
            this.unitTestTSM.Click += new System.EventHandler(this.unitTestTSM_Click);
            // 
            // toolsDropDown
            // 
            this.toolsDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magnifyTSM,
            this.themesToolStripMenuItem});
            this.toolsDropDown.Image = ((System.Drawing.Image)(resources.GetObject("toolsDropDown.Image")));
            this.toolsDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsDropDown.Name = "toolsDropDown";
            this.toolsDropDown.Size = new System.Drawing.Size(58, 24);
            this.toolsDropDown.Text = "Tools";
            // 
            // magnifyTSM
            // 
            this.magnifyTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInTSM,
            this.zoomOutTSM,
            this.zoom100TSM});
            this.magnifyTSM.Name = "magnifyTSM";
            this.magnifyTSM.Size = new System.Drawing.Size(146, 26);
            this.magnifyTSM.Text = "Magnify";
            // 
            // zoomInTSM
            // 
            this.zoomInTSM.Name = "zoomInTSM";
            this.zoomInTSM.Size = new System.Drawing.Size(172, 26);
            this.zoomInTSM.Text = "Zoom In";
            this.zoomInTSM.Click += new System.EventHandler(this.zoomInTSM_Click);
            // 
            // zoomOutTSM
            // 
            this.zoomOutTSM.Name = "zoomOutTSM";
            this.zoomOutTSM.Size = new System.Drawing.Size(172, 26);
            this.zoomOutTSM.Text = "Zoom Out";
            this.zoomOutTSM.Click += new System.EventHandler(this.zoomOutTSM_Click);
            // 
            // zoom100TSM
            // 
            this.zoom100TSM.Name = "zoom100TSM";
            this.zoom100TSM.Size = new System.Drawing.Size(172, 26);
            this.zoom100TSM.Text = "Zoom 100%";
            this.zoom100TSM.Click += new System.EventHandler(this.zoom100TSM_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.DarkMode_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.LightMode_Click);
            // 
            // lang
            // 
            this.lang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchToPy,
            this.switchToJava});
            this.lang.Image = ((System.Drawing.Image)(resources.GetObject("lang.Image")));
            this.lang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lang.Name = "lang";
            this.lang.Size = new System.Drawing.Size(88, 24);
            this.lang.Text = "Language";
            // 
            // switchToPy
            // 
            this.switchToPy.Checked = true;
            this.switchToPy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.switchToPy.Name = "switchToPy";
            this.switchToPy.Size = new System.Drawing.Size(137, 26);
            this.switchToPy.Text = "Python";
            this.switchToPy.Click += new System.EventHandler(this.switchToPy_Click);
            // 
            // switchToJava
            // 
            this.switchToJava.Name = "switchToJava";
            this.switchToJava.Size = new System.Drawing.Size(137, 26);
            this.switchToJava.Text = "Java";
            this.switchToJava.Click += new System.EventHandler(this.switchToJava_Click);
            // 
            // Trather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 691);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "Trather";
            this.Text = "Trather";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trather_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Trather_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SplitContainer splitContainer1;
        private TextBox textOutput;
        private System.Windows.Forms.Timer UpdateTimer;
        private ScintillaNET.Scintilla textInput;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton File;
        private ToolStripMenuItem saveTSM;
        private ToolStripMenuItem submitTSM;
        private ToolStripDropDownButton Test;
        private ToolStripMenuItem runTSM;
        private ToolStripMenuItem unitTestTSM;
        private ToolStripDropDownButton toolsDropDown;
        private ToolStripMenuItem magnifyTSM;
        private ToolStripMenuItem zoomInTSM;
        private ToolStripMenuItem zoomOutTSM;
        private ToolStripMenuItem zoom100TSM;
        private Button enterInput;
        private TextBox userInput;
        private Button stopBTN;
        private ToolStripDropDownButton lang;
        private ToolStripMenuItem switchToPy;
        private ToolStripMenuItem switchToJava;
        private ToolStripMenuItem themesToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
    }
}