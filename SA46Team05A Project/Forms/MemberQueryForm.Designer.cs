namespace SA46Team05A_Project.Forms
{
    partial class MemberQueryForm
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
            this.LookUpCustomerNameLabel = new System.Windows.Forms.Label();
            this.Member_ID_Label = new System.Windows.Forms.Label();
            this.Search_DataGridView = new System.Windows.Forms.DataGridView();
            this.Member_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_ID_TextBox = new System.Windows.Forms.TextBox();
            this.Member_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Ok_Button = new System.Windows.Forms.Button();
            this.Edit_Member_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Search_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(424, 376);
            // 
            // LookUpCustomerNameLabel
            // 
            this.LookUpCustomerNameLabel.AutoSize = true;
            this.LookUpCustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LookUpCustomerNameLabel.Location = new System.Drawing.Point(224, 99);
            this.LookUpCustomerNameLabel.MaximumSize = new System.Drawing.Size(0, 30);
            this.LookUpCustomerNameLabel.Name = "LookUpCustomerNameLabel";
            this.LookUpCustomerNameLabel.Size = new System.Drawing.Size(100, 17);
            this.LookUpCustomerNameLabel.TabIndex = 5;
            this.LookUpCustomerNameLabel.Text = "Member Name";
            // 
            // Member_ID_Label
            // 
            this.Member_ID_Label.AutoSize = true;
            this.Member_ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Member_ID_Label.Location = new System.Drawing.Point(224, 67);
            this.Member_ID_Label.MaximumSize = new System.Drawing.Size(0, 30);
            this.Member_ID_Label.Name = "Member_ID_Label";
            this.Member_ID_Label.Size = new System.Drawing.Size(76, 17);
            this.Member_ID_Label.TabIndex = 6;
            this.Member_ID_Label.Text = "Member ID";
            // 
            // Search_DataGridView
            // 
            this.Search_DataGridView.AllowUserToAddRows = false;
            this.Search_DataGridView.AllowUserToDeleteRows = false;
            this.Search_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Search_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Search_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Member_ID_Column,
            this.Member_Name_Column,
            this.Address_Column,
            this.Phone_Number_Column});
            this.Search_DataGridView.Location = new System.Drawing.Point(40, 152);
            this.Search_DataGridView.MultiSelect = false;
            this.Search_DataGridView.Name = "Search_DataGridView";
            this.Search_DataGridView.ReadOnly = true;
            this.Search_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Search_DataGridView.Size = new System.Drawing.Size(696, 200);
            this.Search_DataGridView.TabIndex = 4;
            // 
            // Member_ID_Column
            // 
            this.Member_ID_Column.DataPropertyName = "MemberID";
            this.Member_ID_Column.HeaderText = "Member ID";
            this.Member_ID_Column.Name = "Member_ID_Column";
            this.Member_ID_Column.ReadOnly = true;
            // 
            // Member_Name_Column
            // 
            this.Member_Name_Column.DataPropertyName = "MemberName";
            this.Member_Name_Column.HeaderText = "Member Name";
            this.Member_Name_Column.Name = "Member_Name_Column";
            this.Member_Name_Column.ReadOnly = true;
            // 
            // Address_Column
            // 
            this.Address_Column.DataPropertyName = "Address";
            this.Address_Column.HeaderText = "Address";
            this.Address_Column.Name = "Address_Column";
            this.Address_Column.ReadOnly = true;
            // 
            // Phone_Number_Column
            // 
            this.Phone_Number_Column.DataPropertyName = "PhoneNumber";
            this.Phone_Number_Column.HeaderText = "Phone No.";
            this.Phone_Number_Column.Name = "Phone_Number_Column";
            this.Phone_Number_Column.ReadOnly = true;
            // 
            // Member_ID_TextBox
            // 
            this.Member_ID_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Member_ID_TextBox.Location = new System.Drawing.Point(336, 66);
            this.Member_ID_TextBox.MaximumSize = new System.Drawing.Size(100, 30);
            this.Member_ID_TextBox.MinimumSize = new System.Drawing.Size(10, 30);
            this.Member_ID_TextBox.Name = "Member_ID_TextBox";
            this.Member_ID_TextBox.Size = new System.Drawing.Size(56, 23);
            this.Member_ID_TextBox.TabIndex = 7;
            this.Member_ID_TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_KeyUp);
            // 
            // Member_Name_TextBox
            // 
            this.Member_Name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Member_Name_TextBox.Location = new System.Drawing.Point(336, 97);
            this.Member_Name_TextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.Member_Name_TextBox.Name = "Member_Name_TextBox";
            this.Member_Name_TextBox.Size = new System.Drawing.Size(192, 23);
            this.Member_Name_TextBox.TabIndex = 7;
            this.Member_Name_TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_KeyUp);
            // 
            // Title_Label
            // 
            this.Title_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Title_Label.Location = new System.Drawing.Point(232, 16);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(304, 43);
            this.Title_Label.TabIndex = 8;
            this.Title_Label.Text = "Member Search";
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ok_Button
            // 
            this.Ok_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Ok_Button.Location = new System.Drawing.Point(272, 376);
            this.Ok_Button.MinimumSize = new System.Drawing.Size(0, 30);
            this.Ok_Button.Name = "Ok_Button";
            this.Ok_Button.Size = new System.Drawing.Size(75, 30);
            this.Ok_Button.TabIndex = 9;
            this.Ok_Button.Text = "Ok";
            this.Ok_Button.UseVisualStyleBackColor = true;
            this.Ok_Button.Visible = false;
            this.Ok_Button.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Edit_Member_Button
            // 
            this.Edit_Member_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Edit_Member_Button.Location = new System.Drawing.Point(224, 376);
            this.Edit_Member_Button.MinimumSize = new System.Drawing.Size(0, 30);
            this.Edit_Member_Button.Name = "Edit_Member_Button";
            this.Edit_Member_Button.Size = new System.Drawing.Size(144, 30);
            this.Edit_Member_Button.TabIndex = 10;
            this.Edit_Member_Button.Text = "Edit Member Details";
            this.Edit_Member_Button.UseVisualStyleBackColor = true;
            this.Edit_Member_Button.Visible = false;
            this.Edit_Member_Button.Click += new System.EventHandler(this.Edit_Member_Button_Click);
            // 
            // MemberQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(776, 444);
            this.Controls.Add(this.Ok_Button);
            this.Controls.Add(this.Title_Label);
            this.Controls.Add(this.Member_Name_TextBox);
            this.Controls.Add(this.Member_ID_TextBox);
            this.Controls.Add(this.LookUpCustomerNameLabel);
            this.Controls.Add(this.Member_ID_Label);
            this.Controls.Add(this.Search_DataGridView);
            this.Controls.Add(this.Edit_Member_Button);
            this.Name = "MemberQueryForm";
            this.Text = "Member Search";
            this.Controls.SetChildIndex(this.Edit_Member_Button, 0);
            this.Controls.SetChildIndex(this.Back_Button, 0);
            this.Controls.SetChildIndex(this.Search_DataGridView, 0);
            this.Controls.SetChildIndex(this.Member_ID_Label, 0);
            this.Controls.SetChildIndex(this.LookUpCustomerNameLabel, 0);
            this.Controls.SetChildIndex(this.Member_ID_TextBox, 0);
            this.Controls.SetChildIndex(this.Member_Name_TextBox, 0);
            this.Controls.SetChildIndex(this.Title_Label, 0);
            this.Controls.SetChildIndex(this.Ok_Button, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Search_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LookUpCustomerNameLabel;
        private System.Windows.Forms.Label Member_ID_Label;
        private System.Windows.Forms.DataGridView Search_DataGridView;
        private System.Windows.Forms.TextBox Member_ID_TextBox;
        private System.Windows.Forms.TextBox Member_Name_TextBox;
        protected System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number_Column;
        private System.Windows.Forms.Button Ok_Button;
        private System.Windows.Forms.Button Edit_Member_Button;
    }
}
