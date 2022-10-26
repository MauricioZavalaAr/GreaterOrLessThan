bool playAgain = true;
bool validResponse = true;
string UAnswer;
while(playAgain == true) 
{
// start
int num1;
int num2;
bool isNumber;

Console.WriteLine("We will ask for two numbers and will tell you which one is greater, lower or if they are equal!");
do{

Console.Write("Enter the first number: ");

isNumber = int.TryParse(Console.ReadLine(), out num1);
if(isNumber==false)
{
    Console.WriteLine("Enter valid data,");
}

}while(isNumber==false);

do{

Console.Write("Enter the second number: ");

isNumber = int.TryParse(Console.ReadLine(), out num2);

if(isNumber==false)
{
    Console.WriteLine("Enter valid data,");
}

}while(isNumber==false);

if(num1>num2)
{
    Console.WriteLine($"{num1} is greater than {num2}");
    Console.WriteLine($"{num2} is lower than {num1}");
}
else if(num1<num2)
{
    Console.WriteLine($"{num1} is lower than {num2}");
    Console.WriteLine($"{num2} is greater than {num1}");
}
else
{
    Console.WriteLine($"{num1} and {num2} are equal");
    Console.WriteLine($"{num2} and {num2} are equal");
}


validResponse = true;
while(validResponse == true) 
     {
        Console.Write("Do you want to play again? (Y/N): "); 
        UAnswer = Console.ReadLine().ToUpper();
        if (UAnswer == "Y")
        {
            playAgain = true;
            validResponse = false; 
        }
        else if (UAnswer == "N") 
        {
            playAgain = false; 
            validResponse = false; 
        }
        else 
        {
        validResponse = true; 
        playAgain = false; 
        Console.WriteLine(UAnswer + " is not a valid response. Enter a response again");
        }
    }
Console.WriteLine("Thank you for playing!"); 
}


