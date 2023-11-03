internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear(); 
        /*Ejercicio: "Suma de elementos pares"
        Escribe un programa en C# que solicite al usuario ingresar una serie de números enteros. El programa debe almacenar estos números en una lista. Luego, el programa debe sumar todos los números pares en la lista y mostrar el resultado.*/

        //Declaracion de las variables a usar (1er commit): 
        int lenght, suma = 0;
        int[]matriz_nums;  
        Console.WriteLine("Ingrese la cantidad de numeros a ingresar: ");  lenght = int.Parse(Console.ReadLine());
        matriz_nums = new int[lenght];

        //Rellenado de la matriz seleccion de los numeros pares (2do commit): 

        Console.Clear(); 
        for (int i = 0; i < matriz_nums.Length; i++)
        {
            Console.WriteLine("Ingrese un numero: "); matriz_nums[i] = int.Parse(Console.ReadLine()); 

            if(matriz_nums[i] % 2 == 0){
                suma += matriz_nums[i]; 
            }

        }

        



        







    }
}