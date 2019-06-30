using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace LibNegocioFletero
{
    public class Comuna
    {

        #region Atributos
        string _mensaje;
        bool _exito = false;
        int _id;
        string _nombre;
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

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
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

    }
}
