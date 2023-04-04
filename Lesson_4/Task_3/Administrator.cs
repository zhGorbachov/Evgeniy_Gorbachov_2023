namespace LiskovSubstitution;

public class Administrator : User
{
    public override void WriteToFile(string filename)
    {
        base.WriteToFile(filename);
    }

    public override Guid CheckUser(Guid user)
    {
        return base.CheckUser(user);
    }

    public virtual void GetDataFromFile(string filename)
    {
        if(CheckRole(new Guid()) == new Guid("Owner"))
            Console.WriteLine("File deleted");
    }

    public virtual void DeleteFile(string filename)
    {
        Console.WriteLine("File deleted");
    }

    public override void CheckFile(string filename)
    {
        base.CheckFile(filename);
    }

    public override void SaveToFile(string filename)
    {
        base.SaveToFile(filename);
    }

    public override Guid CheckRole(Guid role)
    {
        return base.CheckRole(role);
    }
}