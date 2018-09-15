namespace SA46Team05A_Project.Forms
{
    partial class Facility_Edit_Form
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
            this.FacilityEdit_Title_Label = new System.Windows.Forms.Label();
            this.FacilityEditForm_NotInUse_Label = new System.Windows.Forms.Label();
            this.Not_In_Use_Today_CheckBox = new System.Windows.Forms.CheckBox();
            this.Not_In_Use_Tmr_CheckBox = new System.Windows.Forms.CheckBox();
            this.FacilityEditForm_Next_Button = new System.Windows.Forms.Button();
            this.FacilityEditForm_FacilityName_Label = new System.Windows.Forms.Label();
            this.FacilityEditForm_Auto_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(263, 203);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // FacilityEdit_Title_Label
            // 
            this.FacilityEdit_Title_Label.AutoSize = true;
            this.FacilityEdit_Title_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityEdit_Title_Label.Location = new System.Drawing.Point(119, 23);
            this.FacilityEdit_Title_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacilityEdit_Title_Label.Name = "FacilityEdit_Title_Label";
            this.FacilityEdit_Title_Label.Size = new System.Drawing.Size(218, 33);
            this.FacilityEdit_Title_Label.TabIndex = 0;
            this.FacilityEdit_Title_Label.Text = "Facility Edit Form";
            // 
            // FacilityEditForm_NotInUse_Label
            // 
            this.FacilityEditForm_NotInUse_Label.AutoSize = true;
            this.FacilityEditForm_NotInUse_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityEditForm_NotInUse_Label.Location = new System.Drawing.Point(111, 103);
            this.FacilityEditForm_NotInUse_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacilityEditForm_NotInUse_Label.Name = "FacilityEditForm_NotInUse_Label";
            this.FacilityEditForm_NotInUse_Label.Size = new System.Drawing.Size(115, 17);
            this.FacilityEditForm_NotInUse_Label.TabIndex = 3;
            this.FacilityEditForm_NotInUse_Label.Text = "Not available for:";
            // 
            // Not_In_Use_Today_CheckBox
            // 
            this.Not_In_Use_Today_CheckBox.AutoSize = true;
            this.Not_In_Use_Today_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Not_In_Use_Today_CheckBox.Location = new System.Drawing.Point(181, 127);
            this.Not_In_Use_Today_CheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Not_In_Use_Today_CheckBox.Name = "Not_In_Use_Today_CheckBox";
            this.Not_In_Use_Today_CheckBox.Size = new System.Drawing.Size(67, 21);
            this.Not_In_Use_Today_CheckBox.TabIndex = 4;
            this.Not_In_Use_Today_CheckBox.Text = "Today";
            this.Not_In_Use_Today_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Not_In_Use_Tmr_CheckBox
            // 
            this.Not_In_Use_Tmr_CheckBox.AutoSize = true;
            this.Not_In_Use_Tmr_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Not_In_Use_Tmr_CheckBox.Location = new System.Drawing.Point(181, 158);
            this.Not_In_Use_Tmr_CheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Not_In_Use_Tmr_CheckBox.Name = "Not_In_Use_Tmr_CheckBox";
            this.Not_In_Use_Tmr_CheckBox.Size = new System.Drawing.Size(90, 21);
            this.Not_In_Use_Tmr_CheckBox.TabIndex = 5;
            this.Not_In_Use_Tmr_CheckBox.Text = "Tomorrow";
            this.Not_In_Use_Tmr_CheckBox.UseVisualStyleBackColor = true;
            // 
            // FacilityEditForm_Next_Button
            // 
            this.FacilityEditForm_Next_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityEditForm_Next_Button.Location = new System.Drawing.Point(114, 203);
            this.FacilityEditForm_Next_Button.Name = "FacilityEditForm_Next_Button";
            this.FacilityEditForm_Next_Button.Size = new System.Drawing.Size(75, 29);
            this.FacilityEditForm_Next_Button.TabIndex = 6;
            this.FacilityEditForm_Next_Button.Text = "Next";
            this.FacilityEditForm_Next_Button.UseVisualStyleBackColor = true;
            this.FacilityEditForm_Next_Button.Click += new System.EventHandler(this.FacilityEditForm_Confirm_Button_Click);
            // 
            // FacilityEditForm_FacilityName_Label
            // 
            this.FacilityEditForm_FacilityName_Label.AutoSize = true;
            this.FacilityEditForm_FacilityName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityEditForm_FacilityName_Label.Location = new System.Drawing.Point(111, 72);
            this.FacilityEditForm_FacilityName_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacilityEditForm_FacilityName_Label.Name = "FacilityEditForm_FacilityName_Label";
            this.FacilityEditForm_FacilityName_Label.Size = new System.Drawing.Size(96, 17);
            this.FacilityEditForm_FacilityName_Label.TabIndex = 7;
            this.FacilityEditForm_FacilityName_Label.Text = "Facility Name:";
            // 
            // FacilityEditForm_Auto_Label
            // 
            this.FacilityEditForm_Auto_Label.AutoSize = true;
            this.FacilityEditForm_Auto_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FacilityEditForm_Auto_Label.Location = new System.Drawing.Point(210, 72);
            this.FacilityEditForm_Auto_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacilityEditForm_Auto_Label.Name = "FacilityEditForm_Auto_Label";
            this.FacilityEditForm_Auto_Label.Size = new System.Drawing.Size(46, 17);
            this.FacilityEditForm_Auto_Label.TabIndex = 8;
            this.FacilityEditForm_Auto_Label.Text = "label1";
            // 
            // Facility_Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(459, 268);
            this.Controls.Add(this.FacilityEditForm_Auto_Label);
            this.Controls.Add(this.FacilityEditForm_FacilityName_Label);
            this.Controls.Add(this.FacilityEditForm_Next_Button);
            this.Controls.Add(this.Not_In_Use_Tmr_CheckBox);
            this.Controls.Add(this.Not_In_Use_Today_CheckBox);
            this.Controls.Add(this.FacilityEditForm_NotInUse_Label);
            this.Controls.Add(this.FacilityEdit_Title_Label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Facility_Edit_Form";
            this.Text = "Facility_Edit_Form";
            this.Controls.SetChildIndex(this.FacilityEdit_Title_Label, 0);
            this.Controls.SetChildIndex(this.FacilityEditForm_NotInUse_Label, 0);
            this.Controls.SetChildIndex(this.Not_In_Use_Today_CheckBox, 0);
            this.Controls.SetChildIndex(this.Not_In_Use_Tmr_CheckBox, 0);
            this.Controls.SetChildIndex(this.FacilityEditForm_Next_Button, 0);
            this.Controls.SetChildIndex(this.Back_Button, 0);
            this.Controls.SetChildIndex(this.FacilityEditForm_FacilityName_Label, 0);
            this.Controls.SetChildIndex(this.FacilityEditForm_Auto_Label, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FacilityEdit_Title_Label;
      
        private System.Windows.Forms.Label FacilityEditForm_NotInUse_Label;
        private System.Windows.Forms.CheckBox Not_In_Use_Today_CheckBox;
        private System.Windows.Forms.CheckBox Not_In_Use_Tmr_CheckBox;
        protected System.Windows.Forms.Button FacilityEditForm_Next_Button;
        private System.Windows.Forms.Label FacilityEditForm_FacilityName_Label;
        private System.Windows.Forms.Label FacilityEditForm_Auto_Label;
    }
}