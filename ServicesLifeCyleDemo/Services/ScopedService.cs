namespace ServicesLifeCyleDemo.Services
{
    public class ScopedService
    {
        private readonly Guid _id;
        public ScopedService()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return _id;
        }
    }
}
