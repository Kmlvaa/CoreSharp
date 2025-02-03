using Generics.Common;

namespace Generics
{
    public class Car : BaseEntity, IEmployee
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
