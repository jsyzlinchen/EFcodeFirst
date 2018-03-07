using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyUse.MyGeneric
{
    class Program
    {
        /// <summary>
        /// 泛型的引入，声明，和使用
        /// 泛型的原理
        /// </summary>
        /// <param name="args"></param>
        /// 
         
        static void Main(string[] args)
        {

                int iparameter = 331087108;
                DateTime dtparameter = DateTime.Now;


                People people = new People()
                {
                    Id = 11,
                    Name = "linc"
                };

            Common.showInt(iparameter);
            Common.showDateTime(dtparameter);
            Common.showPeople(people);

            Console.WriteLine("----------------Object ----------------");
            object oParameter = "o_linc";
            Common.showObject(oParameter);
            Common.showObject(iparameter);
            Common.showObject(dtparameter);
            Common.showObject(people);

            Console.WriteLine("----------------Generic ----------------");
            GenericHelp.ShowT<int>(iparameter);
            GenericHelp.ShowT<DateTime>(dtparameter);
            GenericHelp.ShowT<People>(people);
           // GenericHelp.ShowT<People>(people.Name);  
            GenericHelp.ShowT<Object>(oParameter);
            GenericHelp.ShowT<string>("林晨");
            GenericHelp.ShowT("类型参数可以省略，会自动推算");



            Console.Read();
        }
    }
}
