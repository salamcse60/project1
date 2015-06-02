using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Information_App.BLL;
using Employee_Information_App.Model;

namespace Employee_Information_App
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
        }
        EmployeeManager anEmployeeManager = new EmployeeManager();

        //email unique check

        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();

            anEmployee.Name= nameTextBox.Text;
            anEmployee.Email = emailTextBox.Text;
            anEmployee.Address = addressTextBox.Text;
            anEmployee.Salary = decimal.Parse(salaryTextBox.Text);
            
            MessageBox.Show(anEmployeeManager.Save(anEmployee));
          
    }

    }
}
