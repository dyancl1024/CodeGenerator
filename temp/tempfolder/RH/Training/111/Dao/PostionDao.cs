using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Postion ( RH_Postion ) Dao类
    ///</summary>
    public class PostionDao
    {

        /// <summary>
        /// 添加
        /// RH_Postion : RH_Postion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramPostionEntity" type="PostionEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, PostionEntity paramPostionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Postion");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    Name,");
                strBuilder.Append("    Code,");
                strBuilder.Append("    Sort");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @Name,");
                strBuilder.Append("    @Code,");
                strBuilder.Append("    @Sort");
                strBuilder.Append("  )");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramPostionEntity.ID);

                ///职位名称 : nvarchar(50) Name
                if (paramPostionEntity.Name != null && "".Equals(paramPostionEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramPostionEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///编号 : varchar(50) Code
                if (paramPostionEntity.Code != null && "".Equals(paramPostionEntity.Code.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", paramPostionEntity.Code);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", DBNull.Value);
                }

                ///顺序 : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramPostionEntity.Sort);

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
        /// RH_Postion : RH_Postion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramPostionEntity" type="PostionEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, PostionEntity paramPostionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Postion");
                strBuilder.Append("  set ");
                strBuilder.Append("    Name=@Name,");
                strBuilder.Append("    Code=@Code,");
                strBuilder.Append("    Sort=@Sort");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramPostionEntity.ID);

                ///职位名称 : nvarchar(50) Name
                if (paramPostionEntity.Name != null && "".Equals(paramPostionEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramPostionEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///编号 : varchar(50) Code
                if (paramPostionEntity.Code != null && "".Equals(paramPostionEntity.Code.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", paramPostionEntity.Code);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", DBNull.Value);
                }

                ///顺序 : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramPostionEntity.Sort);

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
        /// RH_Postion : RH_Postion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramPostionEntity" type="PostionEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, PostionEntity paramPostionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Postion");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramPostionEntity.ID);

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
        /// RH_Postion : RH_Postion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramPostionEntity" type="PostionEntity"></param>
        /// <returns type="PostionEntity"></returns>
        public PostionEntity SelectByPK(Object paramConnectionEntity, PostionEntity paramPostionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            PostionEntity postionEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   Code AS Code,");
                strBuilder.Append("   Sort AS Sort");
                strBuilder.Append(" from RH_Postion");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramPostionEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        postionEntity = ParseDataRowToEntity(dataRows[0]);
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

            return postionEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Postion : RH_Postion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramPostionEntity" type="PostionEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllPostionByForeignKeys(Object paramConnectionEntity, PostionEntity paramPostionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable postionEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   Code AS Code,");
                strBuilder.Append("   Sort AS Sort");
                strBuilder.Append(" from RH_Postion");
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
        /// <returns type="PostionEntity"></returns>
        private PostionEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return PostionMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}