using Microsoft.AspNetCore.Components;

namespace _1C.Data
{
    public class db_connection : ComponentBase
    {
        [Parameter]
        public static List<Agent> agentsList { get; set; } = new List<Agent>();

        [Parameter]
        public static List<PurchaseInvoice> operationsList { get; set; } = new List<PurchaseInvoice>();

        [Parameter]
        public static double TotalPrice { get; set; }
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
            this.Price = price;
            DateTime = DateTime.Now;
        }

        public Agent Agent { get; set; }
        public double Price { get; set; }
        public DateTime DateTime { get; set; }
    }
}
