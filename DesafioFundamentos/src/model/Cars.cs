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
        public Cars
        (
            
            string VehicleModel,
            string Vehicleplate,  
            string VehicleColor,
            DateTime VehicleBegin
            
        ):
         base(
                VehicleModel,
                Vehicleplate,
                VehicleColor,
                VehicleBegin
         ){
                
        }
       
        
        public override void VehicleAdd(){
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
