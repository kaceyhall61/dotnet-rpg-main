using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.DTOs.Character
{
    public class AddCharacterSkillDTO
    {
        public int CharacterID { get; set; }
        public int SkillId { get; set; }
    }
}