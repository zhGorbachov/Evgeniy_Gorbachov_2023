using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Classes;

public class Owner : Administrator, IOwner
{
    public void DeleteFile(string filename)
    {
        var role = CheckRole(new Guid());

        if (role == null)
            return;
        
        Console.WriteLine("File deleted");
        return;
    }

    public void GetDataFromFile(string filename)
    {
        var role = CheckRole(new Guid());
        
        if (role == null)
            return;
        
        Console.WriteLine("Data got from file");
        // Return data
        return;
    }
}