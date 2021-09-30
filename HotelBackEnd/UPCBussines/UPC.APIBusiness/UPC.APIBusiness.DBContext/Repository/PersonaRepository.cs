using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;


namespace DBContext
{
    public class PersonaRepository : BaseRepository , IPersonaRepository
    {
        

        BaseResponse IPersonaRepository.GetPersona(PersonaEntity persona)
        {
            var personaEntity = new PersonaEntity();
            var returnEntity = new BaseResponse();
        

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"Usp_BuscarPersona";

                    var p = new DynamicParameters();
                    p.Add(name: "@TX_NUMERO_DOCUMENTO", value: persona.Tx_Numero_Documento, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_TIPO_DOCUMENTO", value: persona.Co_Tipo_Doc, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    personaEntity = db.Query<PersonaEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure).FirstOrDefault();

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

  

        BaseResponse IPersonaRepository.RegistroPersona(PersonaEntity persona)
        {


            var returnEntity = new BaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"usp_InsertarPersona";

                    var p = new DynamicParameters();
                    p.Add(name: "@CO_PERSONA", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    p.Add(name: "@CO_TIPO_PERSONA", value: persona.Co_Tipo_Persona, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_TIPO_DOC", value: persona.Co_Tipo_Doc, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@TX_NUMERO_DOCUMENTO", value: persona.Tx_Numero_Documento, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@TX_NOMBRE_COMPLETO", value: persona.Tx_Nombre_Completo, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@TX_CORREO", value: persona.Tx_Correo, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@TX_TELEFONO", value: persona.Tx_Telefono, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@TX_DIRECCION", value: persona.Tx_Direccion, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@FE_NACIEMIENTO", value: persona.Fe_Naciemiento_Str, dbType: DbType.String, direction: ParameterDirection.Input);
                    //      p.Add(name: "@FE_REGISTRO", value: 1, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_USUARIO", value: 1, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_GENERO", value: persona.Co_Genero, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    var data = db.Query<PersonaEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure)
                        .FirstOrDefault();

                    int idPersona = p.Get<int>("@CO_PERSONA");

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
