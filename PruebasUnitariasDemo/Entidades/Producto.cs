namespace PruebasUnitariasDemo.Entidades
{
    //Entidades sirven para representar un objeto
    //Representa un producto
    //No meter funciones en las entidades

    //Es como si fuera una tabla en SQL la entidad y los props las columnas
    public class Producto
    {
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
