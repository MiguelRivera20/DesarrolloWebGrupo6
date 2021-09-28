using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace DBContext
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {

        BaseResponse IUsuarioRepository.GetUsuarioPorDocumentoPersona(int tipoDocumento, string numeroDocumento)
        {
            var usuarioEntity = new UsuarioPersonaEntity();
            var returnEntity = new BaseResponse();


            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"Usp_BuscarUsuarioPorPersona";

                    var p = new DynamicParameters();
                    p.Add(name: "@TX_NUMERO_DOCUMENTO", value: numeroDocumento, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_TIPO_DOCUMENTO", value: tipoDocumento, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    usuarioEntity = db.Query<UsuarioPersonaEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure).FirstOrDefault();

                    if (usuarioEntity != null)
                    {

                        returnEntity.isSuccess = true;
                        returnEntity.errorCode = "0000";
                        returnEntity.errorMessage = string.Empty;
                        returnEntity.data = usuarioEntity;
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

        BaseResponse IUsuarioRepository.GetUsuario(UsuarioEntity usuario)
        {
            var usuarioEntity = new List<UsuarioPersonaEntity>();
            var returnEntity = new BaseResponse();


            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"Usp_ListarUsuario";

                    var p = new DynamicParameters();
                    p.Add(name: "@CO_PERFIL", value: usuario.Co_Perfil, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@USERNAME", value: usuario.Tx_Username, dbType: DbType.String, direction: ParameterDirection.Input);

                    usuarioEntity = db.Query<UsuarioPersonaEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure).ToList();

                    if (usuarioEntity != null)
                    {

                        returnEntity.isSuccess = true;
                        returnEntity.errorCode = "0000";
                        returnEntity.errorMessage = string.Empty;
                        returnEntity.data = usuarioEntity;
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

        BaseResponse IUsuarioRepository.RegistroUsuario(UsuarioEntity usuario)
        {


            var returnEntity = new BaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"usp_InsertarUsuario";

                    var p = new DynamicParameters();
                    p.Add(name: "@CO_USUARIO", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    p.Add(name: "@CO_PERSONA", value: usuario.Co_Persona, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_PERFIL", value: usuario.Co_Perfil, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@CO_SITUACION", value: usuario.Co_Situacion, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@TX_USERNAME", value: usuario.Tx_Username, dbType: DbType.String, direction: ParameterDirection.Input);


                    var data = db.Query<UsuarioEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure)
                        .FirstOrDefault();

                    int idPersona = p.Get<int>("@CO_USUARIO");

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
