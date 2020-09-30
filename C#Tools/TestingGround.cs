//Override the "ToString" methos of the base object class to return information that would allow you to more easily identify an instance while debugging. 
public class TestingGround
{
    TestingGround() : this(0)
    {

    }
    TestingGround(int ObjectId)
    {
        ObjectId = ObjectId;
    }

    public int ObjectId;
    public string ObjectName { get; set; }

    public override string ToString() => ObjectName;
}