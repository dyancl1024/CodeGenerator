using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Subject ( RH_Subject ) Dao类
    ///</summary>
    public class SubjectDao
    {

        /// <summary>
        /// 添加
        /// RH_Subject : RH_Subject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSubjectEntity" type="SubjectEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, SubjectEntity paramSubjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Subject");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    SubjectName,");
                strBuilder.Append("    SubCode,");
                strBuilder.Append("    SubjectSort");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @SubjectName,");
                strBuilder.Append("    @SubCode,");
                strBuilder.Append("    @SubjectSort");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramSubjectEntity.ID);

                ///SubjectName : nvarchar(50) SubjectName
                if (paramSubjectEntity.SubjectName != null && "".Equals(paramSubjectEntity.SubjectName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectName", paramSubjectEntity.SubjectName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectName", DBNull.Value);
                }

                ///SubCode : varchar(50) SubCode
                if (paramSubjectEntity.SubCode != null && "".Equals(paramSubjectEntity.SubCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubCode", paramSubjectEntity.SubCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubCode", DBNull.Value);
                }

                ///SubjectSort : nvarchar(50) SubjectSort
                if (paramSubjectEntity.SubjectSort != null && "".Equals(paramSubjectEntity.SubjectSort.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectSort", paramSubjectEntity.SubjectSort);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectSort", DBNull.Value);
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
        /// RH_Subject : RH_Subject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSubjectEntity" type="SubjectEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, SubjectEntity paramSubjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Subject");
                strBuilder.Append("  set ");
                strBuilder.Append("    SubjectName=@SubjectName,");
                strBuilder.Append("    SubCode=@SubCode,");
                strBuilder.Append("    SubjectSort=@SubjectSort");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramSubjectEntity.ID);

                ///SubjectName : nvarchar(50) SubjectName
                if (paramSubjectEntity.SubjectName != null && "".Equals(paramSubjectEntity.SubjectName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectName", paramSubjectEntity.SubjectName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectName", DBNull.Value);
                }

                ///SubCode : varchar(50) SubCode
                if (paramSubjectEntity.SubCode != null && "".Equals(paramSubjectEntity.SubCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubCode", paramSubjectEntity.SubCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubCode", DBNull.Value);
                }

                ///SubjectSort : nvarchar(50) SubjectSort
                if (paramSubjectEntity.SubjectSort != null && "".Equals(paramSubjectEntity.SubjectSort.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectSort", paramSubjectEntity.SubjectSort);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectSort", DBNull.Value);
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
        /// RH_Subject : RH_Subject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSubjectEntity" type="SubjectEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, SubjectEntity paramSubjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Subject");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramSubjectEntity.ID);

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
        /// RH_Subject : RH_Subject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSubjectEntity" type="SubjectEntity"></param>
        /// <returns type="SubjectEntity"></returns>
        public SubjectEntity SelectByPK(Object paramConnectionEntity, SubjectEntity paramSubjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            SubjectEntity subjectEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubjectName AS SubjectName,");
                strBuilder.Append("   SubCode AS SubCode,");
                strBuilder.Append("   SubjectSort AS SubjectSort");
                strBuilder.Append(" from RH_Subject");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramSubjectEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        subjectEntity = ParseDataRowToEntity(dataRows[0]);
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

            return subjectEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Subject : RH_Subject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSubjectEntity" type="SubjectEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllSubjectByForeignKeys(Object paramConnectionEntity, SubjectEntity paramSubjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable subjectEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubjectName AS SubjectName,");
                strBuilder.Append("   SubCode AS SubCode,");
                strBuilder.Append("   SubjectSort AS SubjectSort");
                strBuilder.Append(" from RH_Subject");
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
        /// <returns type="SubjectEntity"></returns>
        private SubjectEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return SubjectMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}