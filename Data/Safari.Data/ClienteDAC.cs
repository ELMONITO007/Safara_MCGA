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
    public class ClienteDAC : DataAccessComponent, IRepository<Cliente>
    {
        public Cliente Create(Cliente entity)
        {
            const string SQL_STATEMENT = "insert into Cliente(Nombre,Apellido,Email,Telefono,Url,FechaNacimiento,Domicilio)values(@Nombre,@Apellido,@Email,@Telefono,@Url,@FechaNAcimiento,@Domicilio)";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, entity.Nombre);
                db.AddInParameter(cmd, "@Apellido", DbType.AnsiString, entity.Apellido);

                db.AddInParameter(cmd, "@Email", DbType.AnsiString, entity.Email);
                db.AddInParameter(cmd, "@Telefono", DbType.AnsiString, entity.Telefono);
                db.AddInParameter(cmd, "@Url", DbType.AnsiString, entity.Url);
                db.AddInParameter(cmd, "@FechaNAcimiento", DbType.Date, entity.FechaNacimiento);
                db.AddInParameter(cmd, "@Domicilio", DbType.AnsiString, entity.Nombre);

            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "DELETE Cliente WHERE [Id]= @Id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Cliente> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM Cliente ";

            List<Cliente> result = new List<Cliente>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Cliente cliente = LoadCliente(dr);
                        result.Add(cliente);
                    }
                }
            }
            return result;
        }

        public Cliente ReadBy(int id)
        {

            const string SQL_STATEMENT = "SELECT * FROM Cliente WHERE [Id]=@Id ";
            Cliente cliente = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        cliente = LoadCliente(dr);
                    }
                }
                return cliente;
            }
        }

        public void Update(Cliente entity)
        {
            const string SQL_STATEMENT = "update Cliente set Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Telefono = @Telefono, Url =@Url, FechaNacimiento = @FechaNacimiento, Domicilio = @Domicilio where id = @Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, entity.Nombre);
                db.AddInParameter(cmd, "@Apellido", DbType.AnsiString, entity.Apellido);

                db.AddInParameter(cmd, "@Email", DbType.AnsiString, entity.Email);
                db.AddInParameter(cmd, "@Telefono", DbType.AnsiString, entity.Telefono);
                db.AddInParameter(cmd, "@Url", DbType.AnsiString, entity.Url);
                db.AddInParameter(cmd, "@FechaNAcimiento", DbType.Date, entity.FechaNacimiento);
                db.AddInParameter(cmd, "@Domicilio", DbType.AnsiString, entity.Nombre);
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

            private Cliente LoadCliente(IDataReader dr)
        {
            Cliente cliente = new Cliente();
            cliente.Id = GetDataValue<int>(dr, "Id");
            cliente.Nombre = GetDataValue<string>(dr, "Nombre");
            cliente.Apellido = GetDataValue<string>(dr, "Apellido");
            cliente.Email = GetDataValue<string>(dr, "Email");
            cliente.Telefono = GetDataValue<string>(dr, "Telefono");
            cliente.Url = GetDataValue<string>(dr, "Url");
            cliente.Domicilio = GetDataValue<string>(dr, "Domicilio");
            cliente.FechaNacimiento=GetDataValue<DateTime>(dr, "FechaNacimiento");

            return cliente;
        }
    }
}
