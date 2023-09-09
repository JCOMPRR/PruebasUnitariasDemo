using PuntoDeVenta.Entidades;
using PuntoDeVenta.Servicios;

namespace PuntoDeVenta.MSTest
{
    [TestClass]
    public class VentasServiciosMSTest
    {
        [TestMethod]
        public void CalcularImporte_UnProducto_ImporteCorrectoTest()
        {
            //Arrange
            VentaDetalle concepto = new VentaDetalle
            {
                Cantidad = 2,
                Producto = new Producto
                {
                    PrecioUnitario = 10.5m
                }
            };

            decimal esperado = 21.0m;

            //Act
            decimal actual = VentasServicios.CalcularImporte(concepto);

            //Assert
            Assert.AreEqual(esperado, actual);
        }
       
        [TestMethod]
        public void CalcularIvaConcepto_UnProducto_ImporteCorrectoTest()
        {
            //Arrange
            VentaDetalle concepto = new VentaDetalle
            {
                Cantidad = 2,
                TasaIva = 0.16m,
                Producto = new Producto
                {
                    PrecioUnitario = 10.5m
                }
            };

            decimal esperado = 3.36m;

            //Act
            decimal actual = VentasServicios.CalcularIvaConcepto(concepto);

            //Assert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void CalcularIvaConcepto_UnProducto_ImporteIncorrectoTest()
        {
            //Arrange
            VentaDetalle concepto = new VentaDetalle
            {
                Cantidad = 2,
                TasaIva = 0.08m,
                Producto = new Producto
                {
                    PrecioUnitario = 10.5m
                }
            };

            decimal esperado = 3.36m;

            //Act
            decimal actual = VentasServicios.CalcularIvaConcepto(concepto);

            //Assert
            Assert.AreNotEqual(esperado, actual);
        }


    }
}
