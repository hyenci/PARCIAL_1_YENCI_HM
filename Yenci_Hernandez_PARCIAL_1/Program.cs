using System;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("**************");
            Console.WriteLine("PROGRAMA NO.1");
            Console.WriteLine("**************");

            Console.WriteLine("Ingrese un número entero positivo:");
            int numi1 = int.Parse(Console.ReadLine());


            int opi = 0;
            do
            {
                Console.WriteLine("***********************************");
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1. Calcular factorial");
                Console.WriteLine("2. Calcular raíz cuadrada");
                Console.WriteLine("3. Salir del programa");
                Console.WriteLine("**************************************");


                opi = int.Parse(Console.ReadLine());


                switch (opi)
                {
                    case 1:
                        int factorial = 1;

                        for (int i = 1; i <= numi1; i++)
                        {
                            factorial *= i;
                        }

                        Console.WriteLine("El factorial del numero ingresado es:" + factorial);



                        break;
                    case 2:
                        double raizCuadrada = Math.Sqrt(numi1);
                        Console.WriteLine("La raiz cuadrada es:" + raizCuadrada);
                        break;
                    case 3:
                        Console.WriteLine("¡GRACIAS POR USAR ESTE PROGRAMA!");
                        break;
                    default:
                        Console.WriteLine("Opcion ingresada incorrecta, pr favor vuelva a intentarlo");
                        break;
                }


                Console.WriteLine("TOCA UNA TECLA PARA VOLVER AL MENU PRINCIPAL");


            } while (opi != 3);

            Console.WriteLine("");
            Console.WriteLine("**************");
            Console.WriteLine("PROGRAMA NO.2 CALCULADORA");
            Console.WriteLine("**************");
            Console.WriteLine("");
            Console.WriteLine("Ingrese los numeros para realizar la operacion");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el primer numero");
            int numir = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Ingrese el primer numero");
            int numir2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Ingrese el operador logico correspondinete a la operacion que desea realizar");
            string operador = Console.ReadLine();

            if (operador == "+")
            {
                int suma = numir + numir2;

                Console.WriteLine("El resultado de la suma es: " + suma);
            }
            else if (operador == "-")
            {

                int resta = numir - numir2;

                Console.WriteLine("El resultado de la resta es: " + resta);
            }
            else if (operador == "*")
            {

                int multi = numir * numir2;

                Console.WriteLine("El resultado de la multiplicación es: " + multi);
            }
            else if (operador == "/")
            {

                double divi = numir / numir2;

                Console.WriteLine("El resultado de la división es: " + divi);
            }
            else
            {
                Console.WriteLine("EL OPERADOR QUE INGRESO ES INCORRECTO POR FAVOR VOLVER A INTENTAR");
            }

            Console.WriteLine("**************************************");
            Console.WriteLine("PROGRAMA NO.3 TABLAS DE MULTIPLICACIÓN");
            Console.WriteLine("**************************************");

            Console.WriteLine("");
            Console.WriteLine("Ingrese el numero que desea ver su tabla de multiplicación de 1 a 10");
            int multnumi = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {


                int tabli = multnumi * i;


                Console.WriteLine("Resultado: " + tabli);





            }


            Console.WriteLine("**************");
            Console.WriteLine("PROGRAMA NO.4");
            Console.WriteLine("**************");
            Console.WriteLine("");
            Console.WriteLine("Ingresa valores enteros positivos hasta encontrar el numero secreto entre 1 a 100");
            int opis = 0;
            int numsecre = 21;

            do
            {
                opis = int.Parse(Console.ReadLine());

                if (opis < numsecre)
                {

                    Console.WriteLine("Su numero ingresado es menor al numero secreto");


                }
                else if (opis > numsecre)
                {
                    Console.WriteLine("Su numero ingresado es mayor al numero secreto");
                }
                else
                {
                    Console.WriteLine("¡FELICIDADES HA ENCONTRADO EL NUMERO SECRETO¡");
                }



            }
            while (opis != 21);

            Console.WriteLine("TOCA UNA TECLA PARA VOLVER AL MENU PRINCIPAL");

        }

        catch
        {

            Console.WriteLine("HA OCURRIDO UN ERROR EN EL PROGRAMA");

        }

    }


}
