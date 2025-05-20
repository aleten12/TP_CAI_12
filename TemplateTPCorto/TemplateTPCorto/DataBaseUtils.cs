using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Datos;

namespace Persistencia.DataBase
{
    public class DataBaseUtils
    {
        private readonly string rutaBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "Tablas");


        public List<String> BuscarRegistro(String nombreArchivo) 
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Persistencia\DataBase\Tablas\", nombreArchivo);
            rutaArchivo = Path.GetFullPath(rutaArchivo);
            List<String> listado = new List<String>();

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        listado.Add(linea);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo:");
                Console.WriteLine(e.Message);
            }
            return listado;
        }

        public List<String> BuscarDatosPersistencia(String nombreArchivo)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Persistencia\DataBase\Tablas\", nombreArchivo);
            rutaArchivo = Path.GetFullPath(rutaArchivo);

            List<String> listado = new List<String>();

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        listado.Add(linea);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo:");
                Console.WriteLine(e.Message);
            }
            return listado;
        }

        // Método para borrar un registro
        public void BorrarRegistro(string id, String nombreArchivo)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Persistencia\DataBase\Tablas\", nombreArchivo);
            rutaArchivo = Path.GetFullPath(rutaArchivo);

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("El archivo no existe: " + rutaArchivo);
                    return;
                }

                // Leer el archivo y obtener las líneas
                List<string> listado = BuscarRegistro(nombreArchivo);

                // Filtrar las líneas que no coinciden con el ID a borrar (comparar solo la primera columna)
                var registrosRestantes = listado.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != id; // Verifica solo el ID (primera columna)
                }).ToList();

                // Sobrescribir el archivo con las líneas restantes
                File.WriteAllLines(rutaArchivo, registrosRestantes);

                Console.WriteLine($"Registro con ID {id} borrado correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar borrar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }

        // Método para agregar un registro
        public void AgregarRegistro(string nombreArchivo, string nuevoRegistro)
        {
            string archivoCsv = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Persistencia\DataBase\Tablas\", nombreArchivo);
            archivoCsv = Path.GetFullPath(archivoCsv);

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(archivoCsv))
                {
                    Console.WriteLine("El archivo no existe: " + archivoCsv);
                    return;
                }

                // Abrir el archivo y agregar el nuevo registro
                using (StreamWriter sw = new StreamWriter(archivoCsv, append: true))
                {
                    sw.WriteLine(nuevoRegistro); // Agregar la nueva línea
                }

                Console.WriteLine("Registro agregado correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar agregar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }

        public void SobrescribirArchivo(string nombreArchivo, List<string> nuevasLineas)
        {
            string rutaRelativa = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Persistencia\DataBase\Tablas\", nombreArchivo);
            string rutaCompleta = Path.GetFullPath(rutaRelativa);

            try
            {
                File.WriteAllLines(rutaCompleta, nuevasLineas);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al sobrescribir el archivo:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }


        public void ActualizarCredencial(Credencial credencial, string nombreArchivo)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Persistencia\DataBase\Tablas\", nombreArchivo);
            rutaArchivo = Path.GetFullPath(rutaArchivo); 

            try
            {
                // Leer todas las líneas del archivo
                List<string> listado = File.ReadAllLines(rutaArchivo).ToList();
                bool encontrado = false; 

                // Construir la nueva línea con los datos del objeto Credencial
                string nuevaLinea = string.Join(";", new string[]
                {
                    credencial.Legajo,
                    credencial.NombreUsuario,
                    credencial.Contrasena,
                    credencial.FechaAlta.ToString("d/M/yyyy"),
                    credencial.FechaUltimoLogin.HasValue
                   ? credencial.FechaUltimoLogin.Value.ToString("d/M/yyyy")
                   : ""
                });

                for (int i = 0; i < listado.Count; i++)
                {
                    var campos = listado[i].Split(';');

                    if (campos[0] == credencial.Legajo)
                    {
                        listado[i] = nuevaLinea;
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    File.WriteAllLines(rutaArchivo, listado);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar actualizar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }
    }


}
