using System;

namespace Sudoku_Solver
{
    class Person
    {
        private Car _car;
        public Person(Car car)
        {
            _car = car;
        }
        public void Drive()
        {
            _car.TurnOnOff();
            _car.Drive();
        }
    }
}
