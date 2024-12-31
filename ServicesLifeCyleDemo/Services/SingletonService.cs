namespace ServicesLifeCyleDemo.Services
{
    public class SingletonService
    {
        private readonly Guid _id;
        public SingletonService()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return _id;
        }
    }
}
