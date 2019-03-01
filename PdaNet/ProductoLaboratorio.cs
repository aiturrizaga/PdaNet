using System;
using System.Text;

namespace PdaNet
{
    public class ProductoLaboratorio
    {
        private string coProducto { get; set; }
        private string deProducto { get; set; }
        private string deUnidad { get; set; }
        private string deUnidadFraccion { get; set; }
        private string coLaboratorio { get; set; }
        private string deLaboratorio { get; set; }
        private int vaFraccion { get; set; }
        private string codigoBarra { get; set; }
        private int caEntero { get; set; }
        private int caFraccion { get; set; }
        private string inProdFraccionado { get; set; }
        private string nuAnaquel { get; set; }
        private string nuAnaquelConcat { get; set; }
        private bool nuevo = true;

        public string inventario()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(this.coProducto);
            builder.Append("@");
            builder.Append(this.coLaboratorio);
            builder.Append("@");
            builder.Append(this.inProdFraccionado);
            builder.Append("@");
            builder.Append(this.vaFraccion);
            builder.Append("@");
            builder.Append(this.caEntero);
            builder.Append("@");
            builder.Append(this.caFraccion);
            builder.Append("@");
            builder.Append(this.nuAnaquelConcat);
            builder.Append("@");
            builder.Append("N");
            return builder.ToString();
        }

        public int getCaEntero() 
        {
            return this.caEntero;
        }

        public int getCaFraccion()
        {
            return this.caFraccion;
        }

        public string getCodigoBarra()
        {
            return this.codigoBarra;
        }

        public string getCoLaboratorio()
        {
            return this.coLaboratorio;
        }

        public string getCoProducto()
        {
            return this.coProducto;
        }

        public string getDeLaboratorio()
        {
            return this.deLaboratorio;
        }

        public string getDeProducto()
        {
            return this.deProducto;
        }

        public string getDeUnidad()
        {
            return this.deUnidad;
        }

        public string getDeUnidadFraccion()
        {
            return this.deUnidadFraccion;
        }

        public string getInProdFraccionado()
        {
            return this.inProdFraccionado;
        }

        public string getNuAnaquel()
        {
            return this.nuAnaquel;
        }

        public int getVaFraccion()
        {
            return this.vaFraccion;
        }

        public string getNuAnaquelConcat()
        {
            return this.nuAnaquelConcat;
        }

        public bool isNuevo()
        {
            return this.nuevo;
        }

        public void setNuevo(bool nuevo)
        {
            this.nuevo = nuevo;
        }

        public void setCaEntero(int caEntero)
        {
            this.caEntero = caEntero;
        }

        public void setCaFraccion(int caFraccion)
        {
            this.caFraccion = caFraccion;
        }

        public void setCodigoBarra(string codigoBarra)
        {
            this.codigoBarra = codigoBarra;
        }

        public void setCoLaboratorio(string coLaboratorio)
        {
            this.coLaboratorio = coLaboratorio;
        }

        public void setCoProducto(string coProducto)
        {
            this.coProducto = coProducto;
        }

        public void setDeLaboratorio(string deLaboratorio)
        {
            this.deLaboratorio = deLaboratorio;
        }

        public void setDeProducto(string deProducto)
        {
            this.deProducto = deProducto;
        }

        public void setDeUnidad(string deUnidad)
        {
            this.deUnidad = deUnidad;
        }

        public void setDeUnidadFraccion(string deUnidadFraccion)
        {
            this.deUnidadFraccion = deUnidadFraccion;
        }

        public void setInProdFraccionado(string inProdFraccionado)
        {
            this.inProdFraccionado = inProdFraccionado;
        }

        public void setNuAnaquel(string nuAnaquel)
        {
            this.nuAnaquel = nuAnaquel;
        }

        public void setVaFraccion(int vaFraccion)
        {
            this.vaFraccion = vaFraccion;
        }

        public void setNuAnaquelConcant(string nuAnaquelConcat)
        {
            this.nuAnaquelConcat = nuAnaquelConcat;
        }

    }
}
