using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Grade ( RH_Grade ) Dao类
    ///</summary>
    public class GradeDao
    {

        /// <summary>
        /// 添加
        /// RH_Grade : RH_Grade
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeEntity" type="GradeEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, GradeEntity paramGradeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Grade");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    Name,");
                strBuilder.Append("    Code,");
                strBuilder.Append("    Sort,");
                strBuilder.Append("    ParentID");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @Name,");
                strBuilder.Append("    @Code,");
                strBuilder.Append("    @Sort,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramGradeEntity.ID);

                ///Name : nvarchar(50) Name
                if (paramGradeEntity.Name != null && "".Equals(paramGradeEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramGradeEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///Code : varchar(50) Code
                if (paramGradeEntity.Code != null && "".Equals(paramGradeEntity.Code.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", paramGradeEntity.Code);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", DBNull.Value);
                }

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramGradeEntity.Sort);

                ///0：大学段（如：小学） ，&lt;&gt;0:小学段（如小学1-6年级） : int ParentID
                m_sqlCmd.Parameters.AddWithValue("@ParentID",paramGradeEntity.ParentID);

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
        /// RH_Grade : RH_Grade
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeEntity" type="GradeEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, GradeEntity paramGradeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Grade");
                strBuilder.Append("  set ");
                strBuilder.Append("    Name=@Name,");
                strBuilder.Append("    Code=@Code,");
                strBuilder.Append("    Sort=@Sort,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramGradeEntity.ID);

                ///Name : nvarchar(50) Name
                if (paramGradeEntity.Name != null && "".Equals(paramGradeEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramGradeEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///Code : varchar(50) Code
                if (paramGradeEntity.Code != null && "".Equals(paramGradeEntity.Code.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", paramGradeEntity.Code);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", DBNull.Value);
                }

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramGradeEntity.Sort);

                ///0：大学段（如：小学） ，&lt;&gt;0:小学段（如小学1-6年级） : int ParentID
                m_sqlCmd.Parameters.AddWithValue("@ParentID",paramGradeEntity.ParentID);

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
        /// RH_Grade : RH_Grade
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeEntity" type="GradeEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, GradeEntity paramGradeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Grade");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramGradeEntity.ID);

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
        /// RH_Grade : RH_Grade
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeEntity" type="GradeEntity"></param>
        /// <returns type="GradeEntity"></returns>
        public GradeEntity SelectByPK(Object paramConnectionEntity, GradeEntity paramGradeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            GradeEntity gradeEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   Code AS Code,");
                strBuilder.Append("   Sort AS Sort,");
                strBuilder.Append("   ParentID AS ParentID");
                strBuilder.Append(" from RH_Grade");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramGradeEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        gradeEntity = ParseDataRowToEntity(dataRows[0]);
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

            return gradeEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Grade : RH_Grade
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeEntity" type="GradeEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllGradeByForeignKeys(Object paramConnectionEntity, GradeEntity paramGradeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable gradeEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   Code AS Code,");
                strBuilder.Append("   Sort AS Sort,");
                strBuilder.Append("   ParentID AS ParentID");
                strBuilder.Append(" from RH_Grade");
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
        /// <returns type="GradeEntity"></returns>
        private GradeEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return GradeMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}