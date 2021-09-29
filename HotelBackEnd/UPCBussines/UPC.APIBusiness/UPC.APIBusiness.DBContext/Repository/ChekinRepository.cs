using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;
using Dapper;
using System.Data;
using System.Linq;

namespace DBContext
{
    public class ChekinRepository : BaseRepository, IChekinRepository
    {
        BaseResponse IChekinRepository.GetChekin(DBEntity.CheckInEntity checkIn)
        {
            var personaEntity = new CheckInEntity();
            var returnEntity = new BaseResponse();

            try
            {
                using (var db=GetSqlConnection())
                {
                    const string sql = @"Usp_BuscarChekin";
                    
                    var p = new DynamicParameters();
                    p.Add(name: "@CO_Chekin", value: checkIn.Co_Chekin, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_CLIENTE", value: checkIn.Co_Cliente, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    personaEntity = db.Query<CheckInEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure).FirstOrDefault();

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



        BaseResponse IChekinRepository.ChekinPersona(CheckInEntity checkIn)
        {


            var returnEntity = new BaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"usp_AplicarChekin";

                    var p = new DynamicParameters();
                    p.Add(name: "@CO_Check_In", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    p.Add(name: "@CO_CLIENTE", value: checkIn.Co_Cliente, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_HABITACION", value: checkIn.Co_Habitacion, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_Reserva", value: checkIn.Fe_Ingreso, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                    p.Add(name: "@Nu_Acompañantes", value: "", dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Fe_Ingreso", value: checkIn.Fe_Ingreso, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                    p.Add(name: "@Fe_Salida", value: checkIn.Fe_Salida, dbType: DbType.DateTime, direction: ParameterDirection.Input) ;
                    p.Add(name: "@NU_MONTO_ADELANTADO", value: checkIn.Nu_Monto_Adelantado, dbType: DbType.Double, direction: ParameterDirection.Input);
                    p.Add(name: "@NU_Precio_Total", value: checkIn.Nu_Precio_Total, dbType: DbType.Int32, direction: ParameterDirection.Input);
                   

                    var data = db.Query<PersonaEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure)
                        .FirstOrDefault();

                    int idPersona = p.Get<int>("@CO_Chekin");

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

