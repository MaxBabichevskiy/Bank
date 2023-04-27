using Bank;

using (ApplicationContext db = new ApplicationContext())
{
    Account Tom = new Account { Name = "Tom", Surname = "Parker", Money = 10234, Role = "User" };
    Account Jessy = new Account { Name = "Jessy", Surname = "Rodrigez", Money = 567, Role = "User" };
    Account Daniel = new Account { Name = "Daniel", Surname = "Tompson", Money = 534732, Role = "User" };

    db.Accounts.Add(Tom);
    db.Accounts.Add(Jessy);
    db.Accounts.Add(Daniel);
    db.SaveChanges();
    

    var accounts = db.Accounts.ToList();
    Console.WriteLine("Список объектов");
    foreach (var user in accounts) Console.WriteLine($"{user.Id}.{user.Name} - {user.Surname} - {user.Money} - {user.Role}");
}
