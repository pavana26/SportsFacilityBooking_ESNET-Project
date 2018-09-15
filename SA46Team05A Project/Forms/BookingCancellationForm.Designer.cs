namespace SA46Team05A_Project.Forms
{
    partial class BookingCancellationForm
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
            this.Transaction_DataGridView = new System.Windows.Forms.DataGridView();
            this.Member_ID_TextBox = new System.Windows.Forms.TextBox();
            this.Member_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Cancel_Booking_Button = new System.Windows.Forms.Button();
            this.Member_Query_Button = new System.Windows.Forms.Button();
            this.Find_Transactions_Button = new System.Windows.Forms.Button();
            this.Transaction_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facility_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Booked_Date_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Time_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Time_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel_Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Transaction_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(408, 402);
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
            // Transaction_DataGridView
            // 
            this.Transaction_DataGridView.AllowUserToAddRows = false;
            this.Transaction_DataGridView.AllowUserToDeleteRows = false;
            this.Transaction_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Transaction_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transaction_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaction_ID_Column,
            this.Facility_Name_Column,
            this.Booked_Date_Column,
            this.Start_Time_Column,
            this.End_Time_Column,
            this.Cancel_Column});
            this.Transaction_DataGridView.Location = new System.Drawing.Point(40, 178);
            this.Transaction_DataGridView.MultiSelect = false;
            this.Transaction_DataGridView.Name = "Transaction_DataGridView";
            this.Transaction_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Transaction_DataGridView.Size = new System.Drawing.Size(696, 200);
            this.Transaction_DataGridView.TabIndex = 4;
            this.Transaction_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Transaction_DataGridView_CellClick);
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
            // 
            // Member_Name_TextBox
            // 
            this.Member_Name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Member_Name_TextBox.Location = new System.Drawing.Point(336, 97);
            this.Member_Name_TextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.Member_Name_TextBox.Name = "Member_Name_TextBox";
            this.Member_Name_TextBox.Size = new System.Drawing.Size(192, 23);
            this.Member_Name_TextBox.TabIndex = 7;
            // 
            // Title_Label
            // 
            this.Title_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Title_Label.Location = new System.Drawing.Point(232, 16);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(304, 43);
            this.Title_Label.TabIndex = 8;
            this.Title_Label.Text = "Booking Cancellation";
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cancel_Booking_Button
            // 
            this.Cancel_Booking_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cancel_Booking_Button.Location = new System.Drawing.Point(224, 402);
            this.Cancel_Booking_Button.MinimumSize = new System.Drawing.Size(0, 30);
            this.Cancel_Booking_Button.Name = "Cancel_Booking_Button";
            this.Cancel_Booking_Button.Size = new System.Drawing.Size(123, 30);
            this.Cancel_Booking_Button.TabIndex = 9;
            this.Cancel_Booking_Button.Text = "Cancel Booking";
            this.Cancel_Booking_Button.UseVisualStyleBackColor = true;
            this.Cancel_Booking_Button.Click += new System.EventHandler(this.Cancel_Booking_Click);
            // 
            // Member_Query_Button
            // 
            this.Member_Query_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Member_Query_Button.Location = new System.Drawing.Point(402, 63);
            this.Member_Query_Button.MinimumSize = new System.Drawing.Size(0, 30);
            this.Member_Query_Button.Name = "Member_Query_Button";
            this.Member_Query_Button.Size = new System.Drawing.Size(48, 30);
            this.Member_Query_Button.TabIndex = 10;
            this.Member_Query_Button.Text = "...";
            this.Member_Query_Button.UseVisualStyleBackColor = true;
            this.Member_Query_Button.Click += new System.EventHandler(this.Member_Query_Button_Click);
            // 
            // Find_Transactions_Button
            // 
            this.Find_Transactions_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Find_Transactions_Button.Location = new System.Drawing.Point(312, 136);
            this.Find_Transactions_Button.MinimumSize = new System.Drawing.Size(0, 30);
            this.Find_Transactions_Button.Name = "Find_Transactions_Button";
            this.Find_Transactions_Button.Size = new System.Drawing.Size(112, 30);
            this.Find_Transactions_Button.TabIndex = 9;
            this.Find_Transactions_Button.Text = "Find Bookings";
            this.Find_Transactions_Button.UseVisualStyleBackColor = true;
            this.Find_Transactions_Button.Click += new System.EventHandler(this.Find_Bookings_Click);
            // 
            // Transaction_ID_Column
            // 
            this.Transaction_ID_Column.DataPropertyName = "TransactionID";
            this.Transaction_ID_Column.HeaderText = "Transaction ID";
            this.Transaction_ID_Column.Name = "Transaction_ID_Column";
            // 
            // Facility_Name_Column
            // 
            this.Facility_Name_Column.DataPropertyName = "FacilityName";
            this.Facility_Name_Column.HeaderText = "Facility Name";
            this.Facility_Name_Column.Name = "Facility_Name_Column";
            // 
            // Booked_Date_Column
            // 
            this.Booked_Date_Column.DataPropertyName = "BookedDate";
            this.Booked_Date_Column.HeaderText = "Date";
            this.Booked_Date_Column.Name = "Booked_Date_Column";
            // 
            // Start_Time_Column
            // 
            this.Start_Time_Column.DataPropertyName = "StartTime";
            this.Start_Time_Column.HeaderText = "Start Time";
            this.Start_Time_Column.Name = "Start_Time_Column";
            // 
            // End_Time_Column
            // 
            this.End_Time_Column.DataPropertyName = "EndTime";
            this.End_Time_Column.HeaderText = "End Time";
            this.End_Time_Column.Name = "End_Time_Column";
            // 
            // Cancel_Column
            // 
            this.Cancel_Column.DataPropertyName = "Cancelled";
            this.Cancel_Column.HeaderText = "Cancel?";
            this.Cancel_Column.Name = "Cancel_Column";
            this.Cancel_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cancel_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BookingCancellationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(776, 502);
            this.Controls.Add(this.Member_Query_Button);
            this.Controls.Add(this.Find_Transactions_Button);
            this.Controls.Add(this.Cancel_Booking_Button);
            this.Controls.Add(this.Title_Label);
            this.Controls.Add(this.Member_Name_TextBox);
            this.Controls.Add(this.Member_ID_TextBox);
            this.Controls.Add(this.LookUpCustomerNameLabel);
            this.Controls.Add(this.Member_ID_Label);
            this.Controls.Add(this.Transaction_DataGridView);
            this.Name = "BookingCancellationForm";
            this.Text = "Booking Cancellation";
            this.Controls.SetChildIndex(this.Back_Button, 0);
            this.Controls.SetChildIndex(this.Transaction_DataGridView, 0);
            this.Controls.SetChildIndex(this.Member_ID_Label, 0);
            this.Controls.SetChildIndex(this.LookUpCustomerNameLabel, 0);
            this.Controls.SetChildIndex(this.Member_ID_TextBox, 0);
            this.Controls.SetChildIndex(this.Member_Name_TextBox, 0);
            this.Controls.SetChildIndex(this.Title_Label, 0);
            this.Controls.SetChildIndex(this.Cancel_Booking_Button, 0);
            this.Controls.SetChildIndex(this.Find_Transactions_Button, 0);
            this.Controls.SetChildIndex(this.Member_Query_Button, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Transaction_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LookUpCustomerNameLabel;
        private System.Windows.Forms.Label Member_ID_Label;
        private System.Windows.Forms.DataGridView Transaction_DataGridView;
        private System.Windows.Forms.TextBox Member_ID_TextBox;
        private System.Windows.Forms.TextBox Member_Name_TextBox;
        protected System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Button Cancel_Booking_Button;
        private System.Windows.Forms.Button Member_Query_Button;
        private System.Windows.Forms.Button Find_Transactions_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facility_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Booked_Date_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Time_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Time_Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Cancel_Column;
    }
}
