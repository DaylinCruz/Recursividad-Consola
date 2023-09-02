
using System.IO;
bool final = false;
while(final == false)
{
    Console.WriteLine("Digite la ruta para ver los archivos");
    //string carpeta = @"C:\Users\dayli\OneDrive\Escritorio\INFORMÁTICA    II SEMESTRE\Contabilidad               2 INFORMÁTICA";
    string carpeta = Console.ReadLine();

    if (Directory.Exists(carpeta))
    {
        string[] archivos = Directory.GetFiles(carpeta);


        foreach (string archivo in archivos)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            Console.WriteLine(nombreArchivo);
        }
    }
    else
    {
        Console.WriteLine("La carpeta no existe.");
    }

    Console.WriteLine("\n1= Intentar de nuevo\n2= Salir");
    int resp = int.Parse(Console.ReadLine());
    
    if(resp == 1)
    {

    }
    else
    {
        final = true;
       
    }
}





