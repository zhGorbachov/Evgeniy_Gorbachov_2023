﻿namespace ClassLibrary1.Interfaces;

public interface IUser
{
    public string ReadFromFile(string filename);
    public void DownloadFile(string filename);
    public void CopyFile(string filename);
    
}