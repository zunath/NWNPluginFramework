using static NWN.NWScript;

namespace NWN.Plugin.Framework.Wrappers
{
    public class NWObject: Object
    {
        public string Name
        {
            get => GetName(this);
            set => SetName(this, value);
        }

        public string Tag
        {
            get => GetTag(this);
            set => SetTag(this, value);
        }

        public string Resref => GetResRef(this);

        public Location Location
        {
            get => GetLocation(this);
            set
            {
                AssignCommand(this, () => JumpToLocation(value));
            }
        }

        public Object Area => GetArea(this);

        public Vector Position => GetPosition(this);

        public bool IsPlot
        {
            get => GetPlotFlag(this) == 1;
            set => SetPlotFlag(this, value ? 1 : 0);
        }

        public float Facing
        {
            get => GetFacing(this);
            set => AssignCommand(this, () => SetFacing(value));
        }

        public int GetLocalInt(string name)
        {
            return NWScript.GetLocalInt(this, name);
        }

        public void SetLocalInt(string name, int value)
        {
            NWScript.SetLocalInt(this, name, value);
        }


        public string GetLocalString(string name)
        {
            return NWScript.GetLocalString(this, name);
        }

        public void SetLocalString(string name, string value)
        {
            NWScript.SetLocalString(this, name, value);
        }


        public float GetLocalFloat(string name)
        {
            return NWScript.GetLocalFloat(this, name);
        }

        public void SetLocalFloat(string name, float value)
        {
            NWScript.SetLocalFloat(this, name, value);
        }


        public Location GetLocalLocation(string name)
        {
            return NWScript.GetLocalLocation(this, name);
        }

        public void SetLocalLocation(string name, Location value)
        {
            NWScript.SetLocalLocation(this, name, value);
        }


        public Object GetLocalObject(string name)
        {
            return NWScript.GetLocalObject(this, name);
        }

        public void SetLocalObject(string name, Object value)
        {
            NWScript.SetLocalObject(this, name, value);
        }

    }
}
