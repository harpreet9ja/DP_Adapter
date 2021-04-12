using System;

namespace DP_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new Adapter());
            client.ShowEmployeeList();
        }
    }
}
