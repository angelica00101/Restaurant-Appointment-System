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

 }