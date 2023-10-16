//chetno ili nechetno

int a = 115;
int result = a % 2;

Console.WriteLine(result);

//if (result == 0)
//{
//    Console.WriteLine($"{a} is an even number");
//}
//else
//{
//    Console.WriteLine($"{a} is an odd number");

//}

switch (result)
{
    case 0:
        Console.WriteLine($"{a} is an even number");
        break;
    case 1:
        Console.WriteLine($"{a} is an odd number");
        break;
    default:
        Console.WriteLine("WRONG");
        break;
}




//int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);
//Console.WriteLine(weekDay);

//switch (weekDay)
//{
//    case 0:
//        Console.WriteLine("Sunday");
//        break;
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Thusday");
//        break;
//    case 3:
//        Console.WriteLine("Wedneday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    default:
//        Console.WriteLine("invalid Value");
//        break;
//}