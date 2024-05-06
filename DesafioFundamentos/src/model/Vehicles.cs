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
        public Vehicles(string VehicleModel, string Vehicleplate,  string VehicleColor, int VehicleBegin, int vMinutos){
            
          this.VehicleModel = VehicleModel;
          this.Vehicleplate = Vehicleplate;
          this.VehicleColor = VehicleColor;
          this.VehicleBegin = VehicleBegin;
          this.vMinutos = vMinutos;
        }

     
      
      public string? VehicleModel{get; set;} 
      public string? Vehicleplate{get; set;}
      public string? VehicleColor{get; set;}

    

      public int VehicleBegin { get; set;}
      public int vMinutos { get; set;}

      public List<Vehicles> auto = new();  

      public virtual void VehicleAdd(){}

      public virtual void VehicleRemove(){}
        public virtual void ListVehicles(){}
    }
}
