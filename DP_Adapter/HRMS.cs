using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Adapter
{
    class HRMS
    {
        private List<string> RetrieveEmployees()
        {
           return new List<string>() {"Employee1", "Employee2" };
        }

        public void DisplayEmployees()
        {
            foreach(string emp in this.RetrieveEmployees())
            {
                Console.WriteLine(emp);
            }
        }
    }
}
