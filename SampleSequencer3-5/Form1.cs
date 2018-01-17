using System;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.Generic;

namespace SampleSequencer3_5
{
    public partial class Form1 : Form
    {
        private IWavePlayer waveOut;
        //private Pattern pattern;
        private List<Pattern> patternList;
        private PatternSampleProvider patternSequencer;
        private List<PatternSampleProvider> pspList;
        private int tempo;
        private List<string> notes;
        private List<SampleControlsCollection> sccList;
        private List<Panel> patternPanels;
        private List<Panel> sccPanels;
        private List<DataGridView> dgvList;
        private Form sccForm;
        //private MixingSampleProvider mixer;

        public Form1()
        {
            InitializeComponent();

            //Initialize the form properties.
            tempo = Convert.ToInt32(tempoTextBox.Text);
            sccList = new List<SampleControlsCollection>();
            notes = new List<string>();
            sccPanels = new List<Panel>();
            patternPanels = new List<Panel>();
            patternList = new List<Pattern>();
            dgvList = new List<DataGridView>();
            pspList = new List<PatternSampleProvider>();

            sccForm = new Form();
            sccForm.AutoSize = true;

            patternPanels.Add(patternPanel0);

            //patternDataGrid initialization
            patternDataGrid0.ColumnCount = 17;
            patternDataGrid0.RowCount = 4;
            dgvList.Add(patternDataGrid0);

            patternDataGrid0.CellClick += (sender, e) => patternDataGrid_CellClick(sender, e, patternList.Count - 1);

            //add the sample names to List for use on the patternDataGrid
            notes.Add("kick-trimmed.wav");
            notes.Add("snare-trimmed.wav");
            notes.Add("closed-hats-trimmed.wav");
            notes.Add("open-hats-trimmed.wav");

            //initialize the Pattern
            Pattern pattern = new Pattern(notes, 16);
            patternList.Add(pattern);

            // auto-setup with a simple example beat
            pattern[0, 0] = pattern[0, 8] = 127;
            pattern[1, 4] = pattern[1, 12] = 127;
            for (int n = 0; n < pattern.Steps; n++)
            {
                pattern[2, n] = 127;
            }

            //"draw" the sample names and the pattern onto the patternDataGrid
            DrawNoteNames(patternList.Count - 1);
            DrawPattern(patternList.Count - 1);

            patternSequencer = new PatternSampleProvider(pattern);

            //SampleControlCollection initialization
            string[] defaultFiles = { patternSequencer.Samples.FilePaths[0],
                patternSequencer.Samples.FilePaths[1],
                patternSequencer.Samples.FilePaths[2],
                patternSequencer.Samples.FilePaths[3]};

            //create panel to group together the initial SampleControlCollections for pattern 1
            Panel panel = new Panel();
            panel.Location = new Point(0, 0);
            panel.AutoSize = true;

            Label sccLabel = new Label();
            sccLabel.Text = "Pattern 1";
            sccLabel.Location = new Point(0, 0);
            sccLabel.AutoSize = true;
            panel.Controls.Add(sccLabel);

            for (int i = 0; i < 4; i++)
            {
                SampleControlsCollection scc = new SampleControlsCollection();
                sccList.Add(scc);
                scc.Name = "scc" + (sccList.Count - 1);
                scc.Location = new Point(0, 10 + (100 * (sccList.Count - 1)));
                scc.AddToComboBox(defaultFiles[i]);

                panel.Controls.Add(scc);
            }

            sccPanels.Add(panel);
            sccForm.Controls.Add(panel);
            sccForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// The masterPlaybackButton_Click event handler calls the Play function to start playback.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void masterPlaybackButton_Click(object sender, EventArgs e, int patternNum)
        {
            Play(patternNum);
        }

        /// <summary>
        /// The stopPlaybackButton_Click event handler calls the Stop function to halt playback.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopPlaybackButton_Click(object sender, EventArgs e)
        {
            Stop();
        }

        /// <summary>
        /// The newSampleMenuItem_Click event handler creates a new SampleControlCollection and adds a new sample to the 
        /// PatternSampleProvider set to a default file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newSampleMenuItem_Click(object sender, EventArgs e, int patternNum)
        {
            string defaultFile = "D:\\VS Workspace\\NAudioSampleSequencerForms\\NAudioSampleSequencerForms\\Samples\\snare-trimmed.wav";

            SampleControlsCollection scc = new SampleControlsCollection();
            sccList.Add(scc);
            scc.Name = "scc" + (sccList.Count - 1);
            scc.Location = new Point(0, 0 + (100 * (sccList.Count - 1)));
            scc.AddToComboBox(defaultFile);

            sccPanels[patternNum].Controls.Add(scc);

            patternSequencer.Samples.AddNewSample(defaultFile);

            AddNewSampleRow(patternNum);
        }

        private void patternDataGrid_CellClick(object sender, DataGridViewCellEventArgs e, int patternNum)
        {
            DataGridViewCell cell = patternDataGrid0.Rows[e.RowIndex].Cells[e.ColumnIndex];
            PatternIndex pi = (PatternIndex)cell.Tag;
            Pattern pattern = patternList[patternNum];

            pattern[pi.Note, pi.Step] = pattern[pi.Note, pi.Step] == 0 ? (byte)127 : (byte)0;
            if (GetBackColor(pi.Note, pi.Step, patternNum) == true)
            {
                cell.Style.BackColor = Color.LightSalmon;
            }
            else
            {
                cell.Style.BackColor = Color.White;
            }

            patternList[patternNum] = pattern;
        }

        /// <summary>
        /// The setTempoButton_Click event handler sets the tempo variable to the current value of the tempoBox TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setTempoButton_Click(object sender, EventArgs e)
        {
            tempo = Convert.ToInt32(tempoTextBox.Text);
        }

        /// <summary>
        /// The setSampleButton_Click event handler iterates through each sample and sets it to what the current
        /// SelectedItem of its corresponding ComboBox is.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setSamplesButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sccList.Count; i++)
            {
                //Set new note name
                String str = sccList[i].sampleSourceComboBox.SelectedItem.ToString();
                Char delimiter = '\\';
                String[] substrings = str.Split(delimiter);
                notes[i] = substrings[substrings.Length - 1];
                patternDataGrid0.Rows[i].Cells[0].Value = notes[i];

                //Set sample
                patternSequencer.Samples.setSample(str, i);
            }
        }

