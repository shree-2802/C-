public class BankAccount{
    public string AccountNumber{get;}
    public int Balance{get;private set;}
    public BankAccount(string accountNumber){
        this.AccountNumber=accountNumber;
    } 
    public void Deposit(int depositAmount){
        this.Balance+=depositAmount;
    }
}