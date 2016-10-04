using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace KSP_Part_Finder
{
    public partial class Form1 : Form
    {
        private List <string> FoundList;
        private int i;
        private string [] allConfigs;
        private bool searching;

        public Form1 ()
        {
            InitializeComponent();
        }

        private void ChooseFolder_Click (object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog () == DialogResult.OK)
            {
                DataPath.Text = folderBrowserDialog1.SelectedPath;
                WriteSettings();
            }
        }

        private void SearchButton_Click (object sender, EventArgs e)
        {
            WriteSettings ();
            if (string.IsNullOrEmpty(DataPath.Text) || string.IsNullOrWhiteSpace (DataPath.Text))
                return;
            i = 0;
            ProgressBar.Value = 0;
            ProgressBar.Visible = true;
            allConfigs = Directory.GetFiles(DataPath.Text, "*.cfg", SearchOption.AllDirectories);
            ProgressBar.Maximum = allConfigs.Length;
            ProgressBar.Refresh ();
            Thread thread = new Thread (new ThreadStart(FindInFiles));
            thread.Start ();
        }

        private void FindInFiles ()
        {
            if (FoundList == null)
                FoundList = new List<string>();
            FoundList.Clear();
            foreach (var config in allConfigs)
            {
                i++;

                if (!File.Exists(config))
                    continue;
                var cfg = config.ToLower();
                if (IgnoreTweakScale.CheckState == CheckState.Checked && cfg.Contains(@"\tweakscale\"))
                    continue;
                if (IgnoreFilterExtensions.CheckState == CheckState.Checked && cfg.Contains(@"filterextensions"))
                    continue;
                if (IgnoreMechJeb.CheckState == CheckState.Checked && cfg.Contains(@"mechjeb"))
                    continue;
                var configContent = File.ReadAllText(config).ToLower();

                if (configContent.Contains(TextForSearch.Text.ToLower()))
                {
                    FoundList.Add(config);
                }
            }
            i = 0;
            if (FoundList.Count == 0)
            {
                MessageBox.Show("The text was not found in any of the config files", "Error");
                return;
            }
            if (FoundList.Count > 4)
            {
                MessageBox.Show("There are more than four files with the text you searched for. Opening them will cause problems, please narrow down your search.", "Warning");
                return;
            }
            foreach (var config in FoundList)
            {
                if (!File.Exists(config))
                    continue;
                string arguments = "/select, \"" + config + "\"";
                System.Diagnostics.Process.Start("explorer.exe", arguments);
            }
            searching = false;
        }

        private void WriteSettings ()
        {
            var settings = Path.Combine (Application.StartupPath, "Settings.cfg");
            if (File.Exists (settings))
                File.Delete (settings);
            var settingObject = new Settings
                                {
                                    DataPath = DataPath.Text,
                                    Text = TextForSearch.Text,
                                    IgnoreTweakScale = IgnoreTweakScale.Checked,
                                    IgnoreFilterExtensions = IgnoreFilterExtensions.Checked,
                                    IgnoreMechJeb = IgnoreMechJeb.Checked
                                };
            var setting = JsonConvert.SerializeObject (settingObject);
            File.WriteAllText (settings, setting);
        }

        private void IgnoreFilterExtensions_CheckStateChanged (object sender, EventArgs e)
        {
            WriteSettings();
        }

        private void IgnoreMechJeb_CheckStateChanged (object sender, EventArgs e)
        {
            WriteSettings();
        }

        private void IgnoreTweakScale_CheckStateChanged (object sender, EventArgs e)
        {
            WriteSettings();
        }

        private void timer1_Tick (object sender, EventArgs e)
        {
            if (! searching)
            {
                if (ProgressBar.Visible == true)
                    ProgressBar.Visible = false;
                return;
            }
            if (ProgressBar.Visible == false)
                ProgressBar.Visible = true;
            ProgressBar.Value = i;
            ProgressBar.Refresh ();
        }

        private void Form1_Load (object sender, EventArgs e)
        {

            FoundList = new List<string>();
            var settings = Path.Combine(Application.StartupPath, "Settings.cfg");
            if (!File.Exists(settings))
            {
                var settingObject = new Settings
                {
                    IgnoreTweakScale = true,
                    IgnoreFilterExtensions = true,
                    IgnoreMechJeb = true
                };
                var setting = JsonConvert.SerializeObject(settingObject);
                File.WriteAllText(settings, setting);
            }
            else
            {
                var setting = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(settings));
                DataPath.Text = setting.DataPath;
                TextForSearch.Text = setting.Text;
                IgnoreTweakScale.Checked = setting.IgnoreTweakScale;
                IgnoreFilterExtensions.Checked = setting.IgnoreFilterExtensions;
                IgnoreMechJeb.Checked = setting.IgnoreMechJeb;
            }
        }
    }
}
