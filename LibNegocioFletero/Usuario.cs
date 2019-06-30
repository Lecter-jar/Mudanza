using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibNegocioMudanza
{
    public class Usuario
    {

        #region Atributos
        string _mensaje;
        bool _exito = false;
        int _id;
        string _rut;
        string _primerNombre;
        string _segundoNombre;
        string _apellidoPaterno;
        string _apellidoMaterno;
        DateTime _fechaNacimiento;
        string _direccion;
        int _comuna;
        string _fono;
        string _email;
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

        public string Rut
        {
            get
            {
                return _rut;
            }

            set
            {
                _rut = value;
            }
        }

        public string PrimerNombre
        {
            get
            {
                return _primerNombre;
            }

            set
            {
                _primerNombre = value;
            }
        }

        public string SegundoNombre
        {
            get
            {
                return _segundoNombre;
            }

            set
            {
                _segundoNombre = value;
            }
        }

        public string ApellidoPaterno
        {
            get
            {
                return _apellidoPaterno;
            }

            set
            {
                _apellidoPaterno = value;
            }
        }

        public string ApellidoMaterno
        {
            get
            {
                return _apellidoMaterno;
            }

            set
            {
                _apellidoMaterno = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }

            set
            {
                _fechaNacimiento = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }

            set
            {
                _direccion = value;
            }
        }

        public int Comuna
        {
            get
            {
                return _comuna;
            }

            set
            {
                _comuna = value;
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






    } // fin class

} // fin namespace
