using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubd
{
     public class person

    {
        private string dni;
        private string apellido;
        private string nombre;
        private string fechanac;
        private string fechainscrip;
        private string direccion;
        private string email;
        private string telefono;
        private string conturgencia;
        private string fichamed;
        private bool socio;
        private string estado;

        public person()
        {
            this.dni = Dni;
            this.apellido = Apellido;
            this.nombre = Nombre;
            this.fechanac = Fechanac;
            this.fechainscrip = Fechainscrip;
            this.direccion = Direccion;
            this.email = Email;
            this.telefono = Telefono;
            this.conturgencia = Conturgencia;
            this.fichamed = Fichamed;
            this.socio = Socio;
            this.estado = Estado;

        }
        //setters and getters
        public string Dni { get { return dni; } set { dni = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Fechanac { get { return fechanac; } set { fechanac = value; } }
        public string Fechainscrip { get { return fechainscrip; } set { fechainscrip = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Conturgencia { get { return conturgencia; } set { conturgencia = value; } }
        public string Fichamed { get { return fichamed; } set { fichamed = value; } }
        public bool Socio { get { return socio; } set { socio = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
    }

     class Pago_Actividad
    {
        private int idactividad;
        private string idnsocio;
        private string fechapago;
        private string nombreactividad;
        private double precioactividad;

        //constructor
        public Pago_Actividad()
        {
            this.idactividad = Idactividad;
            this.idnsocio = Idnsocio;
            this.fechapago = Fechapago;
            this.nombreactividad = Nombreactividad;
            this.precioactividad = Precioactividad;
        }
        //getters and setters
        public int Idactividad { get { return idactividad; } set { idactividad = value; } }
        public string Idnsocio { get { return idnsocio; } set { idnsocio = value; } }
        public string Fechapago { get { return fechapago; } set { fechapago = value; } }
        public string Nombreactividad { get { return nombreactividad; } set { nombreactividad = value; } }
        public double Precioactividad { get { return precioactividad; } set { precioactividad = value; } }

    }

    class Cuota
    {
        private int idcuota;
        private string idsocio;
        private double preciocuotasocial;
        private string fechapago;
        private string metodopago;
        private string fechavencimiento;

        //constructor
        public Cuota()
        {
            this.idcuota = Idcuota;
            this.idsocio = Idsocio;
            this.preciocuotasocial = Preciocuotasocial;
            this.fechapago = Fechapago;
            this.metodopago = Metodopago;
            this.fechavencimiento = Fechavencimiento;
        }

        //getters and setters
        public int Idcuota { get { return idcuota; } set { idcuota = value; } }
        public string Idsocio { get { return idsocio; } set { idsocio = value; } }
        public double Preciocuotasocial { get { return preciocuotasocial; } set { preciocuotasocial = value; } }
        public string Fechapago { get { return fechapago; } set { fechapago = value; } }
        public string Metodopago { get { return metodopago; } set { metodopago = value; } }
        public string Fechavencimiento { get { return fechavencimiento; } set { fechavencimiento = value; } }

    }

    public class ResultadoBusquedaPersona
    {
        public bool Existe { get; set; }
        public bool EsSocio { get; set; }
    }


}
