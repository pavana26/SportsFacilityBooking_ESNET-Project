using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseLibrary.ParentForms
{
    public partial class BaseForm : Form
    {
        protected Form caller;

        public BaseForm()
        {
            InitializeComponent();
        }

        public BaseForm(Form caller): this()
        {
            this.caller = caller;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            caller.Show();
            Dispose();
        }
    }
}
