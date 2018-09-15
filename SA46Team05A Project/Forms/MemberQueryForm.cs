using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BaseLibrary.Entities;
using BaseLibrary.ParentForms;

namespace SA46Team05A_Project.Forms
{
    public partial class MemberQueryForm : BaseForm
    {
        TextBox idTextBox;
        TextBox nameTextBox;
        SportsFacBookingEntities context;

        BindingSource searchBinding;

        public MemberQueryForm(Form caller): base(caller)
        {
            // Constructor used when calling form is the main menu
            InitializeComponent();
            context = new SportsFacBookingEntities();          

            // Prepare Search_DataGridView
            Search_DataGridView.AutoGenerateColumns = false;
            searchBinding = new BindingSource();
            RefreshLookupOutput();
            Search_DataGridView.DataSource = searchBinding;

            Edit_Member_Button.Show();
        }

        public MemberQueryForm(Form caller, TextBox id, TextBox name) : this(caller)
        {
            // Constructor used when calling form needs member details to be filled.
            idTextBox = id;
            nameTextBox = name;

            Edit_Member_Button.Hide();
            Ok_Button.Show();
        }

        // Refresh Search_DataGridView
        private void RefreshLookupOutput()
        {
            searchBinding.DataSource = context.Members.ToList();
        }

        // Event Handlers

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            string idSubStr = Member_ID_TextBox.Text;
            string nameSubStr = Member_Name_TextBox.Text;

            searchBinding.DataSource = context.Members.Where(x =>
                                        x.MemberName.Contains(nameSubStr)
                                        && x.MemberID.ToString().Contains(idSubStr)).ToList();

            Status.Text = String.Format("{0} results found.", searchBinding.Count);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Status.Text = "";

            if (!(Search_DataGridView.SelectedCells is null))
            {
                DataGridViewRow row = Search_DataGridView.Rows[Search_DataGridView.SelectedCells[0].RowIndex];
                idTextBox.Text = row.Cells["Member_ID_Column"].Value.ToString();
                nameTextBox.Text = row.Cells["Member_Name_Column"].Value.ToString();
                Dispose();
            }
            else
            {
                Status.Text = "Please select one customer, or press Cancel to return to the Loan form";
            }
        }

        private void Edit_Member_Button_Click(object sender, EventArgs e)
        {
            Status.Text = "";
            if (!(Search_DataGridView.SelectedCells is null))
            {
                DataGridViewRow row = Search_DataGridView.Rows[Search_DataGridView.SelectedCells[0].RowIndex];
                int memberID = (int)row.Cells["Member_ID_Column"].Value;
                MemberMaintenanceForm f = new MemberMaintenanceForm(this, memberID);
                f.Show();
                Hide();
            }
            else
            {
                Status.Text = "Please select one customer, or press Cancel to return to the Loan form";
            }
        }
    }
}
