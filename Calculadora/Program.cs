using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora

    {
        static void Main(string[] args)
        {


            //variables para entrar a los diferentes menús

            Menu();
            
          


        }

        public static void Menu()
        {
            string seleccionar;


            //Menú de opciones.

            Console.WriteLine(" 1 - Modo Manual.");

            Console.WriteLine(" 2 - Modo Automático.");

            Console.WriteLine(" 0 - Salir.");

            seleccionar = Console.ReadLine();

            switch (seleccionar)
            {
                case "1":

                    manual();

                    break;

                case "2":

                    automatico();

                    break;

                case "0":

                    salir();

                    break;

                default:

                    Console.WriteLine("Opción incorrecta, prueba con los dígitos indicados");

                    Menu();

                    break;



            }
        }
        //Función manual: consiste en introducir el signo de la operación y los valores que vamos a utilizar para que la aplicación pueda calcular el resultado.
        public static  void  manual()
            {

                int valor1;
                int valor2;
                string signo;
            

                //Mediante este fragmento de código se piden los valores (valor1 y valor 2) y el signo de la operación(signo).

                Console.WriteLine("Bienvenido al modo Manual, ¿Qué operación quiere realizar?");
                signo = Console.ReadLine();

                if (signo == "^")
                {
                    Console.WriteLine("Indice la base de la potencia");
                    valor1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Indique el exponencial de la potenia");
                    valor2 = int.Parse(Console.ReadLine());
                }
                else
                {

                    Console.WriteLine("Inserte un valor");
                    valor1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Inserte un valor");
                    valor2 = int.Parse(Console.ReadLine());
                }

                // Funciones de calculadora. Tenemos la lista de las operaciones que se es capaz de realizar la aplicación.

                int sumar = valor1 + valor2;
                int restar = valor1 - valor2;
                int multiplicar = valor1 * valor2;
                int dividir = valor1 / valor2;
                double potencia = Math.Pow(valor1, valor2);//Pendiente de hacer sin la libreria Math.Pow. 



            switch(signo)
                {
                            case "+":
                                Console.WriteLine($"El resultado de la suma entre {valor1} y {valor2} es {sumar}");
                    Menu();
                    break;
                            case "-":
                                Console.WriteLine($"El resultado de la resta de {valor1} y {valor2} es {restar}");
                    Menu();
                    break;
                            case "*":
                                Console.WriteLine($"El resultado de multiplicar {valor1} por {valor2} es {multiplicar}");
                    Menu();
                    break;
                            case "/":
                                Console.WriteLine($"El resultado de la división entre {valor1} y {valor2} es {dividir}");
                    Menu();
                break;

                           case "^":
                           Console.WriteLine($"El resultado de la potencia con base {valor1} y exponente {valor2} es {potencia}");
                    Menu();
                    break;

                default:
                                Console.WriteLine("Opción Incorrecta");

                    Menu();

                break;



            }

        }
        //Función automatica de operaciones de una cifra, que permite realizar calculos automaticos sin necesidad de indicar previamente el signo.
        public static void automatico()
            {
                string operacion;


                Console.WriteLine("Bienvenido al modo Automático, por favor, introduzca la Operación que quiere realizar");
                operacion = Console.ReadLine();
            
            if (operacion.Length > 3)
            {
                Console.WriteLine("Esa operación no se puede realizar");
                Menu();
            }
            //Dividimos el string operacion en 3 substrings diferentes. Las variables valor3 y valor 5 pertenencen a los números, por lo que vamos a convertilas en variables tipo int.
                string valor3 = operacion.Substring(0,1);
                string valor4 = operacion.Substring(1, 1);
                string valor5 = operacion.Substring(2,1);

                int valor3conv = Int32.Parse(valor3);
                int valor5conv = Int32.Parse(valor5);
            
            
            
            //mediante este switch, en el cual introducimos el valor4 (sería el operador de la operación), podemos determinar que calculo se está realizando.
            switch(valor4)
                {
                            case "+":
                                Console.WriteLine($"El resultado de la suma entre {valor3conv} y {valor5conv} es {valor3conv+valor5conv}");
                    Menu();
                    break;
                            case "-":
                                Console.WriteLine($"El resultado de la resta de {valor3conv} y {valor5conv} es {valor3conv-valor5conv}");
                    Menu();
                    break;
                            case "*":
                                Console.WriteLine($"El resultado de multiplicar {valor3conv} y {valor5conv} es {valor3conv*valor5conv}");
                    Menu();
                    break;
                            case "/":
                                Console.WriteLine($"El resultado de la división entre {valor3conv} y {valor5conv} es {valor3conv/valor5conv}");
                    Menu();
                    break;

                           case "^":
                           Console.WriteLine($"El resultado de la potencia con base {valor3conv} y exponente {valor5conv} es {Math.Pow(valor3conv, valor5conv)}");
                    Menu();
                    break;

                default:
                                Console.WriteLine("Opción Incorrecta");
                    Menu();
                    break;



            }

        }

        //Función para salir de la consola de la aplicación.
        public static void salir()
            {
                Console.WriteLine(" °º¤ø,¸¸,ø¤º°`°º¤ø,¸( Hasta la próxima )¸,ø¤º°`°º¤ø,¸,ø¤º°");
                Environment.Exit(0);
            }
        }
    }
