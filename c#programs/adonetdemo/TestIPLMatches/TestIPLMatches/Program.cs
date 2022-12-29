using TestIPLMatches;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, Woiplrld!");

         iplmatches.Connection();
        iplmatches.AddData();
        iplmatches.DisplayMatch();
         iplmatches.PlayMatch();
        iplmatches.DeletePlayer();
    }
}