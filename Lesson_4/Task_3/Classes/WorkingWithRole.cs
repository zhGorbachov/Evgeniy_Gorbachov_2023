using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Classes;

public class WorkingWithRole : IWorkingWithRole
{
    public Guid CheckRole(Guid role)
    {
        var user = CheckUser(role);
        if (user == null)
            return Guid.Empty;
                
        return role;
    }

    public Guid CheckUser(Guid user)
    {
        return user;
    }
}