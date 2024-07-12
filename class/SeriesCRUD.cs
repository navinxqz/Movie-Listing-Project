namespace Project{
    public class SeriesCRUD : IRepo<SeriesMethods>{
        private List<SeriesMethods> slist = new();

        public SeriesCRUD(){    //added a predefined series, can b deleted later
            slist.Add(new SeriesMethods(1, MovieGenre.Action, "Daredevil season 1", "fight devil fight. no eye cool guy", 2015));
            slist.Add(new SeriesMethods(2, MovieGenre.Animation, "Spider-man: Into the Spider-Verse", "Spider bite Miles. Miles became spiderman. Gwen hot", 2019));
            slist.Add(new SeriesMethods(3, MovieGenre.Romance, "Romeo Juliet","Romeo fight Juliet. Juliet fall in love with Rick.", 2025));
            slist.Add(new SeriesMethods(4, MovieGenre.Comedy, "Microwave", "Did you know when a small person waves, its called microwave!",2030));
            slist.Add(new SeriesMethods(4, MovieGenre.Comedy, "The Movie", "Are you sure it is a movie!",1111));
        }
        public List<SeriesMethods> List(){
            return new List<SeriesMethods>(slist);
            //return a new list to avoid external modification
            }
        public SeriesMethods GetId(int id){
            return slist.Find(s => s.ID == id);
            }
        public void Add(SeriesMethods entity){
            slist.Add(entity);
        }
        public void Delete(int id){
            SeriesMethods series = slist.Find(s => s.GetId() == id);
            if(series != null){
                series.Delete();
            }else{
                Console.WriteLine("Series not found!\n");
            }
        }
        public void Update(int id, SeriesMethods entity){
            int index = slist.FindIndex(s => s.ID ==id);
            if(index != -1){
                slist[index] = entity;
                Console.WriteLine("Series updated successfully.\n");
            }else{
                Console.WriteLine("Series not found!\n");
            }
        }
        public int NextId(){ return slist.Count+1; }
    }
}