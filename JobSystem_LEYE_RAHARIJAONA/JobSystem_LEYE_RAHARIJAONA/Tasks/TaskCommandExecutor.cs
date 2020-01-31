using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using JobSystem_LEYE_RAHARIJAONA.Communication;

namespace JobSystem_LEYE_RAHARIJAONA.Tasks
{
    class TaskCommandExecutor
    {
        /** Comment faire une liste d'objets de classe template ? **/ 
        private List<Command> tasks { get; set; }

        private List<Thread> threads { get; set; }

        private ComCreator modeCommunication;


        /** Constructeur avec param **/
        public TaskCommandExecutor(List<Command> tasks, List<Thread> threads)
        {
            this.tasks = tasks;
            this.threads = threads;
        }

        /** Constructeur passant par Communication to have le nombre de threads **/
        public TaskCommandExecutor(ComCreator comCreator)
        {
            int nbThreads = comCreator.getNumThreads();
            tasks = new List<Command>();
            threads = new List<Thread>(nbThreads);

            for(int iterateurThread=0; iterateurThread < nbThreads; iterateurThread++)
            {
                Thread newThread = new Thread(new ThreadStart(Work)) { Name = "Thread " + (iterateurThread)};
                newThread.Start();
                threads.Add(newThread);
            }
            
        }

        /** La fonction qui va faire travailler les threads **/
        public void Work()
        {
            Console.WriteLine("Dans WORK OK");
            TaskCommand<String> taskTemplate = null;

            if (tasks.Count > 0)
            {
                Console.WriteLine("AVANT LOCK OK");
                lock (tasks)
                {
                    Console.WriteLine("Dans LOCK OK");
                    Thread.Sleep(500);
                    taskTemplate =(TaskCommand<String>) tasks.First();
                    tasks.Remove(tasks.First());

                    // test de l'affichage

                    Console.WriteLine("Thread Name = {0}", Thread.CurrentThread.Name);
                    Console.WriteLine("Sur la tache : ");
                    taskTemplate.Execute();

                    Console.WriteLine("\n \n");

                    //envoyer vers flux pour traiter si chiffré ou compressé ou clair ..



                }
            }
        }

        public void queueTasks (ComCreator comCreator)
        {
            this.tasks.AddRange(comCreator.getListTasks());

            /** on vide la liste vu qu'on a délégué toutes les taches à l'exécutor **/
            comCreator.getListTasks().Clear();
        }
    }
}
