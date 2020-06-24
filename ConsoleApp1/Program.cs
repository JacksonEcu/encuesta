//con la palbra system estoy llamando a las librerias
using System;

class Encuesta // aqui encontramos  la classe llamada encuesta
{
    public static void Main(string[] encuesta)//tengo mi argumento encuesta,un tipo de dato y la palabra void que no devulve nada

    {
        Console.WriteLine("Cual es tu rutina de ejercicios?");//mi metodo console lo cual digo que muestre el nombre a ingresar
        String rut; //Tipo Variable
        rut = Console.ReadLine(); //
        Console.WriteLine("la rutina es: " + rut); //Retorna los datos

        Console.WriteLine("Que parte de tu cuerpo trabajas mas?");
        String mas;
        mas = Console.ReadLine();
        Console.WriteLine("la parte mas tranajada: " + mas);

        Console.WriteLine("Prefieres un gymnasio o desde casa?");
        String gym;
        gym= Console.ReadLine();
        Console.WriteLine("Prefieres ejercitarte desde: " + gym);

        int abd; //Tipo de varianble numerica
        Console.WriteLine("Cuantas abdominales repites?");//La consola consulta la edad
        abd = int.Parse(Console.ReadLine());//Lee el valor ingresado a la variable y sea diferende de nulo
        Console.WriteLine("Tus repeticiones: " + abd);//La consola escribe la informacion de la variable

        int max;
        Console.WriteLine("Cual es tu maximo en planchas?");
        max = int.Parse(Console.ReadLine());
        Console.WriteLine("Tus planchas son: " + max);
        Console.ResetColor();


        Console.WriteLine("Segun tu experiencia que parte se te complico mas?");
        String exp;
        exp = Console.ReadLine();
        Console.WriteLine("tu parte complicada:" + exp);


        Console.ReadKey();
        Console.Clear();
        Console.Beep();


    }





}
