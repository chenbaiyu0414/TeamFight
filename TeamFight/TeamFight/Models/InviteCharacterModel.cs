﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamFight.Models
{
    public class InviteCharacterModel
    {
        public int CharacterId { get; set; }

        public int InvitedCharacterId { get; set; }
    }
}