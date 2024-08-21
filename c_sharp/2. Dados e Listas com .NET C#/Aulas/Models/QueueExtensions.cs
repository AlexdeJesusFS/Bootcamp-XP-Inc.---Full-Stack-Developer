using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
//Classe estatica como novo metodo estatico implemntado extendida da Classe Queue:
{
    public static class QueueExtensions
    {
        public static void ForEach<T>(this Queue<T> queue, Action<T> action)
        {
            foreach (var item in queue)
            {
                action(item);
            }
        }
    }
}
