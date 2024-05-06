using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.src.model
{
    public class Cars:Vehicles 
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        public Cars(){}
        public Cars(){}
        
        public Cars
        (
            
            string VehicleModel,
            string Vehicleplate,  
            string VehicleColor,
            DateTime VehicleBegin,
            int VehicleBegin,
            int vMinutos           
        ):
         base(
                VehicleModel,
                Vehicleplate,
                VehicleColor,
                VehicleBegin,
                vMinutos
         ){
                
        }

        public override void VehicleAdd(){
        public  override void VehicleAdd(){
>>>>>>> dev-estacionamento
             Cars fourWheels = new Cars();
              DateTime dateTime = DateTime.Now;
              Console.Clear();
              Console.WriteLine("Digite dados do Veiculo:"); 
              Console.WriteLine("Modelo do Veiculo: ");
              fourWheels.VehicleModel = Console.ReadLine();
              Console.WriteLine("Placa do Veiculo: ");
              fourWheels.Vehicleplate = Console.ReadLine();
              Console.WriteLine("cor do Veiculo: ");
              fourWheels.VehicleColor = Console.ReadLine();
              fourWheels.VehicleBegin = dateTime;
              Console.Clear();
              auto.Add(fourWheels);
              Console.WriteLine($"Data-{fourWheels.VehicleBegin}");
              fourWheels.VehicleBegin = dateTime.Hour;
              fourWheels.vMinutos = dateTime.Minute;
              Console.Clear();
              auto.Add(fourWheels);
              Console.WriteLine($"Data-{dateTime}");
              Console.Write($"Carro:{fourWheels.VehicleModel}\nPlaca:{fourWheels.Vehicleplate}\nCor:{fourWheels.VehicleColor}\n");
              Console.Write("Cadastrado com sucesso!\n");    
       }
       public override void VehicleRemove(){
                Console.WriteLine("Digite a placa do veículo para remover:");
                string searchPlate = Console.ReadLine();
                 foreach(Cars fourWheels in auto){
                    if(fourWheels.Vehicleplate == searchPlate){
                        string ExitData = Console.ReadLine();
                        Console.Write($"Carro:{fourWheels.VehicleModel}\nPlaca:{fourWheels.Vehicleplate}\nCor:{fourWheels.VehicleColor}\n");
                        auto.Remove(fourWheels);
                         Console.Write("Foi removido!");
                    }else{
                        Console.Write($"O carro de Placa:{searchPlate}\nNão foi cadastrado aqui!");
                    }   
                }                  
              }

               int vEnd,tempoUso,qtdHour;
               int achou = 0;
               string searchPlate,vP;
               DateTime dateTime = DateTime.Now;
               decimal precoInicial = 5.00m, precoTotal;
               Console.WriteLine("Digite a placa do veículo para remover:");
                searchPlate = Console.ReadLine();
                 foreach(Cars fourWheels in auto){
                    if(fourWheels.Vehicleplate == searchPlate){
                         achou = achou + 1; 
                         if(achou > 0)
                         {     
                            Console.WriteLine($"Placa - {fourWheels.Vehicleplate} encontrada");
                            vEnd = dateTime.Hour;
                            Console.WriteLine($"Data/Hora Saida\n ->{dateTime} ");  
                            qtdHour = vEnd -  fourWheels.VehicleBegin;
                             if(qtdHour <= 1){
                                                  
                                                  tempoUso = dateTime.Minute - fourWheels.vMinutos;
                                                  if(tempoUso < 5){
                                                    
                                                   Console.Write("|=======***|TICKET DE SAIDA VEICULO|***=======|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=================|PAGMENTO|==================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|================|DIO DESAFIO|================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write($"|  Estacionamento {dateTime}         |\n"                               );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write($"| Tempo de Uso -> {tempoUso}Min                     |\n"                );
                                                   Console.Write($"| Saldo Devedor R$-{precoInicial}                       |\n"            );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write($"| Carro -> {fourWheels.VehicleModel}                                |\n");
                                                   Console.Write($"| Placa -> {fourWheels.Vehicleplate}                           |\n"     );
                                                   Console.Write("| Removido com Sucesso !                      |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   auto.Remove(fourWheels);
                                                  }
                                                  else if(tempoUso == 5 || tempoUso <= 30){
                                                    decimal saldo = 1.25m;
                                                    precoInicial = precoInicial + saldo;
                                                   Console.Write("|=======***|TICKET DE SAIDA VEICULO|***=======|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=================|PAGMENTO|==================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|================|DIO DESAFIO|================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write($"|  Estacionamento {dateTime}         |\n"                               );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write($"| Tempo de Uso -> {tempoUso}Min                       |\n"              );
                                                   Console.Write($"| Saldo Devedor R$-{precoInicial}                       |\n"            );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write($"| Carro -> {fourWheels.VehicleModel}                                |\n");
                                                   Console.Write($"| Placa -> {fourWheels.Vehicleplate}                           |\n"     );
                                                   Console.Write("| Removido com Sucesso !                      |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   auto.Remove(fourWheels);
                                                  }else{
                                                  precoInicial = precoInicial + 2.50m;
                                                   Console.Write("|=======***|TICKET DE SAIDA VEICULO|***=======|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=================|PAGMENTO|==================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|================|DIO DESAFIO|================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write($"|  Estacionamento {dateTime}         |\n"                               );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write($"| Minutos de Uso -> {tempoUso}                        |\n"              );
                                                   Console.Write($"| Saldo Devedor R$-{precoInicial}                       |\n"            );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write($"| Carro -> {fourWheels.VehicleModel}                                |\n");
                                                   Console.Write($"| Placa -> {fourWheels.Vehicleplate}                           |\n"     );
                                                   Console.Write("| Removido com Sucesso !                      |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   auto.Remove(fourWheels);
                                                

                                                  }
                                                  
                                            }else{  
                                                  tempoUso = dateTime.Hour - fourWheels.VehicleBegin;
                                                   
                                                   precoTotal = precoInicial*qtdHour;
                                                   Console.Write("|=======***|TICKET DE SAIDA VEICULO|***=======|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=================|PAGMENTO|==================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|================|DIO DESAFIO|================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write($"|  Estacionamento {dateTime}         |\n"                               );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|                                             |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write($"| Horas de Uso -> {tempoUso}                          |\n"              );
                                                   Console.Write($"| Saldo Devedor R$-{precoInicial}                       |\n"            );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   Console.Write($"| Carro -> {fourWheels.VehicleModel}                                |\n");
                                                   Console.Write($"| Placa -> {fourWheels.Vehicleplate}                           |\n"     );
                                                   Console.Write("| Removido com Sucesso !                      |\n"                       );
                                                   Console.Write("|=============================================|\n"                       );
                                                   auto.Remove(fourWheels);
                                                 }
                     
                         }else{
                                Console.Write($"O carro de Placa:{searchPlate}\nNão foi cadastrado aqui!");
                             }
                    }
                }                          
            }                  
            public void VehicleList()
            {
                if(auto.Count > 0){
                      foreach(Cars item in auto)
                      {Console.WriteLine("Carro:"+item.VehicleModel+"\nPlaca:"+item.Vehicleplate+"|Cor:"+item.VehicleColor); }

                }else
                {
                  Console.WriteLine("Não há veículos estacionados.");  
                }
                

            }  
                  
        }    
    }    
                
                else
                {
                  Console.WriteLine("Não há veículos estacionados.");  
                }
            }  
                  
        }    
}
       
>>>>>>> dev-estacionamento
