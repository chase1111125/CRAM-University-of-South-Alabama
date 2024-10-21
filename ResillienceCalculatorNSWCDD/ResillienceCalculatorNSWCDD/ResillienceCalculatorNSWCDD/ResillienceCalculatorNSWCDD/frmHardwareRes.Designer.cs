namespace ResillienceCalculatorNSWCDD
{
    partial class frmHardwareRes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHardwareRes));
            cboNode = new ComboBox();
            btnReset = new Button();
            btnExit = new Button();
            lstOutput = new ListBox();
            btnResillience = new Button();
            lbCboNode = new Label();
            lsTitle = new Label();
            label1 = new Label();
            cboAssociatedCVEs = new ComboBox();
            lstSelectedCVE = new ListBox();
            label2 = new Label();
            label3 = new Label();
            lstSelectedCVEs = new ListBox();
            label4 = new Label();
            warnRHEL_OutdatedSW = new ErrorProvider(components);
            warnCISCO_DiscontinuedSW = new ErrorProvider(components);
            warnWindowsServer_DiscontinuedSW = new ErrorProvider(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            tsmSet = new ToolStripMenuItem();
            tsmSetReset = new ToolStripMenuItem();
            tsmSetExit = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)warnRHEL_OutdatedSW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)warnCISCO_DiscontinuedSW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)warnWindowsServer_DiscontinuedSW).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cboNode
            // 
            cboNode.FormattingEnabled = true;
            cboNode.Location = new Point(99, 107);
            cboNode.Name = "cboNode";
            cboNode.Size = new Size(300, 28);
            cboNode.TabIndex = 0;
            cboNode.SelectedIndexChanged += cboNode_SelectedIndexChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1300, 635);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 31);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1392, 635);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(144, 31);
            btnExit.TabIndex = 3;
            btnExit.Text = "Close";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(434, 85);
            lstOutput.Margin = new Padding(3, 4, 3, 4);
            lstOutput.MultiColumn = true;
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(501, 224);
            lstOutput.TabIndex = 4;
            // 
            // btnResillience
            // 
            btnResillience.Location = new Point(99, 144);
            btnResillience.Margin = new Padding(3, 4, 3, 4);
            btnResillience.Name = "btnResillience";
            btnResillience.Size = new Size(209, 31);
            btnResillience.TabIndex = 5;
            btnResillience.Text = "Calculate Resillience";
            btnResillience.UseVisualStyleBackColor = true;
            btnResillience.Click += btnResillience_Click;
            // 
            // lbCboNode
            // 
            lbCboNode.AutoSize = true;
            lbCboNode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCboNode.Location = new Point(21, 103);
            lbCboNode.Name = "lbCboNode";
            lbCboNode.Size = new Size(73, 28);
            lbCboNode.TabIndex = 6;
            lbCboNode.Text = "Nodes:";
            // 
            // lsTitle
            // 
            lsTitle.AutoSize = true;
            lsTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lsTitle.Location = new Point(21, 49);
            lsTitle.Name = "lsTitle";
            lsTitle.Size = new Size(334, 31);
            lsTitle.TabIndex = 7;
            lsTitle.Text = "Hardware Resiliency Calculator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(994, 88);
            label1.Name = "label1";
            label1.Size = new Size(248, 28);
            label1.TabIndex = 9;
            label1.Text = "Individual Associated CVEs:";
            // 
            // cboAssociatedCVEs
            // 
            cboAssociatedCVEs.FormattingEnabled = true;
            cboAssociatedCVEs.Location = new Point(1247, 88);
            cboAssociatedCVEs.Name = "cboAssociatedCVEs";
            cboAssociatedCVEs.Size = new Size(301, 28);
            cboAssociatedCVEs.TabIndex = 8;
            cboAssociatedCVEs.SelectedIndexChanged += cboAssociatedCVEs_SelectedIndexChanged;
            // 
            // lstSelectedCVE
            // 
            lstSelectedCVE.DrawMode = DrawMode.OwnerDrawFixed;
            lstSelectedCVE.FormattingEnabled = true;
            lstSelectedCVE.Location = new Point(997, 124);
            lstSelectedCVE.Name = "lstSelectedCVE";
            lstSelectedCVE.Size = new Size(551, 364);
            lstSelectedCVE.TabIndex = 10;
            lstSelectedCVE.SelectedIndexChanged += lstSelectedCVE_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(434, 53);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 11;
            label2.Text = "Nodes Info:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(997, 53);
            label3.Name = "label3";
            label3.Size = new Size(214, 28);
            label3.TabIndex = 12;
            label3.Text = "CVE Risk and Inspector:";
            // 
            // lstSelectedCVEs
            // 
            lstSelectedCVEs.FormattingEnabled = true;
            lstSelectedCVEs.Location = new Point(434, 345);
            lstSelectedCVEs.MultiColumn = true;
            lstSelectedCVEs.Name = "lstSelectedCVEs";
            lstSelectedCVEs.Size = new Size(501, 304);
            lstSelectedCVEs.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(434, 314);
            label4.Name = "label4";
            label4.Size = new Size(319, 28);
            label4.TabIndex = 14;
            label4.Text = "All Associated CVEs and Likelihood:";
            // 
            // warnRHEL_OutdatedSW
            // 
            warnRHEL_OutdatedSW.ContainerControl = this;
            warnRHEL_OutdatedSW.Icon = (Icon)resources.GetObject("warnRHEL_OutdatedSW.Icon");
            // 
            // warnCISCO_DiscontinuedSW
            // 
            warnCISCO_DiscontinuedSW.ContainerControl = this;
            warnCISCO_DiscontinuedSW.Icon = (Icon)resources.GetObject("warnCISCO_DiscontinuedSW.Icon");
            // 
            // warnWindowsServer_DiscontinuedSW
            // 
            warnWindowsServer_DiscontinuedSW.ContainerControl = this;
            warnWindowsServer_DiscontinuedSW.Icon = (Icon)resources.GetObject("warnWindowsServer_DiscontinuedSW.Icon");
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(116, 28);
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(115, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmSet });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1560, 30);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmSet
            // 
            tsmSet.DropDownItems.AddRange(new ToolStripItem[] { tsmSetReset, tsmSetExit });
            tsmSet.Name = "tsmSet";
            tsmSet.Size = new Size(76, 24);
            tsmSet.Text = "Settings";
            // 
            // tsmSetReset
            // 
            tsmSetReset.Name = "tsmSetReset";
            tsmSetReset.Size = new Size(128, 26);
            tsmSetReset.Text = "Reset";
            tsmSetReset.Click += tsmSetReset_Click;
            // 
            // tsmSetExit
            // 
            tsmSetExit.Name = "tsmSetExit";
            tsmSetExit.Size = new Size(128, 26);
            tsmSetExit.Text = "Exit";
            tsmSetExit.Click += tsmSetExit_Click;
            // 
            // frmHardwareRes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1560, 679);
            Controls.Add(menuStrip1);
            Controls.Add(label4);
            Controls.Add(lstSelectedCVEs);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstSelectedCVE);
            Controls.Add(label1);
            Controls.Add(cboAssociatedCVEs);
            Controls.Add(lsTitle);
            Controls.Add(lbCboNode);
            Controls.Add(btnResillience);
            Controls.Add(lstOutput);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(cboNode);
            MainMenuStrip = menuStrip1;
            Name = "frmHardwareRes";
            Text = "Hardware Resillience";
            Load += ResillienceCalc_Load;
            ((System.ComponentModel.ISupportInitialize)warnRHEL_OutdatedSW).EndInit();
            ((System.ComponentModel.ISupportInitialize)warnCISCO_DiscontinuedSW).EndInit();
            ((System.ComponentModel.ISupportInitialize)warnWindowsServer_DiscontinuedSW).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboNode;
        private Button btnReset;
        private Button btnExit;
        private ListBox lstOutput;
        private Button btnResillience;
        private Label lbCboNode;
        private Label lsTitle;
        private Label label1;
        private ComboBox cboAssociatedCVEs;

        private ListBox lstSelectedCVE;

        private Label label2;
        private Label label3;
        private ListBox lstSelectedCVEs;
        private Label label4;
        private ErrorProvider warnRHEL_OutdatedSW;
        private ErrorProvider warnCISCO_DiscontinuedSW;
        private ErrorProvider warnWindowsServer_DiscontinuedSW;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmSet;
        private ToolStripMenuItem tsmSetReset;
        private ToolStripMenuItem tsmSetExit;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
    }
}
