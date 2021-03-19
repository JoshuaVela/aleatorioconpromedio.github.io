using System;

namespace Trabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num_random = Generador_ConMix(4,5,7,8); 
            // promedio(num_random);
            if(promedio(num_random) && poker(num_random))
            {
                Console.WriteLine("No se rechaza la hipotesis");
            }else
            {
                Console.WriteLine("Se rechaza la hipotesis");
            }
// SET != lista entonces habia repetidos
            // la serie es completa si no hay numeros repetidos
            // for lista numeros primos a,c, m=1001, X_0= nuemro de la suerte
            // las series que pasasn las guardan en archivo.
            for(int i=0; i<num_random.Length;i++)
            {
                Console.WriteLine(num_random[i]);
            }
        }
        public static double[] Generador_ConMix (int x0, int a, int c, int mod)
        {
            int Xn;
            int Xsig=0;
            Xn = x0;
            double[] num_random = new double[mod];
                //mod porcentaje division que da el residuo 
            for(int i = 0; i < mod; i++)
            {
                Xsig = ((a*Xn)+c)%(mod);
                // Console.WriteLine(Xsig);
                Xn=Xsig;
                num_random[i] = (Xsig*1.0)/mod;
            }
            return num_random;
        }

        // 1,2,3,4
        
        static bool promedio (double[] num_random)
        {
            double formula;
            double promedio;
            double suma = 0;
            for(int i = 0; i < num_random.Length; i++)
            {
                suma = num_random[i] + suma;
            }
            promedio = suma/num_random.Length;
            formula = Math.Abs(((0.5 - Math.Abs(promedio))*4.4721)/0.28867513);
            Console.WriteLine(formula);
            Console.WriteLine(promedio);
            if(formula < 1.96)
            {
                return true;
            }else
            {
                return false;
            }
        }

        static bool poker (double[] num_random)
        {
            double formula;
            double promedio;
            double suma = 0;
            for(int i = 0; i < num_random.Length; i++)
            {
                suma = num_random[i] + suma;
            }
            promedio = suma/num_random.Length;
            formula = Math.Abs(((0.5 - Math.Abs(promedio))*4.4721)/0.28867513);
            Console.WriteLine(formula);
            Console.WriteLine(promedio);
            if(formula < 1.96)
            {
                return true;
            }else
            {
                return false;
            }
        }


    }
}
