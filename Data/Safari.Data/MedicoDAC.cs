using Microsoft.Practices.EnterpriseLibrary.Data;
using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safari.Data
{
    public class MedicoDAC : DataAccessComponent, IRepository<Medico>
    {
        public Medico Create(Medico entity)
        {
            try
            {
                const string SQL_STATEMENT = "insert into Medico(TipoMatricula,NumeroMatricula,Apellido,Nombre,Especialidad,FechaNacimiento,Email,Telefono)values(@TipoMatricula,@NumeroMatricula,@Apellido,@Nombre,@Especialidad,@FechaNacimiento,@Email,@Telefono)";

                var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
                using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
                {
                    db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, entity.Nombre);
                    db.AddInParameter(cmd, "@TipoMatricula", DbType.AnsiString, entity.TipoMatricula);
                    db.AddInParameter(cmd, "@Apellido", DbType.AnsiString, entity.Apellido);
                    db.AddInParameter(cmd, "@NumeroMatricula", DbType.Int32, entity.NumeroMatricula);
                    db.AddInParameter(cmd, "@Email", DbType.AnsiString, entity.Email);
                    db.AddInParameter(cmd, "@Telefono", DbType.AnsiString, entity.Telefono);
                    db.AddInParameter(cmd, "@Especialidad", DbType.AnsiString, entity.Especialidad);
                    db.AddInParameter(cmd, "@FechaNAcimiento", DbType.Date, entity.FechaNacimiento);

                    db.ExecuteNonQuery(cmd);
                    return entity;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return entity;
            }
           
           
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "DELETE Medico WHERE [Id]= @Id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Medico> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM Medico ";

            List<Medico> result = new List<Medico>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Medico medico = LoadMedico(dr);
                        result.Add(medico);
                    }
                }
            }
            return result;
        }

        public Medico ReadBy(int id)
        {

            const string SQL_STATEMENT = "SELECT * FROM MEdico WHERE [Id]=@Id ";
            Medico medico = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        medico = LoadMedico(dr);
                    }
                }
                return medico;
            }
        }

        public void Update(Medico entity)
        {
            const string SQL_STATEMENT = "update Medico set Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Telefono = @Telefono, TipoMatricula =@TipoMatricula, FechaNacimiento = @FechaNacimiento,  Especialidad = @Especialidad,NumeroMatricula = @NumeroMatricula where id = @Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, entity.Nombre);
                db.AddInParameter(cmd, "@TipoMatricula", DbType.AnsiString, entity.TipoMatricula);
                db.AddInParameter(cmd, "@Apellido", DbType.AnsiString, entity.Apellido);
                db.AddInParameter(cmd, "@NumeroMatricula", DbType.AnsiString, entity.NumeroMatricula);
                db.AddInParameter(cmd, "@Email", DbType.AnsiString, entity.Email);
                db.AddInParameter(cmd, "@Telefono", DbType.AnsiString, entity.Telefono);
                db.AddInParameter(cmd, "@Especialidad", DbType.AnsiString, entity.Especialidad);
                db.AddInParameter(cmd, "@FechaNAcimiento", DbType.Date, entity.FechaNacimiento);
            

                db.ExecuteNonQuery(cmd);
            }
        }
        private Medico LoadMedico(IDataReader dr)
        {
            Medico medico = new Medico();
           medico.Id = GetDataValue<int>(dr, "Id");
           medico.Nombre = GetDataValue<string>(dr, "Nombre");
           medico.Apellido = GetDataValue<string>(dr, "Apellido");
           medico.Email = GetDataValue<string>(dr, "Email");
           medico.Telefono = GetDataValue<string>(dr, "Telefono");
           medico.Especialidad = GetDataValue<string>(dr, "Especialidad");
           medico.NumeroMatricula = GetDataValue<int>(dr, "NumeroMatricula");
           medico.FechaNacimiento = GetDataValue<DateTime>(dr, "FechaNacimiento");
            medico.TipoMatricula = GetDataValue<string>(dr, "TipoMatricula");

            return medico;
        }
    }
}
