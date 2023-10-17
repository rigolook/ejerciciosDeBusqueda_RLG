namespace ejerciciosDeBusqueda_RLG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusquedaLineal busqueda = new BusquedaLineal();
            //lineal
            //busqueda.listaEnteros();
            //busqueda.BuscarCadena();
            //busqueda.NumeroPar();
            //busqueda.TodosNumerosPares();

            //binario
            BusquedaBinaria busque= new BusquedaBinaria();
            //busque.BuscarFormaBinario();
            //busque.BuscarCadenaBinaria();
            busque.BuscarPrimerParBini();
        }
    }
}