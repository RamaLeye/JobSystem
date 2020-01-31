using JobSystem_LEYE_RAHARIJAONA.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSystem_LEYE_RAHARIJAONA.Tasks
{
    class TaskCommand <T> : Command
    {
        /** Message de tout type ( int, string, bool) **/
        private T message { get; set; }

        private ComCreator modeCommunication;

        /** Constructeur  **/
        public TaskCommand(T message, ComCreator comCreator)
        {
            this.message = message;
            modeCommunication = comCreator;

            //on ajoute la tache dans le comCreator
            comCreator.getListTasks().Add(this);
        }

        

        public void Execute()
        {
            Console.WriteLine(this.message);
        }
    }
}
