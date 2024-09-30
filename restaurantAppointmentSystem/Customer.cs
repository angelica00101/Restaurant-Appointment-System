public class Customer
{
    public string Name { get; set; }
    public DateTime Schedule { get; set; }
    public int TableNumber { get; set; }
    public Customer (string name, DateTime schedule, int tableNumber)
    {
        Name = name;
        Schedule = schedule;
        TableNumber = tableNumber;
    }
}