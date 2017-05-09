using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_DesignBusiness ( RH_DesignBusiness ) Dao类
    ///</summary>
    public class DesignBusinessDao
    {

        /// <summary>
        /// 添加
        /// RH_DesignBusiness : RH_DesignBusiness
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignBusinessEntity" type="DesignBusinessEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, DesignBusinessEntity paramDesignBusinessEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_DesignBusiness");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    DesignID,");
                strBuilder.Append("    UserID,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @DesignID,");
                strBuilder.Append("    @UserID,");
                strBuilder.Append("    @CreateBy,");
                strBuilder.Append("    @CreateTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignBusinessEntity.ID);

                ///DesignID : int DesignID
                m_sqlCmd.Parameters.AddWithValue("@DesignID",paramDesignBusinessEntity.DesignID);

                ///UserID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramDesignBusinessEntity.UserID);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignBusinessEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignBusinessEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignBusinessEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
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
        /// RH_DesignBusiness : RH_DesignBusiness
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignBusinessEntity" type="DesignBusinessEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, DesignBusinessEntity paramDesignBusinessEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_DesignBusiness");
                strBuilder.Append("  set ");
                strBuilder.Append("    DesignID=@DesignID,");
                strBuilder.Append("    UserID=@UserID,");
                strBuilder.Append("    CreateBy=@CreateBy,");
                strBuilder.Append("    CreateTime=@CreateTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignBusinessEntity.ID);

                ///DesignID : int DesignID
                m_sqlCmd.Parameters.AddWithValue("@DesignID",paramDesignBusinessEntity.DesignID);

                ///UserID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramDesignBusinessEntity.UserID);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignBusinessEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignBusinessEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignBusinessEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
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
        /// RH_DesignBusiness : RH_DesignBusiness
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignBusinessEntity" type="DesignBusinessEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, DesignBusinessEntity paramDesignBusinessEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_DesignBusiness");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignBusinessEntity.ID);

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
        /// RH_DesignBusiness : RH_DesignBusiness
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignBusinessEntity" type="DesignBusinessEntity"></param>
        /// <returns type="DesignBusinessEntity"></returns>
        public DesignBusinessEntity SelectByPK(Object paramConnectionEntity, DesignBusinessEntity paramDesignBusinessEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DesignBusinessEntity designBusinessEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignID AS DesignID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_DesignBusiness");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignBusinessEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        designBusinessEntity = ParseDataRowToEntity(dataRows[0]);
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

            return designBusinessEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_DesignBusiness : RH_DesignBusiness
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignBusinessEntity" type="DesignBusinessEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllDesignBusinessByForeignKeys(Object paramConnectionEntity, DesignBusinessEntity paramDesignBusinessEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable designBusinessEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignID AS DesignID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_DesignBusiness");
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
        /// <returns type="DesignBusinessEntity"></returns>
        private DesignBusinessEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return DesignBusinessMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}