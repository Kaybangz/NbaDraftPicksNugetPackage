using System;
using System.ComponentModel;
using System.Globalization;
using NbaFirstRoundPicks.Utilities;

namespace NbaFirstRoundPicks
{
    public static class FetchPlayer
    {
        public static void FetchAllFirstRoundPicks()
        {
            foreach (var player in FirstRoundpicks.GetFirstRoundPicks())
            {
                Console.WriteLine($"{player.FirstName} {player.LastName} drafted on {player.DraftDate} by {player.DraftTeam}\n");
            }
        }


        public static void FetchSingleFirstRoundPick(string playerName)
        {
            try
            {
                foreach(var player in FirstRoundpicks.GetFirstRoundPicks())
                {
                    if(playerName.ToLower() == player.FirstName?.ToLower() || playerName.ToLower() == player.LastName?.ToLower() || playerName.ToLower() == player.FirstName?.ToLower() + " " + player.LastName?.ToLower() || playerName.ToLower() == player.LastName?.ToLower() + " " + player.FirstName?.ToLower())
                    {
                        Console.WriteLine($"{player.FirstName} {player.LastName} drafted on {player.DraftDate} by {player.DraftTeam}\n");
                    }
                }  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
