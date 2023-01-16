using System;
using NbaFirstRoundPicks.Model;
using System.Collections.Generic;

namespace NbaFirstRoundPicks.Utilities
{
    public class FirstRoundpicks
    {
        public static List<PlayerDetails> GetFirstRoundPicks()
        {
            List<PlayerDetails> firstRoundPicks = new List<PlayerDetails>
            {
                new PlayerDetails {FirstName = "Martin", LastName = "Kenyon", DraftTeam = "New Jersey Nets", DraftDate = new DateOnly(2000, 6, 28), IsInNba = false  },

                new PlayerDetails {FirstName = "Kwame", LastName = "Brown", DraftTeam = "Washington Wizards", DraftDate = new DateOnly(2001, 6, 27), IsInNba = false  },

                new PlayerDetails {FirstName = "Yao", LastName = "Ming", DraftTeam = "Houston Rockets", DraftDate = new DateOnly(2002, 6, 26), IsInNba = false  },

                new PlayerDetails {FirstName = "James", LastName = "Lebron", DraftTeam = "Cleveland Cavaliers", DraftDate = new DateOnly(2003, 6, 26), IsInNba = true  },

                new PlayerDetails {FirstName = "Dwight", LastName = "Howard", DraftTeam = "Orlando Magic", DraftDate = new DateOnly(2004, 6, 24), IsInNba = true  },

                new PlayerDetails {FirstName = "Andrew", LastName = "Bogut", DraftTeam = "Milwaukee Bucks", DraftDate = new DateOnly(2005, 6, 28), IsInNba = false  },

                new PlayerDetails {FirstName = "Andrea", LastName = "Bargnani", DraftTeam = "Toronto Raptors", DraftDate = new DateOnly(2006, 6, 28), IsInNba = false  },

                new PlayerDetails {FirstName = "Greg", LastName = "Oden", DraftTeam = "Portland Trail Blazers", DraftDate = new DateOnly(2007, 6, 28), IsInNba = false  },

                new PlayerDetails {FirstName = "Derrick", LastName = "Rose", DraftTeam = "Chicago Bulls", DraftDate = new DateOnly(2008, 4, 15), IsInNba = true  },

                new PlayerDetails {FirstName = "Blake", LastName = "Griffin", DraftTeam = "LA Clippers", DraftDate = new DateOnly(2009, 5, 19), IsInNba = true  },

                new PlayerDetails {FirstName = "John", LastName = "Wall", DraftTeam = "Washington Wizards", DraftDate = new DateOnly(2010, 6, 24), IsInNba = true  },

                new PlayerDetails {FirstName = "Kyrie", LastName = "Irving", DraftTeam = "Cleveland Cavaliers", DraftDate = new DateOnly(2011, 6, 23), IsInNba = true  },

                new PlayerDetails {FirstName = "Anthony", LastName = "Davis", DraftTeam = "New Orleans Hornets", DraftDate = new DateOnly(2012, 6, 28), IsInNba = true  },

                new PlayerDetails {FirstName = "Anthony", LastName = "Bennett", DraftTeam = "Cleveland Cavaliers", DraftDate = new DateOnly(2013, 6, 28), IsInNba = false  },

                new PlayerDetails {FirstName = "Andrew", LastName = "Wiggins", DraftTeam = "Cleveland Cavaliers", DraftDate = new DateOnly(2014, 6, 26), IsInNba = true  },

                new PlayerDetails {FirstName = "Karl-Anthony", LastName = "Towns", DraftTeam = "Minnesota Timberwolves", DraftDate = new DateOnly(2015, 6, 25), IsInNba = true  },

                new PlayerDetails {FirstName = "Ben", LastName = "Simmons", DraftTeam = "Philadelphia 76ers", DraftDate = new DateOnly(2016, 6, 23), IsInNba = true  },

                new PlayerDetails {FirstName = "Markelle", LastName = "Fultz", DraftTeam = "Philadelphia 76ers", DraftDate = new DateOnly(2017, 6, 22), IsInNba = true  },

                new PlayerDetails {FirstName = "Deandrea", LastName = "Ayton", DraftTeam = "Phoenix Suns", DraftDate = new DateOnly(2018, 6, 21), IsInNba = true  },

                new PlayerDetails {FirstName = "Zion", LastName = "Williamson", DraftTeam = "New Orleans Pelicans", DraftDate = new DateOnly(2019, 6, 20), IsInNba = true  },

                new PlayerDetails {FirstName = "Anthony", LastName = "Edwards", DraftTeam = "Minnesota Timberwolves", DraftDate = new DateOnly(2020, 8, 20), IsInNba = true  },

                new PlayerDetails {FirstName = "Cade", LastName = "Cunningham", DraftTeam = "Detriot Pistons", DraftDate = new DateOnly(2021, 6, 29), IsInNba = true  },

                new PlayerDetails {FirstName = "Paolo", LastName = "Banchero", DraftTeam = "Orlando Magic", DraftDate = new DateOnly(2022, 6, 15), IsInNba = true  },
            };

            return firstRoundPicks;
        }
    }
}