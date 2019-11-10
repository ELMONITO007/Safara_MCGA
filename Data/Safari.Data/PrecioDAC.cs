using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Safari.Entities;

namespace Safari.Data
{
    public class PrecioDAC : DataAccessComponent, IRepository<Precio>
    {
        public Precio Create(Precio entity)


        {
            const string SQL_STATEMENT = "insert into Precio (TipoServicioId,FechaDesde,FechaHasta,Valor)values(@TipoServicioId,@FechaDesde,@FechaHasta,@Valor); SELECT SCOPE_IDENTITY();";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@TipoServicioId", DbType.Int16, entity.tipoServicioID);
                db.AddInParameter(cmd, "@FechaDesde", DbType.DateTime, entity.fechaDesde);
                db.AddInParameter(cmd, "@FechaHasta", DbType.DateTime, entity.fechaHasta);
                db.AddInParameter(cmd, "@Valor", DbType.Int32, entity.valor);
                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }
          

           

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "DELETE Precio WHERE [Id]= @Id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Precio> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM Precio";

            List<Precio> result = new List<Precio>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Precio precio = LoadPrecio(dr);
                        result.Add(precio);
                    }
                }
            }
            return result;
        }

        public Precio ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM Precio WHERE [Id]=@Id ";
            Precio precio = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        precio = LoadPrecio(dr);
                    }
                }
            }
            return precio;
        }

        public void Update(Precio entity)
        {
            const string SQL_STATEMENT = "	update Precio set TipoServicioId=@TipoServicioId, FechaDesde=@FechaDesde,FechaHasta=@FechaHasta,Valor=@Valor WHERE [Id]= @Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@TipoServicioId", DbType.Int16, entity.tipoServicioID);
                db.AddInParameter(cmd, "@FechaDesde", DbType.DateTime, entity.fechaDesde);
                db.AddInParameter(cmd, "@FechaHasta", DbType.DateTime, entity.fechaHasta);
                db.AddInParameter(cmd, "@Valor", DbType.Int32, entity.valor);
                db.ExecuteNonQuery(cmd);
            }
        }

        private Precio LoadPrecio(IDataReader dr)
        {
            Precio precio = new Precio();
           
            precio.fechaDesde = GetDataValue<DateTime>(dr, "FechaDesde");
            precio.fechaHasta = GetDataValue<DateTime>(dr, "FechaHasta");
            precio.tipoServicioID = GetDataValue<int>(dr, "TIpoServicioId");
            precio.valor = GetDataValue<int>(dr, "Valor");
           
            return precio;
        }
    }
}
