using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LibDataMudanza;

namespace LibNegocioMudanza
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

        #region Operaciones

        // metodo para obtener el obj comuna devuelto por el obj db
        public Comuna listar(Comuna objComuna)
        {
            DataBase objDb = new DataBase();
            objComuna = objDb.listar(objComuna);

            return objComuna;
        }


        #endregion

    }
}
