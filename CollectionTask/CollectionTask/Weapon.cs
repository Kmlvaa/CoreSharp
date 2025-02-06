using System;
using CollectionTask.Enum;

namespace CollectionTask
{
    public class Weapon : BaseClass
    {
        public string Name { get; set; }
        public BulletTypeEnum BulletType { get; set; }
        public int BulletLimit { get; set; }
        public Queue<Bullet> Bullets { get; set; }
        public Weapon(string name, BulletTypeEnum bulletType, int bulletLimit) : base()
        {
            Name = name;
            BulletType = bulletType;
            BulletLimit = bulletLimit;
            Bullets = new Queue<Bullet>();
        }

        public void Fire()
        {
            if (Bullets.Count > 0)
            {
                Bullets.Dequeue();
            }
            else throw new NullReferenceException("Bullet count is 0. Refill the weapon.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Weapon: {Name} || Bullet type: {BulletType} || Bullet left: {Bullets.Count}");
            Console.ResetColor();
        }
        public void Fill()
        {
            while(Bullets.Count < BulletLimit)
            {
                Bullet bullet = new Bullet(BulletType);
                Bullets.Enqueue(bullet);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Weapon filled.");
            Console.ResetColor();
        }
        public void PullTrigger()
        {
            if(Bullets.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Bullet nextBullet = Bullets.Peek();
                Console.WriteLine($"Next bullet: {nextBullet}");
                Console.ResetColor();
            }
            else throw new NullReferenceException("Bullet count is 0. Refill the weapon.");

        }
    }
}
