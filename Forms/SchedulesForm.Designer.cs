namespace Wind_up_Zeno
{
    partial class SchedulesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtWeekly = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDaylie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCacpot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtLoopCacpot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ChkXIVLN = new System.Windows.Forms.CheckBox();
            this.ChkBadWordsBlackList = new System.Windows.Forms.CheckBox();
            this.ChkRunBot = new System.Windows.Forms.CheckBox();
            this.ChkUpdateSlashCommands = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weekly";
            // 
            // TxtWeekly
            // 
            this.TxtWeekly.Location = new System.Drawing.Point(55, 30);
            this.TxtWeekly.Name = "TxtWeekly";
            this.TxtWeekly.Size = new System.Drawing.Size(41, 20);
            this.TxtWeekly.TabIndex = 1;
            this.TxtWeekly.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Daylie";
            // 
            // TxtDaylie
            // 
            this.TxtDaylie.Location = new System.Drawing.Point(55, 56);
            this.TxtDaylie.Name = "TxtDaylie";
            this.TxtDaylie.Size = new System.Drawing.Size(41, 20);
            this.TxtDaylie.TabIndex = 1;
            this.TxtDaylie.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "GC";
            // 
            // TxtGC
            // 
            this.TxtGC.Location = new System.Drawing.Point(55, 82);
            this.TxtGC.Name = "TxtGC";
            this.TxtGC.Size = new System.Drawing.Size(41, 20);
            this.TxtGC.TabIndex = 1;
            this.TxtGC.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cacpot";
            // 
            // TxtCacpot
            // 
            this.TxtCacpot.Location = new System.Drawing.Point(55, 108);
            this.TxtCacpot.Name = "TxtCacpot";
            this.TxtCacpot.Size = new System.Drawing.Size(41, 20);
            this.TxtCacpot.TabIndex = 1;
            this.TxtCacpot.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "WARNING!!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Set UTC hours.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "App will translate to local time.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtWeekly);
            this.groupBox1.Controls.Add(this.TxtCacpot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtGC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtDaylie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FF Reset hours";
            // 
            // TxtLoopCacpot
            // 
            this.TxtLoopCacpot.Location = new System.Drawing.Point(99, 19);
            this.TxtLoopCacpot.Name = "TxtLoopCacpot";
            this.TxtLoopCacpot.Size = new System.Drawing.Size(41, 20);
            this.TxtLoopCacpot.TabIndex = 1;
            this.TxtLoopCacpot.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cacpot noticer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtLoopCacpot);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 55);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loop delays";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Set on milliseconds.";
            // 
            // ChkXIVLN
            // 
            this.ChkXIVLN.AutoSize = true;
            this.ChkXIVLN.Enabled = false;
            this.ChkXIVLN.Location = new System.Drawing.Point(310, 26);
            this.ChkXIVLN.Name = "ChkXIVLN";
            this.ChkXIVLN.Size = new System.Drawing.Size(244, 17);
            this.ChkXIVLN.TabIndex = 4;
            this.ChkXIVLN.Text = "Lodestone News ((need reconnect for turn off)";
            this.ChkXIVLN.UseVisualStyleBackColor = true;
            // 
            // ChkBadWordsBlackList
            // 
            this.ChkBadWordsBlackList.AutoSize = true;
            this.ChkBadWordsBlackList.Location = new System.Drawing.Point(310, 49);
            this.ChkBadWordsBlackList.Name = "ChkBadWordsBlackList";
            this.ChkBadWordsBlackList.Size = new System.Drawing.Size(128, 17);
            this.ChkBadWordsBlackList.TabIndex = 4;
            this.ChkBadWordsBlackList.Text = "Bad Words Black List";
            this.ChkBadWordsBlackList.UseVisualStyleBackColor = true;
            // 
            // ChkRunBot
            // 
            this.ChkRunBot.AutoSize = true;
            this.ChkRunBot.Location = new System.Drawing.Point(310, 72);
            this.ChkRunBot.Name = "ChkRunBot";
            this.ChkRunBot.Size = new System.Drawing.Size(149, 17);
            this.ChkRunBot.TabIndex = 4;
            this.ChkRunBot.Text = "Run Bot (need reconnect)";
            this.ChkRunBot.UseVisualStyleBackColor = true;
            // 
            // ChkUpdateSlashCommands
            // 
            this.ChkUpdateSlashCommands.AutoSize = true;
            this.ChkUpdateSlashCommands.Location = new System.Drawing.Point(310, 95);
            this.ChkUpdateSlashCommands.Name = "ChkUpdateSlashCommands";
            this.ChkUpdateSlashCommands.Size = new System.Drawing.Size(207, 17);
            this.ChkUpdateSlashCommands.TabIndex = 4;
            this.ChkUpdateSlashCommands.Text = "Update SlashCommands server cache";
            this.ChkUpdateSlashCommands.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "All changes will be saved when this window is closed.";
            // 
            // SchedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 235);
            this.Controls.Add(this.ChkUpdateSlashCommands);
            this.Controls.Add(this.ChkRunBot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ChkBadWordsBlackList);
            this.Controls.Add(this.ChkXIVLN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchedulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "⚙️ Bot Settings ⚙️";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SchedulesForm_FormClosing);
            this.Shown += new System.EventHandler(this.SchedulesForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtWeekly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDaylie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCacpot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtLoopCacpot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ChkXIVLN;
        private System.Windows.Forms.CheckBox ChkBadWordsBlackList;
        private System.Windows.Forms.CheckBox ChkRunBot;
        private System.Windows.Forms.CheckBox ChkUpdateSlashCommands;
        private System.Windows.Forms.Label label9;
    }
}