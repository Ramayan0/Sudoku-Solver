// using System;

// namespace Sudoku_Solver
// {
//     class LINQ
//     {
//         static void Main(string[] args)
//         {
//             Hobbie[] hobbies = { new Hobbie(1, "Walking"), new Hobbie(2, "Swimming"),
//              new Hobbie(3, "Body Building") };
//             var hobbie = hobbies.Where(h => h.Name.Equals("Walking")).Select(h => h.Name);//lambda expressions
//             var anotherHobbie = from h in hobbies where h.Name.Equals("Walking") select h.Name;
//             //skip
//             var everyHobbieExceptFirstOne = hobbies.Skip(1);
//             //get
//             var swimmingHobbie = hobbies.Skip(1).Take(1);

//         }
//         class Hobbie
//         {
//             public Hobbie(int id, string name) //constructor
//             {
//                 Id = id;
//                 Name = name;
//             }
//             public int Id { get; set; } //properties
//             public string Name { get; set; }
//         }
//     }
// }


