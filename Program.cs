const string SenhaCorreta = "Gui@1708";
string senha, permissaoAcesso;

Console.Write("Olá, usuário. Por favor, digite sua senha: ");
senha = Console.ReadLine()!;

permissaoAcesso = senha == SenhaCorreta ? "permitido" : "negado";

Console.WriteLine($"Acesso {permissaoAcesso}");