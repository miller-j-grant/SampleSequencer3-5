using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleSequencer3_5
{
    public partial class SampleControlsCollection : UserControl
    {
        Form parent;

        public SampleControlsCollection()
        {
            InitializeComponent();

            this.parent = (Form)this.FindForm();

            // Associate the event-handling method with the 
            // SelectedIndexChanged event.
            //this.sampleSourceComboBox.SelectedIndexChanged += new System.EventHandler(sampleSourceComboBox_SelectedIndexChanged);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            //Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                sampleSourceComboBox.Items.Add(filePath);
                sampleSourceComboBox.SelectedItem = filePath;
            }
        }

        public void AddToComboBox(string str)
        {
            sampleSourceComboBox.Items.Add(str);
            sampleSourceComboBox.SelectedItem = str;
        }
    }
}