        private void newPatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initialize the new Panel, Label, DataGridView, and Buttons.
            Panel panel = new Panel();
            patternPanels.Add(panel);
            panel.Name = "patternPanel" + (patternPanels.Count - 1);
            panel.Location = new Point(7, 0 + (350 * (patternPanels.Count - 1)));
            panel.AutoSize = true;
            this.Controls.Add(panel);

            Label label = new Label();
            label.Name = "patternLabel" + (patternPanels.Count - 1);
            label.Text = "Pattern " + (patternPanels.Count);
            label.Location = new Point(3, 9);
            label.Size = new Size(66, 17);
            panel.Controls.Add(label);

            DataGridView dataGridView = new DataGridView();
            dataGridView.Name = "patternDataGrid" + (patternPanels.Count - 1);
            dataGridView.Location = new Point(3, 29);
            dataGridView.Size = new Size(750, 250);
            dataGridView.AutoSize = false;
            //ADD EVENT HANDLERS HERE
            panel.Controls.Add(dataGridView);

            Button playButton = new Button();
            playButton.Name = "playbackButtonPattern" + (patternPanels.Count - 1);
            playButton.Text = "Pattern " + (patternPanels.Count - 1) + " Playback";
            playButton.Location = new Point(755, 29);
            playButton.Size = new Size(154, 31);
            //ADD EVENT HANDLERS HERE
            panel.Controls.Add(playButton);

