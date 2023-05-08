using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new EMPDBEntities())
            //{ 
            //            {
            //                var std = new CLIENT_MASTER()
            //                {
            //                    CLIENTNO = "C0006",
            //                    NAME = "Gates",
            //                    ADDRESS1 = "kalarikkal",
            //                    ADDRESS2 = "parakkal",
            //                    CITY = "kochi",
            //                    STATE = "KARNATAKA",
            //                    Phone_no = "9876543213",
            //                    BALDUE = 1076


            //,
            //                };
            //context.CLIENT_MASTER.Add(std);



            using (var context = new EMPDBEntities())
            { 
            var obj  =  context.CLIENT_MASTER.Where(Y => Y.CLIENTNO == "C0002").First<CLIENT_MASTER>();
                obj.NAME = "HARI";
               
                    
                        //context.CLIENT_MASTER.Remove(obj);       FOR REMOVING.
             



                context.SaveChanges();
            }
        }
    }
}
