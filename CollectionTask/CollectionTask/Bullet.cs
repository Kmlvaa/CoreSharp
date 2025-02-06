using CollectionTask.Enum;

namespace CollectionTask
{
    public class Bullet : BaseClass
    {
        public BulletTypeEnum Type { get; set; }
        public Bullet(BulletTypeEnum bullet) : base()
        {
            Type = bullet;
        }

        public override string ToString() => $"ID: {Id} | {Type}";
    }
}
