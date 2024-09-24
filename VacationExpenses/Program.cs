string season = Console.ReadLine();
string type = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

int pricePerNight = 0;
double discount = 0;

if (type == "Hotel")
{
	switch (season)
	{
        case "Spring":
            pricePerNight = 30;
            discount = 20;
            break;
        case "Summer":
            pricePerNight = 50;
            break;
        case "Autumn":
            pricePerNight = 20;
            discount = 30;
            break;
        case "Winter":
            pricePerNight = 40;
            discount = 10;
            break;
    }
}
else if (type == "Camping")
{
    switch (season)
    {
        case "Spring":
            pricePerNight = 10;
            discount = 20;
            break;
        case "Summer":
            pricePerNight = 30;
            break;
        case "Autumn":
            pricePerNight = 15;
            discount = 30;
            break;
        case "Winter":
            pricePerNight = 10;
            discount = 10;
            break;
    }
}

double finalPrice = pricePerNight * days *(1 - (discount / 100));
Console.WriteLine($"{finalPrice:F2}");







// testing if but not too good 
//if (type == "Hotel")
//{
//    if (season == "Spring")
//    {
//        pricePernight = 30;
//        discount *= 0.2;
//    }
//    else if (season == "Summer")
//    {
//        pricePernight = 50;
//        discount = 0;
//    }
//    else if (season == "Autumn")
//    {
//        pricePernight = 20;
//        discount *= 0.3;
//    }
//    else if (season == "Winter")
//    {
//        pricePernight = 40;
//        discount *= 0.1;
//    }
//}
//else if (type == "Camping")
//{
//    if (season == "Spring")
//    {
//        pricePernight = 10;
//        discount *= 0.2;
//    }
//    else if (season == "Summer")
//    {
//        pricePernight = 30;
//        discount = 0;
//    }
//    else if (season == "Autumn")
//    {
//        pricePernight = 15;
//        discount *= 0.3;
//    }
//    else if (season == "Winter")
//    {
//        pricePernight = 10;
//        discount *= 0.1;
//    }
//}
