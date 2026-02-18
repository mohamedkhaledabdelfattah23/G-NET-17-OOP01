namespace ConsoleAppOOP01


    
{

    using ClassLibraryOOP01;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // PART 01


            #region Question 01

            /* Class → Reference Type (stored in heap, passed by reference).

               Struct → Value Type (stored in stack, copied when assigned). */


            //Person c1 = new Person();
            //c1.Name = "Ali";

            //Person c2 = c1;
            //c2.Name = "Omar";

            //Console.WriteLine(c1.Name); // Omar (same reference)


            //PersonStr s1;
            //s1.Name = "Ali";

            //PersonStr s2 = s1;
            //s2.Name = "Omar";

            //Console.WriteLine(s1.Name); // Ali (copied value)


            #endregion



            #region Question 02

            /*  public → accessible from anywhere.

                private → accessible only inside the same class. */

            //class Car
            //{
            //    public string Model;
            //    private int Speed;

            //    public void SetSpeed(int s)
            //    {
            //        Speed = s;
            //    }
            //}


            #endregion


            #region Question 03


            /* Q3: Steps to Create a Class Library

                Open Visual Studio

                Click Create New Project

                Choose Class Library

                Write your classes.

                Build the project.

                Add reference to it from another project:

                Right click Dependencies

                Add Project Reference

                Select the library. */
            #endregion



            #region Question 04



            /* Q4: What is a Class Library?

                A Class Library is a collection of reusable classes and methods packaged into a DLL.

                Why use it?

                Code reuse

                Better organization

                Easier maintenance

                Separation of concerns */

            #endregion




            // PART 02

            #region Part 02

            //Console.Write("Enter Movie Name: ");
            //string movie = Console.ReadLine();

            //Console.Write("Enter Ticket Type (0=Standard,1=VIP,2=IMAX): ");
            //TicketType type = (TicketType)int.Parse(Console.ReadLine());

            //Console.Write("Enter Seat Row: ");
            //char row = char.Parse(Console.ReadLine());

            //Console.Write("Enter Seat Number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Enter Price: ");
            //double price = double.Parse(Console.ReadLine());

            //Console.Write("Enter Discount Amount: ");
            //double discount = double.Parse(Console.ReadLine());

            //Ticket ticket = new Ticket(movie, type, new Seat(row, number), price);

            //ticket.PrintTicket(14);

            //Console.WriteLine("\n===== After Discount =====");
            //Console.WriteLine($"Discount Before : {discount:F2}");

            //ticket.ApplyDiscount(ref discount);

            //Console.WriteLine($"Discount After  : {discount:F2}");

            //ticket.PrintTicket(14);

            #endregion






        }




    }

    #region Question 012
    //public class Person
    // {
    //     public string Name;
    // }

    // public struct PersonStr
    // {
    //     public string Name;
    // }

    #endregion
}
