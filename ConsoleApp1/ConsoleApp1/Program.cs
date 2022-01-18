// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string final = "";
for (int i = 0; i < 2022; i++)
{
    int reversed = 0;
    int norevser = i;
     reversed =reverse(i);
   
    if (norevser != reversed)
    {

        if (reverse(norevser * norevser) == reversed*reversed)
        {
            Console.WriteLine("carré :" + reverse(norevser * norevser));
            Console.WriteLine("carré :" + reversed * norevser);
            Console.WriteLine("resultat : " + norevser);
        }
    }



    int reverse(int i)
    {
        int norevser = i;
        int j = i;
        int reverse = 0, rem;

        while (j != 0)
        {
            rem = j % 10;
            reverse = reverse * 10 + rem;
            j /= 10;
        }
        final += i + "; ";
        return reverse;

    }
}

