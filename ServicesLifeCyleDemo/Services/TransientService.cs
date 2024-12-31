namespace ServicesLifeCyleDemo.Services
{
    public class TransientService
    {
        private readonly Guid _id;
        public TransientService()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return _id;
        }
    }
}
