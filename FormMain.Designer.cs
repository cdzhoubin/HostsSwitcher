namespace Barbar.HostsSwitcher {
  partial class FormMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnUseAsHosts = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnViewEdit = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSwitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panContent = new System.Windows.Forms.Panel();
            this.lblHosts = new System.Windows.Forms.Label();
            this.lblUsing = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listHosts = new System.Windows.Forms.ListBox();
            this.panBottom = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUseAsHosts,
            this.btnCopy,
            this.btnDelete,
            this.btnViewEdit,
            this.btnOpenFolder,
            this.toolStripSeparator1,
            this.btnExit});
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // btnUseAsHosts
            // 
            resources.ApplyResources(this.btnUseAsHosts, "btnUseAsHosts");
            this.btnUseAsHosts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUseAsHosts.Name = "btnUseAsHosts";
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopy.Name = "btnCopy";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Name = "btnDelete";
            // 
            // btnViewEdit
            // 
            resources.ApplyResources(this.btnViewEdit, "btnViewEdit");
            this.btnViewEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnViewEdit.Name = "btnViewEdit";
            // 
            // btnOpenFolder
            // 
            resources.ApplyResources(this.btnOpenFolder, "btnOpenFolder");
            this.btnOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenFolder.Name = "btnOpenFolder";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.Name = "btnExit";
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.ContextMenuStrip = this.menuStrip;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripShow,
            this.menuStripExit,
            this.quickSwitchToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // menuStripShow
            // 
            resources.ApplyResources(this.menuStripShow, "menuStripShow");
            this.menuStripShow.Name = "menuStripShow";
            this.menuStripShow.Click += new System.EventHandler(this.menuStripShow_Click);
            // 
            // menuStripExit
            // 
            resources.ApplyResources(this.menuStripExit, "menuStripExit");
            this.menuStripExit.Name = "menuStripExit";
            this.menuStripExit.Click += new System.EventHandler(this.menuStripExit_Click);
            // 
            // quickSwitchToolStripMenuItem
            // 
            resources.ApplyResources(this.quickSwitchToolStripMenuItem, "quickSwitchToolStripMenuItem");
            this.quickSwitchToolStripMenuItem.Name = "quickSwitchToolStripMenuItem";
            // 
            // panContent
            // 
            resources.ApplyResources(this.panContent, "panContent");
            this.panContent.Controls.Add(this.lblHosts);
            this.panContent.Controls.Add(this.lblUsing);
            this.panContent.Controls.Add(this.panel1);
            this.panContent.Controls.Add(this.listHosts);
            this.panContent.Name = "panContent";
            // 
            // lblHosts
            // 
            resources.ApplyResources(this.lblHosts, "lblHosts");
            this.lblHosts.Name = "lblHosts";
            // 
            // lblUsing
            // 
            resources.ApplyResources(this.lblUsing, "lblUsing");
            this.lblUsing.Name = "lblUsing";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.toolStrip);
            this.panel1.Name = "panel1";
            // 
            // listHosts
            // 
            resources.ApplyResources(this.listHosts, "listHosts");
            this.listHosts.FormattingEnabled = true;
            this.listHosts.Name = "listHosts";
            this.listHosts.DoubleClick += new System.EventHandler(this.listHosts_DoubleClick);
            // 
            // panBottom
            // 
            resources.ApplyResources(this.panBottom, "panBottom");
            this.panBottom.Controls.Add(this.txtLog);
            this.panBottom.Controls.Add(this.lblLog);
            this.panBottom.Name = "panBottom";
            // 
            // txtLog
            // 
            resources.ApplyResources(this.txtLog, "txtLog");
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            // 
            // lblLog
            // 
            resources.ApplyResources(this.lblLog, "lblLog");
            this.lblLog.Name = "lblLog";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.ToolStripButton btnUseAsHosts;
    private System.Windows.Forms.ToolStripButton btnCopy;
    private System.Windows.Forms.ToolStripButton btnDelete;
    private System.Windows.Forms.ToolStripButton btnViewEdit;
    private System.Windows.Forms.ToolStripButton btnOpenFolder;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton btnExit;
    private System.Windows.Forms.NotifyIcon notifyIcon;
    private System.Windows.Forms.Panel panContent;
    private System.Windows.Forms.ListBox listHosts;
    private System.Windows.Forms.Panel panBottom;
    private System.Windows.Forms.Label lblLog;
    private System.Windows.Forms.TextBox txtLog;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ContextMenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem menuStripExit;
    private System.Windows.Forms.ToolStripMenuItem menuStripShow;
    private System.Windows.Forms.Label lblHosts;
    private System.Windows.Forms.Label lblUsing;
    private System.Windows.Forms.ToolStripMenuItem quickSwitchToolStripMenuItem;
  }
}

