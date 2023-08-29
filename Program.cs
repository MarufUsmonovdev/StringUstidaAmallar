using System;

System.Console.WriteLine("Write someting: ");
string str = Console.ReadLine();
System.Console.WriteLine("Enter any number: ");
int x = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(str.Length);
System.Console.WriteLine(d);

string answer = 
    x > d
        ?$"Katta Harf: {str.ToUpper()}"
        :$"Kichkina Harf: {str.ToLower()}";
System.Console.WriteLine(answer);