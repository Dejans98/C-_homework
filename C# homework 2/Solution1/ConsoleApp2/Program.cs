namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 =  { "Ratko","Petko","Boshko","Mile","Zoki" };
            string[] studentsG2 =  {"Dejan","Petar","Filip","Stefan","Bube" };

            Console.WriteLine("Enter a student group 1 or 2:");
            string input = Console.ReadLine();
            
                if (input =="1")
                {
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    string student = studentsG1[i];
                    Console.WriteLine(student);
                }    
                }

                else if (input == "2")
                {
                for (int i =0;i<studentsG2.Length;i++)
                {
                string student = studentsG2[i];
                    Console.WriteLine(student);    
                }
                }

                else
                {
                Console.WriteLine("Invalid number please enter 1 or 2: ");
                }








      

            //Console.WriteLine("Hello, World!");
        }
    }
}
