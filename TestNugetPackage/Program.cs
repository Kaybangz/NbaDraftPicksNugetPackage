using NbaFirstRoundPicks;

namespace TestNugetPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FetchPlayer.FetchAllFirstRoundPicks();
            FetchPlayer.FetchSingleFirstRoundPick("anthony edwards");
        }
    }
}