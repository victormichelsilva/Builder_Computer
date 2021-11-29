namespace Builder_Computer
{
    //ConcreteBuilder
    class DesktopBuilder : ComputadorBuilder
    {
        Computador computador;

        public DesktopBuilder()
        {
            computador = new Computador("Desktop");
        }

        public override void BuildDispositivos()
        {
            System.Console.WriteLine("Build Dispositivos no Desktop...");
        }

        public override void BuildSO()
        {
            System.Console.WriteLine("Build Sistema Operacional no Desktop...");
        }

        public Computador TipoComputador 
        {
            get { return computador; }
        }
    }
}
