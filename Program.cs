namespace Project{
    class Program{
        private static string Option(){ //option display for user
            Console.WriteLine("\nWelcome User! choose any option from below");

            Console.WriteLine("\t[1] List of Series");
            Console.WriteLine("\t[2] Add a new Series");
            Console.WriteLine("\t[3] Update Series");
            Console.WriteLine("\t[4] Delete any Series");
            Console.WriteLine("\t[5] View Series info");
            Console.WriteLine("\t[R] Refresh screen");
            Console.WriteLine("\t[X] Exit\n");

            string option = Console.ReadLine().ToUpper();
            return option;
        }
        private static void AddOption(){
            Console.Write("Insert a new series: ");
            foreach (int item in Enum.GetValues(typeof(MovieGenre))){
                Console.WriteLine("{0} - {1}",item,Enum.GetValues(typeof(MovieGenre)));
            }Console.Write("Input the Genre from the List:");

            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add Series Title: ");
            Console.WriteLine("Add Series Description:");
            string desc = Console.ReadLine();

        }
        private static void List(){
            Console.WriteLine("\nList of all series:");
        }
        public static void Main(String[] args){
            string op = Option();
            while(op.ToUpper() != "X"){
                switch(op){
                    case "1": break;
                    default: Console.WriteLine("Invalid selection!"); break;
                }
            }
        }
    }
}