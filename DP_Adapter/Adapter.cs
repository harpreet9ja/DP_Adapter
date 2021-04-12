using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Adapter
{
    class Adapter : IAdapter
    {
        HRMS ThirdPartySystem = new HRMS();
        public void ListEmployees()
        {
            ThirdPartySystem.DisplayEmployees();
        }
    }
}
