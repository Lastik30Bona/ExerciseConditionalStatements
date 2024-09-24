double firstNum = double.Parse(Console.ReadLine());
double secondNum = double.Parse(Console.ReadLine());
string mathOperator = (Console.ReadLine());
double result = 0;

switch (mathOperator)
{
	case "+":
		 result = firstNum + secondNum;
		break;
	case "-":
		 result = firstNum - secondNum;
		break;
	case "*":
         result = firstNum * secondNum;	
		break;
	case "/":
        result = firstNum / secondNum;
		break;
}
Console.WriteLine($"{firstNum} {mathOperator} {secondNum} = {result:F2}");