using System;
using IntermediateCourse.UpCastingDownCasting;
using System.IO;

namespace IntermediateCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            var exercise = new ExercisePolymorphism();
            exercise.run();

            //StreamReader reader = new StreamReader(new MemoryStream());


            //var car = new Car("XYZ123");


            //var dbMigrator = new DbMigrator(new Logger());

            //var logger = new Logger();
            //var installer = new Installer(logger);

            //dbMigrator.Migrate();

            //installer.Install();

            //var text = new Text();
            //text.Width = 100;
            //text.Copy();

            //var post = new ExerciseStackOverFlowPost();
            //post.run();

            //var cookie = new HttpCookie();
            //cookie["name"] = "Harish";
            //Console.WriteLine(cookie["name"]);
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            point.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            point.Move(null);

        }
    }
}
