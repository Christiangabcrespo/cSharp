using System;

namespace Ejercico03
{

    public class Password
    {

        //Atributos

        /**
         * Longitud de la contraseña
         */
        private int longitud;

        private string contraseña;

        //Metodos publicos

        public int getLongitud()
        {
            return longitud;
        }
        public void setLongitud(int longitud)
        {
            this.longitud = longitud;
        }

        public string getContraseña()
        {
            return contraseña;
        }
        public string generaPassword()
        {
            string password = "";
            char[] letras = {'Q','W','E','E','R','T','Y','U','I', 'O', 'P', 'A','S','D','F','G', 'H', 'J', 'K', 'L'
            ,'Ñ','Z','X','C','V','B','N','M','q','w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l'
            ,'ñ','z','x','c','v','b','n','m','0','1','2','3','4','5','6','7','8','9'};
            Random random = new Random();
            for (int i = 0; i < this.longitud; i++)
            {
                int letraR = random.Next(letras.Length);
                password = password + letras[letraR];
            }
            return password;
        }

        public bool esFuerte()
        {
            int cuentanumeros = 0;
            int cuentaminusculas = 0;
            int cuentamayusculas = 0;
            //Vamos caracter a caracter y comprobamos que tipo de caracter es
            for (int i = 0; i < contraseña.Length; i++)
            {
                if (contraseña[i] >= 97 && contraseña[i] <= 122)
                {
                    cuentaminusculas += 1;
                }
                else
                {
                    if (contraseña[i] >= 65 && contraseña[i] <= 90)
                    {
                        cuentamayusculas += 1;
                    }
                    else
                    {
                        cuentanumeros += 1;
                    }
                }
            }
            //Si la constraseña tiene mas de 5 numeros, mas de 1 minuscula y mas de 2 mayusculas
            if (cuentanumeros > 5 && cuentaminusculas > 1 && cuentamayusculas > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Constructores
        /**
         * Crea una contraseña al azar
         */
        public Password(int longitud)
        {
            this.longitud = longitud;
            contraseña = generaPassword();
        }
        public Password(object longitud)
        {
            this.longitud = (int)longitud;
            contraseña = generaPassword();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un tamaño para el array: ");
            string tamanioIngresado = Console.ReadLine();
            int tamanioParse = Int32.Parse(tamanioIngresado);

            Console.Write("Introduce la longitud del password: ");
            string longIngresado = Console.ReadLine();
            int longParse = Int32.Parse(longIngresado);

            Password[] listaPasswords = new Password[tamanioParse];
            bool[] fortalezaPassword = new bool[tamanioParse];

            for (int i = 0; i < listaPasswords.Length; i++)
            {
                Password pass = new Password(longParse);
                listaPasswords[i] = pass;
                fortalezaPassword[i] = listaPasswords[i].esFuerte();
                Console.WriteLine(listaPasswords[i].getContraseña() + " " + fortalezaPassword[i]);
            }
            Console.ReadKey();
        }
    }
}
