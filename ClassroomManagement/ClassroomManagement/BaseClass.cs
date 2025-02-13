namespace ClassroomManagement
{
    public class BaseClass
    {
        private int _id;
        public static int Id { get; set; }

        public BaseClass()
        {
            Id = _id++;
        }
    }
}
