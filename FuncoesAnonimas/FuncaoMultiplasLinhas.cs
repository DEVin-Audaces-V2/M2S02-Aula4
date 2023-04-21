namespace FuncoesAnonimas
{
    public class FuncaoMultiplasLinhas
    {
        public void Executar (){
            Func<int,int,int> SomaFunc = (num1, num2) => {
                int resultado =  num1 + num2 ;
                Console.WriteLine(resultado);
                return resultado;
            };

            Console.WriteLine(SomaFunc(1,5));
        }
        private int Soma(int num1, int num2){
            int resultado =  num1 + num2 ;
            Console.WriteLine(resultado);
            return resultado;
        }
    }
}