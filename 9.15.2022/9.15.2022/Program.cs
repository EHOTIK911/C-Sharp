﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._15._2022
{
    /*
     * Класс - пользовательский тип, состоящий из поелй данных и методов, которые работают с этими данными. 
     * Множество полей данных представляют "состояние" экземпляра класса.
     * 
     *          ///ЭКЗЕМПЛЯРЫ КЛАССА ИНАЧЕ НАЗЫВАЮТСЯ ОБЪЕКТАМИ\\\
     * Класс может быть без параметров, а так же с параметрами
     * Класс может вообще не содержать конструкторов в этом случае компилятор добавит конструктор по умолчанию
     * В котором значимым полям будет присваиваться 0, а ссылочным null
     * Если в классе определен хотя бы один конструктор с параметром, то конструктор по умолчанию пишет сам(компилятор его уже не добавляет)
     * Всего в классе может быть 2^n конструкторов, где n - количество полей
     *          
     */


    class Motorcycle
    {
        public int driverIntensity = default;
        public string name = default;
        Motorcycle()
        {
            Console.WriteLine("In default");
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
