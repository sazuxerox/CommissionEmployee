using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class CommissionEmployee : object
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private decimal grossSales;           //gross weekly sales
        private decimal commissionRate;       //commission percentage


        //five-parameter constructor
        public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rates)
        {
            // implicit call to object constructor occurs here 
            firstName = first; 
            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
            grossSales = sales;              //validate gross sales via property 
            commissionRate = rates;          //validate commission rates via property
        }//end five-parameter CommissionEmployee constructor


        //read-only property that only get and set commision employee's firstname
        public string FirstName 
        {
            get 
            {
                return firstName;
            }//end get
        }//end property FirstName


        //read-only property that only get and set commision employee's lasttname
        public string LastName 
        {
            get 
            {
                return lastName;
            }//end get
        }//end property LastName

        //read-only property that only get and set commision employee's social security number
        public string SocialSecurityNumber 
        {
            get 
            {
                return socialSecurityNumber;
            }//end get
        }//end property SocialSecurityNumber


        //property that only get and set commision employee's gross sales
        public decimal GrossSales 
        {
            get 
            {
                return grossSales;
            }//end get

            set 
            {
                if (value >= 0)
                    grossSales = value;

                else
                    throw new ArgumentOutOfRangeException(
                     "GrossSales", value, "GrossSales must be >= 0");
            }//end set
        }//end property GrossSales


        //property that only get and set commision employee's commission rates
        public decimal CommissionRate 
        {
            get 
            {
                return commissionRate;
            }//end get

            set 
            {
                if (value > 0 && value < 1)
                    commissionRate = value;
                else
                    throw new ArgumentOutOfRangeException(
                     "CommissionRates", value, "CommissionRates must be  > 0 && < 1");
            }//end set
        }//end property CommissionRate
    
       
        //calculate employee's earning
        public decimal Earning() 
        {
            return commissionRate * grossSales;
        }//end method Earnings()

        //return string representation of commision object
        public override string ToString()
        {
            return string.Format(
            "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}", 
            "commission employee", FirstName, LastName, 
            "social security number", SocialSecurityNumber, 
            "gross sales", GrossSales, "commission rate", CommissionRate );
        }//end method ToString()

      
    }//end class CommissionEmployee
}
