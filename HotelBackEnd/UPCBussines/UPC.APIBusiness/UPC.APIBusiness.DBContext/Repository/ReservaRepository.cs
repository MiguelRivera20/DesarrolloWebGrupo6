using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;
using Dapper;
using System.Data;
using System.Linq;


namespace DBContext
{
    public class ReservaRepository : BaseRepository, IReservaRepository
    {


        BaseResponse IReservaRepository.GetReserva(ReservaEntity reserva)
        {
            var personaEntity = new ReservaEntity();
            var returnEntity = new BaseResponse();


            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"Usp_InsertarReserva";

                    var p = new DynamicParameters();
                    p.Add(name: "@CO_RESERVA", value: reserva.Co_Reserva, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_CLIENTE", value: reserva.Co_Cliente, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    personaEntity = db.Query<ReservaEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure).FirstOrDefault();

                    if (personaEntity != null)
                    {

                        returnEntity.isSuccess = true;
                        returnEntity.errorCode = "0000";
                        returnEntity.errorMessage = string.Empty;
                        returnEntity.data = personaEntity;
                    }
                    else
                    {
                        returnEntity.isSuccess = true;
                        returnEntity.errorCode = "0000";
                        returnEntity.errorMessage = string.Empty;
                        returnEntity.data = null;
                    }
                }
            }
            catch (Exception ex)
            {
                returnEntity.isSuccess = false;
                returnEntity.errorCode = "0001";
                returnEntity.errorMessage = ex.Message;
                returnEntity.data = null;
            }

            return returnEntity;
        }



        BaseResponse IReservaRepository.ReservaPersona(ReservaEntity reserva)
        {


            var returnEntity = new BaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"usp_AplicarReserva";

                    var p = new DynamicParameters();
                    p.Add(name: "@CO_RESERVA", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    p.Add(name: "@CO_CLIENTE", value: reserva.Co_Cliente, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_TIPO_HABITACION", value: reserva.Co_Tipo_Habitacion, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@FE_INGRESO", value: reserva.Fe_Ingreso, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                    p.Add(name: "@FE_SALIDA", value: "", dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@FL_PAGO_TOTAL", value: reserva.Fl_Pago_Total, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@NU_ACOMPANIANTES", value: reserva.Nu_Acompaniantes, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@NU_MONTO_ADELANTADO", value: reserva.Nu_Monto_Adelanto, dbType: DbType.Double, direction: ParameterDirection.Input);
                    p.Add(name: "@NU_TIPO_PAGO", value: reserva.Nu_Tipo_Pago, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    //      p.Add(name: "@FE_REGISTRO", value: 1, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@FE_REGISTRO", value: reserva.Fe_Registro, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                    p.Add(name: "@FL_ESTADO", value: reserva.Fl_Estado, dbType: DbType.String, direction: ParameterDirection.Input);

                    var data = db.Query<PersonaEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure)
                        .FirstOrDefault();

                    int idPersona = p.Get<int>("@CO_RESERVA");

                    if (idPersona > 0)
                    {
                        returnEntity.isSuccess = true;
                        returnEntity.errorCode = "0000";
                        returnEntity.errorMessage = string.Empty;
                        returnEntity.data = new
                        {
                            id = idPersona
                        };
                    }
                    else
                    {
                        returnEntity.isSuccess = true;
                        returnEntity.errorCode = "0000";
                        returnEntity.errorMessage = string.Empty;
                        returnEntity.data = null;
                    }
                }
            }
            catch (Exception ex)
            {
                returnEntity.isSuccess = false;
                returnEntity.errorCode = "0001";
                returnEntity.errorMessage = ex.Message;
                returnEntity.data = null;
            }

            return returnEntity;
        }
    }
}
