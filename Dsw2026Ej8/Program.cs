namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pruebas para el problema 1            
            Console.WriteLine("\nproblema 1:");
            ProductHelper helper = new ProductHelper();


            Console.WriteLine(helper.ObtenerEtiquetaProducto(1001, "Leche", 1250.00m));
            Console.WriteLine(helper.ObtenerEtiquetaProducto(2048, "Arroz", 980.50m));
            Console.WriteLine(helper.ObtenerEtiquetaProducto(3999, "Aceite de oliva", 2375.99m));

            //pruebas para el problema 2
            Console.WriteLine("\nproblema 2:");
            var p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(101, "Harina 1kg", 3, 450.00m));  
            Console.WriteLine(p2.CrearResumenVenta(102, "Azúcar 500g", 0, 300.00m)); 
            Console.WriteLine(p2.CrearResumenVenta(103, "Yerba 500g", -1, 800.00m));

            //pruebas para el problema 3
            Console.WriteLine("\nproblema 3:");
            var p3 = new Problema3();
            var product = new Product("Notebook Lenovo");
            Console.WriteLine(p3.CompararCopias(10, product));

            //pruebas para el problema 4
            Console.WriteLine("\nproblema 4:");
            var p4 = new Problema4();
            Console.WriteLine(p4.CalcularPromedio(8, 6, 10));    
            Console.WriteLine(p4.CalcularPromedio(null, 7, 5));  
            Console.WriteLine(p4.CalcularPromedio(null, null, null));  
            Console.WriteLine(p4.CalcularPromedio(-1, 5, 11));    
            Console.WriteLine(p4.CalcularPromedio(null, -5, null));

            Console.WriteLine("\nproblema 5:");
            var p5 = new Problema5();

            Sale retail = new RetailSale(1000m);
            Sale wholesale = new WholesaleSale(1000m);

            Console.WriteLine($"RetailSale de 1000:  {p5.ObtenerImporteFinal(retail)}");     
            Console.WriteLine($"WholesaleSale de 1000:  {p5.ObtenerImporteFinal(wholesale)}");  
        }
    }
}
