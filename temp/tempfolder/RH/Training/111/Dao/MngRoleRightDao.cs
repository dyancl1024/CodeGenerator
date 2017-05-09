using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_MngRoleRight ( RH_MngRoleRight ) Dao类
    ///</summary>
    public class MngRoleRightDao
    {

        /// <summary>
        /// 添加
        /// RH_MngRoleRight : RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_MngRoleRight");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    RoleCode,");
                strBuilder.Append("    MenuCode,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @RoleCode,");
                strBuilder.Append("    @MenuCode,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngRoleRightEntity.ID);

                ///RoleCode : varchar(50) RoleCode
                if (paramMngRoleRightEntity.RoleCode != null && "".Equals(paramMngRoleRightEntity.RoleCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleCode", paramMngRoleRightEntity.RoleCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleCode", DBNull.Value);
                }

                ///菜单code  对应RH_MngMenu : varchar(50) MenuCode
                if (paramMngRoleRightEntity.MenuCode != null && "".Equals(paramMngRoleRightEntity.MenuCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuCode", paramMngRoleRightEntity.MenuCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuCode", DBNull.Value);
                }

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramMngRoleRightEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramMngRoleRightEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramMngRoleRightEntity.CreateTime);
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
        /// RH_MngRoleRight : RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_MngRoleRight");
                strBuilder.Append("  set ");
                strBuilder.Append("    RoleCode=@RoleCode,");
                strBuilder.Append("    MenuCode=@MenuCode,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngRoleRightEntity.ID);

                ///RoleCode : varchar(50) RoleCode
                if (paramMngRoleRightEntity.RoleCode != null && "".Equals(paramMngRoleRightEntity.RoleCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleCode", paramMngRoleRightEntity.RoleCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleCode", DBNull.Value);
                }

                ///菜单code  对应RH_MngMenu : varchar(50) MenuCode
                if (paramMngRoleRightEntity.MenuCode != null && "".Equals(paramMngRoleRightEntity.MenuCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuCode", paramMngRoleRightEntity.MenuCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuCode", DBNull.Value);
                }

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramMngRoleRightEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramMngRoleRightEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramMngRoleRightEntity.CreateTime);
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
        /// RH_MngRoleRight : RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_MngRoleRight");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngRoleRightEntity.ID);

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
        /// RH_MngRoleRight : RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="MngRoleRightEntity"></returns>
        public MngRoleRightEntity SelectByPK(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            MngRoleRightEntity mngRoleRightEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   RoleCode AS RoleCode,");
                strBuilder.Append("   MenuCode AS MenuCode,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_MngRoleRight");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngRoleRightEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        mngRoleRightEntity = ParseDataRowToEntity(dataRows[0]);
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

            return mngRoleRightEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_MngRoleRight : RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllMngRoleRightByForeignKeys(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable mngRoleRightEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   RoleCode AS RoleCode,");
                strBuilder.Append("   MenuCode AS MenuCode,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_MngRoleRight");
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
        /// <returns type="MngRoleRightEntity"></returns>
        private MngRoleRightEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return MngRoleRightMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}