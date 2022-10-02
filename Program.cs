using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
          Menu ();
        }

        //Menu para exibir as funçoes para o usuario atravez do Console.writeLine("");//
        static void Menu()
        {
          Console.Clear();
            Console.WriteLine("Escolha Uma das opções Abaixo");
             Console.WriteLine("S = Segundo => 10s = 10 segundos");
               Console.WriteLine("M = Minuto => 1m = 1 Minuto");
                 Console.WriteLine("0 = Sair");
//USAR O TOLOWER PARA NÃO PRECISAR FAZER VERIFICAÇOES COM IF OU ELSE POIS FICARIA MAIS TRABALHOSO//
                    string data = Console.ReadLine().ToLower();
                     //uso do char.Parse para converter a string 
                     //// DATA.LENGTH PARA LER A QUANTIDADE DE CARACTERES QUE O USER DIGITOU PARA PEGARMOS A ULTIMO DIGITO //
                     // -1 porque sempre que envolver numeros 123 etc . (0) zero vem primeiro
                       char type =char.Parse( data.Substring(data.Length-1 , 1));
                       //pegando e fazendo leitura dos primeiros e ulltimo caractere
                       int time = int.Parse(data.Substring(0 , data.Length -1));

                      int multplier = 1;
                        //adicionando um multiplicador
                      if (type == 'm') 
                         multplier = 60;

                      if (time ==0)
                      System.Environment.Exit(0);
                    Start(time * multplier);
                        
        }
              static void Start(int time)
              {
                 int currentTime = 0;
                   while (currentTime != time)
                           {
                           Console.Clear();
                             currentTime++;
                               Console.WriteLine(currentTime);
                                 Thread.Sleep(1000);
                            }
                                     Console.Clear();
                                        Console.WriteLine("Cronometro Finalizado");
                                           Thread.Sleep(2500);
                                             Menu ();
                    //finalizado este processo agora vou criar um Menu abaixo do onde chameu a função //    
            }
    }
}
