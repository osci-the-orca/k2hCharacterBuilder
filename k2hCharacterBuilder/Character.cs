using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace k2hCharacterBuilder
{
    class Character
    {   
        public int Strength { get; set; }
        public int Endurance { get; set; }
        public int Agility { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int StartStatPoints = 25;
        public int StatPoint { get; set; }

        public const int StartHp = 60;
        public const int StartMp = 30;
        public const int StartStamina = 40;

        public int SumOfStats => Strength + Endurance + Agility + Wisdom + Intelligence;

        public int TotalHp => StartHp + (Endurance * 2);
        public int TotalMp => StartMp + Wisdom + Intelligence;
        public int MeeleDmg => Strength / 5;
        public int RangeDmg => (Agility / 7) + (Strength / 9);
        public int TotalStamina => StartStamina + Endurance;

        internal int SetStatpoint() => (((SetLevel() - 1) * 3) + StartStatPoints) - SumOfStats;

        internal int SetLevel()
        {
            if(SumOfStats <= StartStatPoints)
            {
                return 1;
            }
            else
            {
            return (int)Math.Ceiling(1 + (Convert.ToDecimal(SumOfStats - StartStatPoints) / 3));
            }
        }

    }
}
