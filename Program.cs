using Sudoku_Solver;
using Sudoku_Solver.Workers;
using Sudoku_Solver.Strategies;
using System.Linq;

namespace Sudoku_Solver
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                SudokuMapper sudokuMapper = new SudokuMapper();
                SudokuBoardStateManager sudokuBoardStateManager = new SudokuBoardStateManager();
                SudokuSolverEngine sudokuSolverEngine = new SudokuSolverEngine(sudokuBoardStateManager, sudokuMapper);
                SudokuFileReader sudokuFileReader = new SudokuFileReader();
                SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();

                Console.WriteLine("Please enter the filename containing the Sudoku Puzzle:");
                var filename = Console.ReadLine();

                var sudokuBoard = sudokuFileReader.ReadFile(filename);
                sudokuBoardDisplayer.Display("Initial State", sudokuBoard);

                bool isSudokuSolved = sudokuSolverEngine.Solve(sudokuBoard);
                sudokuBoardDisplayer.Display("Final State", sudokuBoard);

                Console.WriteLine(isSudokuSolved
                    ? "You have successfully solved this Sudoku Puzzle!"
                    : "Unfortunatley, current algorithm(s) were not enough to solve the current Sudoku Puzzle!");
            }
            catch (Exception ex)
            {
                // In real world we would want to log this message
                Console.WriteLine("{0} : {1}", "Sudoku Puzzle cannot be solved because there was an error:", ex.Message);
            }
        }
    }
}

// Notes on Interfaces:
// Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
// Interface methods do not have a body - the body is provided by the "implement" class
// On implementation of an interface, you must override all of its methods
// Interfaces can contain properties and methods, but not fields/variables
// Interface members are by default abstract and public
// An interface cannot contain a constructor (as it cannot be used to create objects)
// Why And When To Use Interfaces?
// 1) To achieve security - hide certain details and only show the important details of an object (interface).

// 2) C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces. Note: To implement multiple interfaces, separate them with a comma (see example below)

//  // Car car = new Car(); // this will bring an error sinnce we cannot instantiate an abstract class
// Car ferrari = new Ferrari();
// Person person = new Person(ferrari);
// person.Drive();

// Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.

//LINQ

//// Converting 2D into 1D array
//  {
//             {
//                 int[,] a = new int[2, 2] {
//             {1, 2},{3,4} };
//                 int i, j;
//                 int[] b = new int[4];
//                 int k = 0;
//                 Console.WriteLine("Two-Dimensional Array...");
//                 for (i = 0; i < 2; i++)
//                 {
//                     for (j = 0; j < 2; j++)
//                     {
//                         Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);

//                     }

//                 }
//                 Console.WriteLine("One-Dimensional Array...");
//                 for (i = 0; i < 2; i++)
//                 {
//                     for (j = 0; j < 2; j++)
//                     {
//                         b[k++] = a[i, j];

//                     }

//                 }
//                 for (i = 0; i < 2 * 2; i++)
//                 {
//                     Console.WriteLine("{0}\t", b[i]);

//                 }
//                 Console.ReadKey();

//             }

//         }
