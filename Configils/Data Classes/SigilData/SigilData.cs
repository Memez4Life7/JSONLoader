﻿using System.Collections.Generic;
using TinyJson;

namespace JLPlugin.Data
{
    [System.Serializable]
    public partial class SigilData : JSONParser.IInitializable
    {
        public string GUID;
        public JSONParser.LocalizableField name;
        public JSONParser.LocalizableField description;
        public List<string> metaCategories;
        public string texture;
        public string pixelTexture;
        public int? powerLevel;
        public string abilityLearnedDialogue;

        public int? priority;
        public bool? opponentUsable;
        public bool? canStack;
        public bool? isSpecialAbility;

        public activationCost activationCost;

        public List<AbilityBehaviourData> abilityBehaviour;
    
        public SigilData()
        {
            // Required for JSONParser to work properly with Localisation
            Initialize();
        }

        public void Initialize()
        {
            name = new("name"); // name, name_es... etc
            description = new("description"); // description, description_ko... etc
        }
    }
}
