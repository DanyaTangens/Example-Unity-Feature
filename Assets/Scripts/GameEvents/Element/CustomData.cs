namespace GameEvents.Element
{
    public class CustomData
    {
        private int _id;
        private string _description;
        private int _cost;

        public int ID => _id;
        public string Description => _description;
        public int Cost => _cost;

        public CustomData(int id, string description, int cost)
        {
            _id = id;
            _description = description;
            _cost = cost;
        }
    }
}