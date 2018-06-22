using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
    public class Equipo
    {
        private int _id;
        private string _descripcion;
        private Modelo _modelo;
        private string _serie;
        private Marca _marca;

        public int Id
        {
            get{return _id; }
            set{ _id = value;}
        }
        public string Descripcion
        {
            get{return _descripcion;}
            set{_descripcion = value;}
        }
        public Modelo Modelo
        {
            get {return _modelo;}
            set{_modelo = value;}
        }
        public string Serie
        {
            get{ return _serie; }
            set{ _serie = value; }
        }

        public Marca Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }
        public Equipo()
        {
            _modelo = new Modelo();
            _marca = new Marca();
        }
    }
}
