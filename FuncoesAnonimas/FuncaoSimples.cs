using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuncoesAnonimas
{
    public class FuncaoSimples
    {
        public void Executar (){      
            //Chamada do Método Padrão               
            Console.WriteLine(EhMaiorQueZero(5));
            Console.WriteLine(EhMaiorQueZero(-5));

            //Declaração da função em uma variavel 
            Func<int, bool> EhMaiorQueZeroFuncao = num => num > 0;

            //chamando a função 
            Console.WriteLine(EhMaiorQueZeroFuncao(5));
            Console.WriteLine(EhMaiorQueZeroFuncao(-5));
            
            //passando a função por parâmetro
            ExecutarFuncoes(EhMaiorQueZeroFuncao);

            //Criando uma função diretamente 
            ExecutarFuncoes(num => num > 0);
        }

        //Métodos Tradicionais 
        //MétodoPadrão
        private bool EhMaiorQueZero (int num) => num > 0;
        //Método resumido usando =>
        private bool EhMaiorQueZero1 (int num) {
        return  num > 0;
        }

        //Método que Recebe uma função anonima
        private void ExecutarFuncoes(Func<int, bool> funcao){
            int num = 5 ; 
            Console.WriteLine(funcao(num));
        }
    }
}