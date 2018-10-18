using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Employee emp = new Employee() { EmpAddress = new Address() };
        Employee empCopied;

        StringBuilder sb = new StringBuilder();

        private void btnShollowCopy_Click(object sender, EventArgs e)
        {
            empCopied = (Employee)this.emp.ShallowCopy();
            Refresh();
        }

        private void btnDeepCopy_Click(object sender, EventArgs e)
        {
            empCopied = (Employee)this.emp.DeepCopy();
            Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblOutput.ResetText();
            emp.ID = txtEmpId.Text;
            emp.Name = txtEmpName.Text;
            emp.EmpAddress.Country = txtCountry.Text;
            emp.EmpAddress.DoorNumber = int.Parse(txtDoorNo.Text);
            emp.EmpAddress.StreetNumber = int.Parse(txtStreet.Text);
            emp.EmpAddress.Zipcode = int.Parse(txtZip.Text);
            MessageBox.Show("Updated");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            sb.Clear();
            sb.AppendLine("---------------------------------");
            sb.AppendLine(string.Format("Main Employee : {0} ",
                this.emp.ToString()));
            sb.AppendLine();
            sb.AppendLine(string.Format("Copied Employee : {0} ",
                empCopied.ToString()));
            sb.AppendLine("-----------------------------------");
            sb.AppendLine(txtOutput.Text);

            txtOutput.Text = sb.ToString();
        }
 
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.ResetText();
        }
    }
}
