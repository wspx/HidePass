using System;
using System.Text;

namespace HidePass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Usuario...");

            Console.Write("Ditige a tua senha: ");
            
            //Criando uma StringBuilder para armazenar a senha digitada
            StringBuilder senha = new StringBuilder();



            //Laço responsavel por ficar lendo a entrada do teclado
            //ate que a tecla ENTER for pressinada
            while(true)
            {
                var TeclaDigitada = Console.ReadKey(true);

                    if( TeclaDigitada.Key == ConsoleKey.Enter) 
                        break;//Para a execucao quando a tecla ENTER for pressionada
                    else if( TeclaDigitada.Key == ConsoleKey.Backspace && senha.Length > 0)
                        senha.Remove( senha.Length-1, 1); //Remove do fim, 1 caractere da StringBuilder
                    else
                        senha.Append(TeclaDigitada.KeyChar); //Adicionar o caractere na StringBuilder
            }

            Console.WriteLine("\n"); //Pula Linha para deixar a visualização mais agradavel
            Console.WriteLine($"Senha Digitada: {senha.ToString()}");


        }
    }
}
