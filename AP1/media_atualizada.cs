using System;

class media 
{
	public static void Main()
	{
		float n1 = 0;
		float n2 = 0;
		float media = 0;
		
		Console.WriteLine("Informe a nota da G1: ");
		n1 = float.Parse(Console.ReadLine());
		
		Console.WriteLine("Informe a nota da G2: ");
		n2 = float.Parse(Console.ReadLine());
		
		media = (n1+(n2*2))/3;
		
		if(media>=6)
		
		{
		Console.WriteLine("parabéns, tu é fodão e passou com a média " + media); 
	}
		else
		{
		Console.WriteLine("você é burro e foi reprovado com a media " + media);
	}
		
		Console.ReadLine(); 
		
		
		
	}	
}
