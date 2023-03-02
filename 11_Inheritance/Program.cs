using _11_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {

        clsSubTutorials altsinif= new clsSubTutorials();

        altsinif.DersAdiBelirle(".Net Tutorials from Linkedin.."); // çağırdığım bu metot alt sınıfta

        Console.WriteLine(altsinif.getTutorialName()); // alt sınıftan üst sınıfın bir metodunu çağırabiliyorum (Kalıtım)....
        // 12. satıra geldiğimde yazmak için getTutorialName metodu çağırıyorum. Ama aslında bu metot üst sınıfta. alt sınıfın sanki bir metoduymuş gibi çağırabiliyorum(miras almasın dolayı)

        int bigSecondNumber;


        Console.ReadKey();
    }
}