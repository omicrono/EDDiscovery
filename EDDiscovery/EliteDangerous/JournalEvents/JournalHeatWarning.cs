﻿using Newtonsoft.Json.Linq;
using System.Linq;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    //When written: player was HeatWarning by player or npc
    //Parameters: 
    public class JournalHeatWarning : JournalEntry
    {
        public JournalHeatWarning(JObject evt, EDJournalReader reader) : base(evt, JournalTypeEnum.HeatWarning, reader)
        {


        }


    }
}