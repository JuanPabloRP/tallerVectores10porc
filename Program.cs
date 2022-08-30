using System;


namespace TallerVector
{
    class TallerVector10
    {
        static void Main(string[] args)
        {
            Menu();
            Console.WriteLine("\nFin.\n");
        }


        static void Menu()
        {
            
                int op = 0;
                string dato = "";



                Console.WriteLine("\nMenu de opciones: \n1-Productos y precios de la canasta familiar \n2-Ver los datos ingresados inversos \n3-Interseccion de vectores \n4-Factorial de los priemros 20 numeros naturales \n5-Punto bonus");
                do
                {
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Ingrese el numero de la opción a la cual desea ir (1 al 5): ");

                    Console.WriteLine("-------------------------------------------------------------");
                    dato = Console.ReadLine();

                    if (int.TryParse(dato, out op))
                    {
                        switch (op)
                        {
                            case 1:
                                CanastaFamiliar();
                                break;
                            case 2:
                            datosInversos();
                                break;
                            case 3:
                            interseccionVectores();
                                break;
                            case 4:
                            Factorial();
                                break;
                            case 5:
                            Bonus();
                                break;
                            

                            default:
                                Console.WriteLine("Error, valor fuera de rango");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error, valor invalido");
                    }




                } while ((!(int.TryParse(dato, out op))) || (op < 1 || op > 5));
            
        }


        
        static void CanastaFamiliar()
        {
            double[] precioProds = { 2000, 15000, 18000, 10000, 4000, 3800, 6000 };
            string[] nombreProds = { "Libra de arroz", "Canasta de huevos", "Libra de carne de res", "Bandeja de pollo","Quesito pequeño", "Litro de leche", "Libra de frijoles" };

            Console.WriteLine();
            for (int i = 0; i < precioProds.Length; i++)
            {
                Console.WriteLine("Producto: " + nombreProds[i] + "\t\t\tPrecio: $" + precioProds[i] );
            }
        }


        
        static void datosInversos()
        {
            string[] vector = new string[10];
            string[] vectorInv = new string[10];
            string dato = "";
            int cont = 0, i = 0;

            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un dato en posicion "+ (i + 1) +": ");
                dato = Console.ReadLine();

                if ((dato.Length > 0 && dato != "" && dato != null) && (i < vector.Length))
                {
                    
                    vector[i] = dato;
                    i++;
                }
                else
                {
                    Console.WriteLine("Ingrese un dato valido");
                }

                

            } while ((dato.Length > 0 || dato == "" || dato == null) && (i < 10) );


            cont = 0;
            for(i = (vector.Length - 1); i >= 0; i--)
            {
                vectorInv[cont] = vector[i];
                cont++;
            }


            Console.WriteLine("\nEl vector invertido quedó: ");
            for (i = 0; i < vectorInv.Length; i++)
            {
                Console.Write("\n" + vector[i] + "\t");
                Console.Write(vectorInv[i] + "\t");

            }
            Console.WriteLine();

        }


        static void interseccionVectores()
        {
            int[] v1;
            int[] v2;
            int[] v3;

            int tamV3 = 0, i = 0;

            Console.WriteLine("Creando y llenando v1");
            v1 = crearVector();
            Console.WriteLine("Creando y llenando v2");
            v2 = crearVector();

            
            for (i = 0; i < v1.Length; i++)
            {
                Console.WriteLine("v1: " + v1[i]);
            }

            Console.WriteLine("\n");

            for (i = 0; i < v2.Length; i++)
            {
                Console.WriteLine("v2: " + v2[i]);
            }
            


            for (i = 0; i < v1.Length; i++)
            {
                for (int j = 0; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        tamV3++;
                    }
                }
            }

            v3 = new int[tamV3];
            int k = 0;

            if (tamV3 == 0)
            {
                Console.WriteLine("Los datos en v1 y v2 no se repiten, por lo cual el v3 no existe");
            }else if (tamV3 > 0)
            {
                for (i = 0; i < v1.Length; i++)
                {
                    for (int j = 0; j < v2.Length; j++)
                    {
                        if (v1[i] == v2[j])
                        {
                            v3[k] = v1[i];
                            k++;
                        }
                    }
                }

                Console.WriteLine("\nEl tamaño de v3 es: " + v3.Length);
                Console.WriteLine("\nEl vector resultante de la intersección de v1 y v2 es: \n");
                for (i = 0; i < v3.Length; i++)
                {
                    Console.WriteLine("v3: " + v3[i]);
                }
            }
            

        }  

        static int[] crearVector()
        {
            
            int[] vector;

            int num = 0, aux = 0, i = 0, tam = 0;
            string datoTam = "", dato;
            bool ok = false;
            do
            {
                Console.WriteLine("Ingrese el tamaño: ");
                datoTam = Console.ReadLine();

                //se trata de parsear a int
                if ( int.TryParse(datoTam, out tam) )
                {
                    if (tam > 0) 
                    {
                        ok = true;

                    }
                    else

                    {
                        Console.WriteLine("Error, valor fuera de rango");
                    }
                }
                else
                {
                    Console.WriteLine("Error, tipo de dato incorrecto.");

                }
            } while ( (tam <= 0) || (!(int.TryParse(datoTam, out tam))) );

            vector = new int[tam]; 
            
            do
            {
                
                Console.WriteLine("Ingrese num: ");
                dato = Console.ReadLine();

                //se trata de parsear a int
                if (int.TryParse(dato, out num))
                {
                    vector[i] = num;
                    i++;
                    
                }
                else
                {
                    Console.WriteLine("Error, valor ingresado no es un entero.");
                }

            } while (i != vector.Length);

            return vector;

        }

        static void Factorial()
        {
            decimal num = 1;
            decimal[] fact = new decimal[20];

            for (int i = 0; i < fact.Length ; i++)
            {
                num *= (i+1);
                Console.WriteLine("Factorial del numero " + (i + 1) + " es: " + (fact[i] = num));
            }
        }

        static void Bonus()
        {
            int[] vector = { 5, 8, 10, 15, 28, 35, 7, 48, 96, 18 };
            int aux = 0;

            Console.WriteLine("Vector desordenado: ");

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "\t");
            }


            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < (vector.Length - 1); j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }

            /*
                Consiste en la comparacion de 2 posiciones consecutivas en el arreglo, se evalua
            si vector[j] es mayor a vector[j + 1], en caso de ser asi intercambian posiciones, seguido se
            suma 1 a j y sigue evaluando vector[j] > vector[j + 1], esto sigue hasta que j sea el tamaño del vector - 1
            para que asi pueda comparar con el ultimo dato, el ciclo de afuera sirve para repetir esta accioón la cantidad de
            veces que sea necesario para que el vector quede ordenado de menor a mayor.
             */

            Console.WriteLine("\n\nVector ordenado: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "\t");
            }

            Console.WriteLine("\n");

        }



    }
}


/*
 1. Realice un programa que imprima el nombre y precio de por lo menos 5 productos
de la canasta familiar almacenados en dos vectores paralelos.
2. Realice un programa que llene un vector de 10 posiciones con datos ingresados
por pantalla y muestre el vector en orden inverso al ingresado.
3. Realice un programa que cree y llene dos vectores (V1 y V2) de tamaño (A y B),
luego cree un tercer vector que almacene el resultado de la intersección de los dos
arreglos.
4. Realice un programa que almacene en un vector llamado FACT, el factorial de los
primeros 20 números naturales. Ejemplo: FACT = {1!, 2!,3!, ... 20!} y los muestre
en pantalla.
 */