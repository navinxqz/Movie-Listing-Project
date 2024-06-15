namespace Project{
    class Program{
        public static SeriesCRUD crud = new();
        private static string Option(){ //option display for user
            Console.WriteLine("\nWelcome User! choose any option from below");

            Console.WriteLine("\t[1] List of Series");
            Console.WriteLine("\t[2] Add a new Series");
            Console.WriteLine("\t[3] Update Series");
            Console.WriteLine("\t[4] Delete any Series");
            Console.WriteLine("\t[5] View Series info");
            Console.WriteLine("\t[X] Exit\n");

            string option = Console.ReadLine().ToUpper();
            return option;
        }
        private static void View(){ //(5)
            Console.Write("Enter the series Id: ");
            if(int.TryParse(Console.ReadLine(),out int seriesIndex)){
                var series = crud.GetId(seriesIndex);
                Console.WriteLine(series);
            }else{
                System.Console.WriteLine("\nInvalid Id!\n");
            }
        }
        private static void List(){ //(1)
            Console.WriteLine("\nList of all series:");
            var list = crud.List();

            if(list.Count == 0){
                Console.WriteLine("No series found!\n");
                return;
            }
            foreach(var item in list){
                var deleted = item.IsDeleted();
                Console.WriteLine("ID {0}: - {1} - {2}",item.GetId(),item.GetTitle(),(deleted ? "Deleted" : ""));
            }
        }
        private static void AddOption(){    //add list (2)
            Console.WriteLine("Insert a new series:");
            foreach (int item in Enum.GetValues(typeof(MovieGenre))){
                Console.WriteLine("{0} - {1}", item, (MovieGenre)item);
            }Console.Write("Input the Genre from the List: ");

            if(int.TryParse(Console.ReadLine(), out int g)&& Enum.IsDefined(typeof(MovieGenre),g)){
            Console.Write("Add Series Title: ");
            string title = Console.ReadLine();
            
            Console.WriteLine("Add Series Description:");
            string desc = Console.ReadLine();

            Console.Write("Add Release Year: ");
            int ry = Convert.ToInt32(Console.ReadLine());

            SeriesMethods newSeries = new(crud.NextId(), (MovieGenre)g, title, desc, ry);
            crud.Add(newSeries);
            Console.WriteLine("\nSeries added successfully.\n");
            }else{
                Console.WriteLine("\nInvalid Genre input!\n");
            }
        }
        private static void Update(){   //(3)
            Console.Write("Input the series id to update: ");

            if(int.TryParse(Console.ReadLine(), out int seriesIndex)){
                var series = crud.GetId(seriesIndex);
                if(series !=null){
                    Console.WriteLine($"Current Details of series-id: {seriesIndex}");
                    Console.WriteLine(series);  //seriesmethod has ovrridden ToString()
                    Console.WriteLine("\nEnter new details:");
                    
                    foreach(int item in Enum.GetValues(typeof(MovieGenre))){
                    Console.WriteLine("{0} - {1}",item, (MovieGenre)item);
                }
                Console.Write("Input new genre: ");
                int g = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input new title: ");
                string title = Console.ReadLine();

                Console.WriteLine("Input new desc:");
                string desc = Console.ReadLine();

                Console.Write("Iput new release year: ");
                int ry = Convert.ToInt32(Console.ReadLine());

                SeriesMethods update = new(seriesIndex, (MovieGenre)g, title, desc, ry);
                crud.Update(seriesIndex,update);
                Console.WriteLine("Series updated successfully\n");
            }else{
                Console.WriteLine("\nSeries not found!\n");
            }
            }else{
                Console.WriteLine("\nInvalid ID\n");
            }
        }
        private static void Delete(){   //(4)
            Console.Write("Input series id to delete: ");
            string i = Console.ReadLine();
            if(int.TryParse(i, out int seriesIndex)){
                var series = crud.GetId(seriesIndex);
                if(series!=null){
                    crud.Delete(seriesIndex);
                    Console.WriteLine("Series Deleted Successfully\n");
                }else{
                    Console.WriteLine("Series not found\n");
                }
            }else{
                Console.WriteLine("Invalid ID!\n");
            }
        }
        public static void Main(String[] args){
            string op = Option();
            while(op.ToUpper() != "X"){
                switch(op){
                    case "1": List(); break;
                    case "2": AddOption(); break;
                    case "3": Update(); break;
                    case "4": Delete(); break;
                    case "5": View(); break;
                    case "X": Environment.Exit(0); break;
                    default: Console.WriteLine("Invalid selection!"); break;
                }
                op = Option();
            }System.Console.WriteLine("Thanks alot for using me.\n");
        }
    }
}