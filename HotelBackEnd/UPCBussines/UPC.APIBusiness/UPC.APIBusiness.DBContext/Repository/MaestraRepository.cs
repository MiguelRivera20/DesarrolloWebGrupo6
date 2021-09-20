using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace DBContext
{
    public class MaestraRepository : BaseRepository, IMaestraRepository
    {
      public BaseResponse  GetMaestro(string maestro)
        {
            BaseResponse res = new BaseResponse();
            var lstMaestraEntity = new List<MaestraEntity>();
            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"Usp_ListarMaestra";
                    var p = new DynamicParameters();
                    p.Add(name: "@TX_MAESTRA", value: maestro, dbType: DbType.String, direction: ParameterDirection.Input);

                    /*
                    entitiesProjects = db.Query<EntityProject>(sql,
                        commandType: CommandType.StoredProcedure).ToList();*/

                    lstMaestraEntity = db.Query<MaestraEntity>(sql: sql, param: p,
                        commandType: CommandType.StoredProcedure).ToList();
                    if (lstMaestraEntity != null)
                    {
                        res.isSuccess = true;
                        res.errorCode = "0000";
                        res.errorMessage = string.Empty;
                        res.data = lstMaestraEntity;
                    } else
                    {
                        res.isSuccess = true;
                        res.errorCode = "0000";
                        res.errorMessage = string.Empty;
                        res.data = null;
                    }
                  
                }
            }
            catch (Exception e)
            {
                res.isSuccess = false;
                res.errorCode = "0001";
                res.errorMessage = e.Message;
                res.data = null;
              //  throw new Exception(e.Message);
            }
            return res;
        }
    }
}
