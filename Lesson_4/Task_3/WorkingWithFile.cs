namespace LiskovSubstitution;

public class WorkingWithFile
{
    public partial class User : Administrator
    {
        
    }

    public partial class Administrator : Owner
    {
        
    }
    
    public partial class Owner : IWorkingWithFile
    {
        public string ReadFromFile(string filename)
        {
            CheckRole(new Guid());
            return filename;
        }

        public void WriteToFile(string filename)
        {
            CheckRole(new Guid());
        }

        public void DeleteFile(string filename)
        {
            CheckRole(new Guid());
        }

        public void DownloadFile(string filename)
        {
            CheckRole(new Guid());
        }

        public void CopyFile(string filename)
        {
            CheckRole(new Guid());
        }

        public void GetDataFromFile(string filename)
        {
            CheckRole(new Guid());
        }

        public void CheckFile(string filename)
        {
            CheckRole(new Guid());
        }

        public void SaveToFile(string filename)
        {
            CheckRole(new Guid());
        }

        public Guid CheckRole(Guid role)
        {
            return role;
        }

        public Guid CheckUser(Guid user)
        {
            return user;
        }
    }
}