using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace DBContext
{
    public class ProjectRepository : BaseRepository ,IProjectRepository
    {
       public List<EntityProject> GetProjects()
        {
            var entitiesProjects = new List<EntityProject>();
            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"usp_ListarProyectos";

                    entitiesProjects = db.Query<EntityProject>(sql,
                        commandType: CommandType.StoredProcedure).ToList();
                }
                  
            } catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return entitiesProjects;
        }
        public EntityProject GetProject(int id)
        {
            var entityProject = new EntityProject();
            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"usp_ObtenerProyecto";
                    var p = new DynamicParameters();
                    p.Add(name: "@IDPROYECTO", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    entityProject = db.Query<EntityProject>(sql: sql, param: p,
                        commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return entityProject;
        }

    }
}
