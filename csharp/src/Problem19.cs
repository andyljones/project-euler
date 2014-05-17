using System;

class Problem19
{
  public static void Run() 
  {
    DateTime date = new DateTime(1901, 1, 6);
    DateTime lastDay = new DateTime(2000, 12, 31);

    int count = 0;
    while(date < lastDay)
    {
      if (date.Day == 1)
      {
        count = count + 1;
        Console.WriteLine(date.ToString() + ", " + date.DayOfWeek);
      }
      date = date.AddDays(7);  
    }

    Console.WriteLine(count);
  }
}