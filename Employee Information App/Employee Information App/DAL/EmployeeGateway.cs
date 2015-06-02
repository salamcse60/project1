using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Employee_Information_App.Model;

namespace Employee_Information_App.DAL
{
    class EmployeeGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["EmployeeConString"].ConnectionString;
        
        public int save(Employee anEmployee)
        {
            SqlConnection aSqlConnection = new SqlConnection(connectionString);

            string query = "INSERT INTO tbl_employee VALUES ('" + anEmployee.Name + "', '" + anEmployee.Email + "', '" + anEmployee.Address + "', '" + anEmployee.Salary + "')";

            SqlCommand aSqlCommand = new SqlCommand(query,aSqlConnection);

            aSqlConnection.Open();

            int rowAffected = aSqlCommand.ExecuteNonQuery();

            aSqlConnection.Close();

            return rowAffected;

        }

        public Employee isEmailExist(string email)
        {
            SqlConnection aSqlConnection = new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_employee WHERE email = '" + email + "'";

            aSqlConnection.Open();

            SqlCommand aSqlCommand = new SqlCommand(query,aSqlConnection);

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            Employee anEmployee = new Employee();


            if (aSqlDataReader.HasRows)
            {
                aSqlDataReader.Read();
                anEmployee.Email = aSqlDataReader["email"].ToString();
                aSqlDataReader.Close();
                aSqlConnection.Close();

                return anEmployee;
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();
            return null;

        }

            
            
        }

    }
