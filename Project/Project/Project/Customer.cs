using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Customer
    {
        private int CustomerId;
        private string Email;
        private string Name;
        private string ContactName;
        private string ContactPhone;
        private string password;
        private int Importance;
        private isActive Active;
        private isSpecialCountry specialCountry;
        private Employee CreatedBy;


        public Customer (int ID, string email, string name, string contactName, string phone, string password, int importance, isActive active, isSpecialCountry special, Employee emp, bool is_new)
        {
            this.CustomerId = ID;
            this.Email = email;
            this.Name = name;
            this.ContactName = contactName;
            this.password = password;
            this.Importance = importance;
            this.Active = active;
            this.specialCountry = special;
            this.CreatedBy = emp;
            if (is_new) { }
        }


        public int getId()
        {
            return this.CustomerId;
        }

        public void set_id(int id)
        {
            this.CustomerId = id;
        }

        public void set_email(string email)
        {
            this.Email = email ;
        }

        public string getEmail()
        {
            return this.Email;
        }

        public void set_Name(string name)
        {
            this.Name = name ;
        }

        public string getName()
        {
            return this.Name;
        }

        public void set_ContactName(string ContactName)
        {
            this.ContactName = ContactName;
        }

        public string getContactName()
        {
            return this.ContactName;
        }

        public void set_ContactPhone(string ContactPhone)
        {
            this.ContactPhone = ContactPhone;
        }

        public string getContactPhone()
        {
            return this.ContactPhone;
        }

        public void set_password(string password)
        {
            this.password = password ;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void set_Importance(int importance)
        {
            this.Importance = importance;
        }

        public int getImportance()
        {
            return this.Importance;
        }

        public void set_Active(isActive active)
        {
            this.Active = active;
        }

        public isActive getActive()
        {
            return this.Active;
        }

        public void set_specialCountry(isSpecialCountry specialCountry)
        {
            this.specialCountry = specialCountry;
        }

        public isSpecialCountry getSpecialCountry()
        {
            return this.specialCountry;
        }

        public void set_CreatedBy(Employee CreatedBy)
        {
            this.CreatedBy = CreatedBy;
        }

        public Employee getCreatedBy()
        {
            return this.CreatedBy;
        }
    }
}
}