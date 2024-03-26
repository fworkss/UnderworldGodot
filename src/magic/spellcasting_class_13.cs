using System;

namespace Underworld
{
    public partial class SpellCasting : UWClass
    {
        /// <summary>
        /// Special extra spells only found in UW2
        /// </summary>
        /// <param name="minorclass"></param>
        public static void CastClassD_Spells(int minorclass)
        {
            switch (minorclass)
            {
                case 7:
                    {//Map area
                        if (automap.CanMap(playerdat.dungeon_level))
                        {
                            var castscore = Math.Max(playerdat.Casting-13,0);
                            var range = 2 + (castscore/5); 

                            automap.MarkRangeOfTilesVisited(
                                range: range, 
                                cX: playerdat.tileX, 
                                cY: playerdat.tileY,
                                dungeon_level: playerdat.dungeon_level
                                );
                        }
                        break;
                    }
            }
        }
    }//end class
}//end namespace