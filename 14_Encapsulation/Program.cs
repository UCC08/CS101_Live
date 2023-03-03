using _14_Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Normal durum (herşey açık)

        //clsBank bank = new clsBank();

        //bank.AccountNumber = 12345567890;
        //bank.Name = "Santander Bank";
        //bank.Balance = 500;

        //bank.GetBalance();
        //bank.WithdrawAccount();


        #endregion

        #region getter/setter

        clsBank bankgs = new clsBank();

        bankgs.SetBalanceCaps(500);

        Console.WriteLine($"Balance miktarı : {bankgs.GetBalanceCaps()}");

        #endregion



        Console.ReadKey();
    }
}