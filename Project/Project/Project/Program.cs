using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Project
{
    static class Program
    {
        public static List<Employee> Employee { get; private set; }
        public static List<Customer> Customer { get; private set; }
        public static Employee employeeTemp;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //רשימות
        //public static System.Collections.Generic.List<Employee> Employee;
        //public static System.Collections.Generic.List<Order> Orders;
        [STAThread]

        //שיטה שמחפשת עובד ברשימה לפי תעודת זהות
       

        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_workers();//אתחול הרשימה של העובדים
            init_customers();
        }

        public static Employee seekEmployee(int id)
        {
            foreach (Employee e in Employee)
            {
                if (e.getId() == id)
                    return e;
            }
            return null;
        }

        public static void init_workers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.getEmployees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Employee = new List<Employee>();

            while (rdr.Read())
            {
                EmployeesTypes Type = (EmployeesTypes)Enum.Parse(typeof(EmployeesTypes), rdr.GetValue(4).ToString().Replace(" ", ""));
                EmployeesStatuses Status = (EmployeesStatuses)Enum.Parse(typeof(EmployeesStatuses), rdr.GetValue(5).ToString().Replace(" ", ""));

                employeeTemp = seekEmployee(Int32.Parse(rdr.GetValue(6).ToString()));
                Employee w = new Employee(Int32.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), Int32.Parse(rdr.GetValue(2).ToString()), Int32.Parse(rdr.GetValue(3).ToString()), Type, Status, employeeTemp, false);
                Employee.Add(w);
            }
        }

        public static void init_customers()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.getCustomers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Customer = new List<Customer>();

            while (rdr.Read())
            {
                isSpecialCountry special = (isSpecialCountry)Enum.Parse(typeof(isSpecialCountry), rdr.GetValue(8).ToString().Replace(" ", ""));
                isActive active = (isActive)Enum.Parse(typeof(isActive), rdr.GetValue(7).ToString().Replace(" ", ""));
                employeeTemp = seekEmployee(Int32.Parse(rdr.GetValue(9).ToString()));
                Customer c = new Customer(Int32.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), Int32.Parse(rdr.GetValue(6).ToString()), active, special, employeeTemp, false);
                Customer.Add(c);
            }
        }

       

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();//אתחול כל הרשימות
            //Application.Run(new Form1());
        }
    }
}
