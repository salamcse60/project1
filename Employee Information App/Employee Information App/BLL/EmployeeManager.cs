using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Information_App.DAL;
using Employee_Information_App.Model;

namespace Employee_Information_App.BLL
{
    internal class EmployeeManager
    {
        private EmployeeGateway anEmployeeGateway = new EmployeeGateway();

        public string Save(Employee anEmployee)
        {
            if (anEmployeeGateway.isEmailExist(anEmployee.Email) == null)
            {
                if (anEmployeeGateway.save(anEmployee)>0)
                {
                    return "Saved Successfully";
                }
                else
                {
                    return "Save Failed";
                }
            }
            else
            {
                return "Email Must Be Unique";
            }
           
        }

    }


}
