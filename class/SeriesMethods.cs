namespace Project{
    public enum MovieGenre{
        Action = 1, Western = 2, Romance = 3, Horror = 4,
        Drama = 5, Animation = 6, Thriller = 7,
        Comedy = 8, SciFi = 9, History = 10
    }
    public abstract class Abs{
        public int ID{get; protected set;}
    }
    public class SeriesMethods : Abs{
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
            this.Desc = desc;
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