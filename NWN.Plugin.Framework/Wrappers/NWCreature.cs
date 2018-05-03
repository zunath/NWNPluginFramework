using static NWN.NWScript;

namespace NWN.Plugin.Framework.Wrappers
{
    public class NWCreature: NWObject
    {
        public int Age => GetAge(this);

        public float ChallengeRating => GetChallengeRating(this);

        public int Class1 => GetClassByPosition(1, this);

        public int Class2 => GetClassByPosition(2, this);

        public int Class3 => GetClassByPosition(3, this);

        public bool IsCommandable
        {
            get => GetCommandable(this) == 1;
            set => SetCommandable(value ? 1 : 0, this);
        }

        public int Size => GetCreatureSize(this);

        public int Phenotype
        {
            get => GetPhenoType(this);
            set => SetPhenoType(value, this);
        }

        public string Deity
        {
            get => GetDeity(this);
            set => SetDeity(this, value);
        }

        public int RacialType => GetRacialType(this);

        public int Gender => GetGender(this);

        public bool IsPlayer => GetIsPC(this) == 1 && GetIsDM(this) == 0 && GetIsDMPossessed(this) == 0;

        public bool IsDM => GetIsPC(this) == 0 && (GetIsDM(this) == 1 || GetIsDMPossessed(this) == 1);

        public bool IsResting => GetIsResting(this) == 1;

        public float Weight => GetWeight(this) * 0.1f;

        public int XP
        {
            get => GetXP(this);
            set => SetXP(this, value);
        }
    }
}
