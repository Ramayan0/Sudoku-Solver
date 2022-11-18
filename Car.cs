using System;

namespace Sudoku_Solver
{
    abstract class Car
    {
        protected bool _on;
        //regular methods
        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "The car is on." : "The car is off");
        }
        //abstract methods (does not have a body)
        public abstract void Drive();

    }
}
