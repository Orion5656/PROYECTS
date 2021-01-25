using System;
using System.IO;
namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0; string fr = ultimafrase(); bool mat; int i = 0;
            string d; int k = 0;
            string[,] frase=new string[1,1]; frase=leer(frase);
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Ingresar frase");
                    Console.WriteLine("2. Seleccionar frase registrada");
                    Console.WriteLine("3. Mostrar distribución en matriz");
                    Console.WriteLine("4. Ordenar Columna");
                    Console.WriteLine("5. Ordenar Filas");
                    Console.WriteLine("6. Mostrar matriz guardada");
                    Console.WriteLine("7. Mostrar ultima frase seleccionada");
                    Console.WriteLine("8. Salir");
                    Console.Write("\nSeleccione opcion: ");
                    op = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        switch (op)
                        {
                            case 1:

                                do
                                {
                                    Console.Clear();
                                    Console.Write("Ingrese frase: ");
                                    d = Console.ReadLine();
                                    añadir(d);
                                    do
                                    {
                                        Console.WriteLine("¿Desea ingresar otra frase?");
                                        Console.WriteLine("1. Si ");
                                        Console.WriteLine("2. No ");
                                        Console.Write("Seleccione opcion: ");
                                        k = Convert.ToInt32(Console.ReadLine());
                                    } while (k != 1 && k != 2);
                                } while (k != 2);
                                break;
                            case 2:
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Frases almacenadas: \n");
                                Console.BackgroundColor = ConsoleColor.Black;
                                leer2();
                                Console.Write("\nSeleccione frase: ");
                                fr = Convert.ToString(Console.ReadLine());
                                guardarultimafrase(fr);
                                break;
                            case 3:
                                Console.Clear();
                                mat = true; Random r = new Random();
                                int w = fr.Length;
                                for (i = 0; mat == true; i++)
                                {
                                    if (i * i >= w)
                                    {
                                        mat = false;
                                        break;
                                    }
                                }
                                frase = new string[i, i]; bool y;
                                for (int j = 0; j < w; j++)
                                {
                                    y = false;
                                    while (y == false)
                                    {
                                        int a = r.Next(0, i); int b = r.Next(0, i);
                                        string q = fr.Substring(j, 1);
                                        if (frase[a, b] == null)
                                        {
                                            frase[a, b] = q;
                                            y = true;
                                        }
                                    }
                                }
                                int x = 0, z = 2;
                                for (int f = 0; f < i; f++)
                                {
                                    for (int c = 0; c < i; c++)
                                    {
                                        if (frase[f, c] == null)
                                        {
                                            frase[f, c] = "█";
                                        }
                                    }
                                }
                                for (int f = 0; f < i; f++)
                                {
                                    for (int c = 0; c < i; c++)
                                    {
                                        Console.SetCursorPosition(x, z);
                                        Console.WriteLine(frase[f, c]); x += 5;
                                    }
                                    z += 2; x = 0;
                                }
                                escribeArchivo(frase);
                                Console.ReadKey();
                                break;
                            case 6:
                                Console.Clear();
                                x = 0; z = 2;
                                for (int f = 0; f < frase.GetLength(0); f++)
                                {
                                    for (int c = 0; c < frase.GetLength(0); c++)
                                    {
                                        Console.SetCursorPosition(x, z);
                                        Console.WriteLine(frase[f, c]); x += 5;
                                    }
                                    z += 2; x = 0;
                                }
                                Console.ReadKey();
                                break;
                            case 4:
                                bool fk = false;
                                try
                                {
                                    Console.Clear();
                                    Console.Write("Ingrese el numero de columna que desea ordenar: ");
                                    int col = Convert.ToInt32(Console.ReadLine());
                                    string[] v = new string[frase.GetLength(0)];
                                    for (int f = 0; f < frase.GetLength(0); f++)
                                    {
                                        v[f] = frase[f, col];
                                    }
                                    Array.Sort(v); x = 0; z = 2; fk = false;
                                    while (fk == false)
                                    {
                                        fk = true; int b = v.GetLength(0);
                                        for (int ñ = 0; ñ < b - 1; ñ++)
                                        {
                                            if (v[ñ] == " ")
                                            {
                                                if (v[ñ + 1] != " ")
                                                {
                                                    string aux = v[ñ];
                                                    v[ñ] = v[ñ + 1];
                                                    v[ñ + 1] = aux;
                                                    fk = false;
                                                }
                                            }
                                        }
                                    }
                                    for (int f = 0; f < frase.GetLength(0); f++)
                                    {
                                        frase[f, col] = v[f];
                                    }

                                    for (int f = 0; f < frase.GetLength(0); f++)
                                    {
                                        for (int c = 0; c < frase.GetLength(0); c++)
                                        {
                                            Console.SetCursorPosition(x, z);
                                            if (c == col)
                                            {
                                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                            }
                                            Console.WriteLine(frase[f, c]); x += 5;
                                            Console.BackgroundColor = ConsoleColor.Black;
                                        }
                                        z += 2; x = 0;
                                    }
                                    Console.ReadKey();
                                    escribeArchivo(frase);
                                }
                                catch (Exception)
                                {
                                }
                                break;
                            case 5:
                                try
                                {
                                    Console.Clear();
                                    Console.Write("Ingrese el numero de fila que desea ordenar: ");
                                    int fil = Convert.ToInt32(Console.ReadLine());
                                    string[] v1 = new string[frase.GetLength(0)];
                                    for (int f = 0; f < frase.GetLength(0); f++)
                                    {
                                        v1[f] = frase[fil, f];
                                    }
                                    Array.Sort(v1); x = 0; z = 2; fk = false;
                                    while (fk == false)
                                    {
                                        fk = true; int b = v1.GetLength(0);
                                        for (int ñ = 0; ñ < b - 1; ñ++)
                                        {
                                            if (v1[ñ] == " ")
                                            {
                                                string aux = v1[ñ];
                                                v1[ñ] = v1[ñ + 1];
                                                v1[ñ + 1] = aux;
                                                fk = false;
                                            }
                                        }
                                    }
                                    for (int f = 0; f < frase.GetLength(0); f++)
                                    {
                                        frase[fil, f] = v1[f];
                                    }
                                    for (int f = 0; f < frase.GetLength(0); f++)
                                    {
                                        for (int c = 0; c < frase.GetLength(0); c++)
                                        {
                                            if (f == fil)
                                            {
                                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                            }
                                            Console.SetCursorPosition(x, z);
                                            Console.WriteLine(frase[f, c]); x += 5;
                                            Console.BackgroundColor = ConsoleColor.Black;
                                        }
                                        z += 2; x = 0;
                                    }
                                    Console.ReadKey();
                                    escribeArchivo(frase);
                                }
                                catch (Exception)
                                {
                                }
                                break;
                            case 7:
                                Console.Write("La ultima frase seleccionada fue: ");
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(ultimafrase());
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ReadKey();
                                break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                } while (op != 8);
            }
            catch (Exception)
            {
            }
        }
        static void añadir(string k)
        {
            try
            {
                FileStream archivo = new FileStream(@"Frases.txt", FileMode.Append, FileAccess.Write);
                StreamWriter escribeArchivo = new StreamWriter(archivo);
                escribeArchivo.WriteLine(k);
                escribeArchivo.Close();
                archivo.Close();
            }
            catch (Exception)
            {
            }
        }
        static string[,] leer(string[,] matriz)
        {
            try
            {
                int cont = 0;
                string[] v;
                string a = "";
                FileStream archivo = new FileStream(@"Matriz.txt", FileMode.Open, FileAccess.Read);
                StreamReader leeArchivo = new StreamReader(archivo);
                FileStream archivo1 = new FileStream(@"Matriz.txt", FileMode.Open, FileAccess.Read);
                StreamReader leeArchivo1 = new StreamReader(archivo1);
                while (a != null)
                {
                    a = leeArchivo.ReadLine(); cont++;
                }
                cont -= 1; v = new string[cont];
                for (int i = 0; i < cont; i++)
                {
                    a = leeArchivo1.ReadLine();
                    v[i] = a;
                }
                bool d = false; int k = 1, dim = 0;
                while (d == false)
                {
                    if (k * k == cont)
                    {
                        d = true; dim = k;
                    }
                    k++;
                }
                k = 0; matriz = new string[dim, dim];
                for (int f = 0; f < dim; f++)
                {
                    for (int c = 0; c < dim; c++)
                    {
                        matriz[f, c] = v[k]; k++;
                    }
                }
                leeArchivo.Close();
                leeArchivo1.Close();
                archivo.Close();
                archivo1.Close();
            }
            catch(Exception)
            {
            }
            return matriz;
        }
        static void escribeArchivo(string[,] mensaje)
        {
            try
            {
                FileStream archivo;
                archivo = new FileStream(@"Matriz.txt", FileMode.Create, FileAccess.Write);
                StreamWriter escribeArchivo = new StreamWriter(archivo);
                for (int i = 0; i <= mensaje.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= mensaje.GetUpperBound(0); j++)
                    {
                        escribeArchivo.WriteLine(mensaje[i, j]);
                    }
                }
                escribeArchivo.Close();
                archivo.Close();
            }
            catch (Exception)
            {
            }
        }
        static void leer2()
        {
            try
            {
                FileStream archivo = new FileStream(@"Frases.txt", FileMode.Open, FileAccess.Read);
                StreamReader leeArchivo = new StreamReader(archivo);
                while (leeArchivo.Peek() > -1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(leeArchivo.ReadLine());
                }
                leeArchivo.Close();
                archivo.Close();
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception)
            {
            }
        }
        static string ultimafrase()
        {
            string a = "";
            try
            {
                FileStream archivo = new FileStream(@"ULtimafrase.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader leeArchivo = new StreamReader(archivo);
                a = leeArchivo.ReadLine();
                leeArchivo.Close();
                archivo.Close();
            }
            catch (Exception)
            {
            }
            return a;
        }
        static void guardarultimafrase(string fr)
        {
            try
            {
                int cont = 0;
                string a = "";
                FileStream archivo1 = new FileStream(@"Frases.txt", FileMode.Open, FileAccess.Read);
                StreamReader lee = new StreamReader(archivo1);
                while (a != null)
                {
                    a=lee.ReadLine();
                    if (a == fr)
                    {
                        cont++;
                    }
                }
                if (cont != 0)
                {
                    FileStream archivo = new FileStream(@"ULtimafrase.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter escribe = new StreamWriter(archivo);
                    escribe.WriteLine(fr);
                    escribe.Close();
                    archivo.Close();
                }
                lee.Close();
                archivo1.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}