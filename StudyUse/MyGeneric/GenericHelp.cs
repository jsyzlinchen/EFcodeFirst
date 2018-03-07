using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyUse.MyGeneric
{
    public class GenericHelp
    {
        //运行时的动态解析，会有性能损失

        //而泛型的原理：编译的时候确定类型(不会有性能损失)
        /// <summary>
        /// 方法声明的时候没有指定参数类型，而是推迟到使用方法的时候才指定参数类型
        /// 延迟思想
        /// 要推迟一切可以推迟的，尽量到后面再去声明
        /// 延迟声明，避免装箱拆箱的过程（object）
        /// </summary>
        /// <typeparam name="T"></typeparam>   T是个类型参数
        /// <param name="tparameter">T类型的参数</param>
        public static void ShowT<T>(T tparameter)
        {
            Console.WriteLine("这里是泛型方法Show T ,parameter={0} ,parametertype={1}", tparameter, tparameter.GetType());
        }
    }
}