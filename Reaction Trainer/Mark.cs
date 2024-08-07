namespace Reaction_Trainer
{
    public class Mark
    {
        private int health;
        private Point position;
        private Size size;

        public Mark(Point position)
        {
            this.position = position;
        }
        public void getDamage(int damage)
        {
            health -= damage;
        }
        public void changePosition()
        {
            Random rnd = new Random();
            position = new Point(rnd.Next(), rnd.Next());
        }
        public int getHealth()
        {
            return health;
        }
        public Size getSize()
        {
            return size;
        }
        public Point getPosition()
        {
            return position;
        }
    }
    public class EasyMark : Mark
    {
        private int health = 1;
        private Size size = new Size(10, 10);
        private Point position;

        public EasyMark(Point position) : base(position)
        {
            this.position = position;
        }
    }
}
