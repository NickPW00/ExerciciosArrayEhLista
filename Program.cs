using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        var array1 = new int[3][];
       /* array1[0] = new int[3] { 1, 5, 2 };
        array1[1] = new int[3] { 4, 7, 9 };
        array1[2] = new int[3] { 3, 2, 1 };*/

        array1[0] = new int[3] { 1, 2, 6 };
        array1[1] = new int[3] { 4, 5, 6 };
        array1[2] = new int[3] { 6, 6, 1 };
        var valorTotal = 0;

        for( var i = 0; i < array1.Length; i++ )
        {
            for (var j = 0; j < array1[i].Length; j++)
            {
                valorTotal += array1[i][j];
            }
            Console.WriteLine(valorTotal);
        }

        var elementosDuplicados = 0;
        for(var i = 0; i < array1.Length; i++)
        {
            for(var j = 0; j < array1[i].Length; j++)
            {
                bool valorDuplicado = false;
                for (var k = 0; k < array1.Length; k++)
                {
                    for (var l = 0; l < array1.Length; l++)
                    {
                        if (!valorDuplicado)
                        {
                            if (array1[i][j] == array1[k][l] && j != l)
                            {
                                elementosDuplicados++;
                                valorDuplicado = true;
                            }
                        }
                        Console.WriteLine($"{i} {j} - {k} {l} : {array1[i][j]} - {array1[k][l]} e {valorDuplicado}");
                    }
                }
                valorDuplicado = false;
                Console.WriteLine("----------------------------");
            }
        }
        Console.WriteLine(elementosDuplicados/2);


        /*int[][] array = new int[3][];
        array[0] = new int[10];
        array[1] = new int[10];
        array[2] = new int[10];


        array[0][0] = 0;
        Console.WriteLine(array);

        // Lista nçao generica
        ArrayList lista1 = new ArrayList();
        lista1.Add(1);
        lista1.Add("Lero");
        lista1.Add('a');

        // lista generica

        List <int> somenteInt= new List<int>();
        somenteInt.Add(1);



        Console.WriteLine("Hello, World!");*/
    }
}