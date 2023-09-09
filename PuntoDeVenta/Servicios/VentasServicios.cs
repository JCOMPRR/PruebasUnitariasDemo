using PuntoDeVenta.Entidades;

namespace PuntoDeVenta.Servicios
{
    public static class VentasServicios
    {
        //Ejemplo normal
        public static decimal CalcularImporte(decimal precio, int cantidad)
        {
            return precio * cantidad;
        }

        //Ejemplo del libro Clean Code
        public static decimal CalcularImporte(VentaDetalle concepto)
        {
            return concepto.Cantidad * 
                (concepto.Producto!.PrecioUnitario - (concepto.Producto!.PrecioUnitario * .10m));
        }

        public static decimal CalcularIvaConcepto(VentaDetalle concepto)
        {
            return concepto.Cantidad *
                (concepto.Producto!.PrecioUnitario * concepto.TasaIva);
        }

        public static decimal CalcularSubTotal(Venta venta)
        {
            decimal subTotal = 0.0m;
            foreach (VentaDetalle concepto in venta.Conceptos!)
            {
                subTotal += CalcularImporte(concepto);
            }
            return subTotal;
        }

        public static decimal CalcularIva(Venta venta)
        {
            decimal iva = 0.0m;
            foreach (VentaDetalle concepto in venta.Conceptos!)
            {
                iva += CalcularIvaConcepto(concepto);
            }
            return iva;
        }

        public static decimal CalcularTotal(Venta venta)
        {
            return CalcularSubTotal(venta) + CalcularIva(venta);
        }
    }
}
