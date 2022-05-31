using System.Collections;
using System.Collections.Generic;
using System;

namespace HelloOOP {
    class Program
    {
        static void Main(string[] args){
            Type t = typeof(Car);
            Type tb = t.BaseType;
            Console.WriteLine(tb.FullName);
    }
}



    class Vehicle{

    }

    class Car : Vehicle{

    }
}   
  

 
  
        
 

