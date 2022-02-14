using System;

namespace Input_3;

class Program
{
    public static void Main(string[] args)
    {
        string[] arr = new string[26];
        string[] arr2 = new string[26];
        arr[0] = "Beautiful";
        arr[1] = "Country";
        arr[2] = "Dancing";
        arr[3] = "Day";
        arr[4] = "Example";
        arr[5] = "Goodbye";
        arr[6] = "Hello";
        arr[7] = "House";
        arr[8] = "Life";
        arr[9] = "Man";
        arr[10] = "Moment";
        arr[11] = "No";
        arr[12] = "People";
        arr[13] = "People";
        arr[14] = "Place";
        arr[15] = "Please"; 
        arr[16] = "Slowly";
        arr[17] = "Things";
        arr[18] = "What";
        arr[19] = "Who";
        arr[20] = "Woman";
        arr[21] = "Work";
        arr[22] = "World";
        arr[23] = "Years";
        arr[24] = "Yes";
        arr[25] = "Where";
        arr2[0] = "Bella";
        arr2[1] = "Pais";
        arr2[2] = "Bailando";
        arr2[3] = "Día";
        arr2[4] = "Ejemplo";
        arr2[5] = "Adios";
        arr2[6] = "Hola";
        arr2[7] = "Casa";
        arr2[8] = "Vida";
        arr2[9] = "Hombre";
        arr2[10] = "Momento";
        arr2[11] = "No";
        arr2[12] = "Gente";
        arr2[13] = "Peresonas";
        arr2[14] = "Lugar";
        arr2[15] = "Por Favor";
        arr2[16] = "Despacito";
        arr2[17] = "Cosas";
        arr2[18] = "Que";
        arr2[19] = "Quien";
        arr2[20] = "Mujer";
        arr2[21] = "Trabajo";
        arr2[22] = "Mundo";
        arr2[23] = "Anos";
        arr2[24] = "Si";
        arr2[25] = "Donde";
        Console.WriteLine("Enter word");
        string x = Console.ReadLine();
        bool y = false;
        for (int i = 0; i < arr.Length; i++) {
            if (String.Equals(x, arr[i], StringComparison.OrdinalIgnoreCase) == true)
            {
                Console.WriteLine(arr2[i]);
                y = true;
                break;
            }
        }
        if (!y) {
            Console.WriteLine("Sorry I do not understand!");

        }
    }

}