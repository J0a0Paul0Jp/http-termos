class Controller
{
	public string Saudacao(String nome)
	{
		var atendente = new AtendenteService();
		return atendente.Saudacao(nome);
	}

	public string getServicos()
	{
		var atendente = new AtendenteService();
		return atendente.ServicosOferecidos();
	}
}