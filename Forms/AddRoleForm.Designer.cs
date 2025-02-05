namespace Wind_up_Zeno
{
    partial class AddRoleForm
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
            this.LstRoles = new System.Windows.Forms.ListBox();
            this.BtnAddRole = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstRoles
            // 
            this.LstRoles.FormattingEnabled = true;
            this.LstRoles.Location = new System.Drawing.Point(12, 12);
            this.LstRoles.Name = "LstRoles";
            this.LstRoles.Size = new System.Drawing.Size(120, 95);
            this.LstRoles.TabIndex = 0;
            // 
            // BtnAddRole
            // 
            this.BtnAddRole.Location = new System.Drawing.Point(138, 12);
            this.BtnAddRole.Name = "BtnAddRole";
            this.BtnAddRole.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRole.TabIndex = 1;
            this.BtnAddRole.Text = "Add role";
            this.BtnAddRole.UseVisualStyleBackColor = true;
            this.BtnAddRole.Click += new System.EventHandler(this.BtnAddRole_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(138, 84);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // AddRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 124);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAddRole);
            this.Controls.Add(this.LstRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddRoleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstRoles;
        private System.Windows.Forms.Button BtnAddRole;
        private System.Windows.Forms.Button BtnBack;
    }
}