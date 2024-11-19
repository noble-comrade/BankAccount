BankAccount person1 = new BankAccount("0001", "Willi Wiliams", 14000);
BankAccount person2 = new BankAccount("0002", "John Smith");

person1.putOnAcc(1000);
person1.withdrawFromAcc(100);
person1.transferAnotherAcc(person2, 900);
Console.Write(person1.ownerName+" ");
person1.findOutBalance();
Console.Write(person2.ownerName+" ");
person2.findOutBalance();

class BankAccount
{
    public string accNumber; // номер счета
    public string ownerName; // ФИО владельца
    public int amount; // Сумма на счету
    public BankAccount() { accNumber = "0000"; ownerName = "Noname"; amount = 0; } // конструктор
    public BankAccount(string a, string b, int c) { accNumber = a; ownerName = b; amount = c; } // конструктор с параметрами
    public BankAccount(string a, string b) { accNumber = a; ownerName = b; amount = 0; }
    public void putOnAcc(int number) => amount += number; //положить на счет
    public void withdrawFromAcc(int number) => amount -= number; // снять со счета
    public void findOutBalance() => Console.WriteLine($"Баланс на счету {amount}");// узнать баланс
    public void transferAnotherAcc(BankAccount anotherAcc, int number) // перевести на другой счет
    {
        anotherAcc.putOnAcc(number);
        withdrawFromAcc(number);
    }
}