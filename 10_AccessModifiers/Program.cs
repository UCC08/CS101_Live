using _10_AccessModifiers;

internal class Program : clsMovies // Kalıtım(Inheritance)
{
    private static void Main(string[] args)
    {
        #region public

        //clsTutorials tutorials= new clsTutorials(); // class dan örnekleme yaptım. yani nesneyi oluşturdum..

        //tutorials.setTutorial(1, "C# eğitimi");

        //Console.WriteLine("Eğitim adı : {0}",tutorials.getTutorialName());

        #endregion

        #region private

        //clsStudent student = new clsStudent();

        //student.getName();


        #endregion

        #region protected

        clsMovies movies = new clsMovies();

        Program program= new Program();

        Console.WriteLine($"Movie name : {program.movieName}");


        #endregion



        Console.ReadKey();


    }
}