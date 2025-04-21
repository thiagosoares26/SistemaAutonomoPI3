using AutoSystem_KingMe.Models.Common;
using AutoSystem_KingMe.Models.Common.Attributes;

namespace AutoSystem_KingMe.Models
{
    public class HistoryEntity : EntityBase
    {

        [Position(0)]
        public string UserName { get; set; }
        
        [Position(1)]
        public string MatchPhase { get; set; }

        [Position(2)]
        public string Character { get; set; }
        
        [Position(2)]
        public string Voting { get; set; }
        
        [Position(3)]
        public string Sector { get; set; }
    }
}
