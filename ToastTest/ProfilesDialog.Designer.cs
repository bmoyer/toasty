namespace ToastTest
{
    partial class ProfilesDialog
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
            this.profileList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profileTable = new System.Windows.Forms.DataGridView();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileNameEdit = new System.Windows.Forms.TextBox();
            this.renameProfileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewSaveProfileButton = new System.Windows.Forms.Button();
            this.removeProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileTable)).BeginInit();
            this.SuspendLayout();
            // 
            // profileList
            // 
            this.profileList.FormattingEnabled = true;
            this.profileList.Location = new System.Drawing.Point(12, 31);
            this.profileList.Name = "profileList";
            this.profileList.Size = new System.Drawing.Size(120, 173);
            this.profileList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile:";
            // 
            // profileTable
            // 
            this.profileTable.AllowUserToResizeColumns = false;
            this.profileTable.AllowUserToResizeRows = false;
            this.profileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Temperature,
            this.Duration});
            this.profileTable.Location = new System.Drawing.Point(163, 57);
            this.profileTable.Name = "profileTable";
            this.profileTable.RowHeadersVisible = false;
            this.profileTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.profileTable.Size = new System.Drawing.Size(216, 110);
            this.profileTable.TabIndex = 2;
            // 
            // Temperature
            // 
            this.Temperature.HeaderText = "Temperature";
            this.Temperature.MaxInputLength = 3;
            this.Temperature.Name = "Temperature";
            this.Temperature.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Temperature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration (sec)";
            this.Duration.Name = "Duration";
            this.Duration.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // profileNameEdit
            // 
            this.profileNameEdit.Location = new System.Drawing.Point(217, 31);
            this.profileNameEdit.Name = "profileNameEdit";
            this.profileNameEdit.Size = new System.Drawing.Size(81, 20);
            this.profileNameEdit.TabIndex = 3;
            // 
            // renameProfileButton
            // 
            this.renameProfileButton.Location = new System.Drawing.Point(304, 32);
            this.renameProfileButton.Name = "renameProfileButton";
            this.renameProfileButton.Size = new System.Drawing.Size(75, 19);
            this.renameProfileButton.TabIndex = 4;
            this.renameProfileButton.Text = "Rename";
            this.renameProfileButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Profile:";
            // 
            // addNewSaveProfileButton
            // 
            this.addNewSaveProfileButton.Location = new System.Drawing.Point(163, 181);
            this.addNewSaveProfileButton.Name = "addNewSaveProfileButton";
            this.addNewSaveProfileButton.Size = new System.Drawing.Size(121, 23);
            this.addNewSaveProfileButton.TabIndex = 6;
            this.addNewSaveProfileButton.Text = "Add New/Save Profile";
            this.addNewSaveProfileButton.UseVisualStyleBackColor = true;
            this.addNewSaveProfileButton.Click += new System.EventHandler(this.addNewSaveProfileButton_Click);
            // 
            // removeProfileButton
            // 
            this.removeProfileButton.Location = new System.Drawing.Point(290, 181);
            this.removeProfileButton.Name = "removeProfileButton";
            this.removeProfileButton.Size = new System.Drawing.Size(89, 23);
            this.removeProfileButton.TabIndex = 7;
            this.removeProfileButton.Text = "Remove Profile";
            this.removeProfileButton.UseVisualStyleBackColor = true;
            // 
            // ProfilesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 238);
            this.Controls.Add(this.removeProfileButton);
            this.Controls.Add(this.addNewSaveProfileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.renameProfileButton);
            this.Controls.Add(this.profileNameEdit);
            this.Controls.Add(this.profileTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProfilesDialog";
            this.Text = "Manage Profiles";
            ((System.ComponentModel.ISupportInitialize)(this.profileTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox profileList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView profileTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.TextBox profileNameEdit;
        private System.Windows.Forms.Button renameProfileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewSaveProfileButton;
        private System.Windows.Forms.Button removeProfileButton;
    }
}