            Button stopButton = new Button();
            stopButton.Name = "stopButtonPattern" + (patternPanels.Count - 1);
            stopButton.Text = "Pattern " + (patternPanels.Count - 1) + " Stop";
            stopButton.Location = new Point(755, 66);
            stopButton.Size = new Size(154, 31);
            //ADD EVENT HANDLERS HERE
            panel.Controls.Add(stopButton);

            Button newSampleButton = new Button();
            newSampleButton.Name = "newSampleButtonPattern" + (patternPanels.Count - 1);
            newSampleButton.Text = "New Sample";
            newSampleButton.Location = new Point(755, 129);
            newSampleButton.Size = new Size(154, 31);
            //ADD EVENT HANDLERS HERE
            panel.Controls.Add(newSampleButton);

            Button clearPatternButton = new Button();
            clearPatternButton.Name = "clearPatternButtonPattern" + (patternPanels.Count - 1);
            clearPatternButton.Text = "Clear Pattern";
            clearPatternButton.Location = new Point(755, 166);
            clearPatternButton.Size = new Size(154, 31);
            //ADD EVENT HANDLERS HERE
            panel.Controls.Add(clearPatternButton);

            CheckBox checkBox = new CheckBox();
            checkBox.Name = "switchCheckBoxPattern" + (patternPanels.Count - 1);
            checkBox.Text = "Include Pattern " + (patternPanels.Count) + "in Master Playback";
            checkBox.Location = new Point(755, 215);
            checkBox.AutoSize = true;
            //ADD EVENT HANDLERS HERE
            panel.Controls.Add(checkBox);

            //Add the new SampleControlsCollections for the new Pattern.
            Panel sccPanel = new Panel();
            sccPanel.Location = new Point(0 + (1000 * (sccPanels.Count)), 0);
            sccPanel.AutoSize = true;
            sccPanels.Add(sccPanel);

            Label sccLabel = new Label();
            sccLabel.Text = "Pattern " + (sccPanels.Count);
            sccLabel.Location = new Point(0, 0);
            sccLabel.AutoSize = true;
            sccPanel.Controls.Add(sccLabel);

            string[] defaultFiles = { patternSequencer.Samples.FilePaths[0],
                patternSequencer.Samples.FilePaths[1],
                patternSequencer.Samples.FilePaths[2],
                patternSequencer.Samples.FilePaths[3]};

            for (int i = 0; i < 4; i++)
            {
                SampleControlsCollection scc = new SampleControlsCollection();
                sccList.Add(scc);
                scc.Name = "scc" + (sccList.Count - 1);
                scc.Location = new Point(0, 0 + (100 * (sccList.Count - 1)));
                scc.AddToComboBox(defaultFiles[i]);

                sccPanel.Controls.Add(scc);
            }

            sccForm.Controls.Add(sccPanel);

            //initialize the Pattern
            Pattern pattern = new Pattern(notes,16);
            patternList.Add(pattern);

            //Initialize the data structures for new pattern.
            //patternDataGrid initialization
            dataGridView.ColumnCount = 17;
            dataGridView.RowCount = 4;

            dataGridView.CellClick += (sender1, e1) => patternDataGrid_CellClick(sender1, e1, patternList.Count - 1);

            // auto-setup with a simple example beat
            pattern[0, 0] = pattern[0, 8] = 127;
            pattern[1, 4] = pattern[1, 12] = 127;
            for (int n = 0; n < pattern.Steps; n++)
            {
                pattern[2, n] = 127;
            }

            //"draw" the sample names and the pattern onto the patternDataGrid
            DrawNoteNames(patternList.Count - 1);
            DrawPattern(patternList.Count - 1);
        }

        /// <summary>
        /// The clearPatternButton_Click event handler sets every (note,step) pairing in the Pattern to 0, erasing the
        /// intent to play a sample on the pairing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void clearPatternButton_Click(object sender, EventArgs e)
        //{
        //    for (int step = 0; step < pattern.Steps; step++)
        //    {
        //        for (int note = 0; note < pattern.Notes; note++)
        //        {
        //            if (GetBackColor(note, step) == true)
        //            {
        //                this.pattern[note, step] = 0;
        //            }
        //        }
        //    }

