public string AcceptsANumber(int i)
{
   // when the number is divisible by 3 return the word fizz
   if (i % 3 == 0 )
   {
        return "fizz";
   }
   //when the number is divisible by 5 return the word buzz
   if(i % 5 == 0)
   {   
        return "buzz";
   }
   //when the number is divisible by both, return the word fizzbuzz
   if(i % 5 == 0 && i % 3 == 0)//if it is modulous 5 and modulous 3 then return fizzbuzz 
   {
        return "fizzbuzz";
   }
   else
   {
        Console.WriteLine("Can not determine");
   }
}