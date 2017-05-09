using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_MngUser ( RH_MngUser ) Dao类
    ///</summary>
    public class MngUserDao
    {

        /// <summary>
        /// 添加
        /// RH_MngUser : RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_MngUser");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    UserName,");
                strBuilder.Append("    Password,");
                strBuilder.Append("    TrueName,");
                strBuilder.Append("    RoleID,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @UserName,");
                strBuilder.Append("    @Password,");
                strBuilder.Append("    @TrueName,");
                strBuilder.Append("    @RoleID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngUserEntity.ID);

                ///用户名 : nvarchar(50) UserName
                if (paramMngUserEntity.UserName != null && "".Equals(paramMngUserEntity.UserName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", paramMngUserEntity.UserName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", DBNull.Value);
                }

                ///Password : nvarchar(50) Password
                if (paramMngUserEntity.Password != null && "".Equals(paramMngUserEntity.Password.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", paramMngUserEntity.Password);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", DBNull.Value);
                }

                ///真实姓名 : nvarchar(50) TrueName
                if (paramMngUserEntity.TrueName != null && "".Equals(paramMngUserEntity.TrueName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", paramMngUserEntity.TrueName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", DBNull.Value);
                }

                ///角色id  角色表 : int RoleID
                m_sqlCmd.Parameters.AddWithValue("@RoleID",paramMngUserEntity.RoleID);

                ///状态：1.正常 2.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramMngUserEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramMngUserEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramMngUserEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramMngUserEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramMngUserEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramMngUserEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramMngUserEntity.UpdateTime);
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
        /// RH_MngUser : RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_MngUser");
                strBuilder.Append("  set ");
                strBuilder.Append("    UserName=@UserName,");
                strBuilder.Append("    Password=@Password,");
                strBuilder.Append("    TrueName=@TrueName,");
                strBuilder.Append("    RoleID=@RoleID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngUserEntity.ID);

                ///用户名 : nvarchar(50) UserName
                if (paramMngUserEntity.UserName != null && "".Equals(paramMngUserEntity.UserName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", paramMngUserEntity.UserName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", DBNull.Value);
                }

                ///Password : nvarchar(50) Password
                if (paramMngUserEntity.Password != null && "".Equals(paramMngUserEntity.Password.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", paramMngUserEntity.Password);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", DBNull.Value);
                }

                ///真实姓名 : nvarchar(50) TrueName
                if (paramMngUserEntity.TrueName != null && "".Equals(paramMngUserEntity.TrueName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", paramMngUserEntity.TrueName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", DBNull.Value);
                }

                ///角色id  角色表 : int RoleID
                m_sqlCmd.Parameters.AddWithValue("@RoleID",paramMngUserEntity.RoleID);

                ///状态：1.正常 2.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramMngUserEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramMngUserEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramMngUserEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramMngUserEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramMngUserEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramMngUserEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramMngUserEntity.UpdateTime);
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
        /// RH_MngUser : RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_MngUser");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngUserEntity.ID);

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
        /// RH_MngUser : RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="MngUserEntity"></returns>
        public MngUserEntity SelectByPK(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            MngUserEntity mngUserEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   UserName AS UserName,");
                strBuilder.Append("   Password AS Password,");
                strBuilder.Append("   TrueName AS TrueName,");
                strBuilder.Append("   RoleID AS RoleID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_MngUser");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngUserEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        mngUserEntity = ParseDataRowToEntity(dataRows[0]);
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

            return mngUserEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_MngUser : RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllMngUserByForeignKeys(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable mngUserEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   UserName AS UserName,");
                strBuilder.Append("   Password AS Password,");
                strBuilder.Append("   TrueName AS TrueName,");
                strBuilder.Append("   RoleID AS RoleID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_MngUser");
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
        /// <returns type="MngUserEntity"></returns>
        private MngUserEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return MngUserMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}