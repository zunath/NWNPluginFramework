using static NWN.NWScript;

namespace NWN.Plugin.Framework.Wrappers
{
    public class NWItem: NWObject
    {
        public NWObject Possessor => GetItemPossessor(this) as NWObject;

        public int BaseItemType => GetBaseItemType(this);

        public bool IsDroppable
        {
            get => GetDroppableFlag(this) == 1;
            set => SetDroppableFlag(this, value ? 1 : 0);
        }

        public bool IsCursed
        {
            get => GetItemCursedFlag(this) == 1;
            set => SetItemCursedFlag(this, value ? 1 : 0);
        }

        public bool IsStolen
        {
            get => GetStolenFlag(this) == 1;
            set => SetStolenFlag(this, value ? 1 : 0);
        }

        public int AC => GetItemACValue(this);

        public int Charges
        {
            get => GetItemCharges(this);
            set => SetItemCharges(this, value);
        }

        public int StackSize
        {
            get => GetItemStackSize(this);
            set => SetItemStackSize(this, value);
        }

        public float Weight => GetWeight(this) * 0.1f;
    }
}
