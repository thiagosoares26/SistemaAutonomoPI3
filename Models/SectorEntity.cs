using AutoSystem_KingMe.Models.Common;
using AutoSystem_KingMe.Models.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_KingMe.Models
{
    public class SectorEntity : EntityBase
    {
        [Position(0)]
        public string Id { get; set; }
        
        [Position(1)]
        public string Description { get; set; }
    }
}
