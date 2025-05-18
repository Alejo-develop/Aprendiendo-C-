using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Impresion por consola tipico
            Console.WriteLine("Hello, C#!");

            //Variables
            string myString = "Esto es una cadena de texto";
            Console.WriteLine(myString);

            int myInt = 10;
            Console.WriteLine(myInt);
            myInt += 4;
            Console.WriteLine(myInt);

            //Tipo de dato Decimal
            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            // booleano
            bool myBool = true;
            Console.WriteLine(myBool);

            dynamic myDynamic = 6;
            Console.WriteLine(myDynamic);
            myDynamic = "Ahora esto cambio";
            Console.WriteLine(myDynamic);

            Console.WriteLine($"Mi numero entero es {myInt} y mi booleano es {myBool}");

            //Constantes
            const string MyConstString = "Mi primera constante tipo string";
            Console.WriteLine(MyConstString);

            //Estructuras 
            var myArray = new string[] { "yeyo", "yeyito" };
            Console.WriteLine(myArray);
            Console.WriteLine(myArray[0]);

            var myDictionary = new Dictionary<string, int>
            {
                {
                    "Yeyo", 25
                },
                {
                    "Santiago", 24
                },
                {
                    "Simon", 21
                },
                {
                    "Camp", 25
                }
            };

            Console.WriteLine(myDictionary["Yeyo"]);

            var mySet = new HashSet<string> { "yeyo", "yeyito", "yeyito" };
            Console.WriteLine(mySet);

            var myTuple = (" yeyo", "yeyito");
            Console.WriteLine(myTuple);

            //Bucles 
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }

            foreach (var myItem in myArray)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in myDictionary)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in mySet)
            {
                Console.WriteLine(myItem);
            }

            //flujos
            myInt = 11;
            if (myInt == 11 && myBool == true)
            {
                Console.WriteLine("el valor es 11");
            }
            else if (myInt == 12 || myBool == false)
            {
                Console.WriteLine("el valor es 12");
            }
            else
            {
                Console.WriteLine("El valor no es 11");
            }

            MyFunction();

            //Clases
            var myCLass = new MyCLass("Yeyo");
            Console.WriteLine(myCLass.myName);
        }

        //Funciones 
        static void MyFunction()
        {
            Console.WriteLine(MyFunctionWithReturn(5));
        }

        static int MyFunctionWithReturn(int param)
        {
            return 10 + param;
        }

        class MyCLass
        {
            public MyCLass(string myCurrentName)
            {
                this.myName = myCurrentName;
            }

            public string myName { get; set; }
        }
    }
}
