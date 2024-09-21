using Humanizer;

namespace AppDates {
    public class HumanizeExamples {
       
        public void HumanizeQuantities()
        {
            Console.WriteLine("Quantities:");
            Console.WriteLine("case".ToQuantity(0));
            Console.WriteLine("case".ToQuantity(1));
            Console.WriteLine("case".ToQuantity(5));
        }
        public void HumanizeDates()
        {
            Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
            Console.WriteLine("\nDate/Time Manipulation:");
        }

    }
}