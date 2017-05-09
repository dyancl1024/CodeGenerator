using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_UserInfo ( RH_UserInfo ) Dao类
    ///</summary>
    public class UserInfoDao
    {

        /// <summary>
        /// 添加
        /// RH_UserInfo : RH_UserInfo
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserInfoEntity" type="UserInfoEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, UserInfoEntity paramUserInfoEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_UserInfo");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    UserID,");
                strBuilder.Append("    SchoolID,");
                strBuilder.Append("    CUserName,");
                strBuilder.Append("    CPassword,");
                strBuilder.Append("    CSource");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @UserID,");
                strBuilder.Append("    @SchoolID,");
                strBuilder.Append("    @CUserName,");
                strBuilder.Append("    @CPassword,");
                strBuilder.Append("    @CSource");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramUserInfoEntity.ID);

                ///人id : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramUserInfoEntity.UserID);

                ///学校ID : int SchoolID
                m_sqlCmd.Parameters.AddWithValue("@SchoolID",paramUserInfoEntity.SchoolID);

                ///接口用户名 : nvarchar(50) CUserName
                if (paramUserInfoEntity.CUserName != null && "".Equals(paramUserInfoEntity.CUserName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CUserName", paramUserInfoEntity.CUserName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CUserName", DBNull.Value);
                }

                ///CPassword : nvarchar(50) CPassword
                if (paramUserInfoEntity.CPassword != null && "".Equals(paramUserInfoEntity.CPassword.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPassword", paramUserInfoEntity.CPassword);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPassword", DBNull.Value);
                }

                ///CSource : int CSource
                m_sqlCmd.Parameters.AddWithValue("@CSource",paramUserInfoEntity.CSource);

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
        /// RH_UserInfo : RH_UserInfo
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserInfoEntity" type="UserInfoEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, UserInfoEntity paramUserInfoEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_UserInfo");
                strBuilder.Append("  set ");
                strBuilder.Append("    UserID=@UserID,");
                strBuilder.Append("    SchoolID=@SchoolID,");
                strBuilder.Append("    CUserName=@CUserName,");
                strBuilder.Append("    CPassword=@CPassword,");
                strBuilder.Append("    CSource=@CSource");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramUserInfoEntity.ID);

                ///人id : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramUserInfoEntity.UserID);

                ///学校ID : int SchoolID
                m_sqlCmd.Parameters.AddWithValue("@SchoolID",paramUserInfoEntity.SchoolID);

                ///接口用户名 : nvarchar(50) CUserName
                if (paramUserInfoEntity.CUserName != null && "".Equals(paramUserInfoEntity.CUserName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CUserName", paramUserInfoEntity.CUserName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CUserName", DBNull.Value);
                }

                ///CPassword : nvarchar(50) CPassword
                if (paramUserInfoEntity.CPassword != null && "".Equals(paramUserInfoEntity.CPassword.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPassword", paramUserInfoEntity.CPassword);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPassword", DBNull.Value);
                }

                ///CSource : int CSource
                m_sqlCmd.Parameters.AddWithValue("@CSource",paramUserInfoEntity.CSource);

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
        /// RH_UserInfo : RH_UserInfo
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserInfoEntity" type="UserInfoEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, UserInfoEntity paramUserInfoEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_UserInfo");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramUserInfoEntity.ID);

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
        /// RH_UserInfo : RH_UserInfo
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserInfoEntity" type="UserInfoEntity"></param>
        /// <returns type="UserInfoEntity"></returns>
        public UserInfoEntity SelectByPK(Object paramConnectionEntity, UserInfoEntity paramUserInfoEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            UserInfoEntity userInfoEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   SchoolID AS SchoolID,");
                strBuilder.Append("   CUserName AS CUserName,");
                strBuilder.Append("   CPassword AS CPassword,");
                strBuilder.Append("   CSource AS CSource");
                strBuilder.Append(" from RH_UserInfo");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramUserInfoEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        userInfoEntity = ParseDataRowToEntity(dataRows[0]);
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

            return userInfoEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_UserInfo : RH_UserInfo
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserInfoEntity" type="UserInfoEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllUserInfoByForeignKeys(Object paramConnectionEntity, UserInfoEntity paramUserInfoEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable userInfoEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   SchoolID AS SchoolID,");
                strBuilder.Append("   CUserName AS CUserName,");
                strBuilder.Append("   CPassword AS CPassword,");
                strBuilder.Append("   CSource AS CSource");
                strBuilder.Append(" from RH_UserInfo");
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
        /// <returns type="UserInfoEntity"></returns>
        private UserInfoEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return UserInfoMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}