namespace Design
{

    interface Details
    {
        int add(int a, int b);
    }

    public class Implement : Details
    {
        public int add(int a,int b)
        {
            return a + b;
        }
    }

    public class Test
    {
        private Details details;

        Implement implement=new Implement();

        public int add_sum()
        {
            return implement.add(5, 5);
        }

        
        public int get_result(int a,int b)
        {
            return details.add(a,b);
        }
        

       
    }
    public class students
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
    }

    public class DelieverDetails
    {
        public List<students> get_students()

        {
            List<students> Students = new List<students>();
            Students.Add(new students() { Id = 1, StudentName = "Dinesh", StudentAge = 20 });
            Students.Add(new students() { Id = 2, StudentName = "Devanaboina", StudentAge = 30 });
            
            return Students;
        }
    }
    public class Design
    {
        public static void Main(string[] args)
        {
            Test test = new Test();
            int ans = test.add_sum();
            Console.WriteLine(ans);
            Console.WriteLine("Dinesh is a good boy");
            Console.WriteLine("Google");


            
        }
    }

}