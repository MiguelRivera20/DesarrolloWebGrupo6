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
      public  List<MaestraEntity> GetMaestro(string maestro)
        {

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
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return lstMaestraEntity;
        }
    }
}
