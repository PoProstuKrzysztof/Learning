//// This is like the blueprint for the announcement
//public delegate void ThresholdReachedEventHandler(object sender, EventArgs e);

//public delegate void StockPriceRaised(object sender, EventArgs e);

//public class Stock
//{
//    public event StockPriceRaised stockRaisedEvent;

//    protected virtual void OnStockRaisedEvent()
//    {
//        stockRaisedEvent?.Invoke(this, EventArgs.Empty);
//    }

//    public void TriggerEvent()
//    {
//        OnStockRaisedEvent();
//    }
//}

//public class Subscriber
//{
//    public void Subscribe(Stock stock)
//    {
//        stock.stockRaisedEvent += HandleEvent;
//    }

//    public void HandleEvent(object sender, EventArgs e)
//    {
//        Console.WriteLine("Stock raised!");
//    }
//}

TestClass1 testClass1 = new();

TestClass1 testClass13 = new();

testClass13.DoSomething();

testClass1.DoSomething();

TestClass2 testClass2 = new TestClass2();

testClass2.DoSomething();

internal interface ITest
{
    public void DoSomething();
}

public class TestClass1 : ITest
{
    public void DoSomething()
    {
        Console.WriteLine("I did something in {0} ", this.ToString());
    }
}

internal class TestClass2 : TestClass1
{
}