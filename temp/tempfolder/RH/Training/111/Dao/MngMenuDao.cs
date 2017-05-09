using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_MngMenu ( RH_MngMenu ) Dao类
    ///</summary>
    public class MngMenuDao
    {

        /// <summary>
        /// 添加
        /// RH_MngMenu : RH_MngMenu
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngMenuEntity" type="MngMenuEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, MngMenuEntity paramMngMenuEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_MngMenu");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    MenuName,");
                strBuilder.Append("    MenuUrl,");
                strBuilder.Append("    MenuCode,");
                strBuilder.Append("    MenuLevel,");
                strBuilder.Append("    MenuSort,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    ParentID");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @MenuName,");
                strBuilder.Append("    @MenuUrl,");
                strBuilder.Append("    @MenuCode,");
                strBuilder.Append("    @MenuLevel,");
                strBuilder.Append("    @MenuSort,");
                strBuilder.Append("    @Status,");
                strBuilder.Append("    @ParentID");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngMenuEntity.ID);

                ///菜单名字 : nvarchar(50) MenuName
                if (paramMngMenuEntity.MenuName != null && "".Equals(paramMngMenuEntity.MenuName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuName", paramMngMenuEntity.MenuName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuName", DBNull.Value);
                }

                ///菜单路径 : nvarchar(200) MenuUrl
                if (paramMngMenuEntity.MenuUrl != null && "".Equals(paramMngMenuEntity.MenuUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuUrl", paramMngMenuEntity.MenuUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuUrl", DBNull.Value);
                }

                ///MenuCode : varchar(50) MenuCode
                if (paramMngMenuEntity.MenuCode != null && "".Equals(paramMngMenuEntity.MenuCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuCode", paramMngMenuEntity.MenuCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuCode", DBNull.Value);
                }

                ///菜单级别 : int MenuLevel
                m_sqlCmd.Parameters.AddWithValue("@MenuLevel",paramMngMenuEntity.MenuLevel);

                ///菜单排序 : int MenuSort
                m_sqlCmd.Parameters.AddWithValue("@MenuSort",paramMngMenuEntity.MenuSort);

                ///状态：1.正常2.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramMngMenuEntity.Status);

                ///父级菜单id : int ParentID
                m_sqlCmd.Parameters.AddWithValue("@ParentID",paramMngMenuEntity.ParentID);

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
        /// RH_MngMenu : RH_MngMenu
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngMenuEntity" type="MngMenuEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, MngMenuEntity paramMngMenuEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_MngMenu");
                strBuilder.Append("  set ");
                strBuilder.Append("    MenuName=@MenuName,");
                strBuilder.Append("    MenuUrl=@MenuUrl,");
                strBuilder.Append("    MenuCode=@MenuCode,");
                strBuilder.Append("    MenuLevel=@MenuLevel,");
                strBuilder.Append("    MenuSort=@MenuSort,");
                strBuilder.Append("    Status=@Status,");
                strBuilder.Append("    ParentID=@ParentID");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngMenuEntity.ID);

                ///菜单名字 : nvarchar(50) MenuName
                if (paramMngMenuEntity.MenuName != null && "".Equals(paramMngMenuEntity.MenuName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuName", paramMngMenuEntity.MenuName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuName", DBNull.Value);
                }

                ///菜单路径 : nvarchar(200) MenuUrl
                if (paramMngMenuEntity.MenuUrl != null && "".Equals(paramMngMenuEntity.MenuUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuUrl", paramMngMenuEntity.MenuUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuUrl", DBNull.Value);
                }

                ///MenuCode : varchar(50) MenuCode
                if (paramMngMenuEntity.MenuCode != null && "".Equals(paramMngMenuEntity.MenuCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuCode", paramMngMenuEntity.MenuCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@MenuCode", DBNull.Value);
                }

                ///菜单级别 : int MenuLevel
                m_sqlCmd.Parameters.AddWithValue("@MenuLevel",paramMngMenuEntity.MenuLevel);

                ///菜单排序 : int MenuSort
                m_sqlCmd.Parameters.AddWithValue("@MenuSort",paramMngMenuEntity.MenuSort);

                ///状态：1.正常2.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramMngMenuEntity.Status);

                ///父级菜单id : int ParentID
                m_sqlCmd.Parameters.AddWithValue("@ParentID",paramMngMenuEntity.ParentID);

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
        /// RH_MngMenu : RH_MngMenu
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngMenuEntity" type="MngMenuEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, MngMenuEntity paramMngMenuEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_MngMenu");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngMenuEntity.ID);

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
        /// RH_MngMenu : RH_MngMenu
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngMenuEntity" type="MngMenuEntity"></param>
        /// <returns type="MngMenuEntity"></returns>
        public MngMenuEntity SelectByPK(Object paramConnectionEntity, MngMenuEntity paramMngMenuEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            MngMenuEntity mngMenuEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   MenuName AS MenuName,");
                strBuilder.Append("   MenuUrl AS MenuUrl,");
                strBuilder.Append("   MenuCode AS MenuCode,");
                strBuilder.Append("   MenuLevel AS MenuLevel,");
                strBuilder.Append("   MenuSort AS MenuSort,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   ParentID AS ParentID");
                strBuilder.Append(" from RH_MngMenu");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramMngMenuEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        mngMenuEntity = ParseDataRowToEntity(dataRows[0]);
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

            return mngMenuEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_MngMenu : RH_MngMenu
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngMenuEntity" type="MngMenuEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllMngMenuByForeignKeys(Object paramConnectionEntity, MngMenuEntity paramMngMenuEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable mngMenuEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   MenuName AS MenuName,");
                strBuilder.Append("   MenuUrl AS MenuUrl,");
                strBuilder.Append("   MenuCode AS MenuCode,");
                strBuilder.Append("   MenuLevel AS MenuLevel,");
                strBuilder.Append("   MenuSort AS MenuSort,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   ParentID AS ParentID");
                strBuilder.Append(" from RH_MngMenu");
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
        /// <returns type="MngMenuEntity"></returns>
        private MngMenuEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return MngMenuMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}