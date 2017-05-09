using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_AssessmentOptions ( RH_AssessmentOptions ) Dao类
    ///</summary>
    public class AssessmentOptionsDao
    {

        /// <summary>
        /// 添加
        /// RH_AssessmentOptions : RH_AssessmentOptions
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentOptionsEntity" type="AssessmentOptionsEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, AssessmentOptionsEntity paramAssessmentOptionsEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_AssessmentOptions");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    QID,");
                strBuilder.Append("    Options,");
                strBuilder.Append("    SortNO,");
                strBuilder.Append("    Score");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @QID,");
                strBuilder.Append("    @Options,");
                strBuilder.Append("    @SortNO,");
                strBuilder.Append("    @Score");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentOptionsEntity.ID);

                ///问题id : int QID
                m_sqlCmd.Parameters.AddWithValue("@QID",paramAssessmentOptionsEntity.QID);

                ///选项 : nvarchar(Max) Options
                if (paramAssessmentOptionsEntity.Options != null && "".Equals(paramAssessmentOptionsEntity.Options.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Options", paramAssessmentOptionsEntity.Options);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Options", DBNull.Value);
                }

                ///排序 : int SortNO
                m_sqlCmd.Parameters.AddWithValue("@SortNO",paramAssessmentOptionsEntity.SortNO);

                ///分值  1.1分 2.2分 3.3分 : int Score
                m_sqlCmd.Parameters.AddWithValue("@Score",paramAssessmentOptionsEntity.Score);

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
        /// RH_AssessmentOptions : RH_AssessmentOptions
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentOptionsEntity" type="AssessmentOptionsEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, AssessmentOptionsEntity paramAssessmentOptionsEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_AssessmentOptions");
                strBuilder.Append("  set ");
                strBuilder.Append("    QID=@QID,");
                strBuilder.Append("    Options=@Options,");
                strBuilder.Append("    SortNO=@SortNO,");
                strBuilder.Append("    Score=@Score");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentOptionsEntity.ID);

                ///问题id : int QID
                m_sqlCmd.Parameters.AddWithValue("@QID",paramAssessmentOptionsEntity.QID);

                ///选项 : nvarchar(Max) Options
                if (paramAssessmentOptionsEntity.Options != null && "".Equals(paramAssessmentOptionsEntity.Options.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Options", paramAssessmentOptionsEntity.Options);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Options", DBNull.Value);
                }

                ///排序 : int SortNO
                m_sqlCmd.Parameters.AddWithValue("@SortNO",paramAssessmentOptionsEntity.SortNO);

                ///分值  1.1分 2.2分 3.3分 : int Score
                m_sqlCmd.Parameters.AddWithValue("@Score",paramAssessmentOptionsEntity.Score);

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
        /// RH_AssessmentOptions : RH_AssessmentOptions
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentOptionsEntity" type="AssessmentOptionsEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, AssessmentOptionsEntity paramAssessmentOptionsEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_AssessmentOptions");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentOptionsEntity.ID);

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
        /// RH_AssessmentOptions : RH_AssessmentOptions
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentOptionsEntity" type="AssessmentOptionsEntity"></param>
        /// <returns type="AssessmentOptionsEntity"></returns>
        public AssessmentOptionsEntity SelectByPK(Object paramConnectionEntity, AssessmentOptionsEntity paramAssessmentOptionsEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            AssessmentOptionsEntity assessmentOptionsEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   QID AS QID,");
                strBuilder.Append("   Options AS Options,");
                strBuilder.Append("   SortNO AS SortNO,");
                strBuilder.Append("   Score AS Score");
                strBuilder.Append(" from RH_AssessmentOptions");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentOptionsEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        assessmentOptionsEntity = ParseDataRowToEntity(dataRows[0]);
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

            return assessmentOptionsEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_AssessmentOptions : RH_AssessmentOptions
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentOptionsEntity" type="AssessmentOptionsEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllAssessmentOptionsByForeignKeys(Object paramConnectionEntity, AssessmentOptionsEntity paramAssessmentOptionsEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable assessmentOptionsEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   QID AS QID,");
                strBuilder.Append("   Options AS Options,");
                strBuilder.Append("   SortNO AS SortNO,");
                strBuilder.Append("   Score AS Score");
                strBuilder.Append(" from RH_AssessmentOptions");
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
        /// <returns type="AssessmentOptionsEntity"></returns>
        private AssessmentOptionsEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return AssessmentOptionsMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}