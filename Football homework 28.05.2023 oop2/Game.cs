﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_homework_28._05._2023_oop2
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<AssistantReferee> AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }
    }
}