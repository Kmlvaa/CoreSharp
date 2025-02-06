namespace CollectionTask
{
    public class BaseClass
    {
        private static int _id;
        public int Id { get; set; }

        public BaseClass()
        {
            Id = ++_id;
        }
    }
}
