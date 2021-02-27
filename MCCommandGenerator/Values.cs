using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCommandGenerator
{
    public static class Values
    {
        //Commands
        public static short Command = -1;
        //Advancement
        public static bool AdvancementGive = false;
        public static bool AdvancementRemove = false;
        public static bool AdvancementSelector = false;
        public static short AdvancementSelectedAdvancement = -1;
        public static short AdvancementSelectedRecipeBuilding = -1;
        public static short AdvancementSelectedRecipeDecoration = -1;
        public static short AdvancementSelectedRecipeRedstone = -1;
        public static short AdvancementSelectedRecipeTransportation = -1;
        public static short AdvancementSelectedRecipeMisc = -1;
        public static short AdvancementSelectedRecipeFood = -1;
        public static short AdvancementSelectedRecipeTools = -1;
        public static short AdvancementSelectedRecipeCombat = -1;
        public static short AdvancementSelectedRecipeBrewing = -1;
        // Selector
        public static short Selector = -1;
        public static short SelectorAdvancement = -1;
        public static bool SelectorAdvancementTrue = false;
        public static bool SelectorAdvancementFalse = false;
        public static float SelectorDistanceFrom = 0F;
        public static float SelectorDistanceTo = 0F;
        public static float SelectorX = 0F;
        public static float SelectorDX = 0F;
        public static float SelectorY = 0F;
        public static float SelectorDY = 0F;
        public static float SelectorZ = 0F;
        public static float SelectorDZ = 0F;
        public static short SelectorGamemode = -1;
        public static bool SelectorGamemodeNot = false;
        public static float SelectorLevelFrom = 0F;
        public static float SelectorLevelTo = 0F;
        public static float SelectorLimit = 0F;
        public static string SelectorName = "";
        public static bool SelectorNameNot = false;
        public static string SelectorNBT = "";
        public static string SelectorPredicate = "";
        public static string SelectorScores = "";
        public static short SelectorSort = -1;
        public static string SelectorTags = "";
        public static string SelectorTeam = "";
        public static float SelectorXRotationFrom = 0F;
        public static float SelectorXRotationTo = 0F;
        public static float SelectorYRotationFrom = 0F;
        public static float SelectorYRotationTo = 0F;
        public static bool SelectorDistanceFromClosest = false;
        public static bool SelectorDistanceToInfinite = false;
        public static bool SelectorXRotationFromClosest = false;
        public static bool SelectorXRotationToInfinite = false;
        public static bool SelectorYRotationFromClosest = false;
        public static bool SelectorYRotationToInfinite = false;
        public static bool SelectorLevelFromClosest = false;
        public static bool SelectorLevelToInfinite = false;
        public static short SelectorType = -1;
        public static bool SelectorTypeNot = false;
    }
}
