using Microsoft.Practices.EnterpriseLibrary.Data;
using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Data
{
    public class TipoMovimientoDAC : DataAccessComponent, IRepository<TipoMovimiento>
    {
        public TipoMovimiento Create(TipoMovimiento entity)
        {

            const string SQL_STATEMENT = "insert into TipoMovimiento(Nombre,Multiplicador)values(@Nombre,@Multiplador)";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, entity.Nombre);
                db.AddInParameter(cmd, "@Multiplador", DbType.Int16, entity.Multiplador);
                             

            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "DELETE TipoMovimiento WHERE [Id]= @Id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<TipoMovimiento> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM TipoMovimiento ";

            List<TipoMovimiento> result = new List<TipoMovimiento>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        TipoMovimiento tipoMovimiento = LoadTipoMovimiento(dr);
                        result.Add(tipoMovimiento);
                    }
                }
            }
            return result;
        }

        public TipoMovimiento ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM TipoMoviminto WHERE [Id]=@Id ";
            TipoMovimiento tipoMovimiento = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        tipoMovimiento = LoadTipoMovimiento(dr);
                    }
                }
                return tipoMovimiento;
            }
        }

        public void Update(TipoMovimiento entity)
        {
            const string SQL_STATEMENT = "UPDATE TipoMovimiento SET [Nombre]= @Nombre , Multiplador=@Multiplador WHERE [Id]= @Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, entity.Nombre);
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@Multiplador", DbType.Int16, entity.Multiplador);
                db.ExecuteNonQuery(cmd);
            }
        }

        private TipoMovimiento LoadTipoMovimiento(IDataReader dr)
        {
            TipoMovimiento tipoMovimiento = new TipoMovimiento();
            tipoMovimiento.Id = GetDataValue<int>(dr, "Id");
            tipoMovimiento.Nombre = GetDataValue<string>(dr, "Nombre");
            tipoMovimiento.Multiplador = GetDataValue<int>(dr, "Multiplador");
            return tipoMovimiento;
        }
    }
}
