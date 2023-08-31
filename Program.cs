// See https://aka.ms/new-console-template for more information

class Program {
    static void Main(String[] args) {
            //int n = 30;
            //int retorno=Fibonacci(n);
            //Console.WriteLine("Posição  " + n +" de Fibonacci = " + retorno);
            /*int f = 5;
            int fatorial = Fatorial(f);
            Console.WriteLine("Fatorial de  " + f +" é: " + fatorial);*/
            //int []vetor = new int []{1, 2, 3, 4};
            //int retornoVetor = SomaVetor(vetor,0);
            //Console.WriteLine("A soma do vetor é: " + retornoVetor);
            //int retornoMult = Multiplicacao(5,5);
            //Console.WriteLine("A multiplicação entre os dois números é : "+ retornoMult);

        //int retornoPotencia = Potencia(2, 5);
        //Console.WriteLine("O resultado da potenciação é: " + retornoPotencia);

        //string frase = "Esta é uma frase de exemplo.";
        //char letra = 'e';
        //int retornoOcorrencia = OcorreLetra(frase, letra);
        //Console.WriteLine("O nº de ocorrecias da lentra é: "+ retornoOcorrencia);

        //int []vetor = new int []{1, 2, 3, 4};
        //int retornoSomaPar = SomaPar(vetor,0);
        //Console.WriteLine("A soma do vetor de ordem par  é: " + retornoSomaPar);

        //string frase = "Esta é uma frase de exemplo.";
        //string retornoFraseSemVogal = RemoverVogais(frase);
        //Console.WriteLine(frase);
        //Console.WriteLine("Sem vogal: "+ retornoFraseSemVogal);

        int n = 2020;
        string retorno = Binario(n);
        string invertePilha = "";
        for (int i = (retorno.Length)-1; i >= 0; i--){
            invertePilha += retorno[i];
        }
        Console.WriteLine(invertePilha);
    
    }

    public static int Fatorial(int n){
            if (n == 1){
                return n;
            }else{
                int f = n * Fatorial(n-1);
                return f;
            }
        }
       public static int Fibonacci(int n){
            if (n == 0){
                return 0;
            }
            if (n == 1){
                return 1;
            }

            return Fibonacci(n-1) + Fibonacci(n-2);
        }

        public static int SomaVetor (int[]v, int pos){
            if(pos >= v.Length){
                return 0;
            }
            return v[pos] + SomaVetor(v,pos+1);
        }

        public static int Multiplicacao(int A, int B){ 
            if (B == 1)
                return A;
            return A + Multiplicacao(A , B-1);
        }

       

        public static int Potencia(int A, int B){
            if (B == 0){
                return 1;
            }
            return A * Potencia(A, B-1);
        }

        public static int OcorreLetra(string F, char L){
            if (F.Length == 0){
                return 0;
            }else{
                if (F[0] == L){

                    return 1 + OcorreLetra(F.Substring(1), L);
                }else{
                    return OcorreLetra(F.Substring(1), L);
                }
            }

        }

        public static int SomaPar(int[] vetor,int pos){
            if(pos == vetor.Length){
                return 0;
            }
            return vetor[pos] + SomaPar(vetor, pos+2);
            
        }

        static bool EhVogal(char c)
        {
        // Verifica se o caractere é uma vogal (maiúscula ou minúscula).
            return "AEIOUaeiou".Contains(c);
        }

        static string RemoverVogais(string frase){
        // Caso base: a frase está vazia, retorne uma string vazia.
            if (frase.Length == 0)
            {
                return "";
            }
            else
            {
            // Verifique se o primeiro caractere da frase é uma vogal.
            // Se for uma vogal, não o inclua na string resultante.
                if (EhVogal(frase[0]))
                {
                    return RemoverVogais(frase.Substring(1));
                }
                else
                {
                // Se não for uma vogal, inclua-o na string resultante e continue verificando o restante da frase.
                    return frase[0] + RemoverVogais(frase.Substring(1));
                }
        }
    }

        static string Binario(int n){
            if (n == 1){
                return (n).ToString();
            }

            return (n%2).ToString() + Binario(n/2);
        }
}


