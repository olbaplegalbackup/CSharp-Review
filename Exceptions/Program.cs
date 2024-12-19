using System;

namespace Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var arr = new int[3];

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                //     // System.IndexOutOfRangeException
                //     Console.WriteLine(arr[index]);
                // }

                Cadastrar("asdlkfj");
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Não encontrei o indice na lista.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Falha ao cadastrar o texto");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Exceção customizada");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Ops... Algo deu errado!");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }
        }

        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new MinhaException(DateTime.Now);
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}