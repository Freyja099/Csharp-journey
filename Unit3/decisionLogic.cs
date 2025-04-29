string permission = "Admin|Manager";
int level = 99;

bool condition = permission.Contains("Admin") || permission.Contains("Manager") && !(permission.Contains("Manager") && level < 20) ;

if (!condition)
    Console.WriteLine("You do not have sufficient privileges.");


else
{
    if (permission.Contains("Admin"))
    {
        if (level > 55)
            Console.WriteLine("Welcome, super Admin user.");
        else
            Console.WriteLine("Welcome, admin user.");
    }

    //string isManager = (permission.Contains("manager") && level > 20) ? "contact an admin for access " : " you do not have sufficient privileges.";

    //Console.WriteLine(isManager);

    else if (permission.Contains("Manager"))
    {
        if (level >= 20)
            Console.WriteLine("Contact an admin for access.");
        
    }
}
