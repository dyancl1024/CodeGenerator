using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_MngRole ( RH_MngRole ) Dao类
    ///</summary>
    public class MngRoleDao
    {

        /// <summary>
        /// 添加
        /// RH_MngRole : RH_MngRole
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleEntity" type="MngRoleEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, MngRoleEntity paramMngRoleEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_MngRole");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    RoleName,");
                strBuilder.Append("    RoleCode,");
                strBuilder.Append("    SortNum");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @RoleName,");
                strBuilder.Append("    @RoleCode,");
                strBuilder.Append("    @SortNum");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngRoleEntity.ID);

                ///角色名称 : nvarchar(50) RoleName
                if (paramMngRoleEntity.RoleName != null && "".Equals(paramMngRoleEntity.RoleName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleName", paramMngRoleEntity.RoleName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleName", DBNull.Value);
                }

                ///角色代码 : nvarchar(50) RoleCode
                if (paramMngRoleEntity.RoleCode != null && "".Equals(paramMngRoleEntity.RoleCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleCode", paramMngRoleEntity.RoleCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleCode", DBNull.Value);
                }

                ///角色排序 : int SortNum
                m_sqlCmd.Parameters.AddWithValue("@SortNum",paramMngRoleEntity.SortNum);

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
        /// RH_MngRole : RH_MngRole
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleEntity" type="MngRoleEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, MngRoleEntity paramMngRoleEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_MngRole");
                strBuilder.Append("  set ");
                strBuilder.Append("    RoleName=@RoleName,");
                strBuilder.Append("    RoleCode=@RoleCode,");
                strBuilder.Append("    SortNum=@SortNum");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngRoleEntity.ID);

                ///角色名称 : nvarchar(50) RoleName
                if (paramMngRoleEntity.RoleName != null && "".Equals(paramMngRoleEntity.RoleName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleName", paramMngRoleEntity.RoleName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleName", DBNull.Value);
                }

                ///角色代码 : nvarchar(50) RoleCode
                if (paramMngRoleEntity.RoleCode != null && "".Equals(paramMngRoleEntity.RoleCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleCode", paramMngRoleEntity.RoleCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@RoleCode", DBNull.Value);
                }

                ///角色排序 : int SortNum
                m_sqlCmd.Parameters.AddWithValue("@SortNum",paramMngRoleEntity.SortNum);

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
        /// RH_MngRole : RH_MngRole
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleEntity" type="MngRoleEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, MngRoleEntity paramMngRoleEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_MngRole");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngRoleEntity.ID);

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
        /// RH_MngRole : RH_MngRole
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleEntity" type="MngRoleEntity"></param>
        /// <returns type="MngRoleEntity"></returns>
        public MngRoleEntity SelectByPK(Object paramConnectionEntity, MngRoleEntity paramMngRoleEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            MngRoleEntity mngRoleEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   RoleName AS RoleName,");
                strBuilder.Append("   RoleCode AS RoleCode,");
                strBuilder.Append("   SortNum AS SortNum");
                strBuilder.Append(" from RH_MngRole");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngRoleEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        mngRoleEntity = ParseDataRowToEntity(dataRows[0]);
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

            return mngRoleEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_MngRole : RH_MngRole
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleEntity" type="MngRoleEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllMngRoleByForeignKeys(Object paramConnectionEntity, MngRoleEntity paramMngRoleEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable mngRoleEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   RoleName AS RoleName,");
                strBuilder.Append("   RoleCode AS RoleCode,");
                strBuilder.Append("   SortNum AS SortNum");
                strBuilder.Append(" from RH_MngRole");
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
        /// <returns type="MngRoleEntity"></returns>
        private MngRoleEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return MngRoleMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}