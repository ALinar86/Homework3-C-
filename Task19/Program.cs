void Palindrome(string number)
{
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine("Yes, your number is palindrome.");
  }
  else Console.WriteLine("No, your number isn't palindrome.");
}
Console.Write("Input five-digit number: ");
string number = Convert.ToString(Console.ReadLine());
if (number.Length == 5)
{
  Palindrome(number);
}
else Console.WriteLine("Input the correct number");
