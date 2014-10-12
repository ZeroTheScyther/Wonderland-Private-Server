﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonderland_Private_Server.Code.Enums
{
    public enum eBattleState
    {
        notActive,
        Active,
        Ended,
    }
    public enum eBattleType
    {
        pk = 2,
        normal,
        quest,
    }
    public enum eBattleRoundState
    {
        none,
        PrepState,
        ReadyState,
        CalculatingState,
        EndedState,
    }
    public enum eBattleLeaveType
    {
        BattleFinished,
        RunAway,
        Spawn,
        Dced,
    }
    public enum UnknownType
    {
        miss = 2,
    }
    public enum BattleSide
    {
        none,
        Defending = 2,
        Attacking = 5,
        Watching = 4
    }
    public enum eFighterType
    {
        none = 0,
        player = 2,
        Npc = 7,
        Watcher = 2,
        Pet = 4,
    }

    public enum FighterState
    {
        Unknown,
        Alive,
        Dead,
        Sealed,
    }
}
