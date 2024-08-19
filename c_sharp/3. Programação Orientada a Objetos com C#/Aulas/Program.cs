using Aulas.Models;

//Pessoa pessoa = new("Humano", 0); //não pode mais ser instaciada, pois é abstract. Classe somente para herança, tentar instaciar causa uma exceção.
Aluno aluno = new("Lex", 18, 10);
Professor professor = new("Lexus", 20, 1000);

//pessoa.Apresentar();
aluno.Apresentar();
professor.Apresentar();

professor.PagarContas();