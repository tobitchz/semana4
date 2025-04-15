/*Ejercicio 1: 

Crear la clase Persona con diferentes constructores, para ello tendremos en cuenta las siguientes opciones: 

Inicializar una clase Persona con atributos nombre, edad y dni.
Crear un constructor sin parámetros que inicialice con valores por defecto.
Inicializar la clase Persona con solo el nombre.
Crear un constructor que reciba todos los atributos.
Crear un método mostrarDatos() que imprima los atributos.
Definir la edad como privado y crear un método de acceso (get) y un método para modificar su valor (set).
 */


namespace Program
{
    class Program
    {
        public static void Main1(string[] args)
        {


            Persona persona1 = new Persona();

            persona1.nombre = "Ana";
            persona1.dni = 46361742;

            persona1.SetEdad(4);

            persona1.MostrarDatos();
          
        }

        class Persona
        {
            public string nombre;
            private int edad;
            public int dni;

            public Persona()
            {
                nombre = "Desconocido";
                edad = 0;
                dni = 0;
            }

            public void SetEdad(int nuevaEdad)
            {
                edad = nuevaEdad;
            }

            public int GetEdad()
            {
                return edad;
            }




            public void MostrarDatos()
            {
                Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, DNI: {dni}");
            }
        }
    }


}