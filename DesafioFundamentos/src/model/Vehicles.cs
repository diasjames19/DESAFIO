using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.src.model
{

     /* 
            type, model, color, plate, brand
        
        */
    public  abstract class Vehicles
    {

        public Vehicles(){}
<<<<<<< HEAD
<<<<<<< HEAD
        public Vehicles(string VehicleModel, string Vehicleplate,  string VehicleColor, DateTime VehicleBegin){
=======
        public Vehicles(string VehicleModel, string Vehicleplate,  string VehicleColor, int VehicleBegin, int vMinutos){
>>>>>>> dev-estacionamento
=======
        public Vehicles(string VehicleModel, string Vehicleplate,  string VehicleColor, int VehicleBegin, int vMinutos){
>>>>>>> dev-estacionamento
            
          this.VehicleModel = VehicleModel;
          this.Vehicleplate = Vehicleplate;
          this.VehicleColor = VehicleColor;
          this.VehicleBegin = VehicleBegin;
<<<<<<< HEAD
<<<<<<< HEAD

        }

=======
=======
>>>>>>> dev-estacionamento
          this.vMinutos = vMinutos;
        }

     
<<<<<<< HEAD
>>>>>>> dev-estacionamento
=======
>>>>>>> dev-estacionamento
      
      public string? VehicleModel{get; set;} 
      public string? Vehicleplate{get; set;}
      public string? VehicleColor{get; set;}

<<<<<<< HEAD
<<<<<<< HEAD
        public DateTime VehicleBegin { get; set;}
=======
=======
>>>>>>> dev-estacionamento
    

      public int VehicleBegin { get; set;}
      public int vMinutos { get; set;}

<<<<<<< HEAD
>>>>>>> dev-estacionamento
=======
>>>>>>> dev-estacionamento
      public List<Vehicles> auto = new();  

      public virtual void VehicleAdd(){}

      public virtual void VehicleRemove(){}
        public virtual void ListVehicles(){}
    }
}
