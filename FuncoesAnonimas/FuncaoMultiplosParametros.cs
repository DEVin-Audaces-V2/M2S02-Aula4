
namespace FuncoesAnonimas
{
    public class FuncaoMultiplosParametros
    {
        public void Executar(){
            //Chamada do método tradicional 
            bool resultado1 = EhMaior(5,2);
            bool resultado2 = EhMaior(1,6);

            //Criar uma função anonima
            Func<int, int, bool> EhMaiorFuncao = (num1, num2) => num1>num2;
            bool resultado3 = EhMaiorFuncao(5,2);
            bool resultado4= EhMaiorFuncao(1,6);

        }

        private bool EhMaior(int num1, int num2){
            return num1> num2;
        }
        private bool EhMaiorResumido(int num1, int num2) => num1>num2;
    }
}