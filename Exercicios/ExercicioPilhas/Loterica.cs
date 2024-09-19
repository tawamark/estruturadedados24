using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPilhas
{
    public class PassNumber
    {
        private int counter = 0;
        public Stack<PassNumber>? Pass { get; set; }
        public Loterica()
        {
            Pass = new Stack<PassNumber>();
        }

        public void PassX(int pass)
        {
            Pass!.Push
            (
                new PassNumber()
                {
                    Number = ++_counter,
                    Pass = pass,
                    CallTime = DateTime.Now
                }
            );
        }

        public 

    }
}