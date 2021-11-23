
namespace VRChat_Mod_Downloader
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
            this.downloadmodbutt = new System.Windows.Forms.Button();
            this.browsebutt = new System.Windows.Forms.Button();
            this.modsfolder = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.installedmods = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.steamvrstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadvrc = new System.Windows.Forms.Button();
            this.downloadprogress = new System.Windows.Forms.ProgressBar();
            this.vrtoggle = new System.Windows.Forms.CheckBox();
            this.melonloadertoggle = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vRChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.melonLoaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disablemods = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.installedmods.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // downloadmodbutt
            // 
            this.downloadmodbutt.Location = new System.Drawing.Point(16, 367);
            this.downloadmodbutt.Name = "downloadmodbutt";
            this.downloadmodbutt.Size = new System.Drawing.Size(75, 23);
            this.downloadmodbutt.TabIndex = 0;
            this.downloadmodbutt.Text = "Download";
            this.downloadmodbutt.UseVisualStyleBackColor = true;
            this.downloadmodbutt.Click += new System.EventHandler(this.downloadmodbutt_Click);
            // 
            // browsebutt
            // 
            this.browsebutt.Location = new System.Drawing.Point(12, 31);
            this.browsebutt.Name = "browsebutt";
            this.browsebutt.Size = new System.Drawing.Size(75, 23);
            this.browsebutt.TabIndex = 2;
            this.browsebutt.Text = "Browse";
            this.browsebutt.UseVisualStyleBackColor = true;
            this.browsebutt.Click += new System.EventHandler(this.browsebutt_Click);
            // 
            // modsfolder
            // 
            this.modsfolder.Location = new System.Drawing.Point(93, 32);
            this.modsfolder.Name = "modsfolder";
            this.modsfolder.Size = new System.Drawing.Size(478, 23);
            this.modsfolder.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.installedmods);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 287);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // installedmods
            // 
            this.installedmods.Controls.Add(this.panel1);
            this.installedmods.Location = new System.Drawing.Point(4, 24);
            this.installedmods.Name = "installedmods";
            this.installedmods.Padding = new System.Windows.Forms.Padding(3);
            this.installedmods.Size = new System.Drawing.Size(555, 259);
            this.installedmods.TabIndex = 1;
            this.installedmods.Text = "Installed";
            this.installedmods.UseVisualStyleBackColor = true;
            this.installedmods.Click += new System.EventHandler(this.installedmods_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 253);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steamvrstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(587, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // steamvrstatus
            // 
            this.steamvrstatus.Name = "steamvrstatus";
            this.steamvrstatus.Size = new System.Drawing.Size(128, 17);
            this.steamvrstatus.Text = "SteamVR: Not Running";
            // 
            // loadvrc
            // 
            this.loadvrc.Location = new System.Drawing.Point(97, 367);
            this.loadvrc.Name = "loadvrc";
            this.loadvrc.Size = new System.Drawing.Size(105, 23);
            this.loadvrc.TabIndex = 6;
            this.loadvrc.Text = "Launch VRChat";
            this.loadvrc.UseVisualStyleBackColor = true;
            this.loadvrc.Click += new System.EventHandler(this.loadvrc_Click);
            // 
            // downloadprogress
            // 
            this.downloadprogress.Location = new System.Drawing.Point(16, 417);
            this.downloadprogress.Name = "downloadprogress";
            this.downloadprogress.Size = new System.Drawing.Size(559, 23);
            this.downloadprogress.TabIndex = 8;
            // 
            // vrtoggle
            // 
            this.vrtoggle.AutoSize = true;
            this.vrtoggle.Location = new System.Drawing.Point(208, 371);
            this.vrtoggle.Name = "vrtoggle";
            this.vrtoggle.Size = new System.Drawing.Size(40, 19);
            this.vrtoggle.TabIndex = 9;
            this.vrtoggle.Text = "VR";
            this.vrtoggle.UseVisualStyleBackColor = true;
            // 
            // melonloadertoggle
            // 
            this.melonloadertoggle.AutoSize = true;
            this.melonloadertoggle.Location = new System.Drawing.Point(374, 370);
            this.melonloadertoggle.Name = "melonloadertoggle";
            this.melonloadertoggle.Size = new System.Drawing.Size(137, 19);
            this.melonloadertoggle.TabIndex = 10;
            this.melonloadertoggle.Text = "Disable MelonLoader";
            this.melonloadertoggle.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.vRChatToolStripMenuItem,
            this.melonLoaderToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // vRChatToolStripMenuItem
            // 
            this.vRChatToolStripMenuItem.Name = "vRChatToolStripMenuItem";
            this.vRChatToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.vRChatToolStripMenuItem.Text = "VRChat Install folder";
            this.vRChatToolStripMenuItem.Click += new System.EventHandler(this.vRChatToolStripMenuItem_Click);
            // 
            // melonLoaderToolStripMenuItem
            // 
            this.melonLoaderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installToolStripMenuItem,
            this.uninstallToolStripMenuItem,
            this.repairToolStripMenuItem});
            this.melonLoaderToolStripMenuItem.Name = "melonLoaderToolStripMenuItem";
            this.melonLoaderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.melonLoaderToolStripMenuItem.Text = "MelonLoader";
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.installToolStripMenuItem.Text = "Install";
            this.installToolStripMenuItem.Click += new System.EventHandler(this.installToolStripMenuItem_Click);
            // 
            // uninstallToolStripMenuItem
            // 
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.uninstallToolStripMenuItem.Text = "Uninstall";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.uninstallToolStripMenuItem_Click);
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.repairToolStripMenuItem.Text = "Repair";
            this.repairToolStripMenuItem.Click += new System.EventHandler(this.repairToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem,
            this.fAQToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.supportToolStripMenuItem.Text = "Support";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            // 
            // disablemods
            // 
            this.disablemods.AutoSize = true;
            this.disablemods.Location = new System.Drawing.Point(254, 370);
            this.disablemods.Name = "disablemods";
            this.disablemods.Size = new System.Drawing.Size(114, 19);
            this.disablemods.TabIndex = 12;
            this.disablemods.Text = "Disable All Mods";
            this.disablemods.UseVisualStyleBackColor = true;
            this.disablemods.CheckedChanged += new System.EventHandler(this.disablemods_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 471);
            this.Controls.Add(this.disablemods);
            this.Controls.Add(this.melonloadertoggle);
            this.Controls.Add(this.vrtoggle);
            this.Controls.Add(this.downloadprogress);
            this.Controls.Add(this.loadvrc);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.modsfolder);
            this.Controls.Add(this.browsebutt);
            this.Controls.Add(this.downloadmodbutt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VRChat Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.installedmods.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadmodbutt;
        private System.Windows.Forms.Button browsebutt;
        private System.Windows.Forms.TextBox modsfolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage installedmods;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel steamvrstatus;
        private System.Windows.Forms.Button loadvrc;
        private System.Windows.Forms.ProgressBar downloadprogress;
        private System.Windows.Forms.CheckBox vrtoggle;
        private System.Windows.Forms.CheckBox melonloadertoggle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vRChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem melonLoaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox disablemods;
    }
}

