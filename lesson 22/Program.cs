using lesson_22;

Console.WriteLine("****Handling Multiple Exceptions***\n");
Car myCar = new Car("Rusty", 90);
try
{
    //вызвать исключение выхода за пределы диапазона аргумента
    myCar.Accelerate(-10);
}
catch (CarIsDeadException e )
{
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();
