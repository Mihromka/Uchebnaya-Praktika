using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UgadayMelodiyu
{
    public partial class fParam : Form
    {
        public fParam()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbAllDirectoty.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(music_list);
                Victorina.list.Clear();
                Victorina.list.AddRange(music_list);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = cbAllDirectoty.Checked;
            Victorina.gameDuration = Convert.ToInt32(cbGameDuration.Text);
            Victorina.musicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Victorina.randomStart = cbRandomStart.Checked;
            Victorina.WriteParam();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbGameDuration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRandomStart_CheckedChanged(object sender, EventArgs e)
        {

        }

        void Set()
        {
            cbAllDirectoty.Checked = Victorina.allDirectories;
            cbGameDuration.Text = Victorina.gameDuration.ToString();
            cbMusicDuration.Text = Victorina.musicDuration.ToString();
            cbRandomStart.Checked = Victorina.randomStart;
        }

        private void fParam_Load(object sender, EventArgs e)
        {
            Set();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Victorina.list.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
