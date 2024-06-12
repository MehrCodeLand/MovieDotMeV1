using MovieDotMeV1.Db;
using MovieDotMeV1.Models;
namespace MovieDotMeV1.RepositoryCore
{
    public static class MyCore
    {
        public static MyDb db = new MyDb();

        public static IList<Movie> GetAllMovies()
        {
            var movies = db.Movies.ToList();

            if(movies != null )
                return movies;
            else
            {
                return new List<Movie>();
            }
        }
        public static bool SignIn(string username , string password)
        {
            var user = db.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            if(user == null ) return false;
            return true;
        }
        public static bool SignUp(string username , string password)
        {
            var user = db.Users.Any(u => u.Username == username);
            if (user != false)
                return false;

            var newUser = new User()
            {
                Username = username,
                Password = password
            };

            db.Users.Add(newUser);
            db.SaveChanges();

            return true;
        }
        public static User GetUser(string username)
        {
            return db.Users.SingleOrDefault(u => u.Username == username);
        }
        public static IList<Movie> GetMovieUser(int userID)
        {
            var user = db.Users.SingleOrDefault(u => u.UserID == userID);

            return user.Movies.ToList();
        }
        public static bool AddFaveMovies(string username  , string movieTitle)
        {
            var user = db.Users.SingleOrDefault(u => u.Username == username);

            var movie = db.Movies.SingleOrDefault(x => x.Title == movieTitle);

            if(user.Movies.Any(x => x.Title == movie.Title)) return false;

            user.Movies.Add(movie);
            db.SaveChanges();

            return true;
        }
        public static bool RemoveFaveMovies(string username , string movieTile)
        {
            var user = db.Users.SingleOrDefault(x =>x.Username == username);

            var movie = db.Movies.SingleOrDefault(x =>x.Title == movieTile);

            
            user.Movies.Remove(movie);
            db.SaveChanges();

            return true;
        }

        public static void RemoveMovie(string title)
        {
            var movie = db.Movies.SingleOrDefault(x => x.Title == title);
            db.Movies.Remove(movie);
            db.SaveChanges();
        }
        public static void CreateMovie(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        }
        public static bool LoginAdmin(string username , string pass)
        {
            var admin = db.Admins.SingleOrDefault(x => x.Username == username && x.Password == pass);
            if (admin != null)
                return true;

            return false;
        }
        public static void RemoveMovieAll(string title)
        {
            var movies = db.Movies.ToList();

            var myMovie = db.Movies.SingleOrDefault(y => y.Title == title);

            db.Movies.Remove(myMovie);
            db.SaveChanges();
        }
    }
}
