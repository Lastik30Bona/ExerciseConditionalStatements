int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
int thirdNum  = int.Parse(Console.ReadLine());
int fourNum  = int.Parse(Console.ReadLine());
int fiveNum  = int.Parse(Console.ReadLine());

if (firstNum > secondNum && firstNum > thirdNum && firstNum > fourNum && firstNum > fiveNum)
{
    Console.WriteLine(firstNum);
}
else if (secondNum > firstNum && secondNum > thirdNum && secondNum > fourNum && secondNum > fiveNum)
{
    Console.WriteLine(secondNum);
}
else if (thirdNum > firstNum && thirdNum > secondNum && thirdNum > fourNum &&  thirdNum > fiveNum)
{
    Console.WriteLine(thirdNum);
}
else if (fourNum > firstNum && fourNum > secondNum && fourNum > thirdNum && fourNum > fiveNum)
{
    Console.WriteLine(fourNum);
}
else
{
    Console.WriteLine(fiveNum);
}