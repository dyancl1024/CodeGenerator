using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_DesignSuggest ( RH_DesignSuggest ) Dao类
    ///</summary>
    public class DesignSuggestDao
    {

        /// <summary>
        /// 添加
        /// RH_DesignSuggest : RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_DesignSuggest");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    DesignID,");
                strBuilder.Append("    DSuggest,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @DesignID,");
                strBuilder.Append("    @DSuggest,");
                strBuilder.Append("    @Status,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignSuggestEntity.ID);

                ///DesignID : int DesignID
                m_sqlCmd.Parameters.AddWithValue("@DesignID",paramDesignSuggestEntity.DesignID);

                ///DSuggest : nvarchar(200) DSuggest
                if (paramDesignSuggestEntity.DSuggest != null && "".Equals(paramDesignSuggestEntity.DSuggest.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DSuggest", paramDesignSuggestEntity.DSuggest);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DSuggest", DBNull.Value);
                }

                ///1.待审批（对应的动作提交审批） 2.审批中（对应的动作通过、不通过，） 3.已审批（对应的动作立项、不立项） 4.立项（对应的动作分配教务） 5.不立项（对应的动作分配教务） : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramDesignSuggestEntity.Status);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignSuggestEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignSuggestEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignSuggestEntity.CreateTime);
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
        /// RH_DesignSuggest : RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_DesignSuggest");
                strBuilder.Append("  set ");
                strBuilder.Append("    DesignID=@DesignID,");
                strBuilder.Append("    DSuggest=@DSuggest,");
                strBuilder.Append("    Status=@Status,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignSuggestEntity.ID);

                ///DesignID : int DesignID
                m_sqlCmd.Parameters.AddWithValue("@DesignID",paramDesignSuggestEntity.DesignID);

                ///DSuggest : nvarchar(200) DSuggest
                if (paramDesignSuggestEntity.DSuggest != null && "".Equals(paramDesignSuggestEntity.DSuggest.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DSuggest", paramDesignSuggestEntity.DSuggest);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DSuggest", DBNull.Value);
                }

                ///1.待审批（对应的动作提交审批） 2.审批中（对应的动作通过、不通过，） 3.已审批（对应的动作立项、不立项） 4.立项（对应的动作分配教务） 5.不立项（对应的动作分配教务） : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramDesignSuggestEntity.Status);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignSuggestEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignSuggestEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignSuggestEntity.CreateTime);
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
        /// RH_DesignSuggest : RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_DesignSuggest");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignSuggestEntity.ID);

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
        /// RH_DesignSuggest : RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="DesignSuggestEntity"></returns>
        public DesignSuggestEntity SelectByPK(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DesignSuggestEntity designSuggestEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignID AS DesignID,");
                strBuilder.Append("   DSuggest AS DSuggest,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_DesignSuggest");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignSuggestEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        designSuggestEntity = ParseDataRowToEntity(dataRows[0]);
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

            return designSuggestEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_DesignSuggest : RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllDesignSuggestByForeignKeys(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable designSuggestEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignID AS DesignID,");
                strBuilder.Append("   DSuggest AS DSuggest,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_DesignSuggest");
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
        /// <returns type="DesignSuggestEntity"></returns>
        private DesignSuggestEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return DesignSuggestMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}