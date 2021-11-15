
namespace UgadayMelodiyu
{
    partial class fMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMessage));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbShowAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("F77 Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Да";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("F77 Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(205, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Нет";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("F77 Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMessage.Location = new System.Drawing.Point(159, 63);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(79, 19);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("F77 Minecraft", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimer.Location = new System.Drawing.Point(186, 108);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(28, 24);
            this.lbTimer.TabIndex = 3;
            this.lbTimer.Text = "0";
            // 
            // lbShowAnswer
            // 
            this.lbShowAnswer.AutoSize = true;
            this.lbShowAnswer.Font = new System.Drawing.Font("F77 Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbShowAnswer.Location = new System.Drawing.Point(8, 227);
            this.lbShowAnswer.Name = "lbShowAnswer";
            this.lbShowAnswer.Size = new System.Drawing.Size(196, 19);
            this.lbShowAnswer.TabIndex = 4;
            this.lbShowAnswer.Text = "Показать ответ";
            this.lbShowAnswer.Click += new System.EventHandler(this.lbShowAnswer_Click);
            // 
            // fMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.lbShowAnswer);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMessage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMessage_FormClosed);
            this.Load += new System.EventHandler(this.fMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbShowAnswer;
    }
}