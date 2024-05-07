//IBankService? service = Factory.Instantiate.CreateService<IBankService,BankService>();
//if (service != null) {
//    BankOperator bankOperator = new BankOperator(service);
//    bankOperator.TransferAmount(1000, 1123, 1234);
//}

IBankService service = Factory.Instantiate.CreateService();
if (service != null)
{
    BankOperator bankOperator = new BankOperator(service);
    bankOperator.TransferAmount(1000, 1123, 1234);
}

//Factory
class Factory
{
    private static Factory? _factory;

    private Factory() { }

    public static Factory Instantiate
    {
        get
        {
            _factory ??= new Factory();
            return _factory;
        }
    }

    public IBankService CreateService() => new BankService();
    //public TInterface? CreateService<TInterface, TClass>()
    //{
    //    return (TInterface?)Activator.CreateInstance(typeof(TClass));
    //}
}

//contract
interface IBankService
{
    public abstract void CreditAmountToAccount(decimal amount, int creditAccId);
    public abstract void DebitAmountFromAccount(decimal amount, int debitAccId);
}

//implementation
class BankService : IBankService
{
    public void CreditAmountToAccount(decimal amount, int creditAccId)
    {

    }

    public void DebitAmountFromAccount(decimal amount, int debitAccId)
    {

    }
}

class BankOperator
{
    private readonly IBankService bankService;
    public BankOperator(IBankService bankService) => this.bankService = bankService;

    public void TransferAmount(decimal amount, int debitAccId, int creditAccId)
    {
        //IBankService bankService = new BankService();
        bankService.DebitAmountFromAccount(amount, debitAccId);
        bankService.CreditAmountToAccount(amount, creditAccId);
    }
}


