namespace LiskovSubstitution;

public class User : IWorkingWithFile
{
    public virtual void GetDataFromFile(string filename)
    {
        if (CheckRole(new Guid()) == new Guid("Owner"))
            Console.WriteLine("Data got from file");
    }
    public string ReadFromFile(string filename)
    {
        if(CheckUser(new Guid()) == new Guid("User"))
            Console.WriteLine("File read");
        return null;
    }

    public void DownloadFile(string filename)
    {
        if(CheckUser(new Guid()) == new Guid("User"))
            Console.WriteLine("File downloaded");
    }

    public void CopyFile(string filename)
    {
        if(CheckUser(new Guid()) == new Guid("User")) 
            Console.WriteLine("File copied");
    }

    public virtual void WriteToFile(string filename)
    {
        if(CheckRole(new Guid()) == new Guid("Administrator"))
            Console.WriteLine("File wrote");
    }

    public virtual void DeleteFile(string filename)
    {
        if(CheckRole(new Guid()) == new Guid("Owner"))
            Console.WriteLine("File deleted");
    }

    public virtual void CheckFile(string filename)
    {
        if(CheckRole(new Guid()) == new Guid("Administrator"))
            Console.WriteLine("File checked");
    }

    public virtual void SaveToFile(string filename)
    {
        if(CheckRole(new Guid()) == new Guid("Administrator"))
            Console.WriteLine("File saved");
    }

    public virtual Guid CheckUser(Guid user)
    {
        Console.WriteLine("User checked");
        return user;
    }
    public virtual Guid CheckRole(Guid role)
    {
        Console.WriteLine("Role checked");
        return role;
    }
}
