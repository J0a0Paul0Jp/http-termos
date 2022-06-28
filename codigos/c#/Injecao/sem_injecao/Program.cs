class Program
{
	static void Main(String[] args)
	{
		Controller controller = new Controller();
		var resultado = controller.Saudacao("João\n");	
		Console.WriteLine(resultado);
		Console.WriteLine("Serviços Oferecidos\n");
		Console.WriteLine(controller.getServicos());
	}
}