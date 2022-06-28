using service;

class Controller
{
	private readonly IAtendenteService _atendenteService;

	public Controller(IAtendenteService atendenteService)
	{
		_atendenteService = atendenteService;
	}

	public string Saudacao(String nome)
	{
		return _atendenteService.Saudacao(nome);
	}
}