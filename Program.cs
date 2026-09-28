namespace OOP_Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            DeliveryAddress address1 = new DeliveryAddress();
            address1.City = "paris";
            DeliveryAddress address2 = address1;
            address2.City = "london";
            Console.WriteLine(address1.City);
            Console.WriteLine(address2.City);
            // modifying the copy doesn't affect on the original variable when it's value type 
            Customer customer = new Customer();
            customer.Name = "menna";
            Customer customer1 = customer;
            customer1.Name = "ali";
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer1.Name);
            //when a ref type is copied the ref is copied not the object ,
            //2 refs refering to the same object modifying one affects on the other
            #endregion

            #region Question 2
            //problems => all fields are public, No validation , the internal state is exposed
          


            #endregion
}
    }
}
