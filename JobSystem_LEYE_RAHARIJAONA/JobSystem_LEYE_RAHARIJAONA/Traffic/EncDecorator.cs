using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSystem_LEYE_RAHARIJAONA.Traffic
{
     class EncDecorator : FlowDecorator
    {
        public EncDecorator(DataSource data) : base(data)
        {
            
        }

        public void Encrypt( DataSource data)
        {
            Console.WriteLine("******** ENCRYPTED DATA ******" + "\n");
            data.readData();
        }
    }
}
