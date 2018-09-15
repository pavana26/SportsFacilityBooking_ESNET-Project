namespace SA46Team05A_Project.Forms
{
    partial class FacilityCreateForm
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
            this.Create_Facilities_Label = new System.Windows.Forms.Label();
            this.FacilityID_Label = new System.Windows.Forms.Label();
            this.FacilityID_TextBox = new System.Windows.Forms.TextBox();
            this.FacilityName_Label = new System.Windows.Forms.Label();
            this.FacilityName_TextBox = new System.Windows.Forms.TextBox();
            this.Create_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.Location = new System.Drawing.Point(380, 250);
            // 
            // Create_Facilities_Label
            // 
            this.Create_Facilities_Label.AutoSize = true;
            this.Create_Facilities_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Facilities_Label.Location = new System.Drawing.Point(204, 35);
            this.Create_Facilities_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Create_Facilities_Label.Name = "Create_Facilities_Label";
            this.Create_Facilities_Label.Size = new System.Drawing.Size(251, 33);
            this.Create_Facilities_Label.TabIndex = 1;
            this.Create_Facilities_Label.Text = "Create Facilities Form";
            // 
            // FacilityID_Label
            // 
            this.FacilityID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityID_Label.Location = new System.Drawing.Point(144, 118);
            this.FacilityID_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacilityID_Label.Name = "FacilityID_Label";
            this.FacilityID_Label.Size = new System.Drawing.Size(107, 24);
            this.FacilityID_Label.TabIndex = 2;
            this.FacilityID_Label.Text = "Facility ID";
            // 
            // FacilityID_TextBox
            // 
            this.FacilityID_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityID_TextBox.Location = new System.Drawing.Point(308, 114);
            this.FacilityID_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FacilityID_TextBox.MaxLength = 2;
            this.FacilityID_TextBox.Name = "FacilityID_TextBox";
            this.FacilityID_TextBox.Size = new System.Drawing.Size(175, 29);
            this.FacilityID_TextBox.TabIndex = 3;
            // 
            // FacilityName_Label
            // 
            this.FacilityName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityName_Label.Location = new System.Drawing.Point(144, 181);
            this.FacilityName_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacilityName_Label.Name = "FacilityName_Label";
            this.FacilityName_Label.Size = new System.Drawing.Size(124, 39);
            this.FacilityName_Label.TabIndex = 4;
            this.FacilityName_Label.Text = "Facility Name";
            // 
            // FacilityName_TextBox
            // 
            this.FacilityName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityName_TextBox.Location = new System.Drawing.Point(308, 176);
            this.FacilityName_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FacilityName_TextBox.Name = "FacilityName_TextBox";
            this.FacilityName_TextBox.Size = new System.Drawing.Size(175, 29);
            this.FacilityName_TextBox.TabIndex = 5;
            // 
            // Create_Button
            // 
            this.Create_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Button.Location = new System.Drawing.Point(210, 250);
            this.Create_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(75, 29);
            this.Create_Button.TabIndex = 6;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // FacilityCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 316);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.FacilityName_TextBox);
            this.Controls.Add(this.FacilityName_Label);
            this.Controls.Add(this.FacilityID_TextBox);
            this.Controls.Add(this.FacilityID_Label);
            this.Controls.Add(this.Create_Facilities_Label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FacilityCreateForm";
            this.Text = "Create Facilities Form";
            this.Controls.SetChildIndex(this.Create_Facilities_Label, 0);
            this.Controls.SetChildIndex(this.FacilityID_Label, 0);
            this.Controls.SetChildIndex(this.FacilityID_TextBox, 0);
            this.Controls.SetChildIndex(this.FacilityName_Label, 0);
            this.Controls.SetChildIndex(this.FacilityName_TextBox, 0);
            this.Controls.SetChildIndex(this.Create_Button, 0);
            this.Controls.SetChildIndex(this.Back_Button, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Create_Facilities_Label;
        private System.Windows.Forms.Label FacilityID_Label;
        private System.Windows.Forms.TextBox FacilityID_TextBox;
        private System.Windows.Forms.Label FacilityName_Label;
        private System.Windows.Forms.TextBox FacilityName_TextBox;
        private System.Windows.Forms.Button Create_Button;
    }
}

