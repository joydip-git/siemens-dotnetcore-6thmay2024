using Entities;
Account account = new Account(1, "anil", 1000);
//assign the value via the property means you are calling "set" accessor
account.Name = "Anil Kumar";

//just calling the property, but not assigning any value, means you are calling the "get" accessor of the property
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetInformation());

Console.WriteLine(Account.BANK_BRANCH);
