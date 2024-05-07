using Entities;

//SavingsAccount savingsAccount = new SavingsAccount(1, "anil", 1000, 4.5M);
//
SavingsAccount savingsAccount = new SavingsAccount { Id = 1, Name = "Anil", SavingsAccInterestRate = 4.5M };
savingsAccount.Credit(1000);

//A obj = new A();
//obj.GetId();
B obj = new B("", 0);
obj.SetId(1);
obj.GetId();
