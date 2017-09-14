using System;

class Program
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Web site: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Manager's first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager's last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager's age: ");
        string managerAge = Console.ReadLine();

        Console.Write("Manager's phone: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Company name: {0} \nCompany adres: {1} \nTel: {2} \nFax: {3} \nWeb Site: {4} \nManager: {5} (age: {6}, tel: {7})", 
                          companyName, companyAddress, companyPhoneNumber, faxNumber, companyWebSite, managerFirstName + managerLastName, managerAge, managerPhoneNumber);
    }
}

