# VendingMachine-lap3
นายญาณวรุฒม์ บัวอินทร์ 683450054-3

classDiagram
    class Program {
        +static void Main(string[] args)
    }
    class VendingMachine__lap3 {
        -int coffee
        -int water
        -int chocolate
        -int milk
        +VendingMachine__lap3(int coffee, int water, int chocolate, int milk)
        +void Buyblackcoffee(int amount)
        +void Buymocha(int amount)
        +void Buylatte(int amount)
        +void Buychocolate(int amount)
        +void ShowStock()
        +void IncreaseStock(int coffee, int water, int chocolate, int milk)
    }
    Program --> VendingMachine__lap3
