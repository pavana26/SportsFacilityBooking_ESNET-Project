namespace SA46Team05A_Project.Forms
{
    partial class Facility_Query_Form
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
            this.FacilityQueryForm_FacilityName_Label = new System.Windows.Forms.Label();
            this.FacilityQuery_FacilityName_ComboBox = new System.Windows.Forms.ComboBox();
            this.FacilityQuery_Form_Next_Button = new System.Windows.Forms.Button();
            this.FacilityQueryForm_Title_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(344, 252);
            // 
            // FacilityQueryForm_FacilityName_Label
            // 
            this.FacilityQueryForm_FacilityName_Label.AutoSize = true;
            this.FacilityQueryForm_FacilityName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityQueryForm_FacilityName_Label.Location = new System.Drawing.Point(70, 97);
            this.FacilityQueryForm_FacilityName_Label.Name = "FacilityQueryForm_FacilityName_Label";
            this.FacilityQueryForm_FacilityName_Label.Size = new System.Drawing.Size(195, 32);
            this.FacilityQueryForm_FacilityName_Label.TabIndex = 0;
            this.FacilityQueryForm_FacilityName_Label.Text = "Facility Name:";
            // 
            // FacilityQuery_FacilityName_ComboBox
            // 
            this.FacilityQuery_FacilityName_ComboBox.AllowDrop = true;
            this.FacilityQuery_FacilityName_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityQuery_FacilityName_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityQuery_FacilityName_ComboBox.FormattingEnabled = true;
            this.FacilityQuery_FacilityName_ComboBox.ItemHeight = 32;
            this.FacilityQuery_FacilityName_ComboBox.Location = new System.Drawing.Point(318, 97);
            this.FacilityQuery_FacilityName_ComboBox.Name = "FacilityQuery_FacilityName_ComboBox";
            this.FacilityQuery_FacilityName_ComboBox.Size = new System.Drawing.Size(227, 40);
            this.FacilityQuery_FacilityName_ComboBox.TabIndex = 1;
            // 
            // FacilityQuery_Form_Next_Button
            // 
            this.FacilityQuery_Form_Next_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityQuery_Form_Next_Button.Location = new System.Drawing.Point(153, 252);
            this.FacilityQuery_Form_Next_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FacilityQuery_Form_Next_Button.Name = "FacilityQuery_Form_Next_Button";
            this.FacilityQuery_Form_Next_Button.Size = new System.Drawing.Size(112, 45);
            this.FacilityQuery_Form_Next_Button.TabIndex = 3;
            this.FacilityQuery_Form_Next_Button.Text = "Next";
            this.FacilityQuery_Form_Next_Button.UseVisualStyleBackColor = true;
            this.FacilityQuery_Form_Next_Button.Click += new System.EventHandler(this.FacilityQuery_Form_Next_Button_Click);
            // 
            // FacilityQueryForm_Title_Label
            // 
            this.FacilityQueryForm_Title_Label.AutoSize = true;
            this.FacilityQueryForm_Title_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityQueryForm_Title_Label.Location = new System.Drawing.Point(204, 30);
            this.FacilityQueryForm_Title_Label.Name = "FacilityQueryForm_Title_Label";
            this.FacilityQueryForm_Title_Label.Size = new System.Drawing.Size(252, 49);
            this.FacilityQueryForm_Title_Label.TabIndex = 4;
            this.FacilityQueryForm_Title_Label.Text = "Facility Query ";
            // 
            // Facility_Query_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 349);
            this.Controls.Add(this.FacilityQueryForm_Title_Label);
            this.Controls.Add(this.FacilityQuery_Form_Next_Button);
            this.Controls.Add(this.FacilityQuery_FacilityName_ComboBox);
            this.Controls.Add(this.FacilityQueryForm_FacilityName_Label);
            this.Name = "Facility_Query_Form";
            this.Text = "Facility Query Form";
            this.Controls.SetChildIndex(this.FacilityQueryForm_FacilityName_Label, 0);
            this.Controls.SetChildIndex(this.FacilityQuery_FacilityName_ComboBox, 0);
            this.Controls.SetChildIndex(this.FacilityQuery_Form_Next_Button, 0);
            this.Controls.SetChildIndex(this.FacilityQueryForm_Title_Label, 0);
            this.Controls.SetChildIndex(this.Back_Button, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FacilityQueryForm_FacilityName_Label;
        public System.Windows.Forms.ComboBox FacilityQuery_FacilityName_ComboBox;
        protected System.Windows.Forms.Button FacilityQuery_Form_Next_Button;
        private System.Windows.Forms.Label FacilityQueryForm_Title_Label;
    }
}