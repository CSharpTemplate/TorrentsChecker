namespace CheckTorrent.Interfaces
{
    internal interface IOperations
    {
        void Create(string name);
        void Delete();
        void CopyTo(string from , string to);
        void MoveTo(string from , string to);
        void Load();
    }
}
