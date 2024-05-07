using Entities;
//Account account = new Account(1, "anil", 1000);
//Account account = new Account(1);
//assign the value via the property means you are calling "set" accessor
//account.Name = "Anil Kumar";
//account.Credit(1000);

//object initializer (via property)
//Account account = new Account(accId: 1, balance: 2000) { Name = "Anil Kumar" };

//Account account = new Account { Name = "Anil Kumar" };
//account.Credit(1000);

Account account = new Account(accId: 1) { Name = "Anil Kumar" };
account.Credit(1000);
//just calling the property, but not assigning any value, means you are calling the "get" accessor of the property
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetInformation());

Console.WriteLine(Account.BANK_BRANCH);

Category category = new Category { Id = 1, Name = "Laptop" };
