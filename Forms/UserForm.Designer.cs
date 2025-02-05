namespace Wind_up_Zeno
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.LblName = new System.Windows.Forms.Label();
            this.LstRoles = new System.Windows.Forms.ListBox();
            this.BtnRemoveRole = new System.Windows.Forms.Button();
            this.BtnAddRole = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LstPermissions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(179, 117);
            this.LblName.TabIndex = 0;
            this.LblName.Text = resources.GetString("LblName.Text");
            // 
            // LstRoles
            // 
            this.LstRoles.FormattingEnabled = true;
            this.LstRoles.Location = new System.Drawing.Point(254, 25);
            this.LstRoles.Name = "LstRoles";
            this.LstRoles.Size = new System.Drawing.Size(120, 69);
            this.LstRoles.TabIndex = 1;
            this.LstRoles.SelectedIndexChanged += new System.EventHandler(this.LstRoles_SelectedIndexChanged);
            // 
            // BtnRemoveRole
            // 
            this.BtnRemoveRole.Location = new System.Drawing.Point(380, 54);
            this.BtnRemoveRole.Name = "BtnRemoveRole";
            this.BtnRemoveRole.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveRole.TabIndex = 2;
            this.BtnRemoveRole.Text = "Remove role";
            this.BtnRemoveRole.UseVisualStyleBackColor = true;
            this.BtnRemoveRole.Click += new System.EventHandler(this.BtnRemoveRole_Click);
            // 
            // BtnAddRole
            // 
            this.BtnAddRole.Location = new System.Drawing.Point(380, 25);
            this.BtnAddRole.Name = "BtnAddRole";
            this.BtnAddRole.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRole.TabIndex = 3;
            this.BtnAddRole.Text = "Add role";
            this.BtnAddRole.UseVisualStyleBackColor = true;
            this.BtnAddRole.Click += new System.EventHandler(this.BtnAddRole_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(680, 25);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LstPermissions
            // 
            this.LstPermissions.FormattingEnabled = true;
            this.LstPermissions.Location = new System.Drawing.Point(497, 25);
            this.LstPermissions.Name = "LstPermissions";
            this.LstPermissions.Size = new System.Drawing.Size(177, 69);
            this.LstPermissions.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Permissions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Roles";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 177);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstPermissions);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAddRole);
            this.Controls.Add(this.BtnRemoveRole);
            this.Controls.Add(this.LstRoles);
            this.Controls.Add(this.LblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ListBox LstRoles;
        private System.Windows.Forms.Button BtnRemoveRole;
        private System.Windows.Forms.Button BtnAddRole;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ListBox LstPermissions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}