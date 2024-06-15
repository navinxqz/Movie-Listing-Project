namespace Project{
    public class SeriesCRUD : IRepo<SeriesMethods>{
        private List<SeriesMethods> slist = new();
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