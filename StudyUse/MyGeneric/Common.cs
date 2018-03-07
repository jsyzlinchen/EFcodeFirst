using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyUse.MyGeneric

{
    public class Common
    {
        public static void showInt(int iParameter)
        {
            Console.WriteLine("这里是shouInt,Parameter{0}，iParameterType{1}", iParameter, iParameter.GetType());
        }
        public static void showDateTime(DateTime dtParameter)
        {
            Console.WriteLine("这里是shouInt,dtParameter{0}，dtParameterType{1}", dtParameter, dtParameter.GetType());
        }

        public static void showPeople(People peopleParameter)
        {
            Console.WriteLine("这里是shouInt,peopleParameter{0}，peopleParameterType{1}", peopleParameter, peopleParameter.GetType());
        }


        /// <summary>
        /// 通过继承，子类拥有父类的一切属性，任何父类出现的地方，都可以用子类代替
        /// object是所有类型的父类
        /// 有装箱拆箱的过程，有性能损失
        /// </summary>
        /// <param name="oParameter"></param>
        public static void showObject(Object  oParameter)
        {
            Console.WriteLine("这里是showObject,oParameter{0}，oParameter{1}", oParameter, oParameter.GetType());
        }

    }
}