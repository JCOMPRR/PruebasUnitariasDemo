namespace PuntoDeVenta.Entidades
{
    public class VentaDetalle
    {
        public decimal Cantidad { get; set; }
        public Producto? Producto { get; set; }
        public decimal Importe { get; set; }
        public decimal TasaIva { get; set; }
    }
}
