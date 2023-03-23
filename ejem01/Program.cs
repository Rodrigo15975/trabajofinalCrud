//using System.Linq.Expressions;

//dynamic something = "xd";
//Console.WriteLine($"La longitud del texto es {something.Length}");
//something = 12;
//something = new[] { 3, 5, 10 };

//Console.WriteLine($"Valor por defecto(int) = {default(int)}");
//Console.WriteLine($"Valor por defecto(bool) = {default(bool)}");
//Console.WriteLine($"Valor por defecto(DateTime) = {default(DateTime)}");
//Console.WriteLine($"Valor por defecto(string) = {default(string)}");

//int numberOfApples = 12;
//decimal pricePerApple = 0.35M;
//Console.WriteLine(format: "{0} manzanas costaran {1:E}",
//arg0: numberOfApples,
//arg1: pricePerApple * numberOfApples);

//string formatted = string.Format(format: "{0} manzanas cosaran {1:c}",
//    arg0: numberOfApples,
//    arg1: pricePerApple * numberOfApples);
//Console.WriteLine(formatted);

//Console.WriteLine(
//    format: "{0},{1} son amigos {2}",
//    arg0:"deybis",
//    arg1:"malqqui",
//    arg2:"mora");

//Console.WriteLine(
//    format: "{0},{1} son amigos de {2},{3} son grupo de trabajo con {4} y {5},",
//    "deybis", "nilo", "jefferson", "baldeon", "mora", "diego");


//string applesText = "manzana";
//int applesCount = 1234;
//string bananasText = "platanos";
//int bananasCount = 56789;

//Console.WriteLine(
//    format: "{0,-10} {1,6}",
//    arg0: "name",
//    arg1: "count");

//Console.WriteLine(
//    format: "{0,-10} {1,6:N0}",
//    arg0: applesText,
//    arg1: applesCount);

//Console.WriteLine(
//    format: "{0,-10} {1,6:N0}",
//    arg0: bananasText,




//string Linea = new('-', count: 90);

//string horizontalLine = new('-', count: 115);
//WriteLine(horizontalLine);

//int total;
//WriteLine("ingresa tu nombre");
//string nom = ReadLine();
//WriteLine("ingresa tu apellido");
//string apellido = ReadLine();
//WriteLine("ingresa tu edad");
//int edad = Convert.ToInt16(ReadLine());
//WriteLine("Ingrese los dias trabajados");
//int dias = Convert.ToInt16(ReadLine());
//WriteLine("Ingrese el monto");
//int monto = Convert.ToInt16(ReadLine());
//total = dias * monto;



//WriteLine(Linea);
//WriteLine(format: "{0, -10} | {1, -10} |{2, -10} | {3,-10} | {4,-10} |{5,-10}|",
//       "NOMBRES", "APELLIDOS", "EDAD", "DIAS", "MONTO", "TOTAL");


//WriteLine(format: "{0, -10} | {1, -10} |{2, -10} | {3,-10} | {4,-10} |{5,-10}|",
//     nom, apellido, edad, dias, monto, total);

//WriteLine(horizontalLine);




//Write("precione una tecla");
//ConsoleKeyInfo key = Console.ReadKey();
//WriteLine();
//WriteLine("tecla:{0}, caracter: {1}, modificaciones: {2}",
//    arg0: key.Key,
//    arg1: key.KeyChar,
//    arg2: key.Modifiers);

//HttpClient client = new();
//HttpResponseMessage Response =
//await client.GetAsync("https://www.senati.edu.pe/");
//WriteLine("la pagina de senati tiene (0:N0) bytes.",
//Response.Content.Headers.ContentLemgth) ;




//string rowseparator = new string('-', count: 74);
//WriteLine(rowseparator);
//WriteLine("| tipo    bytes en memoria                |              min  |                                      max");

