using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Classes;

public class Administrator : User, IAdministrator
{
    public void WriteToFile(string filename)
    {
        var role = CheckRole(new Guid());
        
        if (role == null)
            return;
        
        Console.WriteLine("Text to file wrote");
        // Return file
        return;
    }
    public void CheckFile(string filename)
    {
        var role = CheckRole(new Guid());
        
        if (role == null)
            return;
        
        Console.WriteLine("File checked");
        // Return file
        return;
    }
    public void SaveToFile(string filename)
    {
        var role = CheckRole(new Guid());
        
        if (role == null)
            return;
        
        Console.WriteLine("File saved");
        // Return file
        return;
    }
}