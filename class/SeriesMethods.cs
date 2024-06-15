namespace Project{
    public abstract class Abs{
        public int ID{get; protected set;}
    }
    class SeriesMethods : Abs{
        private string Title{get; set;}
        private string Desc{get; set;}
        private int RYear{get; set;}
        private bool Deleted{get; set;}
        private MovieGenre Genre{get; set;}

        public SeriesMethods(int id, MovieGenre genre, string title, string desc, int ryear){
            this.Deleted = false;
            this.ID = id;
            this.Genre = genre;
            this.Title = title;
            this.RYear = ryear;
        }
        public void Delete(){
            this.Deleted = true;
        }

        public override string ToString(){
            string s = "";
            s += $"Genre: {this.Genre}\n";
            s += $"Title: {this.Title}\n";
            s += $"Description: {this.Desc}\n";
            s += $"Release Year: {this.RYear}\n";
            s += $"Deleted: {this.Deleted}\n";
            return s;
        }
        public string GetTitle(){return Title;}
        public int GetId(){return ID;}
        public bool IsDeleted(){return Deleted;}
    }
}