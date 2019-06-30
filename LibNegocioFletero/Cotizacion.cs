using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibNegocioMudanza
{
    class Cotizacion
    {
        #region Atributos
        string _mensaje;
        bool _exito = false;
        int _id;
        string _nombres;
        string _apellidos;
        string _fono;
        string _email;
        DateTime _fechaMudanza;
        string _horario;
        string _origen;
        string _destino;
        string _servicioAdicional;
        DateTime _fechaCotizacion;
        DataSet _ds = new DataSet();
        #endregion

        #region Propiedades
        public string Mensaje
        {
            get
            {
                return _mensaje;
            }

            set
            {
                _mensaje = value;
            }
        }

        public bool Exito
        {
            get
            {
                return _exito;
            }

            set
            {
                _exito = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Nombres
        {
            get
            {
                return _nombres;
            }

            set
            {
                _nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }

        public string Fono
        {
            get
            {
                return _fono;
            }

            set
            {
                _fono = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public DateTime FechaMudanza
        {
            get
            {
                return _fechaMudanza;
            }

            set
            {
                _fechaMudanza = value;
            }
        }

        public string Horario
        {
            get
            {
                return _horario;
            }

            set
            {
                _horario = value;
            }
        }

        public string Origen
        {
            get
            {
                return _origen;
            }

            set
            {
                _origen = value;
            }
        }

        public string Destino
        {
            get
            {
                return _destino;
            }

            set
            {
                _destino = value;
            }
        }

        public string ServicioAdicional
        {
            get
            {
                return _servicioAdicional;
            }

            set
            {
                _servicioAdicional = value;
            }
        }

        public DateTime FechaCotizacion
        {
            get
            {
                return _fechaCotizacion;
            }

            set
            {
                _fechaCotizacion = value;
            }
        }

        public DataSet Ds
        {
            get
            {
                return _ds;
            }

            set
            {
                _ds = value;
            }
        }
        #endregion

        #region Operaciones

        public Cotizacion ingresar(Cotizacion objCotizacion)
        {

            return objCotizacion;

        }


        #endregion


    }
}
