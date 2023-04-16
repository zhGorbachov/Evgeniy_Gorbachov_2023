namespace ClassLibrary1.Interfaces;

public interface IWorkingWithRole
{
    public Guid CheckRole(Guid role);
    public Guid CheckUser(Guid user);
}