//WriteLine("=====================================================================================================================");
//WriteLine($"decimal uses{sizeof(decimal),-4} bytes and store numbers in the range {decimal.MinValue,30}to {decimal.MaxValue,30}.");
//WriteLine($"sbyte uses{sizeof(sbyte)-4} bytes and store numbers in the range {sbyte.MinValue,30}to {sbyte.MaxValue,30}.");
//WriteLine($"byte  uses{sizeof(byte)-4} bytes and store numbers in the range {byte.MinValue,30}to {byte.MaxValue,30}.");
//WriteLine($"short uses{sizeof(short)-4} bytes and store numbers in the range {short.MinValue,30}to {short.MaxValue,30}.");
//WriteLine($"ushort uses{sizeof(ushort)-4} bytes and store numbers in the range {ushort.MinValue,30}to {ushort.MaxValue,30}.");
//WriteLine($"int uses{sizeof(int)-4} bytes and store numbers in the range {int.MinValue,30}to {int.MaxValue,30}.");
//WriteLine($"uint uses{sizeof(uint)-4} bytes and store numbers in the range {uint.MinValue,30}to {uint.MaxValue,30}.");
//WriteLine($"long uses{sizeof(long)-4} bytes and store numbers in the range {long.MinValue,30}to {long.MaxValue,30}.");
//WriteLine($"float uses{sizeof(float)-4} bytes and store numbers in the range {float.MinValue,30}to {float.MaxValue,30}.");
//WriteLine($"double uses{sizeof(double)-4} bytes and store numbers in the range {double.MinValue,30}to {double.MaxValue,30}.");

//WriteLine("=====================================================================================================================");




int a = 4;
int b = a++;
WriteLine($"a is {a}; b is {b}");


int f = 3;
double g = 11.0;
WriteLine($"g es {g:N1}, f es {f}");
WriteLine($"g / f = {g / f}");





int c = 3;
int d = ++c;
WriteLine($"c es {c}, d is {d}");
























//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WriteLine("Bytes en la memoria que utiliza cada tipo de número:");

//            WriteLine("Tipo byte:");
//            WriteLine("Tamaño: " + sizeof(byte) + " bytes");
//            WriteLine("Valor mínimo: " + byte.MinValue);
//            WriteLine("Valor máximo: " + byte.MaxValue);

//            WriteLine("Tipo short:");
//            WriteLine("Tamaño: " + sizeof(short) + " bytes");
//            WriteLine("Valor mínimo: " + short.MinValue);
//            WriteLine("Valor máximo: " + short.MaxValue);

//            WriteLine("Tipo ushort:");
//            WriteLine("Tamaño: " + sizeof(ushort) + " bytes");
//            WriteLine("Valor mínimo: " + ushort.MinValue);
//            WriteLine("Valor máximo: " + ushort.MaxValue);

//            WriteLine("Tipo int:");
//            WriteLine("Tamaño: " + sizeof(int) + " bytes");
//            WriteLine("Valor mínimo: " + int.MinValue);
//            WriteLine("Valor máximo: " + int.MaxValue);

//            WriteLine("Tipo long:");
//            WriteLine("Tamaño: " + sizeof(long) + " bytes");
//            WriteLine("Valor mínimo: " + long.MinValue);
//            WriteLine("Valor máximo: " + long.MaxValue);

//            WriteLine("Tipo ulong:");
//            WriteLine("Tamaño: " + sizeof(ulong) + " bytes");
//            WriteLine("Valor mínimo: " + ulong.MinValue);
//            WriteLine("Valor máximo: " + ulong.MaxValue);

//            WriteLine("Tipo float:");
//            WriteLine("Tamaño: " + sizeof(float) + " bytes");
//            WriteLine("Valor mínimo: " + float.MinValue);
//            WriteLine("Valor máximo: " + float.MaxValue);

//            WriteLine("Tipo double:");
//            WriteLine("Tamaño: " + sizeof(double) + " bytes");
//            WriteLine("Valor mínimo: " + double.MinValue);
//            WriteLine("Valor máximo: " + double.MaxValue);

//            WriteLine("Tipo decimal:");
//            WriteLine("Tamaño: " + sizeof(decimal) + " bytes");
//            WriteLine("Valor mínimo: " + decimal.MinValue);
//            WriteLine("Valor máximo: " + decimal.MaxValue);

//            ReadLine();
//        }
//    }
//}