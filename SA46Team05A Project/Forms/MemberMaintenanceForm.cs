using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLibrary.ParentForms;
using BaseLibrary.Entities;
using System.Globalization;

namespace SA46Team05A_Project.Forms
{
    public partial class MemberMaintenanceForm : BaseForm
    {
        SportsFacBookingEntities context;
        List<Member> mList;
        Member member;
        bool create;


        public MemberMaintenanceForm(Form caller) : base(caller)
        {
            // Constructor for create mode
            InitializeComponent();
            member = new Member();
            context = new SportsFacBookingEntities();
            create = true;
            BirthDay_Date_TextBox.Hide();
            BirthDay_Month_TextBox.Hide();
            Birthday_year_Textbox.Hide();
            Title_TextBox.Hide();
            Extend_ExpiryDate_Button.Hide();
            GetJoinDate();
            GetExpiryDate();

            JoinDate_TextBox.ReadOnly = true;
            ExpiryDate_TextBox.ReadOnly = true;

            // Fill birth year combobox
            for (int i = DateTime.Today.Year - 18; i > DateTime.Today.Year - 100; i--)
            {
                BirthDate_Year_Combobox.Items.Add(i);
            }
        }

        public MemberMaintenanceForm(Form caller, int memberID) : this(caller)
        {
            // Constructor for edit mode

            member = context.Members.First(x => x.MemberID == memberID);
            create = false;

            Create_Membership_Label.Text = "Edit Member's Details";

            MemberName_TextBox.ReadOnly = true;
            JoinDate_TextBox.ReadOnly = true;
            ExpiryDate_TextBox.ReadOnly = true;
            Title_TextBox.ReadOnly = true;
            Birthday_year_Textbox.ReadOnly = true;
            BirthDay_Month_TextBox.ReadOnly = true;
            BirthDay_Date_TextBox.ReadOnly = true;

            Title_ComboBox.Hide();
            BirthDate_Date_Combobox.Hide();
            BirthDate_Month_Combobox.Hide();
            BirthDate_Year_Combobox.Hide();            
            Reset_Button.Hide();

            BirthDay_Date_TextBox.Show();
            BirthDay_Month_TextBox.Show();
            Birthday_year_Textbox.Show();
            Title_TextBox.Show();
            Extend_ExpiryDate_Button.Show();

            Create_Button.Text = "Save";

            //Fill Member's Details
            Title_TextBox.Text = member.Salutation.ToUpper();
            Title_ComboBox.Text = member.Salutation.ToUpper();
            MemberName_TextBox.Text = member.MemberName;
            Address_TextBox.Text = member.Address;
            Email_TextBox.Text = member.Email;
            Emergency_Contact_Name_TextBox.Text = member.EmergencyContactName;
            Emergency_Contact_Number_TextBox.Text = member.EmergencyContactPhone;
            PhoneNumber_TextBox.Text = member.PhoneNumber;
            if (Title_TextBox.Text == "MR")
            {
                Male_RadioButton.Checked = true;
            }
            else
            {
                Female_RadioButton.Checked = true;
            }

            BirthDay_Date_TextBox.Text = member.Birthday.Day.ToString();
            BirthDate_Date_Combobox.Text = member.Birthday.Day.ToString();

            BirthDay_Month_TextBox.Text = member.Birthday.Month.ToString();
            BirthDate_Month_Combobox.Text = member.Birthday.Month.ToString();

            Birthday_year_Textbox.Text = member.Birthday.Year.ToString();
            BirthDate_Year_Combobox.Text = member.Birthday.Year.ToString();

            JoinDate_TextBox.Text = member.JoinDate.Date.ToString("dd/MM/yyyy");
            ExpiryDate_TextBox.Text = member.ExpiryDate.Date.ToString("dd/MM/yyyy");
        }

        // Helper Functions
        public string GetBirthdayString()
        {
            string day, month, year;
            day = BirthDate_Date_Combobox.Text;
            month = BirthDate_Month_Combobox.Text;
            year = BirthDate_Year_Combobox.Text;
            return String.Format("{0}/{1}/{2}", day, month, year);        

        }

        public DateTime GetJoinDate()
        {

            DateTime join = DateTime.Today;
            string trimdate = (join.ToString("dd/MM/yyyy"));

            JoinDate_TextBox.Text = trimdate;
            return join;
        }

        public DateTime GetExpiryDate()
        {
            string expiryyear;
            DateTime expyears = DateTime.Today;
            expyears = expyears.AddYears(2);
            expiryyear = Convert.ToString(expyears);
            expiryyear = (expyears.ToString("dd/MM/yyyy"));
            ExpiryDate_TextBox.Text = expiryyear;
            return expyears;
        }

        public string GetGender()
        {
            string value = "";
            bool rb = Male_RadioButton.Checked;

            if (rb)
                value = "M"; //Male_RadioButton.Text;
            else
                value = "F"; // Female_RadioButton.Text;

            return value;
        }

        public string GetPhoneNumber(string phoneTextBox)
        {
            int n;

            if (phoneTextBox.Length != 8)
            {
                MessageBox.Show("Please enter the eight digit phone Number");
                phoneTextBox = "";
            }
            else
            {
                bool isNumeric = int.TryParse(phoneTextBox, out n);

                if (isNumeric == false)
                {
                    MessageBox.Show("Please enter the integer numbers");
                    phoneTextBox = "";
                }
                else
                {
                    string s = phoneTextBox;
                    string str = s.Substring(0, 1);
                    int num = Convert.ToInt32(str);
                    if ((num != 9) && (num != 8))
                    {
                        MessageBox.Show("The first digit of Phone Number should be 9");
                        phoneTextBox = "";
                    }
                }
            }

            return phoneTextBox;
        }


