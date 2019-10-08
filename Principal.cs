using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    class Principal
    {
        Unidad u= new Unidad(); //Intancia de la clase Unidad
        

        public void Menu() // Metodo menu donde se le muestra al usuario las opciones que puede realizar
        {
            Console.WriteLine("    BIENVENIDO");
            Console.WriteLine();
            Console.WriteLine("Seleccione la conversion que desea realizar?");
            Console.WriteLine();
            Console.WriteLine("1) Centrimetros a Metros");
            Console.WriteLine("2) Metros a Pulgadas");
            Console.WriteLine("3) Litros a Mililitros");
            Console.WriteLine();
            int r;

            double res;
            r = Convert.ToInt32(Console.ReadLine());
            Conversiones con = new Conversiones();
          
            
            switch (r) //declaracion de un swithc para elegir la opcion
            { 
                case 1:
                {
                       
                res = con.CentrimetrosMetros(u);
                        Console.WriteLine();
                        Console.WriteLine(res + " Metros");
                        Console.ReadKey();

                    break;
                }
                case 2:
                    {
              res =     con.MetrosPulgadas(u);
                        Console.WriteLine();
                        Console.WriteLine(res + " Pulgadas");
                        Console.ReadKey();
                        break;
                    }
                    
                case 3:
                    {
                res =   con.MililitrosLitros(u);
                        Console.WriteLine();
                        Console.WriteLine(res + " Litros");
                        Console.ReadKey();
                        break;
                    }
                case 4:
                
            
                        break;
                        default:
                        break;
            

        }

        }
        }    
} 
    


