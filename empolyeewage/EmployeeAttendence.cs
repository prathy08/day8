﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empolyeewage
{
    public class EmployeeAttendence
    {
        public void checkEmpolyeeAttendence()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Empolyee is abscent");
            }
        }
        public int calculate()
        {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_WORKING_DAYS = 20;
            const int MAX_HRS_IN_MONTH = 10;
            int emphrs = 0;
            int totalemphrs = 0;
            int totalworkingdays = 0;
            while (totalemphrs <= MAX_HRS_IN_MONTH && totalworkingdays < NUM_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                totalemphrs += emphrs;


                Console.WriteLine("Days:" + totalworkingdays + "Emphrs:" + emphrs);

            }
            int totalempwages = totalemphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalempwages);
            return totalempwages;
        }
       


    }
}

        
        
    


