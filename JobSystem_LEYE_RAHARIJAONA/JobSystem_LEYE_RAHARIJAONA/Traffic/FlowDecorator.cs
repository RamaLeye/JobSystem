using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSystem_LEYE_RAHARIJAONA.Traffic
{
    class FlowDecorator : DataSource
    {
        private DataSource data { get; set; }

        public FlowDecorator(DataSource data)
        {
            this.data = data;
        }

        public void readData()
        {
            throw new NotImplementedException();
        }

        public void writeData()
        {
            throw new NotImplementedException();
        }

       
    }
}
