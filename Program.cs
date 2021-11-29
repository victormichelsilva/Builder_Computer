using System;

namespace Builder_Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            //InstÂncia de Director
            Fabricante fabricante = new Fabricante();

            //Instância do ConcreteBuilder
            NotebookBuilder notebookBuilder = new NotebookBuilder();
            DesktopBuilder desktopBuilder = new DesktopBuilder();

            //Cria objetos conforme o builder
            fabricante.Build(notebookBuilder);
            fabricante.Build(desktopBuilder);

            Console.ReadLine();
        }
    }
}
