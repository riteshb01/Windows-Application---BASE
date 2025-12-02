namespace TechGadgetCollection
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mnuFileLoad = new ToolStripMenuItem();
            mnuFileSave = new ToolStripMenuItem();
            mnuFileExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            mnuAdd = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            mnuViewStatusBar = new ToolStripMenuItem();
            showStatusBarToolStripMenuItem = new ToolStripMenuItem();
            lvGadgets = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnLoad = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnExit = new Button();
            statusStripMain = new StatusStrip();
            tslCount = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tslFile = new ToolStripStatusLabel();
            pbLogo = new PictureBox();
            menuStrip2.SuspendLayout();
            statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, mnuViewStatusBar });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(3, 1, 0, 1);
            menuStrip2.Size = new Size(554, 24);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuFileLoad, mnuFileSave, mnuFileExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "&File";
            // 
            // mnuFileLoad
            // 
            mnuFileLoad.Name = "mnuFileLoad";
            mnuFileLoad.ShortcutKeys = Keys.Control | Keys.O;
            mnuFileLoad.Size = new Size(200, 22);
            mnuFileLoad.Text = "Load Collection";
            // 
            // mnuFileSave
            // 
            mnuFileSave.Name = "mnuFileSave";
            mnuFileSave.ShortcutKeys = Keys.Control | Keys.S;
            mnuFileSave.Size = new Size(200, 22);
            mnuFileSave.Text = "Save Collection";
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuFileExit.Size = new Size(200, 22);
            mnuFileExit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAdd, mnuEdit, mnuDelete });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 22);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.ShortcutKeys = Keys.Control | Keys.N;
            mnuAdd.Size = new Size(208, 22);
            mnuAdd.Text = "Add New Item";
            // 
            // mnuEdit
            // 
            mnuEdit.Name = "mnuEdit";
            mnuEdit.ShortcutKeys = Keys.Control | Keys.E;
            mnuEdit.Size = new Size(208, 22);
            mnuEdit.Text = "Edit Selected Item";
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.ShortcutKeys = Keys.Delete;
            mnuDelete.Size = new Size(208, 22);
            mnuDelete.Text = "Delete Selected Item";
            // 
            // mnuViewStatusBar
            // 
            mnuViewStatusBar.Checked = true;
            mnuViewStatusBar.CheckOnClick = true;
            mnuViewStatusBar.CheckState = CheckState.Checked;
            mnuViewStatusBar.DropDownItems.AddRange(new ToolStripItem[] { showStatusBarToolStripMenuItem });
            mnuViewStatusBar.Name = "mnuViewStatusBar";
            mnuViewStatusBar.Size = new Size(44, 22);
            mnuViewStatusBar.Text = "&View";
            mnuViewStatusBar.Click += mnuViewStatusBar_Click;
            // 
            // showStatusBarToolStripMenuItem
            // 
            showStatusBarToolStripMenuItem.Checked = true;
            showStatusBarToolStripMenuItem.CheckState = CheckState.Checked;
            showStatusBarToolStripMenuItem.Name = "showStatusBarToolStripMenuItem";
            showStatusBarToolStripMenuItem.Size = new Size(180, 22);
            showStatusBarToolStripMenuItem.Text = "Show Status Bar";
            // 
            // lvGadgets
            // 
            lvGadgets.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvGadgets.FullRowSelect = true;
            lvGadgets.Location = new Point(11, 31);
            lvGadgets.Margin = new Padding(2, 1, 2, 1);
            lvGadgets.MultiSelect = false;
            lvGadgets.Name = "lvGadgets";
            lvGadgets.Size = new Size(452, 262);
            lvGadgets.TabIndex = 3;
            lvGadgets.UseCompatibleStateImageBehavior = false;
            lvGadgets.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Model";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Manufacturer";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Purchase Date";
            columnHeader4.Width = 180;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.Control;
            btnLoad.ForeColor = SystemColors.ActiveCaptionText;
            btnLoad.Location = new Point(467, 75);
            btnLoad.Margin = new Padding(2, 1, 2, 1);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(81, 22);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(467, 119);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 22);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ButtonFace;
            btnEdit.ForeColor = SystemColors.ActiveCaptionText;
            btnEdit.Location = new Point(467, 206);
            btnEdit.Margin = new Padding(2, 1, 2, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(81, 22);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(467, 245);
            btnDelete.Margin = new Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 22);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Location = new Point(467, 163);
            btnSave.Margin = new Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(81, 22);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.ForeColor = SystemColors.InactiveCaptionText;
            btnExit.Location = new Point(467, 286);
            btnExit.Margin = new Padding(2, 1, 2, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 22);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // statusStripMain
            // 
            statusStripMain.ImageScalingSize = new Size(32, 32);
            statusStripMain.Items.AddRange(new ToolStripItem[] { tslCount, toolStripStatusLabel1, tslFile });
            statusStripMain.Location = new Point(0, 307);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Padding = new Padding(1, 0, 8, 0);
            statusStripMain.Size = new Size(554, 22);
            statusStripMain.TabIndex = 10;
            statusStripMain.Text = "statusStrip1";
            // 
            // tslCount
            // 
            tslCount.Name = "tslCount";
            tslCount.Size = new Size(73, 17);
            tslCount.Text = "Status Label:";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // tslFile
            // 
            tslFile.Name = "tslFile";
            tslFile.Size = new Size(76, 17);
            tslFile.Text = "Last Opened:";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Gadgets;
            pbLogo.InitialImage = (Image)resources.GetObject("pbLogo.InitialImage");
            pbLogo.Location = new Point(487, 31);
            pbLogo.Margin = new Padding(2, 1, 2, 1);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(40, 35);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 7;
            pbLogo.TabStop = false;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 329);
            Controls.Add(pbLogo);
            Controls.Add(statusStripMain);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(lvGadgets);
            Controls.Add(menuStrip2);
            Margin = new Padding(2, 1, 2, 1);
            MinimizeBox = false;
            Name = "frmMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tech Gadget Collection";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem mnuViewStatusBar;
        private ToolStripMenuItem mnuFileLoad;
        private ToolStripMenuItem mnuFileSave;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem mnuAdd;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDelete;
        private ToolStripMenuItem showStatusBarToolStripMenuItem;
        private ListView lvGadgets;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnExit;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel tslCount;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pbLogo;
        private ToolStripStatusLabel tslFile;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
