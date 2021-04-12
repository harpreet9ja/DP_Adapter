using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Adapter
{
    class Client
    {
        IAdapter Adapter  = null;
        public Client(IAdapter target)
        {
            Adapter = target;
        }

        public void ShowEmployeeList()
        {
            this.Adapter.ListEmployees();
        }
    }
}
