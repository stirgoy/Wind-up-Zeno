namespace Wind_up_Zeno
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnUpdateLists = new System.Windows.Forms.Button();
            this.BtnLogs = new System.Windows.Forms.Button();
            this.BtnData = new System.Windows.Forms.Button();
            this.LstUsers = new System.Windows.Forms.ListBox();
            this.BtnSendMsg = new System.Windows.Forms.Button();
            this.TxtMsg = new System.Windows.Forms.TextBox();
            this.LstChannels = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ChkSendTo = new System.Windows.Forms.RadioButton();
            this.ChkAutostart = new System.Windows.Forms.CheckBox();
            this.BtnUserForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LstRoles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMentionUser = new System.Windows.Forms.TextBox();
            this.TxtMentionChannel = new System.Windows.Forms.TextBox();
            this.BtnCopyUM = new System.Windows.Forms.Button();
            this.BtnCopyMC = new System.Windows.Forms.Button();
            this.BtnAddU = new System.Windows.Forms.Button();
            this.BtnAddC = new System.Windows.Forms.Button();
            this.TxtRM = new System.Windows.Forms.TextBox();
            this.BtnCopyRM = new System.Windows.Forms.Button();
            this.BtnAddR = new System.Windows.Forms.Button();
            this.LblCacpot = new System.Windows.Forms.Label();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.BtnStatus = new System.Windows.Forms.Button();
            this.LstEmotes = new System.Windows.Forms.ListBox();
            this.TxtEmotes = new System.Windows.Forms.TextBox();
            this.BtnCopyE = new System.Windows.Forms.Button();
            this.BtnAddE = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NI = new System.Windows.Forms.NotifyIcon(this.components);
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnToggle = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtLog
            // 
            this.TxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.TxtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLog.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TxtLog.Location = new System.Drawing.Point(0, 61);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLog.Size = new System.Drawing.Size(1333, 481);
            this.TxtLog.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtnStart.Location = new System.Drawing.Point(12, 9);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start Bot";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnStop.Location = new System.Drawing.Point(93, 9);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop Bot";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(178, 9);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(85, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear console";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnUpdateLists
            // 
            this.BtnUpdateLists.Enabled = false;
            this.BtnUpdateLists.Location = new System.Drawing.Point(12, 204);
            this.BtnUpdateLists.Name = "BtnUpdateLists";
            this.BtnUpdateLists.Size = new System.Drawing.Size(119, 44);
            this.BtnUpdateLists.TabIndex = 4;
            this.BtnUpdateLists.Text = "Update lists";
            this.BtnUpdateLists.UseVisualStyleBackColor = true;
            this.BtnUpdateLists.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnLogs
            // 
            this.BtnLogs.Location = new System.Drawing.Point(1134, 11);
            this.BtnLogs.Name = "BtnLogs";
            this.BtnLogs.Size = new System.Drawing.Size(75, 24);
            this.BtnLogs.TabIndex = 5;
            this.BtnLogs.Text = "Logs folder";
            this.BtnLogs.UseVisualStyleBackColor = true;
            this.BtnLogs.Click += new System.EventHandler(this.BtnLogs_Click);
            // 
            // BtnData
            // 
            this.BtnData.Location = new System.Drawing.Point(1053, 11);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(75, 24);
            this.BtnData.TabIndex = 5;
            this.BtnData.Text = "Data folder";
            this.BtnData.UseVisualStyleBackColor = true;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // LstUsers
            // 
            this.LstUsers.FormattingEnabled = true;
            this.LstUsers.Location = new System.Drawing.Point(12, 87);
            this.LstUsers.Name = "LstUsers";
            this.LstUsers.Size = new System.Drawing.Size(120, 82);
            this.LstUsers.TabIndex = 6;
            this.LstUsers.SelectedIndexChanged += new System.EventHandler(this.LstUsers_SelectedIndexChanged);
            // 
            // BtnSendMsg
            // 
            this.BtnSendMsg.Enabled = false;
            this.BtnSendMsg.Location = new System.Drawing.Point(6, 109);
            this.BtnSendMsg.Name = "BtnSendMsg";
            this.BtnSendMsg.Size = new System.Drawing.Size(111, 23);
            this.BtnSendMsg.TabIndex = 8;
            this.BtnSendMsg.Text = "Send message";
            this.BtnSendMsg.UseVisualStyleBackColor = true;
            this.BtnSendMsg.Click += new System.EventHandler(this.BtnSendMsg_Click);
            // 
            // TxtMsg
            // 
            this.TxtMsg.Location = new System.Drawing.Point(7, 16);
            this.TxtMsg.Multiline = true;
            this.TxtMsg.Name = "TxtMsg";
            this.TxtMsg.Size = new System.Drawing.Size(489, 78);
            this.TxtMsg.TabIndex = 9;
            // 
            // LstChannels
            // 
            this.LstChannels.FormattingEnabled = true;
            this.LstChannels.Location = new System.Drawing.Point(274, 87);
            this.LstChannels.Name = "LstChannels";
            this.LstChannels.Size = new System.Drawing.Size(173, 108);
            this.LstChannels.TabIndex = 10;
            this.LstChannels.SelectedIndexChanged += new System.EventHandler(this.LstChannels_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Server users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Server text channels";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(193, 112);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.Text = "User";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ChkSendTo
            // 
            this.ChkSendTo.AutoSize = true;
            this.ChkSendTo.Checked = true;
            this.ChkSendTo.Location = new System.Drawing.Point(123, 112);
            this.ChkSendTo.Name = "ChkSendTo";
            this.ChkSendTo.Size = new System.Drawing.Size(64, 17);
            this.ChkSendTo.TabIndex = 13;
            this.ChkSendTo.TabStop = true;
            this.ChkSendTo.Text = "Channel";
            this.ChkSendTo.UseVisualStyleBackColor = true;
            // 
            // ChkAutostart
            // 
            this.ChkAutostart.AutoSize = true;
            this.ChkAutostart.Location = new System.Drawing.Point(17, 38);
            this.ChkAutostart.Name = "ChkAutostart";
            this.ChkAutostart.Size = new System.Drawing.Size(68, 17);
            this.ChkAutostart.TabIndex = 14;
            this.ChkAutostart.Text = "Autostart";
            this.ChkAutostart.UseVisualStyleBackColor = true;
            this.ChkAutostart.CheckedChanged += new System.EventHandler(this.ChkAutostart_CheckedChanged);
            // 
            // BtnUserForm
            // 
            this.BtnUserForm.Enabled = false;
            this.BtnUserForm.Location = new System.Drawing.Point(12, 175);
            this.BtnUserForm.Name = "BtnUserForm";
            this.BtnUserForm.Size = new System.Drawing.Size(120, 23);
            this.BtnUserForm.TabIndex = 15;
            this.BtnUserForm.Text = "Check";
            this.BtnUserForm.UseVisualStyleBackColor = true;
            this.BtnUserForm.Click += new System.EventHandler(this.BtnUserForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.ChkSendTo);
            this.groupBox1.Controls.Add(this.BtnSendMsg);
            this.groupBox1.Controls.Add(this.TxtMsg);
            this.groupBox1.Location = new System.Drawing.Point(557, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 138);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // LstRoles
            // 
            this.LstRoles.FormattingEnabled = true;
            this.LstRoles.Location = new System.Drawing.Point(1098, 90);
            this.LstRoles.Name = "LstRoles";
            this.LstRoles.Size = new System.Drawing.Size(120, 69);
            this.LstRoles.TabIndex = 17;
            this.LstRoles.SelectedIndexChanged += new System.EventHandler(this.LstRoles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1095, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Server roles";
            // 
            // TxtMentionUser
            // 
            this.TxtMentionUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMentionUser.Location = new System.Drawing.Point(138, 87);
            this.TxtMentionUser.Name = "TxtMentionUser";
            this.TxtMentionUser.Size = new System.Drawing.Size(98, 17);
            this.TxtMentionUser.TabIndex = 18;
            // 
            // TxtMentionChannel
            // 
            this.TxtMentionChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMentionChannel.Location = new System.Drawing.Point(453, 87);
            this.TxtMentionChannel.Name = "TxtMentionChannel";
            this.TxtMentionChannel.Size = new System.Drawing.Size(98, 17);
            this.TxtMentionChannel.TabIndex = 18;
            // 
            // BtnCopyUM
            // 
            this.BtnCopyUM.Location = new System.Drawing.Point(138, 111);
            this.BtnCopyUM.Name = "BtnCopyUM";
            this.BtnCopyUM.Size = new System.Drawing.Size(98, 23);
            this.BtnCopyUM.TabIndex = 19;
            this.BtnCopyUM.Text = "Copy mention";
            this.BtnCopyUM.UseVisualStyleBackColor = true;
            this.BtnCopyUM.Click += new System.EventHandler(this.BtnCopyUM_Click);
            // 
            // BtnCopyMC
            // 
            this.BtnCopyMC.Location = new System.Drawing.Point(453, 111);
            this.BtnCopyMC.Name = "BtnCopyMC";
            this.BtnCopyMC.Size = new System.Drawing.Size(98, 23);
            this.BtnCopyMC.TabIndex = 19;
            this.BtnCopyMC.Text = "Copy mention";
            this.BtnCopyMC.UseVisualStyleBackColor = true;
            this.BtnCopyMC.Click += new System.EventHandler(this.BtnCopyMC_Click);
            // 
            // BtnAddU
            // 
            this.BtnAddU.Location = new System.Drawing.Point(138, 140);
            this.BtnAddU.Name = "BtnAddU";
            this.BtnAddU.Size = new System.Drawing.Size(98, 23);
            this.BtnAddU.TabIndex = 20;
            this.BtnAddU.Text = "Add to msg";
            this.BtnAddU.UseVisualStyleBackColor = true;
            this.BtnAddU.Click += new System.EventHandler(this.BtnAddU_Click);
            // 
            // BtnAddC
            // 
            this.BtnAddC.Location = new System.Drawing.Point(453, 140);
            this.BtnAddC.Name = "BtnAddC";
            this.BtnAddC.Size = new System.Drawing.Size(98, 23);
            this.BtnAddC.TabIndex = 20;
            this.BtnAddC.Text = "Add to msg";
            this.BtnAddC.UseVisualStyleBackColor = true;
            this.BtnAddC.Click += new System.EventHandler(this.BtnAddC_Click);
            // 
            // TxtRM
            // 
            this.TxtRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRM.Location = new System.Drawing.Point(1224, 91);
            this.TxtRM.Name = "TxtRM";
            this.TxtRM.Size = new System.Drawing.Size(98, 17);
            this.TxtRM.TabIndex = 21;
            // 
            // BtnCopyRM
            // 
            this.BtnCopyRM.Location = new System.Drawing.Point(1224, 111);
            this.BtnCopyRM.Name = "BtnCopyRM";
            this.BtnCopyRM.Size = new System.Drawing.Size(98, 23);
            this.BtnCopyRM.TabIndex = 22;
            this.BtnCopyRM.Text = "Copy mention";
            this.BtnCopyRM.UseVisualStyleBackColor = true;
            this.BtnCopyRM.Click += new System.EventHandler(this.BtnCopyRM_Click);
            // 
            // BtnAddR
            // 
            this.BtnAddR.Location = new System.Drawing.Point(1224, 137);
            this.BtnAddR.Name = "BtnAddR";
            this.BtnAddR.Size = new System.Drawing.Size(98, 23);
            this.BtnAddR.TabIndex = 22;
            this.BtnAddR.Text = "Add to msg";
            this.BtnAddR.UseVisualStyleBackColor = true;
            this.BtnAddR.Click += new System.EventHandler(this.BtnAddR_Click);
            // 
            // LblCacpot
            // 
            this.LblCacpot.AutoSize = true;
            this.LblCacpot.Location = new System.Drawing.Point(742, 22);
            this.LblCacpot.Name = "LblCacpot";
            this.LblCacpot.Size = new System.Drawing.Size(37, 13);
            this.LblCacpot.TabIndex = 23;
            this.LblCacpot.Text = "Offline";
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(452, 11);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(203, 20);
            this.TxtStatus.TabIndex = 24;
            // 
            // BtnStatus
            // 
            this.BtnStatus.Location = new System.Drawing.Point(661, 9);
            this.BtnStatus.Name = "BtnStatus";
            this.BtnStatus.Size = new System.Drawing.Size(75, 23);
            this.BtnStatus.TabIndex = 25;
            this.BtnStatus.Text = "Set status";
            this.BtnStatus.UseVisualStyleBackColor = true;
            this.BtnStatus.Click += new System.EventHandler(this.BtnStatus_Click);
            // 
            // LstEmotes
            // 
            this.LstEmotes.FormattingEnabled = true;
            this.LstEmotes.Location = new System.Drawing.Point(1098, 182);
            this.LstEmotes.Name = "LstEmotes";
            this.LstEmotes.Size = new System.Drawing.Size(120, 69);
            this.LstEmotes.TabIndex = 26;
            this.LstEmotes.SelectedIndexChanged += new System.EventHandler(this.LstEmotes_SelectedIndexChanged);
            // 
            // TxtEmotes
            // 
            this.TxtEmotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmotes.Location = new System.Drawing.Point(1224, 181);
            this.TxtEmotes.Name = "TxtEmotes";
            this.TxtEmotes.Size = new System.Drawing.Size(100, 17);
            this.TxtEmotes.TabIndex = 27;
            // 
            // BtnCopyE
            // 
            this.BtnCopyE.Location = new System.Drawing.Point(1224, 202);
            this.BtnCopyE.Name = "BtnCopyE";
            this.BtnCopyE.Size = new System.Drawing.Size(100, 23);
            this.BtnCopyE.TabIndex = 28;
            this.BtnCopyE.Text = "Copy emote";
            this.BtnCopyE.UseVisualStyleBackColor = true;
            this.BtnCopyE.Click += new System.EventHandler(this.BtnCopyE_Click);
            // 
            // BtnAddE
            // 
            this.BtnAddE.Location = new System.Drawing.Point(1224, 228);
            this.BtnAddE.Name = "BtnAddE";
            this.BtnAddE.Size = new System.Drawing.Size(100, 23);
            this.BtnAddE.TabIndex = 28;
            this.BtnAddE.Text = "Add to msg";
            this.BtnAddE.UseVisualStyleBackColor = true;
            this.BtnAddE.Click += new System.EventHandler(this.BtnAddE_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Bot custom status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1095, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Bot emotes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(742, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cacpot noticer";
            // 
            // NI
            // 
            this.NI.Visible = true;
            this.NI.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NI_MouseDoubleClick);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnClose.Location = new System.Drawing.Point(269, 9);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(50, 23);
            this.BtnClose.TabIndex = 32;
            this.BtnClose.Text = "Exit";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnToggle
            // 
            this.BtnToggle.Location = new System.Drawing.Point(1224, 11);
            this.BtnToggle.Name = "BtnToggle";
            this.BtnToggle.Size = new System.Drawing.Size(104, 24);
            this.BtnToggle.TabIndex = 33;
            this.BtnToggle.Text = "Toggle controls";
            this.BtnToggle.UseVisualStyleBackColor = true;
            this.BtnToggle.Click += new System.EventHandler(this.BtnToggle_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(933, 11);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(101, 24);
            this.BtnImport.TabIndex = 34;
            this.BtnImport.Text = "Import bo data";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "kuru.json";
            this.OFD.Filter = "Bot config file|kuru.json";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 541);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.BtnToggle);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAddE);
            this.Controls.Add(this.BtnCopyE);
            this.Controls.Add(this.TxtEmotes);
            this.Controls.Add(this.LstEmotes);
            this.Controls.Add(this.BtnStatus);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.LblCacpot);
            this.Controls.Add(this.BtnAddR);
            this.Controls.Add(this.BtnCopyRM);
            this.Controls.Add(this.TxtRM);
            this.Controls.Add(this.BtnAddC);
            this.Controls.Add(this.BtnAddU);
            this.Controls.Add(this.BtnCopyMC);
            this.Controls.Add(this.BtnCopyUM);
            this.Controls.Add(this.TxtMentionChannel);
            this.Controls.Add(this.TxtMentionUser);
            this.Controls.Add(this.LstRoles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnUserForm);
            this.Controls.Add(this.ChkAutostart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstChannels);
            this.Controls.Add(this.LstUsers);
            this.Controls.Add(this.BtnData);
            this.Controls.Add(this.BtnLogs);
            this.Controls.Add(this.BtnUpdateLists);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wind-up Zeno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Button BtnClear;
        public System.Windows.Forms.Button BtnStart;
        public System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnLogs;
        private System.Windows.Forms.Button BtnData;
        public System.Windows.Forms.Button BtnUpdateLists;
        public System.Windows.Forms.ListBox LstUsers;
        public System.Windows.Forms.Button BtnSendMsg;
        private System.Windows.Forms.TextBox TxtMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton ChkSendTo;
        public System.Windows.Forms.ListBox LstChannels;
        private System.Windows.Forms.CheckBox ChkAutostart;
        private System.Windows.Forms.Button BtnUserForm;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox LstRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMentionUser;
        private System.Windows.Forms.TextBox TxtMentionChannel;
        private System.Windows.Forms.Button BtnCopyUM;
        private System.Windows.Forms.Button BtnCopyMC;
        private System.Windows.Forms.Button BtnAddU;
        private System.Windows.Forms.Button BtnAddC;
        private System.Windows.Forms.TextBox TxtRM;
        private System.Windows.Forms.Button BtnCopyRM;
        private System.Windows.Forms.Button BtnAddR;
        private System.Windows.Forms.Label LblCacpot;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Button BtnStatus;
        private System.Windows.Forms.ListBox LstEmotes;
        private System.Windows.Forms.TextBox TxtEmotes;
        private System.Windows.Forms.Button BtnCopyE;
        private System.Windows.Forms.Button BtnAddE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NotifyIcon NI;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnToggle;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

