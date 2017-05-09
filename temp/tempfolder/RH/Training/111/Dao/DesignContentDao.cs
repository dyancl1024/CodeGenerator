using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_DesignContent ( RH_DesignContent ) Dao类
    ///</summary>
    public class DesignContentDao
    {

        /// <summary>
        /// 添加
        /// RH_DesignContent : RH_DesignContent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentEntity" type="DesignContentEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, DesignContentEntity paramDesignContentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_DesignContent");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    DesignID,");
                strBuilder.Append("    DType,");
                strBuilder.Append("    DName,");
                strBuilder.Append("    DContent,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @DesignID,");
                strBuilder.Append("    @DType,");
                strBuilder.Append("    @DName,");
                strBuilder.Append("    @DContent,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignContentEntity.ID);

                ///DesignID : int DesignID
                m_sqlCmd.Parameters.AddWithValue("@DesignID",paramDesignContentEntity.DesignID);

                ///1.需求分析 2.目标定位 3.内容设计 4.培训阶段 5.培训方式 6.考核评价 7.管理服务 8.培训课程 9.项目标书 : int DType
                m_sqlCmd.Parameters.AddWithValue("@DType",paramDesignContentEntity.DType);

                ///1.需求分析 2.目标定位 3.内容设计 4.培训阶段 5.培训方式 6.考核评价 7.管理服务 8.培训课程 9.项目标书 : nvarchar(50) DName
                if (paramDesignContentEntity.DName != null && "".Equals(paramDesignContentEntity.DName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DName", paramDesignContentEntity.DName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DName", DBNull.Value);
                }

                ///DContent : nvarchar(Max) DContent
                if (paramDesignContentEntity.DContent != null && "".Equals(paramDesignContentEntity.DContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DContent", paramDesignContentEntity.DContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DContent", DBNull.Value);
                }

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignContentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignContentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignContentEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramDesignContentEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramDesignContentEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramDesignContentEntity.UpdateTime);
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
        /// RH_DesignContent : RH_DesignContent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentEntity" type="DesignContentEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, DesignContentEntity paramDesignContentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_DesignContent");
                strBuilder.Append("  set ");
                strBuilder.Append("    DesignID=@DesignID,");
                strBuilder.Append("    DType=@DType,");
                strBuilder.Append("    DName=@DName,");
                strBuilder.Append("    DContent=@DContent,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignContentEntity.ID);

                ///DesignID : int DesignID
                m_sqlCmd.Parameters.AddWithValue("@DesignID",paramDesignContentEntity.DesignID);

                ///1.需求分析 2.目标定位 3.内容设计 4.培训阶段 5.培训方式 6.考核评价 7.管理服务 8.培训课程 9.项目标书 : int DType
                m_sqlCmd.Parameters.AddWithValue("@DType",paramDesignContentEntity.DType);

                ///1.需求分析 2.目标定位 3.内容设计 4.培训阶段 5.培训方式 6.考核评价 7.管理服务 8.培训课程 9.项目标书 : nvarchar(50) DName
                if (paramDesignContentEntity.DName != null && "".Equals(paramDesignContentEntity.DName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DName", paramDesignContentEntity.DName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DName", DBNull.Value);
                }

                ///DContent : nvarchar(Max) DContent
                if (paramDesignContentEntity.DContent != null && "".Equals(paramDesignContentEntity.DContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DContent", paramDesignContentEntity.DContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DContent", DBNull.Value);
                }

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignContentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignContentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignContentEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramDesignContentEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramDesignContentEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramDesignContentEntity.UpdateTime);
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
        /// RH_DesignContent : RH_DesignContent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentEntity" type="DesignContentEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, DesignContentEntity paramDesignContentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_DesignContent");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignContentEntity.ID);

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
        /// RH_DesignContent : RH_DesignContent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentEntity" type="DesignContentEntity"></param>
        /// <returns type="DesignContentEntity"></returns>
        public DesignContentEntity SelectByPK(Object paramConnectionEntity, DesignContentEntity paramDesignContentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DesignContentEntity designContentEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignID AS DesignID,");
                strBuilder.Append("   DType AS DType,");
                strBuilder.Append("   DName AS DName,");
                strBuilder.Append("   DContent AS DContent,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_DesignContent");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignContentEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        designContentEntity = ParseDataRowToEntity(dataRows[0]);
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

            return designContentEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_DesignContent : RH_DesignContent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentEntity" type="DesignContentEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllDesignContentByForeignKeys(Object paramConnectionEntity, DesignContentEntity paramDesignContentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable designContentEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignID AS DesignID,");
                strBuilder.Append("   DType AS DType,");
                strBuilder.Append("   DName AS DName,");
                strBuilder.Append("   DContent AS DContent,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_DesignContent");
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
        /// <returns type="DesignContentEntity"></returns>
        private DesignContentEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return DesignContentMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}