string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    //int outNumber = imputNumber*imputNumber;
    int outNumber = (int)Math.Pow(inputNumber,2);
    
    Console.WriteLine(outNumber);
}