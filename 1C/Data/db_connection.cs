namespace _1C.Data
{
    public class db_connection
    {
        public List<Agent> agents = new List<Agent>();
    }

    public class Agent
    {
        public Agent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    public class PurchaseInvoice
    {
        public PurchaseInvoice(Agent agent, double price)
        {
            Agent = agent;
            this.price = price;
            DateTime = DateTime.Now;
        }

        public Agent Agent { get; set; }
        public double price { get; set; }
        public DateTime DateTime { get; set; }
    }
}
