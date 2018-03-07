using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFcodeFirst.Helper.StudyList
{
    public class GenericHelp
    {
        //运行时的动态解析，会有性能损失

        //而泛型的原理：编译的时候确定类型
        
        public static void ShowT<T>(T tparameter)
        {
            Console.WriteLine("这里是泛型方法Show T ,parameter={0} ,parametertype={1}", tparameter, tparameter.GetType());
        }
    }
}