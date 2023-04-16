using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Classes;

public class User : WorkingWithRole, IUser
{
    public string ReadFromFile(string filename)
    {
        var role = CheckRole(new Guid());
        
        if (role == null)
            return null;

        Console.WriteLine("File has read");
        return "text";
    }

    public void CopyFile(string filename)
    {
        var role = CheckRole(new Guid());
        
        if (role == null)
            return;
        
        Console.WriteLine("File copiyed");
        // Return file 
        return;
    }

    public void DownloadFile(string filename)
    {
        var role = CheckRole(new Guid());
        
        if (role == null)
            return;
        
        Console.WriteLine("File downloaded");
        // Return file
        return;
    }
}