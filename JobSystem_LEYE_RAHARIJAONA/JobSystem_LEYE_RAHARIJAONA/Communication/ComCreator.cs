using JobSystem_LEYE_RAHARIJAONA.Tasks;
using JobSystem_LEYE_RAHARIJAONA.Traffic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSystem_LEYE_RAHARIJAONA.Communication
{
    class ComCreator : Communications
    {

        private int numThreads;

        /** Comment faire une liste d'objets de classe template ? **/
        /** Liste de passage uniquement : taches à passer à Executor , supprimées dés it's done **/
        private List<Command> tasks;

        private DataSource dataToTraffic;

        public ComCreator( int numThreads, DataSource dataToTraffic)
        {
            this.numThreads = numThreads;
            this.dataToTraffic = dataToTraffic;
            tasks = new List<Command>();
        }

        
        void Communications.Communicate()
        {
            Console.WriteLine(" Creator de mode de communication " + "\n");
        }

        public List<Command> getListTasks()
        {
            return tasks;
        }

        public int getNumThreads()
        {
            return numThreads;
        }

        public void encFlow(EncDecorator encDecorator)
        {
             encDecorator.Encrypt(dataToTraffic);
        }

        public void compressFlow(CompressedDecorator compressDecorator)
        {
            compressDecorator.Compress(dataToTraffic);
        }
    }
}
