using ConsoleAppDop2HW0502.Context;

namespace ConsoleAppDop2HW0502;
class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            //        context.Database.EnsureCreated();
            //        // получение всех заказов
            //        var orders = context.Orders.ToList();
            //        Console.WriteLine("Заказы:");
            //        foreach (var order in orders)
            //        {
            //            Console.WriteLine($"OrderId: {order.OrderId}, CustomerId: {order.CustomerId}, OrderDate: {order.OrderDate}, TotalAmount: {order.TotalAmount}");
            //        }
            //        // получение 5 лучших клиентов по общей сумме заказов за последний месяц
            //        var oneMonthAgo = DateTime.Now.AddMonths(-1);
            //        var topCustomers = context.Orders.Where(order => order.OrderDate >= oneMonthAgo).GroupBy(order => order.CustomerId).Select(group => new
            //        { CustomerId = group.Key, TotalAmount = group.Sum(order => order.TotalAmount) })
            //            .OrderByDescending(result => result.TotalAmount).Take(5).ToList();
            //        Console.WriteLine("\nТоп 5 клиентов за последний месяц:");
            //        foreach (var customer in topCustomers)
            //        {
            //            Console.WriteLine($"CustomerId: {customer.CustomerId}, TotalAmount: {customer.TotalAmount}");
            //        }
        }
    }
    }