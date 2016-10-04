namespace KSP_Part_Finder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ChooseFolder = new System.Windows.Forms.Button();
            this.DataPath = new System.Windows.Forms.TextBox();
            this.TextForSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.IgnoreTweakScale = new System.Windows.Forms.CheckBox();
            this.IgnoreFilterExtensions = new System.Windows.Forms.CheckBox();
            this.IgnoreMechJeb = new System.Windows.Forms.CheckBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ChooseFolder
            // 
            this.ChooseFolder.Location = new System.Drawing.Point(472, 6);
            this.ChooseFolder.Name = "ChooseFolder";
            this.ChooseFolder.Size = new System.Drawing.Size(75, 23);
            this.ChooseFolder.TabIndex = 0;
            this.ChooseFolder.Text = "...";
            this.ChooseFolder.UseVisualStyleBackColor = true;
            this.ChooseFolder.Click += new System.EventHandler(this.ChooseFolder_Click);
            // 
            // DataPath
            // 
            this.DataPath.Location = new System.Drawing.Point(109, 8);
            this.DataPath.Name = "DataPath";
            this.DataPath.Size = new System.Drawing.Size(357, 20);
            this.DataPath.TabIndex = 1;
            // 
            // TextForSearch
            // 
            this.TextForSearch.Location = new System.Drawing.Point(109, 34);
            this.TextForSearch.Name = "TextForSearch";
            this.TextForSearch.Size = new System.Drawing.Size(357, 20);
            this.TextForSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Data Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text For Search";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(472, 32);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // IgnoreTweakScale
            // 
            this.IgnoreTweakScale.AutoSize = true;
            this.IgnoreTweakScale.Checked = true;
            this.IgnoreTweakScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IgnoreTweakScale.Location = new System.Drawing.Point(12, 60);
            this.IgnoreTweakScale.Name = "IgnoreTweakScale";
            this.IgnoreTweakScale.Size = new System.Drawing.Size(122, 17);
            this.IgnoreTweakScale.TabIndex = 6;
            this.IgnoreTweakScale.Text = "Ignore Tweak Scale";
            this.IgnoreTweakScale.UseVisualStyleBackColor = true;
            this.IgnoreTweakScale.CheckStateChanged += new System.EventHandler(this.IgnoreTweakScale_CheckStateChanged);
            // 
            // IgnoreFilterExtensions
            // 
            this.IgnoreFilterExtensions.AutoSize = true;
            this.IgnoreFilterExtensions.Checked = true;
            this.IgnoreFilterExtensions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IgnoreFilterExtensions.Location = new System.Drawing.Point(219, 60);
            this.IgnoreFilterExtensions.Name = "IgnoreFilterExtensions";
            this.IgnoreFilterExtensions.Size = new System.Drawing.Size(135, 17);
            this.IgnoreFilterExtensions.TabIndex = 7;
            this.IgnoreFilterExtensions.Text = "Ignore Filter Extensions";
            this.IgnoreFilterExtensions.UseVisualStyleBackColor = true;
            this.IgnoreFilterExtensions.CheckStateChanged += new System.EventHandler(this.IgnoreFilterExtensions_CheckStateChanged);
            // 
            // IgnoreMechJeb
            // 
            this.IgnoreMechJeb.AutoSize = true;
            this.IgnoreMechJeb.Checked = true;
            this.IgnoreMechJeb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IgnoreMechJeb.Location = new System.Drawing.Point(439, 60);
            this.IgnoreMechJeb.Name = "IgnoreMechJeb";
            this.IgnoreMechJeb.Size = new System.Drawing.Size(103, 17);
            this.IgnoreMechJeb.TabIndex = 8;
            this.IgnoreMechJeb.Text = "Ignore MechJeb";
            this.IgnoreMechJeb.UseVisualStyleBackColor = true;
            this.IgnoreMechJeb.CheckStateChanged += new System.EventHandler(this.IgnoreMechJeb_CheckStateChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(13, 84);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(534, 23);
            this.ProgressBar.TabIndex = 9;
            this.ProgressBar.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(555, 112);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.IgnoreMechJeb);
            this.Controls.Add(this.IgnoreFilterExtensions);
            this.Controls.Add(this.IgnoreTweakScale);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextForSearch);
            this.Controls.Add(this.DataPath);
            this.Controls.Add(this.ChooseFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KSP Part Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFolder;
        private System.Windows.Forms.TextBox DataPath;
        private System.Windows.Forms.TextBox TextForSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox IgnoreTweakScale;
        private System.Windows.Forms.CheckBox IgnoreFilterExtensions;
        private System.Windows.Forms.CheckBox IgnoreMechJeb;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}

