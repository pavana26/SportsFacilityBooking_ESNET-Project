namespace SA46Team05A_Project.Forms
{
    partial class AppMainMenu
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
            this.CreateMember_Button = new System.Windows.Forms.Button();
            this.EditMember_Button = new System.Windows.Forms.Button();
            this.FacilityQueryForm_Button = new System.Windows.Forms.Button();
            this.BookingCancellationForm_Button = new System.Windows.Forms.Button();
            this.MemberQueryForm_Button = new System.Windows.Forms.Button();
            this.BookingForm_Button = new System.Windows.Forms.Button();
            this.MainMenu_Label = new System.Windows.Forms.Label();
            this.CreateFacilityForm_Button = new System.Windows.Forms.Button();
            this.BookingCountByDayChart_Button = new System.Windows.Forms.Button();
            this.TransactionReport_button = new System.Windows.Forms.Button();
            this.BookingCountByDayReport_Button = new System.Windows.Forms.Button();
            this.Facility_Label = new System.Windows.Forms.Label();
            this.Booking_Label = new System.Windows.Forms.Label();
            this.Member_Label = new System.Windows.Forms.Label();
            this.Report_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateMember_Button
            // 
            this.CreateMember_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMember_Button.Location = new System.Drawing.Point(135, 335);
            this.CreateMember_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateMember_Button.Name = "CreateMember_Button";
            this.CreateMember_Button.Size = new System.Drawing.Size(320, 40);
            this.CreateMember_Button.TabIndex = 0;
            this.CreateMember_Button.Text = "Add New Member";
            this.CreateMember_Button.UseVisualStyleBackColor = true;
            this.CreateMember_Button.Click += new System.EventHandler(this.Create_Member_Button_Click);
            // 
            // EditMember_Button
            // 
            this.EditMember_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMember_Button.Location = new System.Drawing.Point(135, 370);
            this.EditMember_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditMember_Button.Name = "EditMember_Button";
            this.EditMember_Button.Size = new System.Drawing.Size(320, 40);
            this.EditMember_Button.TabIndex = 0;
            this.EditMember_Button.Text = "Edit Member Details";
            this.EditMember_Button.UseVisualStyleBackColor = true;
            this.EditMember_Button.Click += new System.EventHandler(this.Edit_Member_Button_Click);
            // 
            // FacilityQueryForm_Button
            // 
            this.FacilityQueryForm_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityQueryForm_Button.Location = new System.Drawing.Point(145, 203);
            this.FacilityQueryForm_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FacilityQueryForm_Button.Name = "FacilityQueryForm_Button";
            this.FacilityQueryForm_Button.Size = new System.Drawing.Size(320, 40);
            this.FacilityQueryForm_Button.TabIndex = 0;
            this.FacilityQueryForm_Button.Text = "Edit Facility Status";
            this.FacilityQueryForm_Button.UseVisualStyleBackColor = true;
            this.FacilityQueryForm_Button.Click += new System.EventHandler(this.FacilityQueryForm_Button_Click);
            // 
            // BookingCancellationForm_Button
            // 
            this.BookingCancellationForm_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingCancellationForm_Button.Location = new System.Drawing.Point(744, 203);
            this.BookingCancellationForm_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookingCancellationForm_Button.Name = "BookingCancellationForm_Button";
            this.BookingCancellationForm_Button.Size = new System.Drawing.Size(320, 40);
            this.BookingCancellationForm_Button.TabIndex = 0;
            this.BookingCancellationForm_Button.Text = "Cancel Booking";
            this.BookingCancellationForm_Button.UseVisualStyleBackColor = true;
            this.BookingCancellationForm_Button.Click += new System.EventHandler(this.BookingCancellationForm_Button_Click);
            // 
            // MemberQueryForm_Button
            // 
            this.MemberQueryForm_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberQueryForm_Button.Location = new System.Drawing.Point(135, 408);
            this.MemberQueryForm_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemberQueryForm_Button.Name = "MemberQueryForm_Button";
            this.MemberQueryForm_Button.Size = new System.Drawing.Size(320, 40);
            this.MemberQueryForm_Button.TabIndex = 2;
            this.MemberQueryForm_Button.Text = "Search Member";
            this.MemberQueryForm_Button.UseVisualStyleBackColor = true;
            this.MemberQueryForm_Button.Click += new System.EventHandler(this.MemberQueryForm_Button_Click);
            // 
            // BookingForm_Button
            // 
            this.BookingForm_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingForm_Button.Location = new System.Drawing.Point(744, 167);
            this.BookingForm_Button.Name = "BookingForm_Button";
            this.BookingForm_Button.Size = new System.Drawing.Size(320, 40);
            this.BookingForm_Button.TabIndex = 3;
            this.BookingForm_Button.Text = "Make a booking";
            this.BookingForm_Button.UseVisualStyleBackColor = true;
            this.BookingForm_Button.Click += new System.EventHandler(this.BookingForm_Button_Click);
            // 
            // MainMenu_Label
            // 
            this.MainMenu_Label.AutoSize = true;
            this.MainMenu_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Label.Location = new System.Drawing.Point(387, 41);
            this.MainMenu_Label.Name = "MainMenu_Label";
            this.MainMenu_Label.Size = new System.Drawing.Size(455, 49);
            this.MainMenu_Label.TabIndex = 4;
            this.MainMenu_Label.Text = "Sports Facility Management";
            // 
            // CreateFacilityForm_Button
            // 
            this.CreateFacilityForm_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFacilityForm_Button.Location = new System.Drawing.Point(145, 167);
            this.CreateFacilityForm_Button.Name = "CreateFacilityForm_Button";
            this.CreateFacilityForm_Button.Size = new System.Drawing.Size(320, 40);
            this.CreateFacilityForm_Button.TabIndex = 5;
            this.CreateFacilityForm_Button.Text = "Create Facility";
            this.CreateFacilityForm_Button.UseVisualStyleBackColor = true;
            this.CreateFacilityForm_Button.Click += new System.EventHandler(this.CreateFacilityForm_Button_Click);
            // 
            // BookingCountByDayChart_Button
            // 
            this.BookingCountByDayChart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingCountByDayChart_Button.Location = new System.Drawing.Point(733, 333);
            this.BookingCountByDayChart_Button.Name = "BookingCountByDayChart_Button";
            this.BookingCountByDayChart_Button.Size = new System.Drawing.Size(320, 40);
            this.BookingCountByDayChart_Button.TabIndex = 6;
            this.BookingCountByDayChart_Button.Text = " Booking Count By Day Chart";
            this.BookingCountByDayChart_Button.UseVisualStyleBackColor = true;
            this.BookingCountByDayChart_Button.Click += new System.EventHandler(this.BookingCountByDayChart_Button_Click);
            // 
            // TransactionReport_button
            // 
            this.TransactionReport_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionReport_button.Location = new System.Drawing.Point(733, 406);
            this.TransactionReport_button.Name = "TransactionReport_button";
            this.TransactionReport_button.Size = new System.Drawing.Size(320, 40);
            this.TransactionReport_button.TabIndex = 7;
            this.TransactionReport_button.Text = "Transaction Report";
            this.TransactionReport_button.UseVisualStyleBackColor = true;
            this.TransactionReport_button.Click += new System.EventHandler(this.TransactionReport_Button_Click);
            // 
            // BookingCountByDayReport_Button
            // 
            this.BookingCountByDayReport_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingCountByDayReport_Button.Location = new System.Drawing.Point(733, 368);
            this.BookingCountByDayReport_Button.Name = "BookingCountByDayReport_Button";
            this.BookingCountByDayReport_Button.Size = new System.Drawing.Size(320, 40);
            this.BookingCountByDayReport_Button.TabIndex = 8;
            this.BookingCountByDayReport_Button.Text = " Booking Count By Day Report";
            this.BookingCountByDayReport_Button.UseVisualStyleBackColor = true;
            this.BookingCountByDayReport_Button.Click += new System.EventHandler(this.BookingCountByDayReport_Button_Click);
            // 
            // Facility_Label
            // 
            this.Facility_Label.AutoSize = true;
            this.Facility_Label.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facility_Label.Location = new System.Drawing.Point(241, 125);
            this.Facility_Label.Name = "Facility_Label";
            this.Facility_Label.Size = new System.Drawing.Size(115, 39);
            this.Facility_Label.TabIndex = 9;
            this.Facility_Label.Text = "Facility";
            // 
            // Booking_Label
            // 
            this.Booking_Label.AutoSize = true;
            this.Booking_Label.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Label.Location = new System.Drawing.Point(830, 125);
            this.Booking_Label.Name = "Booking_Label";
            this.Booking_Label.Size = new System.Drawing.Size(119, 39);
            this.Booking_Label.TabIndex = 10;
            this.Booking_Label.Text = "Booking";
            // 
            // Member_Label
            // 
            this.Member_Label.AutoSize = true;
            this.Member_Label.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Member_Label.Location = new System.Drawing.Point(231, 291);
            this.Member_Label.Name = "Member_Label";
            this.Member_Label.Size = new System.Drawing.Size(115, 39);
            this.Member_Label.TabIndex = 11;
            this.Member_Label.Text = "Member";
            // 
            // Report_Label
            // 
            this.Report_Label.AutoSize = true;
            this.Report_Label.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_Label.Location = new System.Drawing.Point(830, 291);
            this.Report_Label.Name = "Report_Label";
            this.Report_Label.Size = new System.Drawing.Size(100, 39);
            this.Report_Label.TabIndex = 12;
            this.Report_Label.Text = "Report";
            // 
            // AppMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 546);
            this.Controls.Add(this.Report_Label);
            this.Controls.Add(this.Member_Label);
            this.Controls.Add(this.Booking_Label);
            this.Controls.Add(this.Facility_Label);
            this.Controls.Add(this.BookingCountByDayReport_Button);
            this.Controls.Add(this.TransactionReport_button);
            this.Controls.Add(this.BookingCountByDayChart_Button);
            this.Controls.Add(this.CreateFacilityForm_Button);
            this.Controls.Add(this.MainMenu_Label);
            this.Controls.Add(this.BookingForm_Button);
            this.Controls.Add(this.MemberQueryForm_Button);
            this.Controls.Add(this.BookingCancellationForm_Button);
            this.Controls.Add(this.FacilityQueryForm_Button);
            this.Controls.Add(this.EditMember_Button);
            this.Controls.Add(this.CreateMember_Button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AppMainMenu";
            this.Text = "AppMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateMember_Button;
        private System.Windows.Forms.Button EditMember_Button;
        private System.Windows.Forms.Button FacilityQueryForm_Button;
        private System.Windows.Forms.Button BookingCancellationForm_Button;
        private System.Windows.Forms.Button MemberQueryForm_Button;
        private System.Windows.Forms.Button BookingForm_Button;
        private System.Windows.Forms.Label MainMenu_Label;
        private System.Windows.Forms.Button CreateFacilityForm_Button;
        private System.Windows.Forms.Button BookingCountByDayChart_Button;
        private System.Windows.Forms.Button TransactionReport_button;
        private System.Windows.Forms.Button BookingCountByDayReport_Button;
        private System.Windows.Forms.Label Facility_Label;
        private System.Windows.Forms.Label Booking_Label;
        private System.Windows.Forms.Label Member_Label;
        private System.Windows.Forms.Label Report_Label;
    }
}