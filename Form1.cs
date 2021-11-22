using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using VRChat_Mod_Manager.Properties;

namespace VRChat_Mod_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string LastFolder { get { return Settings.Default.lastFolder; } set { Settings.Default.lastFolder = value; Settings.Default.Save(); } }
        string vrcinstall { get { return Settings.Default.vrcinstall; } set { Settings.Default.vrcinstall = value; Settings.Default.Save(); } }


        Boolean Running { get
            {
                Process[] processes = Process.GetProcessesByName("vrmonitor");
                return processes.Length > 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            steamvrstatus.Text = Running ? "SteamVR: Running!" : "SteamVR: Not Running...";
            steamvrstatus.ForeColor = Running ? Color.Green : Color.Red;
            if (LastFolder != "")
            {
                modsfolder.Text = LastFolder;
                PopCheckBoxes(LastFolder);
            }

        }

        private void downloadmodbutt_Click(object sender, EventArgs e)
        {
            
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadprogress.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download finished!");
        }

        public static string modsfolderpath;
        void PopCheckBoxes(string Folder)
        {
            CheckBox box;
            DirectoryInfo thing = new DirectoryInfo(Folder);
            FileInfo[] junk = thing.GetFiles();
            if (junk.Length > 0)
            {
                for (int i = 0; i < junk.Length; i++)
                {
                    box = new CheckBox();
                    box.Name = junk[i].FullName;
                    box.Text = junk[i].Name;
                    box.AutoSize = true;
                    box.Location = new Point(10, i * 20);
                    box.CheckedChanged += new EventHandler(this.BoxesCheckedChanged);
                    panel1.Controls.Add(box);
                }
            }
        }

        private void browsebutt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog poop = new FolderBrowserDialog();
            panel1.Controls.Clear();
            if (poop.ShowDialog() == DialogResult.OK)
            {
                LastFolder = poop.SelectedPath;
                modsfolder.Text = LastFolder;
                PopCheckBoxes(LastFolder);
            }
        }


        private void BoxesCheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;

            switch (box.Checked)
            {
                case true:
                    File.Move($"{modsfolder.Text}/{box.Text}", $"{modsfolder.Text}/VRCMM/{box.Text}");
                    break;

                case false:
                    File.Move($"{modsfolder.Text}/VRCMM/{box.Text}", $"{modsfolder.Text}/{box.Text}");
                    break;
            }
        }


        private void loadvrc_Click(object sender, EventArgs e)
        {
            switch (vrtoggle.Checked)
            {
                case true:
                        Process[] processes = Process.GetProcessesByName("vrmonitor");
                        if (processes.Length == 0)
                        {
                        Process.Start($"{modsfolder.Text}/VRChat.exe");
                        Process.Start(@"C:\Program Files (x86)\Steam\steamapps\common\SteamVR\bin\win64\vrmonitor.exe");
                        }
                        break;

                case false:
                    vrtoggle.Enabled = false;
                    Process.Start($"{modsfolder.Text}/VRChat.exe", "--no-vr");
                    break;
            }

            switch (melonloadertoggle.Checked)
            {
                case true:
                    { // adds checks
                        Directory.CreateDirectory($"{vrcinstall}/Mods/VRCMM");
                        File.Move($"{vrcinstall}/version.dll", $"{modsfolder.Text}/Mods/VRCMM/version.dll");
                        Directory.Move($"{vrcinstall}/MelonLoader", $"{modsfolder.Text}/Mods/VRCMM/MelonLoader");
                        Directory.Move($"{vrcinstall}/Dependencies", $"{modsfolder.Text}/Mods/VRCMM/Dependencies");
                        Thread.Sleep(5000);
                        Process.Start($"{modsfolder.Text}/VRChat.exe");
                    }
                    break;
            }
        }

        private void installedmods_Click(object sender, EventArgs e)
        {
            
        }

        private void installToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($"{modsfolder.Text}/MelonLoader"))
            {
                MessageBox.Show("MelonLoader is already installed");
            } else
            {
                Directory.CreateDirectory($"{modsfolder.Text}/VRCMM/MelonZip");
                WebClient webClient = new WebClient();
                webClient.DownloadFileAsync(new Uri("https://github.com/LavaGang/MelonLoader/releases/download/v0.4.3/MelonLoader.x64.zip"), $"{modsfolder.Text}/VRCMM/MelonZip/MelonLoader.x64.zip");
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                Thread.Sleep(5000);
                ZipFile.ExtractToDirectory($"{modsfolder.Text}/VRCMM/MelonZip/MelonLoader.x64.zip", modsfolder.Text);
            }
        }

        private void uninstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mdirinfo = new DirectoryInfo($"{vrcinstall}/MelonLoader");
            var udirinfo = new DirectoryInfo($"{vrcinstall}/UserData");

            foreach (var subdir in mdirinfo.GetDirectories())
            {
                subdir.Delete(true);
            }

            foreach (var file in mdirinfo.GetFiles())
            {
                file.Delete();
            }

            foreach (var file in udirinfo.GetFiles())
            {
                file.Delete();
            }
            foreach (var subdir in udirinfo.GetDirectories())
            {
                subdir.Delete(true);
            }

            Directory.Delete($"{vrcinstall}/MelonLoader");
            File.Delete($"{vrcinstall}/Dependencies/emmVRC.dll");
            Directory.Delete($"{vrcinstall}/Dependencies");
            Directory.Delete($"{vrcinstall}/UserData");
            File.Delete($"{vrcinstall}/NOTICE.txt");
            File.Delete($"{vrcinstall}/version.dll");
            Thread.Sleep(5000);
            MessageBox.Show("MelonLoader uninstalled!");
        }

        private void vRChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start(modsfolder.Text);
        }

        private void repairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.Exists($"{vrcinstall}/MelonLoader");
            File.Exists($"{vrcinstall}/Dependencies/emmVRC.dll");
            Directory.Exists($"{vrcinstall}/Dependencies");
            Directory.Exists($"{vrcinstall}/UserData");
            File.Exists($"{vrcinstall}/NOTICE.txt");
            File.Exists($"{vrcinstall}/version.dll");
            MessageBox.Show("MelonLoader Repaired!");
        }

        private void disablemods_CheckedChanged(object sender, EventArgs e)
        {

            DirectoryInfo thing = new DirectoryInfo(modsfolder.Text);
            FileInfo[] junk = thing.GetFiles();
            DirectoryInfo VRCMM = new DirectoryInfo($"{modsfolder.Text}/VRCMM");
            FileInfo[] VRCMods = VRCMM.GetFiles();

            switch (disablemods.Checked)
            {
                case true:
                    if (junk.Length > 0)
                    {
                        for (int i = 0; i < junk.Length; i++)
                        {
                            File.Move($"{modsfolder.Text}/{junk[i].Name}", $"{modsfolder.Text}/VRCMM/{junk[i].Name}");
                        }
                    }
                    break;

                case false:
                    if (VRCMods.Length > 0)
                    {
                        for (int i = 0; i < VRCMods.Length; i++)
                        {
                            File.Move($"{modsfolder.Text}/VRCMM/{VRCMods[i].Name}", $"{modsfolder.Text}/{VRCMods[i].Name}");
                        }
                    }
                    break;
            }
        }
    }
}
