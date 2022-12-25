// File:    Worker.cs
// Author:  ranalm
// Created: יום שני 12 מאי 2014 21:00:31
// Purpose: Definition of Class Worker

using System;
using System.Data.SqlClient;

namespace Project
{
    public class Employee
    {
        private int EmployeeId;
        private string EmployeeName;
        private int Seniority;
        private int Salary;
        private EmployeesTypes Type;
        private EmployeesStatuses status;
        private Employee CreatedBy;





        //private Title workerTitle;
        //public System.Collections.Generic.List<Order> orders;


        public Employee(int id, string name, int Seniority, int Salary, EmployeesTypes Type, EmployeesStatuses status, Employee CreatedBy, bool is_new)
        {
            this.EmployeeId = id;
            this.EmployeeName = name;
            this.Type = Type;
            this.Seniority = Seniority;
            this.Salary = Salary;
            this.Type = Type;
            this.status = status;
            this.CreatedBy = CreatedBy;
            if (is_new)
            {
                // this.create_worker();
                //Program.Employee.Add(this);

            }
        }

        public int getId()
        {
            return this.EmployeeId;
        }

        public void set_id(int id)
        {
            this.EmployeeId = id;
        }

        public void set_name(string name)
        {
            this.EmployeeName = name; ;
        }

        public int getSeniority()
        {
            return this.Seniority;
        }

        public void set_Seniority(int seniority)
        {
            this.Seniority = seniority; ;
        }

        public int getSalary()
        {
            return this.Salary;
        }

        public void set_Salary(int salary)
        {
            this.Salary = salary;
        }

        public EmployeesStatuses getStatus()
        {
            return this.status;
        }

        public void set_Status(EmployeesStatuses status)
        {
            this.status = status;
        }

        public EmployeesTypes getType()
        {
            return this.Type;
        }

        public void set_type(EmployeesTypes type)
        {
            this.Type = type; ;
        }

        public Employee getCreatedBy()
        {
            return this.CreatedBy;
        }

        public void set_CreatedBy(Employee createdBy)
        {
            this.CreatedBy = createdBy;
        }


    }
}
