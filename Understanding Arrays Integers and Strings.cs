using System;
namespace Program
{
    class Understanding_Arrays
    {
        static void Main()
        {
            // Feel free to change this code and use it for your own propose !

            // Welcome Screen
            Console.WriteLine("\t\t\t\t\t\tWelcome to my program ! ");
            Console.WriteLine("How many students data do you want to enter ? (Enter as integer): ");
            int students = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t\t\t\tYou will be asked to enter data of student respectively !");

            // String Array 
            string[] Names = new string[students];
            // Asking data of Student from name !
            Console.WriteLine("\nEnter the name of the student: ");
            Names[0] = Console.ReadLine();

            for (int i = 1; i < students; i++)
            {
                Console.WriteLine("Enter the name of the another student: ");
                Names[i] = Console.ReadLine();

            }

            // Integer Array 
            int[] Marks = new int[students];
            // Asking data of the student
            try
            {
                for (int i = 0; i < students; i++)
                {
                    Console.WriteLine("Enter the Marks of: {0}", Names[i]);
                    Marks[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Enter marks as a Integer data type! ");
                Console.WriteLine("Enter the data again !");
                Main();
            }
            // Double 
            double[] Roll_No = new double[students];
            try
            {
                for (int i = 0; i < students; i++)
                {
                    Console.WriteLine("Enter the Roll No. of: {0}", Names[i]);
                    Roll_No[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Enter Roll No. as a Double data type! ");
                Console.WriteLine("Enter the data again !");
                Main();
            }
            //Float Array
            float[] Percentange = new float[students];
            try
            {
                for (int i = 0; i < students; i++)
                {
                    Console.WriteLine("Enter the Percentage of: {0}", Names[i]);
                    Percentange[i] = float.Parse(Console.ReadLine());

                }
            }

            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Enter Percentages No. as a Float data type! ");
                Console.WriteLine("Enter the data again !");
                Main();
            }

            // Diplaying the data of students ! 
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("____________________________________________________________________________________________________________________________________________________");
            Console.WriteLine("|____________Name_____________________________________|___________Roll No_________|___________Marks_____________|____________Percentage____________|");
            for (int i = 0; i < students; i++)
            {

                Console.WriteLine(" {0}\t\t\t\t\t\t\t{1}\t\t\t\t{2}\t\t\t\t{3}      ", Names[i], Roll_No[i], Marks[i], Percentange[i]);

            }
            Console.WriteLine("Thank you for using this Program ! ");
        }
    }
}