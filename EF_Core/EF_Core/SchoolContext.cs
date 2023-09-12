namespace EF_Core
{
    internal class SchoolContext : IDisposable
    {
        public object Students { get; internal set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal void Update<T>(T stud)
        {
            throw new NotImplementedException();
        }
    }
}