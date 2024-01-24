Console.WriteLine("Podaj rok:");
int year;
var enteredYear = Console.ReadLine();
Int32.TryParse(enteredYear, out year);

if((year % 4  == 0 && year % 100 !=0) || year % 400 ==0)
{
    Console.WriteLine($"Rok {year} jest rokiem przestępnym");
}
else
{
    Console.WriteLine($"Rok {year} nie jest rokiem przestępnym");
}
