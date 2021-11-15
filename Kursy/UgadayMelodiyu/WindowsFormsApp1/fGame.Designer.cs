
namespace UgadayMelodiyu
{
    partial class fGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCounter1 = new System.Windows.Forms.Label();
            this.lbCounter2 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lbMelodyCount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbMusicDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(-11, 365);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(105, 46);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            this.WMP.Enter += new System.EventHandler(this.WMP_Enter);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("F77 Minecraft", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(193, 238);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(316, 89);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Следующая мелодия";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("F77 Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(189, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Игрок 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("F77 Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(411, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Игрок 2";
            // 
            // lbCounter1
            // 
            this.lbCounter1.AutoSize = true;
            this.lbCounter1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbCounter1.Font = new System.Drawing.Font("F77 Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCounter1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCounter1.Location = new System.Drawing.Point(189, 70);
            this.lbCounter1.Name = "lbCounter1";
            this.lbCounter1.Size = new System.Drawing.Size(23, 19);
            this.lbCounter1.TabIndex = 4;
            this.lbCounter1.Text = "0";
            this.lbCounter1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbCounter1_MouseClick);
            // 
            // lbCounter2
            // 
            this.lbCounter2.AutoSize = true;
            this.lbCounter2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbCounter2.Font = new System.Drawing.Font("F77 Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCounter2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCounter2.Location = new System.Drawing.Point(486, 70);
            this.lbCounter2.Name = "lbCounter2";
            this.lbCounter2.Size = new System.Drawing.Size(23, 19);
            this.lbCounter2.TabIndex = 5;
            this.lbCounter2.Text = "0";
            this.lbCounter2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbCounter1_MouseClick);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("F77 Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPause.Location = new System.Drawing.Point(193, 176);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(156, 44);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Font = new System.Drawing.Font("F77 Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinue.Location = new System.Drawing.Point(353, 176);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(156, 44);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lbMelodyCount
            // 
            this.lbMelodyCount.AutoSize = true;
            this.lbMelodyCount.Font = new System.Drawing.Font("F77 Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMelodyCount.ForeColor = System.Drawing.Color.Aqua;
            this.lbMelodyCount.Location = new System.Drawing.Point(339, 27);
            this.lbMelodyCount.Name = "lbMelodyCount";
            this.lbMelodyCount.Size = new System.Drawing.Size(23, 19);
            this.lbMelodyCount.TabIndex = 8;
            this.lbMelodyCount.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar1.Location = new System.Drawing.Point(192, 127);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(316, 27);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbMusicDuration
            // 
            this.lbMusicDuration.AutoSize = true;
            this.lbMusicDuration.Font = new System.Drawing.Font("F77 Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMusicDuration.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbMusicDuration.Location = new System.Drawing.Point(339, 70);
            this.lbMusicDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMusicDuration.Name = "lbMusicDuration";
            this.lbMusicDuration.Size = new System.Drawing.Size(23, 19);
            this.lbMusicDuration.TabIndex = 10;
            this.lbMusicDuration.Text = "0";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.lbMusicDuration);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbMelodyCount);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lbCounter2);
            this.Controls.Add(this.lbCounter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCounter1;
        private System.Windows.Forms.Label lbCounter2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lbMelodyCount;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbMusicDuration;
    }
}