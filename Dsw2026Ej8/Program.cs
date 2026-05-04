namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pruebas para el problema 1            
            ProductHelper helper = new ProductHelper();

            Console.WriteLine(helper.ObtenerEtiquetaProducto(1001, "Leche", 1250.00m));
            Console.WriteLine(helper.ObtenerEtiquetaProducto(2048, "Arroz", 980.50m));
            Console.WriteLine(helper.ObtenerEtiquetaProducto(3999, "Aceite de oliva", 2375.99m));

            //pruebas para el problema 2
            Console.WriteLine("=== Problema 2: CrearResumenVenta ===");
            var p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(101, "Harina 1kg", 3, 450.00m));  
            Console.WriteLine(p2.CrearResumenVenta(102, "Azúcar 500g", 0, 300.00m)); 
            Console.WriteLine(p2.CrearResumenVenta(103, "Yerba 500g", -1, 800.00m)); 
        }
    }
}
