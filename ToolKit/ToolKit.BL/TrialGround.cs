namespace ToolKit.BL
{
    //Override the "ToString" methods of the base object class to return information that would allow you to more easily 
    //identify an instance while debugging. 
    public class TrialGround
    {
        public TrialGround() : this(0)
        {

        }
        public TrialGround(int objectId)
        {
            ObjectId = objectId;
        }

        public int ObjectId;
        public string ObjectName { get; set; }

        public override string ToString() => ObjectName;
    }
}