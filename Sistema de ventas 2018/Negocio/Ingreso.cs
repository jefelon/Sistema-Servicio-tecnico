using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
    public class Ingreso
    {//Id, Numero, FechaIngreso, ObservacionExterna, ObservacionInterna, MotivoIngreso, FechaProbableReparacion, Adelanto, Estado, ClienteId, EquipoId
        private int _id;
        private int _numero;
        private DateTime _fechaIngreso;
        private string _observacionExterna;
        private string _observacionInterna;
        private string _motivoIngreso;
        private DateTime _fechaProbableReparacion;
        private decimal _adelanto;
        private string _estado;
        private Cliente _cliente;
        private Equipo _equipo;

        public int Id
        {
            get {  return _id; }

            set {_id = value; }
        }

        public int Numero
        {
            get { return _numero;  }

            set {_numero = value; }
        }

        public DateTime FechaIngreso
        {
            get  { return _fechaIngreso; }

            set { _fechaIngreso = value; }
        }

        public string ObservacionExterna
        {
            get  { return _observacionExterna; }

            set { _observacionExterna = value;}
        }

        public string ObservacionInterna
        {
            get {return _observacionInterna; }

            set{  _observacionInterna = value; }
        }

        public string MotivoIngreso
        {
            get { return _motivoIngreso;  }

            set {_motivoIngreso = value; }
        }

        public DateTime FechaProbableReparacion
        {
            get { return _fechaProbableReparacion; }

            set {_fechaProbableReparacion = value; }
        }

        public decimal Adelanto
        {
            get {return _adelanto; }

            set  { _adelanto = value; }
        }

        public string Estado
        {
            get { return _estado; }

            set  {  _estado = value; }
        }

        public Cliente Cliente
        {
            get  { return _cliente; }

            set {_cliente = value;}
        }

        public Equipo Equipo
        {
            get { return _equipo; }

            set { _equipo = value; }
        }
        public Ingreso()
        {
            _cliente = new Cliente();
            _equipo = new Equipo();
        } 
    }
}