        //    DrawPattern();
        //}

        /// <summary>
        /// The AddNewSampleRow function creates a new row in the DataGridView that represents the new sample added by
        /// the user.
        /// </summary>
        private void AddNewSampleRow(int patternNum)
        {
            string defaultSample = "snare-trimmed.wav";
            var oldPattern = patternList[patternNum];
            Pattern pattern = patternList[patternNum];

            dgvList[patternNum].Rows.Add();
            notes.Add(defaultSample);
            patternList[patternNum] = new Pattern(notes, 16);

            for (int n = 0; n < oldPattern.Notes; n++)
            {
                for (int j = 0; j < oldPattern.Steps; j++)
                {
                    pattern[n, j] = oldPattern[n, j];
                }
            }

            patternList[patternNum] = pattern;

            DrawNoteNames(patternNum);
            DrawPattern(patternNum);
        }

        /// <summary>
        /// The Play function starts playback of the drum machine.
        /// </summary>
        private void Play(int patternNum)
        {
            if (waveOut != null)
            {
                Stop();
            }
            waveOut = new WaveOut();
            this.patternSequencer.Reset(patternList[patternNum]);
            this.patternSequencer.Tempo = tempo;
            waveOut.Init(patternSequencer);
            waveOut.Play();
        }

        /// <summary>
        /// The DrawNoteNames function changes the values of the left most column to be the names of the samples currently
        /// set by the user.
        /// </summary>
        private void DrawNoteNames(int patternNum)
        {
            for (int note = 0; note < patternList[patternNum].Notes; note++)
            {
                patternDataGrid0.Rows[note].Cells[0].Value = patternList[patternNum].NoteNames[note];
            }
        }

        /// <summary>
        /// The DrawPattern function changes the color of all DataGridView cells that are meant to play a sample on its beat
        /// to LightSalmon. Otherwise, the cell is the color White.
        /// </summary>
        private void DrawPattern(int patternNum)
        {
            for (int step = 0; step < patternList[patternNum].Steps; step++)
            {
                for (int note = 0; note < patternList[patternNum].Notes; note++)
                {
                    if (GetBackColor(note, step, patternNum) == true)
                    {
                        patternDataGrid0.Rows[note].Cells[step + 1].Style.BackColor = Color.LightSalmon;
                    }
                    else
                    {
                        patternDataGrid0.Rows[note].Cells[step + 1].Style.BackColor = Color.White;
                    }
                    patternDataGrid0.Rows[note].Cells[step + 1].Tag = new PatternIndex(note, step);

                }
            }
        }

        /// <summary>
        /// The GetBackColor function checks if a (note,step) pairing in the Pattern is true, meaning
        /// a sample is meant to be played on that (note,step) pairing, or false.
        /// </summary>
        /// <param name="note"> note is the row on the DataGridView, or the sample that is being played. </param>
        /// <param name="step"> step is the column on the DataGridView, or the beat that the sample is played. </param>
        /// <returns> true if the sample is to be played on the (note,step) pairing. false if the sample is not to
        /// be played on the (note,step) pairing. </returns>
        private bool GetBackColor(int note, int step, int patternNum)
        {
            Pattern pattern = patternList[patternNum];

            if (pattern[note, step] == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            //patternList[patternNum] = pattern;
        }

        class PatternIndex
        {
            public PatternIndex(int note, int step)
            {
                this.Note = note;
                this.Step = step;
            }
            public int Note { get; private set; }
            public int Step { get; private set; }
        }

        /// <summary>
        /// The Stop function stops the playback of the drum machine.
        /// </summary>
        private void Stop()
        {
            if (waveOut != null)
            {
                waveOut.Dispose();
                waveOut = null;
            }
        }
    }
}
