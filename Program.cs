// See https://aka.ms/new-console-template for more information

class Program {
    static void Main(String[] args)  {
            //int n = 30;
            //int retorno=Fibonacci(n);
            //Console.WriteLine("Posição  " + n +" de Fibonacci = " + retorno);
            /*int f = 5;
            int fatorial = Fatorial(f);
            Console.WriteLine("Fatorial de  " + f +" é: " + fatorial);*/
            int []vetor = new int []{1, 2, 3, 4};
            int retornoVetor = SomaVetor(vetor,0);
            Console.WriteLine("A soma do vetor é: " + retornoVetor);
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

      


}


