namespace ToolKit.BL
{
    //Override the "ToString" methods of the base object class to return information that would allow you to more easily 
    //identify an instance while debugging. 
    public class OverrideToStringOfBaseClass
    {
        public OverrideToStringOfBaseClass() : this(0)
        {

        }
        public OverrideToStringOfBaseClass(int objectId)
        {
            ObjectId = objectId;
        }

        public int ObjectId;
        public string ObjName { get; set; }
        public string ObjLastName { get; set; }
        public string FullName { get
            {
                if (!string.IsNullOrWhiteSpace(ObjLastName))
                    return ObjName + ", " + ObjLastName;
                else
                    return ObjName;
            }
        }
        public override string ToString() => ObjName;


    }
}