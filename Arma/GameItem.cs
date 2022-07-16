namespace Arma
{
    internal class GameItem
    {
        public enum ItemType
        {
            Unit = 1,
            Upgrade = 2
        }

        public ItemType type;

        public int Hash { get; set; }
    
    }
}
