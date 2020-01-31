using JobSystem_LEYE_RAHARIJAONA.Communication;
using JobSystem_LEYE_RAHARIJAONA.Tasks;
using JobSystem_LEYE_RAHARIJAONA.Traffic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSystem_LEYE_RAHARIJAONA
{
    class Program
    {
        static void Main(string[] args)
        {

            /** il faut mettre en lien le flow et la tache peut etre avec write **/
            Flow flow = new Flow();

            Console.WriteLine("Flow OK");


            //Com creator
            ComCreator comCreator = new ComCreator(2,flow);
            Console.WriteLine("ComCreator OK");


            //Flow Decorator
            FlowDecorator flowDecorator = new FlowDecorator(flow);
            Console.WriteLine("FlowDecorator OK");

            //Command Executor
            TaskCommandExecutor commandExecutor = new TaskCommandExecutor(comCreator);
            Console.WriteLine("Executor OK");


            //création de 3 taches
            TaskCommand<String> tache1 = new TaskCommand<string>("Message1", comCreator);
            Console.WriteLine("Tache1 OK");
            TaskCommand<String> tache2 = new TaskCommand<string>("Message2", comCreator);
            Console.WriteLine("Tache2 OK");
            TaskCommand<String> tache3 = new TaskCommand<string>("Message3", comCreator);
            Console.WriteLine("Tache3 OK");

            Console.ReadLine();
        }
    }
}
