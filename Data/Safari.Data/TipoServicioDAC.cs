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
    public class TipoServicioDAC : DataAccessComponent, IRepository<TipoServicio>
    {
        public TipoServicio Create(TipoServicio entity)
        {
            const string SQL_STATEMENT = "INSERT INTO TipoServicio ([Nombre]) VALUES(@Nombre); SELECT SCOPE_IDENTITY();";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, entity.Nombre);
                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "DELETE TipoServicio WHERE [Id]= @Id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<TipoServicio> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM TipoServicio ";

            List<TipoServicio> result = new List<TipoServicio>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        TipoServicio tipoServicio = LoadTipoServicio(dr);
                        result.Add(tipoServicio);
                    }
                }
            }
            return result;
        }

        public TipoServicio ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM tipoServicio WHERE [Id]=@Id ";
            TipoServicio tipoServicio = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        tipoServicio = LoadTipoServicio(dr);
                    }
                }
            }
            return tipoServicio;
        }

        public void Update(TipoServicio entity)
        {
            const string SQL_STATEMENT = "UPDATE TipoServicio SET [Nombre]= @Nombre WHERE [Id]= @Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, entity.Nombre);
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.Id);
                db.ExecuteNonQuery(cmd);
            }
        }

        private TipoServicio LoadTipoServicio(IDataReader dr)
        {
            TipoServicio tipoServicio = new TipoServicio();
            tipoServicio.Id = GetDataValue<int>(dr, "Id");
            tipoServicio.Nombre = GetDataValue<string>(dr, "Nombre");
            return tipoServicio;
        }
    }
}
