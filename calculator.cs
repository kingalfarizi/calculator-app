class Calculator
{
	static void main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, penambahan(a,b));
		Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, pengurangan(a,b));
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.ReadKey();
	}
	
	public int penambahan(int a, int b)
	{
		return a + b;
	}
	
	public int pengurangan(int a, int b)
	{
		return a - b;
	}
}