using PruebasUnitariasDemo.Entidades;
using PruebasUnitariasDemo.Servicios;

namespace PruebasUnitariasDemo.MSTest
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
    }
}
