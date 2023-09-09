namespace PruebasUnitariasDemo.Entidades
{
    public class Venta
    {
        public int Folio { get; set; }
        public List<VentaDetalle>? Conceptos { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
    }
}
