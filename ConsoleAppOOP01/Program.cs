namespace ConsoleAppOOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

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
