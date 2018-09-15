namespace SA46Team05A_Project.Forms
{
    partial class BookingForm
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
            this.Title_Label = new System.Windows.Forms.Label();
            this.Facility_Name_Label = new System.Windows.Forms.Label();
            this.Facility_ComboBox = new System.Windows.Forms.ComboBox();
            this.Base_DataGridView = new System.Windows.Forms.DataGridView();
            this.Date_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timeslot_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Booked_Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Available_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tomorrow_CheckBox = new System.Windows.Forms.CheckBox();
            this.Today_CheckBox = new System.Windows.Forms.CheckBox();
            this.Booking_Button = new System.Windows.Forms.Button();
            this.Member_Name_Label = new System.Windows.Forms.Label();
            this.Member_ID_Label = new System.Windows.Forms.Label();
            this.Member_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Member_ID_TextBox = new System.Windows.Forms.TextBox();
            this.Member_Query_Button = new System.Windows.Forms.Button();
            this.Booked_Label = new System.Windows.Forms.Label();
            this.Not_Available_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Base_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(408, 576);
            this.Back_Button.Size = new System.Drawing.Size(75, 30);
            // 
            // Title_Label
            // 
            this.Title_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Title_Label.Location = new System.Drawing.Point(200, 32);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(304, 43);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "Facility Booking";
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Facility_Name_Label
            // 
            this.Facility_Name_Label.AutoSize = true;
            this.Facility_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Facility_Name_Label.Location = new System.Drawing.Point(168, 155);
            this.Facility_Name_Label.Name = "Facility_Name_Label";
            this.Facility_Name_Label.Size = new System.Drawing.Size(92, 17);
            this.Facility_Name_Label.TabIndex = 7;
            this.Facility_Name_Label.Text = "Facility Name";
            // 
            // Facility_ComboBox
            // 
            this.Facility_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Facility_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Facility_ComboBox.FormattingEnabled = true;
            this.Facility_ComboBox.Location = new System.Drawing.Point(288, 152);
            this.Facility_ComboBox.Name = "Facility_ComboBox";
            this.Facility_ComboBox.Size = new System.Drawing.Size(240, 24);
            this.Facility_ComboBox.TabIndex = 9;
            this.Facility_ComboBox.SelectedValueChanged += new System.EventHandler(this.FilterValues_Changed);
            // 
            // Base_DataGridView
            // 
            this.Base_DataGridView.AllowUserToAddRows = false;
            this.Base_DataGridView.AllowUserToDeleteRows = false;
            this.Base_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Base_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Base_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_Column,
            this.Timeslot_Column,
            this.Member_Name_Column,
            this.Booked_Column,
            this.Available_Column,
            this.Member_ID_Column});
            this.Base_DataGridView.Location = new System.Drawing.Point(40, 232);
            this.Base_DataGridView.Name = "Base_DataGridView";
            this.Base_DataGridView.Size = new System.Drawing.Size(632, 272);
            this.Base_DataGridView.TabIndex = 10;
            this.Base_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Base_DataGridView_CellClick);
            // 
            // Date_Column
            // 
            this.Date_Column.DataPropertyName = "AvailDate";
            this.Date_Column.HeaderText = "Date";
            this.Date_Column.Name = "Date_Column";
            this.Date_Column.ReadOnly = true;
            // 
            // Timeslot_Column
            // 
            this.Timeslot_Column.DataPropertyName = "Timeslot";
            this.Timeslot_Column.HeaderText = "Timeslot";
            this.Timeslot_Column.Name = "Timeslot_Column";
            this.Timeslot_Column.ReadOnly = true;
            // 
            // Member_Name_Column
            // 
            this.Member_Name_Column.HeaderText = "Member Name";
            this.Member_Name_Column.Name = "Member_Name_Column";
            this.Member_Name_Column.ReadOnly = true;
            // 
            // Booked_Column
            // 
            this.Booked_Column.DataPropertyName = "Booked";
            this.Booked_Column.HeaderText = "Booked";
            this.Booked_Column.Name = "Booked_Column";
            this.Booked_Column.ReadOnly = true;
            this.Booked_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Booked_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Available_Column
            // 
            this.Available_Column.DataPropertyName = "Available";
            this.Available_Column.HeaderText = "Available";
            this.Available_Column.Name = "Available_Column";
            this.Available_Column.ReadOnly = true;
            this.Available_Column.Visible = false;
            // 
            // Member_ID_Column
            // 
            this.Member_ID_Column.DataPropertyName = "MemberID";
            this.Member_ID_Column.HeaderText = "Member ID";
            this.Member_ID_Column.Name = "Member_ID_Column";
            this.Member_ID_Column.ReadOnly = true;
            this.Member_ID_Column.Visible = false;
            // 
            // Tomorrow_CheckBox
            // 
            this.Tomorrow_CheckBox.AutoSize = true;
            this.Tomorrow_CheckBox.Checked = true;
            this.Tomorrow_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Tomorrow_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tomorrow_CheckBox.Location = new System.Drawing.Point(372, 192);
            this.Tomorrow_CheckBox.Name = "Tomorrow_CheckBox";
            this.Tomorrow_CheckBox.Size = new System.Drawing.Size(90, 21);
            this.Tomorrow_CheckBox.TabIndex = 11;
            this.Tomorrow_CheckBox.Text = "Tomorrow";
            this.Tomorrow_CheckBox.UseVisualStyleBackColor = true;
            this.Tomorrow_CheckBox.CheckedChanged += new System.EventHandler(this.FilterValues_Changed);
            // 
            // Today_CheckBox
            // 
            this.Today_CheckBox.AutoSize = true;
            this.Today_CheckBox.Checked = true;
            this.Today_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Today_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Today_CheckBox.Location = new System.Drawing.Point(252, 192);
            this.Today_CheckBox.Name = "Today_CheckBox";
            this.Today_CheckBox.Size = new System.Drawing.Size(67, 21);
            this.Today_CheckBox.TabIndex = 12;
            this.Today_CheckBox.Text = "Today";
            this.Today_CheckBox.UseVisualStyleBackColor = true;
            this.Today_CheckBox.CheckedChanged += new System.EventHandler(this.FilterValues_Changed);
            // 
            // Booking_Button
            // 
            this.Booking_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Booking_Button.Location = new System.Drawing.Point(184, 576);
            this.Booking_Button.Name = "Booking_Button";
            this.Booking_Button.Size = new System.Drawing.Size(147, 30);
            this.Booking_Button.TabIndex = 13;
            this.Booking_Button.Text = "Make Booking";
            this.Booking_Button.UseVisualStyleBackColor = true;
            this.Booking_Button.Click += new System.EventHandler(this.Booking_Button_Click);
            // 
            // Member_Name_Label
            // 
            this.Member_Name_Label.AutoSize = true;
            this.Member_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Member_Name_Label.Location = new System.Drawing.Point(168, 124);
            this.Member_Name_Label.Name = "Member_Name_Label";
            this.Member_Name_Label.Size = new System.Drawing.Size(100, 17);
            this.Member_Name_Label.TabIndex = 7;
            this.Member_Name_Label.Text = "Member Name";
            // 
            // Member_ID_Label
            // 
            this.Member_ID_Label.AutoSize = true;
            this.Member_ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Member_ID_Label.Location = new System.Drawing.Point(168, 94);
            this.Member_ID_Label.Name = "Member_ID_Label";
            this.Member_ID_Label.Size = new System.Drawing.Size(76, 17);
            this.Member_ID_Label.TabIndex = 7;
            this.Member_ID_Label.Text = "Member ID";
            // 
            // Member_Name_TextBox
            // 
            this.Member_Name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Member_Name_TextBox.Location = new System.Drawing.Point(288, 120);
            this.Member_Name_TextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.Member_Name_TextBox.Name = "Member_Name_TextBox";
            this.Member_Name_TextBox.Size = new System.Drawing.Size(240, 23);
            this.Member_Name_TextBox.TabIndex = 14;
            // 
            // Member_ID_TextBox
            // 
            this.Member_ID_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Member_ID_TextBox.Location = new System.Drawing.Point(288, 88);
            this.Member_ID_TextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.Member_ID_TextBox.Name = "Member_ID_TextBox";
            this.Member_ID_TextBox.Size = new System.Drawing.Size(88, 23);
            this.Member_ID_TextBox.TabIndex = 14;
            // 
            // Member_Query_Button
            // 
            this.Member_Query_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Member_Query_Button.Location = new System.Drawing.Point(384, 85);
            this.Member_Query_Button.Name = "Member_Query_Button";
            this.Member_Query_Button.Size = new System.Drawing.Size(56, 30);
            this.Member_Query_Button.TabIndex = 13;
            this.Member_Query_Button.Text = "...";
            this.Member_Query_Button.UseVisualStyleBackColor = true;
            this.Member_Query_Button.Click += new System.EventHandler(this.Member_Query_Button_Click);
            // 
            // Booked_Label
            // 
            this.Booked_Label.AutoSize = true;
            this.Booked_Label.BackColor = System.Drawing.Color.Pink;
            this.Booked_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booked_Label.Location = new System.Drawing.Point(264, 512);
            this.Booked_Label.Name = "Booked_Label";
            this.Booked_Label.Size = new System.Drawing.Size(56, 16);
            this.Booked_Label.TabIndex = 15;
            this.Booked_Label.Text = "Booked";
            // 
            // Not_Available_Label
            // 
            this.Not_Available_Label.AutoSize = true;
            this.Not_Available_Label.BackColor = System.Drawing.Color.DarkGray;
            this.Not_Available_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Not_Available_Label.Location = new System.Drawing.Point(384, 512);
            this.Not_Available_Label.Name = "Not_Available_Label";
            this.Not_Available_Label.Size = new System.Drawing.Size(89, 16);
            this.Not_Available_Label.TabIndex = 15;
            this.Not_Available_Label.Text = "Not Available";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 654);
            this.Controls.Add(this.Not_Available_Label);
            this.Controls.Add(this.Booked_Label);
            this.Controls.Add(this.Member_ID_TextBox);
            this.Controls.Add(this.Member_Name_TextBox);
            this.Controls.Add(this.Member_Query_Button);
            this.Controls.Add(this.Booking_Button);
            this.Controls.Add(this.Tomorrow_CheckBox);
            this.Controls.Add(this.Today_CheckBox);
            this.Controls.Add(this.Base_DataGridView);
            this.Controls.Add(this.Facility_ComboBox);
            this.Controls.Add(this.Member_ID_Label);
            this.Controls.Add(this.Member_Name_Label);
            this.Controls.Add(this.Facility_Name_Label);
            this.Controls.Add(this.Title_Label);
            this.Name = "BookingForm";
            this.Text = "Facility Booking";
            this.Load += new System.EventHandler(this.FilterValues_Changed);
            this.Controls.SetChildIndex(this.Title_Label, 0);
            this.Controls.SetChildIndex(this.Back_Button, 0);
            this.Controls.SetChildIndex(this.Facility_Name_Label, 0);
            this.Controls.SetChildIndex(this.Member_Name_Label, 0);
            this.Controls.SetChildIndex(this.Member_ID_Label, 0);
            this.Controls.SetChildIndex(this.Facility_ComboBox, 0);
            this.Controls.SetChildIndex(this.Base_DataGridView, 0);
            this.Controls.SetChildIndex(this.Today_CheckBox, 0);
            this.Controls.SetChildIndex(this.Tomorrow_CheckBox, 0);
            this.Controls.SetChildIndex(this.Booking_Button, 0);
            this.Controls.SetChildIndex(this.Member_Query_Button, 0);
            this.Controls.SetChildIndex(this.Member_Name_TextBox, 0);
            this.Controls.SetChildIndex(this.Member_ID_TextBox, 0);
            this.Controls.SetChildIndex(this.Booked_Label, 0);
            this.Controls.SetChildIndex(this.Not_Available_Label, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Base_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label Title_Label;
        protected System.Windows.Forms.Label Facility_Name_Label;
        protected System.Windows.Forms.ComboBox Facility_ComboBox;
        protected System.Windows.Forms.DataGridView Base_DataGridView;
        protected System.Windows.Forms.CheckBox Tomorrow_CheckBox;
        protected System.Windows.Forms.CheckBox Today_CheckBox;
        private System.Windows.Forms.Button Booking_Button;
        protected System.Windows.Forms.Label Member_Name_Label;
        protected System.Windows.Forms.Label Member_ID_Label;
        public System.Windows.Forms.TextBox Member_Name_TextBox;
        public System.Windows.Forms.TextBox Member_ID_TextBox;
        private System.Windows.Forms.Button Member_Query_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timeslot_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_Name_Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Booked_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_ID_Column;
        private System.Windows.Forms.Label Booked_Label;
        private System.Windows.Forms.Label Not_Available_Label;
    }
}

