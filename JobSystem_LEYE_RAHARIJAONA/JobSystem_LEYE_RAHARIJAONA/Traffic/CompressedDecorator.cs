using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSystem_LEYE_RAHARIJAONA.Traffic
{
     class CompressedDecorator : FlowDecorator
    {
        public CompressedDecorator(DataSource data) : base(data)
        {
          
        }

        public void Compress(DataSource data)
        {
            Console.WriteLine("******** ENCRYPTED DATA ******" + "\n");
            data.readData();
        }
    }
}
