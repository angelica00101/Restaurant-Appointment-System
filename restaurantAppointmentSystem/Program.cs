//Restaurant Customer Appointment System
//Functions: Add, remove/edit, view detais
//customer details components: name, date and time, table number
//functions: create methods that will add appointments, edit appointments, cancel appointments using linked list
//functions: create methods using sorted list that will view details of each customers, with exception handling that
//will not add a detail if it is already existing or already assigned to a customer.

class Program
{
     LinkedList<Customer> Customers = new LinkedList<Customer>();
    public Customer SearchInfo(string name)
    {
        foreach (Customer customer in Customers)
        {
            if (customer.Name.ToLower() == name.ToLower())
            {
                return customer;
            }
        }
        return null;
    }
    SortedList<int, string> customerDetails = new SortedList<int, string>();
        public void InputCustomerDetails()
        {
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter schedule (yyyy-MM-dd HH:mm): ");
            DateTime schedule;

                while (!DateTime.TryParse(Console.ReadLine(), out schedule))
                    {
                        Console.WriteLine("Invalid format. Please enter the schedule in the format yyyy-MM-dd HH:mm: ");
                    };

            Console.WriteLine("Enter table number: ");
            int tableNumber;

                while (!int.TryParse(Console.ReadLine(), out tableNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid table number: ");
                }
                    if (!customerDetails.ContainsKey(tableNumber))
                    {
                        customerDetails.Add(tableNumber, $"{name} - {schedule}");
                    }else
                    {
                        Console.WriteLine("Table number already exists. Please book a different one. Thank you!");
                    }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.InputCustomerDetails();
        }
    
}
   

    

      
