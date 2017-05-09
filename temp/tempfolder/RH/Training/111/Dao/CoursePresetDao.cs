using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_CoursePreset ( RH_CoursePreset ) Dao类
    ///</summary>
    public class CoursePresetDao
    {

        /// <summary>
        /// 添加
        /// RH_CoursePreset : RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_CoursePreset");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    Name,");
                strBuilder.Append("    CPDesc,");
                strBuilder.Append("    IfPromote,");
                strBuilder.Append("    IsRequired,");
                strBuilder.Append("    CourseLevel,");
                strBuilder.Append("    Dimension,");
                strBuilder.Append("    Version,");
                strBuilder.Append("    parentID,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @Name,");
                strBuilder.Append("    @CPDesc,");
                strBuilder.Append("    @IfPromote,");
                strBuilder.Append("    @IsRequired,");
                strBuilder.Append("    @CourseLevel,");
                strBuilder.Append("    @Dimension,");
                strBuilder.Append("    @Version,");
                strBuilder.Append("    @parentID,");
                strBuilder.Append("    @Status,");
                strBuilder.Append("    @CreateBy,");
                strBuilder.Append("    @CreateTime,");
                strBuilder.Append("    @UpdateBy,");
                strBuilder.Append("    @UpdateTime");
                strBuilder.Append("  )");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCoursePresetEntity.ID);

                ///Name : nvarchar(50) Name
                if (paramCoursePresetEntity.Name != null && "".Equals(paramCoursePresetEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramCoursePresetEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///CPDesc : nvarchar(200) CPDesc
                if (paramCoursePresetEntity.CPDesc != null && "".Equals(paramCoursePresetEntity.CPDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPDesc", paramCoursePresetEntity.CPDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPDesc", DBNull.Value);
                }

                ///是否提升 1-是 0-否 : int IfPromote
                m_sqlCmd.Parameters.AddWithValue("@IfPromote",paramCoursePresetEntity.IfPromote);

                ///是否必修 1.是 2否 : int IsRequired
                m_sqlCmd.Parameters.AddWithValue("@IsRequired",paramCoursePresetEntity.IsRequired);

                ///能力提升课程等级 1.初级 2.中级 3，高级 : int CourseLevel
                m_sqlCmd.Parameters.AddWithValue("@CourseLevel",paramCoursePresetEntity.CourseLevel);

                ///能力提升课程维度 : int Dimension
                m_sqlCmd.Parameters.AddWithValue("@Dimension",paramCoursePresetEntity.Dimension);

                ///版本号 : int Version
                m_sqlCmd.Parameters.AddWithValue("@Version",paramCoursePresetEntity.Version);

                ///父套餐id，用于套餐复制 : int parentID
                m_sqlCmd.Parameters.AddWithValue("@parentID",paramCoursePresetEntity.parentID);

                ///状态：1-未发布 2-已发布 3 已删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramCoursePresetEntity.Status);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramCoursePresetEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramCoursePresetEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramCoursePresetEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramCoursePresetEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramCoursePresetEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramCoursePresetEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                //执行数据库操作
                m_sqlCmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }
        }

        /// <summary>
        /// 修改
        /// RH_CoursePreset : RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_CoursePreset");
                strBuilder.Append("  set ");
                strBuilder.Append("    Name=@Name,");
                strBuilder.Append("    CPDesc=@CPDesc,");
                strBuilder.Append("    IfPromote=@IfPromote,");
                strBuilder.Append("    IsRequired=@IsRequired,");
                strBuilder.Append("    CourseLevel=@CourseLevel,");
                strBuilder.Append("    Dimension=@Dimension,");
                strBuilder.Append("    Version=@Version,");
                strBuilder.Append("    parentID=@parentID,");
                strBuilder.Append("    Status=@Status,");
                strBuilder.Append("    CreateBy=@CreateBy,");
                strBuilder.Append("    CreateTime=@CreateTime,");
                strBuilder.Append("    UpdateBy=@UpdateBy,");
                strBuilder.Append("    UpdateTime=@UpdateTime");
                strBuilder.Append("  where ");
                strBuilder.Append("    ID=@ID");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCoursePresetEntity.ID);

                ///Name : nvarchar(50) Name
                if (paramCoursePresetEntity.Name != null && "".Equals(paramCoursePresetEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramCoursePresetEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///CPDesc : nvarchar(200) CPDesc
                if (paramCoursePresetEntity.CPDesc != null && "".Equals(paramCoursePresetEntity.CPDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPDesc", paramCoursePresetEntity.CPDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPDesc", DBNull.Value);
                }

                ///是否提升 1-是 0-否 : int IfPromote
                m_sqlCmd.Parameters.AddWithValue("@IfPromote",paramCoursePresetEntity.IfPromote);

                ///是否必修 1.是 2否 : int IsRequired
                m_sqlCmd.Parameters.AddWithValue("@IsRequired",paramCoursePresetEntity.IsRequired);

                ///能力提升课程等级 1.初级 2.中级 3，高级 : int CourseLevel
                m_sqlCmd.Parameters.AddWithValue("@CourseLevel",paramCoursePresetEntity.CourseLevel);

                ///能力提升课程维度 : int Dimension
                m_sqlCmd.Parameters.AddWithValue("@Dimension",paramCoursePresetEntity.Dimension);

                ///版本号 : int Version
                m_sqlCmd.Parameters.AddWithValue("@Version",paramCoursePresetEntity.Version);

                ///父套餐id，用于套餐复制 : int parentID
                m_sqlCmd.Parameters.AddWithValue("@parentID",paramCoursePresetEntity.parentID);

                ///状态：1-未发布 2-已发布 3 已删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramCoursePresetEntity.Status);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramCoursePresetEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramCoursePresetEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramCoursePresetEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramCoursePresetEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramCoursePresetEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramCoursePresetEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                //执行数据库操作
                m_sqlCmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }
        }

        /// <summary>
        /// 删除
        /// RH_CoursePreset : RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_CoursePreset");
                strBuilder.Append(" where ");
                strBuilder.Append("    ID=@ID");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCoursePresetEntity.ID);

                //执行数据库操作
                m_sqlCmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }
        }

        /// <summary>
        /// 查看
        /// RH_CoursePreset : RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="CoursePresetEntity"></returns>
        public CoursePresetEntity SelectByPK(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            CoursePresetEntity coursePresetEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   CPDesc AS CPDesc,");
                strBuilder.Append("   IfPromote AS IfPromote,");
                strBuilder.Append("   IsRequired AS IsRequired,");
                strBuilder.Append("   CourseLevel AS CourseLevel,");
                strBuilder.Append("   Dimension AS Dimension,");
                strBuilder.Append("   Version AS Version,");
                strBuilder.Append("   parentID AS parentID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_CoursePreset");
                strBuilder.Append("   where 1=1 ");
                strBuilder.Append("   AND ID=@ID ");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCoursePresetEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        coursePresetEntity = ParseDataRowToEntity(dataRows[0]);
                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }

            return coursePresetEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_CoursePreset : RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllCoursePresetByForeignKeys(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable coursePresetEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   CPDesc AS CPDesc,");
                strBuilder.Append("   IfPromote AS IfPromote,");
                strBuilder.Append("   IsRequired AS IsRequired,");
                strBuilder.Append("   CourseLevel AS CourseLevel,");
                strBuilder.Append("   Dimension AS Dimension,");
                strBuilder.Append("   Version AS Version,");
                strBuilder.Append("   parentID AS parentID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_CoursePreset");
                strBuilder.Append(" where 1=1 ");

                //---设置查询条件

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                //执行数据库操作
                SqlDataAdapter dat = new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }

            return objDataTable;
        }

        /// <summary>
        /// 实体映射
        /// </summary>
        /// <param name="dataRow" type="DataRow"></param>
        /// <returns type="CoursePresetEntity"></returns>
        private CoursePresetEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return CoursePresetMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}