﻿using Microsoft.Practices.EnterpriseLibrary.Data;
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
    public class SalaDAC : DataAccessComponent, IRepository<Sala>
    {
        public Sala Create(Sala entity)
        {
            const string SQL_STATEMENT = "INSERT INTO Sala ([Nombre],TipoSala) VALUES(@Nombre,@TipoSala); SELECT SCOPE_IDENTITY();";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, entity.Nombre);
                db.AddInParameter(cmd, "@TipoSala", DbType.AnsiString, entity.TipoSala);
                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "DELETE Sala WHERE [Id]= @Id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Sala> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM Sala ";

            List<Sala> result = new List<Sala>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Sala sala = LoadSala(dr);
                        result.Add(sala);
                    }
                }
            }
            return result;
        }

        public Sala ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM Sala WHERE [Id]=@Id ";
            Sala sala = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        sala = LoadSala(dr);
                    }
                }
            }
            return sala;
        }

        public void Update(Sala entity)
        {

            const string SQL_STATEMENT = "UPDATE Sala SET [Nombre]= @Nombre, TipoSala=@TipoSala WHERE [Id]= @Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, entity.Nombre);
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@TipoSala", DbType.AnsiString, entity.TipoSala);
                db.ExecuteNonQuery(cmd);
            }
        }


        private Sala LoadSala(IDataReader dr)
        {
            Sala sala = new Sala();
            sala.Id = GetDataValue<int>(dr, "Id");
            sala.Nombre = GetDataValue<string>(dr, "Nombre");
            sala.TipoSala = GetDataValue<string>(dr, "TipoSala");
            return sala;
        }
    }
}
