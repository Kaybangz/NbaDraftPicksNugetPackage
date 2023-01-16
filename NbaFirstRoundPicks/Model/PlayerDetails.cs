using System;


namespace NbaFirstRoundPicks.Model
{
    public class PlayerDetails
    {
        private string? _firstName;
        private string? _lastName;
        private string? _draftTeam;
        private DateOnly _draftDate;
        private bool _isInNba;


        public string? FirstName 
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string? LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string? DraftTeam
        {
            get { return _draftTeam; }
            set { _draftTeam = value; }
        }

        public DateOnly DraftDate
        {
            get { return _draftDate; }
            set { _draftDate = value; }
        }

        public bool IsInNba
        {
            get { return _isInNba; }
            set { _isInNba = value; }
        }
    }
}
