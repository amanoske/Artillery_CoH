namespace Patton
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.file_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Maps = new System.Windows.Forms.GroupBox();
            this.listbox_Maps = new System.Windows.Forms.ListBox();
            this.groupBox_MapInfo = new System.Windows.Forms.GroupBox();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_MPOverview = new System.Windows.Forms.GroupBox();
            this.pictureBox_MapPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_MapName = new System.Windows.Forms.Label();
            this.label_Players = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Edited = new System.Windows.Forms.Label();
            this.file_menu.SuspendLayout();
            this.groupBox_Maps.SuspendLayout();
            this.groupBox_MapInfo.SuspendLayout();
            this.groupBox_MPOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MapPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // file_menu
            // 
            this.file_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.file_menu.Location = new System.Drawing.Point(0, 0);
            this.file_menu.Name = "file_menu";
            this.file_menu.Size = new System.Drawing.Size(875, 24);
            this.file_menu.TabIndex = 1;
            this.file_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveManifestToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPathToolStripMenuItem,
            this.syncToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.configureToolStripMenuItem.Text = "Tools";
            // 
            // setPathToolStripMenuItem
            // 
            this.setPathToolStripMenuItem.Name = "setPathToolStripMenuItem";
            this.setPathToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.setPathToolStripMenuItem.Text = "Set Path";
            // 
            // syncToolStripMenuItem
            // 
            this.syncToolStripMenuItem.Name = "syncToolStripMenuItem";
            this.syncToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.syncToolStripMenuItem.Text = "Sync With Dropbox";
            // 
            // saveManifestToolStripMenuItem
            // 
            this.saveManifestToolStripMenuItem.Name = "saveManifestToolStripMenuItem";
            this.saveManifestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveManifestToolStripMenuItem.Text = "Import Map";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Refresh Maps";
            // 
            // groupBox_Maps
            // 
            this.groupBox_Maps.Controls.Add(this.listbox_Maps);
            this.groupBox_Maps.Location = new System.Drawing.Point(12, 27);
            this.groupBox_Maps.Name = "groupBox_Maps";
            this.groupBox_Maps.Size = new System.Drawing.Size(512, 406);
            this.groupBox_Maps.TabIndex = 2;
            this.groupBox_Maps.TabStop = false;
            this.groupBox_Maps.Text = "Available Maps";
            // 
            // listbox_Maps
            // 
            this.listbox_Maps.FormattingEnabled = true;
            this.listbox_Maps.Location = new System.Drawing.Point(6, 19);
            this.listbox_Maps.Name = "listbox_Maps";
            this.listbox_Maps.Size = new System.Drawing.Size(484, 381);
            this.listbox_Maps.TabIndex = 0;
            // 
            // groupBox_MapInfo
            // 
            this.groupBox_MapInfo.Controls.Add(this.label_Edited);
            this.groupBox_MapInfo.Controls.Add(this.label_Description);
            this.groupBox_MapInfo.Controls.Add(this.label_Players);
            this.groupBox_MapInfo.Controls.Add(this.label_MapName);
            this.groupBox_MapInfo.Controls.Add(this.label4);
            this.groupBox_MapInfo.Controls.Add(this.label3);
            this.groupBox_MapInfo.Controls.Add(this.label2);
            this.groupBox_MapInfo.Controls.Add(this.label1);
            this.groupBox_MapInfo.Controls.Add(this.groupBox_MPOverview);
            this.groupBox_MapInfo.Location = new System.Drawing.Point(530, 27);
            this.groupBox_MapInfo.Name = "groupBox_MapInfo";
            this.groupBox_MapInfo.Size = new System.Drawing.Size(333, 406);
            this.groupBox_MapInfo.TabIndex = 3;
            this.groupBox_MapInfo.TabStop = false;
            this.groupBox_MapInfo.Text = "Map Info";
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem1.Text = "Quit";
            // 
            // groupBox_MPOverview
            // 
            this.groupBox_MPOverview.Controls.Add(this.pictureBox_MapPreview);
            this.groupBox_MPOverview.Location = new System.Drawing.Point(27, 19);
            this.groupBox_MPOverview.Name = "groupBox_MPOverview";
            this.groupBox_MPOverview.Size = new System.Drawing.Size(271, 211);
            this.groupBox_MPOverview.TabIndex = 0;
            this.groupBox_MPOverview.TabStop = false;
            this.groupBox_MPOverview.Text = "Map Overview";
            // 
            // pictureBox_MapPreview
            // 
            this.pictureBox_MapPreview.Location = new System.Drawing.Point(18, 19);
            this.pictureBox_MapPreview.Name = "pictureBox_MapPreview";
            this.pictureBox_MapPreview.Size = new System.Drawing.Size(247, 186);
            this.pictureBox_MapPreview.TabIndex = 0;
            this.pictureBox_MapPreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Edited:";
            // 
            // label_MapName
            // 
            this.label_MapName.AutoSize = true;
            this.label_MapName.Location = new System.Drawing.Point(230, 250);
            this.label_MapName.Name = "label_MapName";
            this.label_MapName.Size = new System.Drawing.Size(38, 13);
            this.label_MapName.TabIndex = 5;
            this.label_MapName.Text = "NAME";
            // 
            // label_Players
            // 
            this.label_Players.AutoSize = true;
            this.label_Players.Location = new System.Drawing.Point(230, 274);
            this.label_Players.Name = "label_Players";
            this.label_Players.Size = new System.Drawing.Size(56, 13);
            this.label_Players.TabIndex = 6;
            this.label_Players.Text = "PLAYERS";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(42, 324);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(80, 13);
            this.label_Description.TabIndex = 7;
            this.label_Description.Text = "DESCRIPTION";
            // 
            // label_Edited
            // 
            this.label_Edited.AutoSize = true;
            this.label_Edited.Location = new System.Drawing.Point(230, 378);
            this.label_Edited.Name = "label_Edited";
            this.label_Edited.Size = new System.Drawing.Size(47, 13);
            this.label_Edited.TabIndex = 8;
            this.label_Edited.Text = "EDITED";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 457);
            this.Controls.Add(this.groupBox_MapInfo);
            this.Controls.Add(this.groupBox_Maps);
            this.Controls.Add(this.file_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.file_menu;
            this.Name = "Main_Form";
            this.Text = "Artillery v.0.0.";
            this.file_menu.ResumeLayout(false);
            this.file_menu.PerformLayout();
            this.groupBox_Maps.ResumeLayout(false);
            this.groupBox_MapInfo.ResumeLayout(false);
            this.groupBox_MapInfo.PerformLayout();
            this.groupBox_MPOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MapPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip file_menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveManifestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Maps;
        private System.Windows.Forms.ListBox listbox_Maps;
        private System.Windows.Forms.GroupBox groupBox_MapInfo;
        private System.Windows.Forms.Label label_Edited;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Players;
        private System.Windows.Forms.Label label_MapName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_MPOverview;
        private System.Windows.Forms.PictureBox pictureBox_MapPreview;

    }
}

