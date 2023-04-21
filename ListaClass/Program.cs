using ListaClass;

List<Aluno> listAluno = new List<Aluno>();

Aluno aluno = new Aluno(1, "Vitor", "R Pamonha", "12345");

var aluno2 = new Aluno(2, "Marco", "R Girassois", "12345");

listAluno.Add(aluno);
listAluno.Add(aluno2);
listAluno.Add(new Aluno(3, "Beatriz", "R Sol", "12345"));

listAluno.Add(new Aluno(4, "João", "R Girassois", "12345"));


Aluno alunoSelecionado;
foreach(Aluno alunoInterado in listAluno){
  if (alunoInterado.Nome == "Beatriz"){
    alunoSelecionado = alunoInterado;
    break; // Utilizado para sair da repetição
  }
}


//Usando Linq
Aluno alunoSleecionadoFind = listAluno.Find( aluno => aluno.Nome == "Beatriz");
Aluno alunoSleecionadoMeuFind = MeuFind(aluno => aluno.Nome == "Beatriz", listAluno);


List<Aluno> alunosQueMoramNaGirassol = listAluno.Where(aluno => aluno.Endereco == "R Girassois").ToList();

bool verificaSeTemVitor = listAluno.Exists(x => x.Nome == "Vitor");
bool verificaSeTemCamila = listAluno.Exists(aluno => aluno.Nome == "Camila");


Console.ReadLine();

//Simulação do método find do linq 
Aluno MeuFind (Func<Aluno, bool> filtro, List<Aluno> alunos){
  foreach(Aluno alunoInterado in alunos){
    if (filtro(alunoInterado)){
      return alunoInterado;
    }
  }
  return null;
}
