namespace SampleSequencer3_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tempoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tempoTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.setTempoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.masterPlaybackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.stopPlaybackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.setAllSamplesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.patternPanel0 = new System.Windows.Forms.Panel();
            this.stopButtonPattern0 = new System.Windows.Forms.Button();
            this.playbackButtonPattern0 = new System.Windows.Forms.Button();
            this.pattern1Label = new System.Windows.Forms.Label();
            this.patternDataGrid0 = new System.Windows.Forms.DataGridView();
            this.newSampleButtonPattern0 = new System.Windows.Forms.Button();
            this.clearPatternButtonPattern0 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.patternPanel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patternDataGrid0)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1482, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileDropDownButton
            // 
            this.fileDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatternToolStripMenuItem});
            this.fileDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("fileDropDownButton.Image")));
            this.fileDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileDropDownButton.Name = "fileDropDownButton";
            this.fileDropDownButton.Size = new System.Drawing.Size(46, 24);
            this.fileDropDownButton.Text = "File";
            // 
            // newPatternToolStripMenuItem
            // 
            this.newPatternToolStripMenuItem.Name = "newPatternToolStripMenuItem";
            this.newPatternToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newPatternToolStripMenuItem.Text = "New Pattern";
            this.newPatternToolStripMenuItem.Click += new System.EventHandler(this.newPatternToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tempoToolStripLabel,
            this.tempoTextBox,
            this.setTempoToolStripButton,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.masterPlaybackToolStripButton,
            this.toolStripSeparator3,
            this.stopPlaybackToolStripButton,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.setAllSamplesToolStripButton,
            this.toolStripSeparator6,
            this.toolStripSeparator7});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1482, 27);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tempoToolStripLabel
            // 
            this.tempoToolStripLabel.Name = "tempoToolStripLabel";
            this.tempoToolStripLabel.Size = new System.Drawing.Size(55, 24);
            this.tempoToolStripLabel.Text = "Tempo";
            // 
            // tempoTextBox
            // 
            this.tempoTextBox.Name = "tempoTextBox";
            this.tempoTextBox.Size = new System.Drawing.Size(100, 27);
            this.tempoTextBox.Text = "120";
            // 
            // setTempoToolStripButton
            // 
            this.setTempoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.setTempoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("setTempoToolStripButton.Image")));
            this.setTempoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setTempoToolStripButton.Name = "setTempoToolStripButton";
            this.setTempoToolStripButton.Size = new System.Drawing.Size(84, 24);
            this.setTempoToolStripButton.Text = "Set Tempo";
            this.setTempoToolStripButton.Click += new System.EventHandler(this.setTempoButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // masterPlaybackToolStripButton
            // 
            this.masterPlaybackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.masterPlaybackToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("masterPlaybackToolStripButton.Image")));
            this.masterPlaybackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.masterPlaybackToolStripButton.Name = "masterPlaybackToolStripButton";
            this.masterPlaybackToolStripButton.Size = new System.Drawing.Size(120, 24);
            this.masterPlaybackToolStripButton.Text = "Master Playback";
            this.masterPlaybackToolStripButton.Click += (sender, e) => masterPlaybackButton_Click(sender, e, -1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // stopPlaybackToolStripButton
            // 
            this.stopPlaybackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stopPlaybackToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stopPlaybackToolStripButton.Image")));
            this.stopPlaybackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopPlaybackToolStripButton.Name = "stopPlaybackToolStripButton";
            this.stopPlaybackToolStripButton.Size = new System.Drawing.Size(106, 24);
            this.stopPlaybackToolStripButton.Text = "Stop Playback";
            this.stopPlaybackToolStripButton.Click += new System.EventHandler(this.stopPlaybackButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // setAllSamplesToolStripButton
            // 
            this.setAllSamplesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.setAllSamplesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("setAllSamplesToolStripButton.Image")));
            this.setAllSamplesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setAllSamplesToolStripButton.Name = "setAllSamplesToolStripButton";
            this.setAllSamplesToolStripButton.Size = new System.Drawing.Size(116, 24);
            this.setAllSamplesToolStripButton.Text = "Set All Samples";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // patternPanel0
            // 
            this.patternPanel0.AutoSize = true;
            this.patternPanel0.Controls.Add(this.clearPatternButtonPattern0);
            this.patternPanel0.Controls.Add(this.newSampleButtonPattern0);
            this.patternPanel0.Controls.Add(this.stopButtonPattern0);
            this.patternPanel0.Controls.Add(this.playbackButtonPattern0);
            this.patternPanel0.Controls.Add(this.pattern1Label);
            this.patternPanel0.Controls.Add(this.patternDataGrid0);
            this.patternPanel0.Location = new System.Drawing.Point(12, 57);
            this.patternPanel0.Name = "patternPanel0";
            this.patternPanel0.Size = new System.Drawing.Size(1166, 332);
            this.patternPanel0.TabIndex = 2;
            // 
            // stopButtonPattern0
            // 
            this.stopButtonPattern0.Location = new System.Drawing.Point(1009, 66);
            this.stopButtonPattern0.Name = "stopButtonPattern0";
            this.stopButtonPattern0.Size = new System.Drawing.Size(154, 31);
            this.stopButtonPattern0.TabIndex = 3;
            this.stopButtonPattern0.Text = "Pattern 1 Stop";
            this.stopButtonPattern0.UseVisualStyleBackColor = true;
            this.stopButtonPattern0.Click += new System.EventHandler(stopPlaybackButton_Click);
            // 
            // playbackButtonPattern0
            // 
            this.playbackButtonPattern0.Location = new System.Drawing.Point(1009, 29);
            this.playbackButtonPattern0.Name = "playbackButtonPattern0";
            this.playbackButtonPattern0.Size = new System.Drawing.Size(154, 31);
            this.playbackButtonPattern0.TabIndex = 2;
            this.playbackButtonPattern0.Text = "Pattern 1 Playback";
            this.playbackButtonPattern0.UseVisualStyleBackColor = true;
            this.playbackButtonPattern0.Click += (sender, e) => masterPlaybackButton_Click(sender, e, 0);
            // 
            // pattern1Label
            // 
            this.pattern1Label.AutoSize = true;
            this.pattern1Label.Location = new System.Drawing.Point(3, 9);
            this.pattern1Label.Name = "pattern1Label";
            this.pattern1Label.Size = new System.Drawing.Size(66, 17);
            this.pattern1Label.TabIndex = 1;
            this.pattern1Label.Text = "Pattern 1";
            // 
            // patternDataGrid0
            // 
            this.patternDataGrid0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patternDataGrid0.Location = new System.Drawing.Point(3, 29);
            this.patternDataGrid0.Name = "patternDataGrid0";
            this.patternDataGrid0.RowTemplate.Height = 24;
            this.patternDataGrid0.Size = new System.Drawing.Size(1000, 300);
            this.patternDataGrid0.TabIndex = 0;
            // 
            // newSampleButtonPattern0
            // 
            this.newSampleButtonPattern0.Location = new System.Drawing.Point(1009, 129);
            this.newSampleButtonPattern0.Name = "newSampleButtonPattern0";
            this.newSampleButtonPattern0.Size = new System.Drawing.Size(154, 31);
            this.newSampleButtonPattern0.TabIndex = 4;
            this.newSampleButtonPattern0.Text = "New Sample";
            this.newSampleButtonPattern0.UseVisualStyleBackColor = true;
            //ADD EVENT HANDLER HERE
            // 
            // clearPatternButtonPattern0
            // 
            this.clearPatternButtonPattern0.Location = new System.Drawing.Point(1009, 166);
            this.clearPatternButtonPattern0.Name = "clearPatternButtonPattern0";
            this.clearPatternButtonPattern0.Size = new System.Drawing.Size(154, 31);
            this.clearPatternButtonPattern0.TabIndex = 5;
            this.clearPatternButtonPattern0.Text = "Clear Pattern";
            this.clearPatternButtonPattern0.UseVisualStyleBackColor = true;
            //ADD EVENT HANDLER HERE
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.patternPanel0);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.patternPanel0.ResumeLayout(false);
            this.patternPanel0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patternDataGrid0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem newPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tempoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tempoTextBox;
        private System.Windows.Forms.ToolStripButton setTempoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton masterPlaybackToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton stopPlaybackToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton setAllSamplesToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Panel patternPanel0;
        private System.Windows.Forms.Button stopButtonPattern0;
        private System.Windows.Forms.Button playbackButtonPattern0;
        private System.Windows.Forms.Label pattern1Label;
        private System.Windows.Forms.DataGridView patternDataGrid0;
        private System.Windows.Forms.Button clearPatternButtonPattern0;
        private System.Windows.Forms.Button newSampleButtonPattern0;
    }
}

