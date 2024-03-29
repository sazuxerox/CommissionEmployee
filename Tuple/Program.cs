﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {// instantiate CommissionEmployee object
             var employee = new CommissionEmployee( "Sue", "Jones", "222-22-2222", 10000.00M, .06M );


           // display commission-employee data
           Console.WriteLine( "Employee information obtained by properties and methods: \n" );
           Console.WriteLine( "First name is {0}",  employee.FirstName);
           Console.WriteLine( "Last name is {0}",  employee.LastName);
           Console.WriteLine( "Social security number is {0}", employee.SocialSecurityNumber);
           Console.WriteLine( "Gross sales are {0:C}",  employee.GrossSales);
           Console.WriteLine( "Commission rate is {0:F2}", employee.CommissionRate);
           Console.WriteLine( "Earnings are {0:C}",  employee.Earning());
          
            employee.GrossSales = 5000.00M; // set gross sales 
            employee.CommissionRate = .1M; // set commission rate
           
            Console.WriteLine( "\n{0}:\n\n{1}", "Updated employee information obtained by ToString", employee );
             Console.WriteLine( "earnings: {0:C}", employee.Earning()); 
        }
    }
}


