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
    public class MovimientoDAC : DataAccessComponent, IRepository<Movimiento>
    {
        public Movimiento Create(Movimiento entity)
        {
            const string SQL_STATEMENT = "insert into Movimiento (Fecha,ClienteId,TipoMovimientoId,Valor)values(@Fecha,@ClienteId,@TipoMovientoId,@Valor); SELECT SCOPE_IDENTITY();";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Valor", DbType.Int32, entity.valor);
                db.AddInParameter(cmd, "@Fecha", DbType.DateTime, entity.Fecha);
                db.AddInParameter(cmd, "@ClienteId", DbType.Int32, entity.Cliente);
                db.AddInParameter(cmd, "@TipoMovientoId", DbType.Int32, entity.tipoMovimiento);


                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));

            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "DELETE Movimiento WHERE [Id]= @Id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Movimiento> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM Movimiento ";

            List<Movimiento> result = new List<Movimiento>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Movimiento movimiento = LoadMovimiento(dr);
                        result.Add(movimiento);
                    }
                }
            }
            return result;
        }

        public Movimiento ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM Movimiento WHERE [Id]=@Id ";
            Movimiento movimiento = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        movimiento = LoadMovimiento(dr);
                    }
                }
            }
            return movimiento;
        }

        public void Update(Movimiento entity)
        {
            const string SQL_STATEMENT = "update Movimiento set Fecha=@Fecha,ClienteId=@ClienteId,TipoMovimientoId=@TipoMovimientoId,Valor=@Valor  WHERE [Id]= @Id";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.Id);
                
                db.AddInParameter(cmd, "@Fecha", DbType.DateTime, entity.Fecha);
                db.AddInParameter(cmd, "@ClienteId", DbType.Int32, entity.Cliente);
                db.AddInParameter(cmd, "@TipoMovimientoId", DbType.Int32, entity.tipoMovimiento);
                db.AddInParameter(cmd, "@Valor", DbType.Int32, entity.valor);
                db.ExecuteNonQuery(cmd);
            }
        }
        private Movimiento LoadMovimiento(IDataReader dr)
        {
            Movimiento movimiento = new Movimiento();
          
            movimiento.Fecha = GetDataValue<DateTime>(dr, "Fecha");
            movimiento.Cliente= GetDataValue<int>(dr, "ClienteId");
            movimiento.tipoMovimiento = GetDataValue<int>(dr, "TipoMovimientoId");
            movimiento.valor = GetDataValue<int>(dr, "Valor");
            movimiento.Id = GetDataValue<int>(dr, "Id");
            return movimiento;
        }
    }
}
