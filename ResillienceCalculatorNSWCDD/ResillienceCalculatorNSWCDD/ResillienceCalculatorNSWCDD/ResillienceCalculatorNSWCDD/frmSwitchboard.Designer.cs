namespace ResillienceCalculatorNSWCDD
{
    partial class frmSwitchboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSwitchboard));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pbPhysical = new PictureBox();
            pbHardware = new PictureBox();
            pbSoftware = new PictureBox();
            btnResilliencePage = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPhysical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHardware).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSoftware).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 28);
            label1.Name = "label1";
            label1.Size = new Size(328, 28);
            label1.TabIndex = 0;
            label1.Text = "USA CRAM Resillience Tool Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 85);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 1;
            label2.Text = "Physical Resillience";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 85);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 2;
            label3.Text = "Hardware Resillience";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(618, 85);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 3;
            label4.Text = "Software Resillience";
            // 
            // pbPhysical
            // 
            pbPhysical.Image = (Image)resources.GetObject("pbPhysical.Image");
            pbPhysical.Location = new Point(49, 125);
            pbPhysical.Name = "pbPhysical";
            pbPhysical.Size = new Size(128, 128);
            pbPhysical.TabIndex = 4;
            pbPhysical.TabStop = false;
            pbPhysical.Click += pbPhysical_Click_1;
            // 
            // pbHardware
            // 
            pbHardware.Image = (Image)resources.GetObject("pbHardware.Image");
            pbHardware.Location = new Point(335, 125);
            pbHardware.Name = "pbHardware";
            pbHardware.Size = new Size(128, 128);
            pbHardware.TabIndex = 5;
            pbHardware.TabStop = false;
            pbHardware.Click += pbHardware_Click_1;
            // 
            // pbSoftware
            // 
            pbSoftware.Image = (Image)resources.GetObject("pbSoftware.Image");
            pbSoftware.Location = new Point(625, 125);
            pbSoftware.Name = "pbSoftware";
            pbSoftware.Size = new Size(128, 128);
            pbSoftware.TabIndex = 6;
            pbSoftware.TabStop = false;
            pbSoftware.Click += pbSoftware_Click;
            // 
            // btnResilliencePage
            // 
            btnResilliencePage.Location = new Point(490, 297);
            btnResilliencePage.Name = "btnResilliencePage";
            btnResilliencePage.Size = new Size(157, 29);
            btnResilliencePage.TabIndex = 10;
            btnResilliencePage.Text = "Final Scoring";
            btnResilliencePage.UseVisualStyleBackColor = true;
            btnResilliencePage.Click += btnResilliencePage_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(813, 28);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(224, 26);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(666, 297);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmSwitchboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 357);
            Controls.Add(btnExit);
            Controls.Add(btnResilliencePage);
            Controls.Add(pbSoftware);
            Controls.Add(pbHardware);
            Controls.Add(pbPhysical);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmSwitchboard";
            Text = "University of South Alabama CRAM Team Resillience Tool";
//            Load += frmSwitchboard_Load;
            ((System.ComponentModel.ISupportInitialize)pbPhysical).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHardware).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSoftware).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pbPhysical;
        private PictureBox pbHardware;
        private PictureBox pbSoftware;
        private Button btnResilliencePage;
        private MenuStrip menuStrip1;
        private Button btnExit;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}