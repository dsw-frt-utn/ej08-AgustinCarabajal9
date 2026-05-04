namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();

            Console.WriteLine(helper.ObtenerEtiquetaProducto(1001, "Leche", 1250.00m));
            Console.WriteLine(helper.ObtenerEtiquetaProducto(2048, "Arroz", 980.50m));
            Console.WriteLine(helper.ObtenerEtiquetaProducto(3999, "Aceite de oliva", 2375.99m));
        }
    }
}
