using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Logic
{
    public class Employee_Service
    {
        private Employee_DAO em_DAO = new Employee_DAO();
        public List<Employee> GetAllEmployees()
        {
            try
            {
                return em_DAO.DB_GetAllEmployees();
            }
            catch
            {
                //add fake employees to the list in case database connection is not working;
                List<Employee> employees = new List<Employee>();
                Employee em1 = new Employee();
                Employee em2 = new Employee();
                employees.Add(em1);
                employees.Add(em2);
                return employees;
            }
        }

        public Employee GetByID(int id)
        {
            try
            {
                return em_DAO.DB_GetEmployeeByID(id);
            }
            catch
            {
                //return a fake employee information in case database connection is not working;
                return new Employee();
            }
        }

        public Employee GetByUsername(string username)
        {
            try
            {
                return em_DAO.DB_GetByUsername(username);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Employee();
            }
        }
    }
}