        public string GetEmailID()
        {
            if (Email_TextBox.Text != "")
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(Email_TextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter valid EmailID");
                    Email_TextBox.Text = "";
                }
            }

            return Email_TextBox.Text;
        }

        // Event Handlers
        private void Create_Button_Click(object sender, EventArgs e)
        {
            mList = context.Members.ToList();

            if (Title_ComboBox.Text == "")
            {
                MessageBox.Show("Please Enter the Title");
            }
            else if (MemberName_TextBox.Text == "")
            {
                MessageBox.Show("Please Enter the MemberName");
            }
            else if (PhoneNumber_TextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Phone Number");
            }
            else if (Emergency_Contact_Name_TextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Emergency Contact Name");
            }
            else if (Emergency_Contact_Number_TextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Emergency Contact Number");
            }
            else if (BirthDate_Date_Combobox.Text == "")
            {
                MessageBox.Show("Please Enter the Birth date");
            }
            else if (BirthDate_Month_Combobox.Text == "")
            {
                MessageBox.Show("Please Enter the Birth Month");
            }
            else if (BirthDate_Year_Combobox.Text == "")
            {
                MessageBox.Show("Please Enter the Birth Year");
            }
            else if (!DateTime.TryParse(GetBirthdayString(), out DateTime x))
            {
                MessageBox.Show("Please enter a valid date for birthday");
            }
            else if (Address_TextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Address");
            }
            else if ((Male_RadioButton.Checked == false) && (Female_RadioButton.Checked == false))
            {
                MessageBox.Show("Please select the gender");
            }
            else if (PhoneNumber_TextBox.Text == Emergency_Contact_Number_TextBox.Text)
            {
                MessageBox.Show("Phone Number and Emergency Contact Number should be different");

            }
            else
            {
                member.Salutation = Title_ComboBox.Text;
                member.MemberName = MemberName_TextBox.Text;
                member.Birthday = DateTime.Parse(GetBirthdayString());
                member.Sex = GetGender();
                member.PhoneNumber = GetPhoneNumber(PhoneNumber_TextBox.Text);
                member.Address = Address_TextBox.Text;
                member.Email = GetEmailID();
                member.EmergencyContactName = Emergency_Contact_Name_TextBox.Text;
                member.EmergencyContactPhone = GetPhoneNumber(Emergency_Contact_Number_TextBox.Text);
                member.JoinDate = DateTime.Parse(JoinDate_TextBox.Text);
                member.ExpiryDate = DateTime.Parse(ExpiryDate_TextBox.Text);
                
                if (create)
                {
                    mList.Add(member);
                    context.Members.Add(member);
                    context.SaveChanges();
                    MessageBox.Show("Member Created successfully");
                   string print= String.Format("Member ID is : {0}", member.MemberID);                    
                    MessageBox.Show(print);
                }
                else
                {
                    context.SaveChanges();
                    MessageBox.Show("Member details updated sucessfully");
                }

                Dispose();
            }
        }

        private void Title_ComboBox_TextChanged(object sender, EventArgs e)
        {
            if (Title_ComboBox.Text == "MR")
            {
                Female_RadioButton.Enabled = false;
                Male_RadioButton.Enabled = true;
                Male_RadioButton.Checked = true;
            }
            else
            {
                Female_RadioButton.Enabled = true;
                Male_RadioButton.Enabled = false;
                Female_RadioButton.Checked = true;
            }
        }

        private void PhoneNumber_TextBox_Leave(object sender, EventArgs e)
        {
            string phone = GetPhoneNumber(PhoneNumber_TextBox.Text);
            if (phone == "")
            {
                PhoneNumber_TextBox.Text = "";
            }
        }

        private void Emergency_Contact_Number_TextBox_Leave(object sender, EventArgs e)
        {
            string phone = GetPhoneNumber(Emergency_Contact_Number_TextBox.Text);
            if (phone == "")
            {
                Emergency_Contact_Number_TextBox.Text = "";
            }

        }

        private void Email_TextBox_Leave(object sender, EventArgs e)
        {
            GetEmailID();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Title_ComboBox.Text = "";
            MemberName_TextBox.Text = "";
            BirthDate_Date_Combobox.Text = "";
            BirthDate_Month_Combobox.Text = "";
            BirthDate_Year_Combobox.Text = "";
            Male_RadioButton.Checked = false;
            Female_RadioButton.Checked = false;
            Email_TextBox.Text = "";
            PhoneNumber_TextBox.Text = "";
            Emergency_Contact_Name_TextBox.Text = "";
            Emergency_Contact_Number_TextBox.Text = "";
            Address_TextBox.Text = "";
        }

        private void Extend_ExpiryDate_Button_Click(object sender, EventArgs e)
        {
            if (DateTime.Today < member.ExpiryDate)
                member.ExpiryDate = member.ExpiryDate.AddYears(2);
            else
            {
                member.ExpiryDate = DateTime.Today.AddYears(2);
            }
            if (DateTime.Today > member.JoinDate)
            {
                member.JoinDate = DateTime.Today;
            }
            else
            {
                member.JoinDate = member.JoinDate;
            }
            JoinDate_TextBox.Text = member.JoinDate.ToString("dd/MM/yyyy");
            ExpiryDate_TextBox.Text = member.ExpiryDate.ToString("dd/MM/yyyy");
            Extend_ExpiryDate_Button.Enabled = false;

        }

        private void Birthday_SelectedValueChanged(object sender, EventArgs e)
        {
            if (BirthDate_Date_Combobox.Text != "" 
                && BirthDate_Month_Combobox.Text != ""
                && BirthDate_Year_Combobox.Text != "")
            {
                if (!DateTime.TryParseExact(GetBirthdayString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime x))
                {
                    MessageBox.Show("Please enter a valid date for birthday");
                }
            }
        }
    }
}