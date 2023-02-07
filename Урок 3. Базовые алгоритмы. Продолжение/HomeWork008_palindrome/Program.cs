System.Console.Write("Ввидите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int TenThousand = num/10000;
int Ten = num%10;
int Thousand = (num - (TenThousand * 10000))/1000;
int Hundred = ((num-Ten)%100)/10;
if((TenThousand==Ten)&(Thousand==Hundred))
System.Console.WriteLine($"число: {num} - является полиндром");
else
System.Console.WriteLine($"число: {num} - НЕ является полиндромом");
