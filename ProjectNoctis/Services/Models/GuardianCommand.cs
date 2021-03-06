﻿using ProjectNoctis.Domain.SheetDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNoctis.Services.Models
{
    public class GuardianCommand
    {
        public SheetGuardianSummons Info { get; set; }
        public Dictionary<string, List<SheetStatus>> GuardianStatuses { get; set; }
        public Dictionary<string, List<SheetOthers>> GuardianOthers { get; set; }
    }
}
