using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_AssessmentQuestion ( RH_AssessmentQuestion ) Dao类
    ///</summary>
    public class AssessmentQuestionDao
    {

        /// <summary>
        /// 添加
        /// RH_AssessmentQuestion : RH_AssessmentQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionEntity" type="AssessmentQuestionEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, AssessmentQuestionEntity paramAssessmentQuestionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_AssessmentQuestion");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    AssessmentID,");
                strBuilder.Append("    Question,");
                strBuilder.Append("    QuestionDesc,");
                strBuilder.Append("    TypeID,");
                strBuilder.Append("    Dimensions,");
                strBuilder.Append("    SortNo,");
                strBuilder.Append("    Status");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @AssessmentID,");
                strBuilder.Append("    @Question,");
                strBuilder.Append("    @QuestionDesc,");
                strBuilder.Append("    @TypeID,");
                strBuilder.Append("    @Dimensions,");
                strBuilder.Append("    @SortNo,");
                strBuilder.Append("    @Status");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentQuestionEntity.ID);

                ///测评工具id 对应RH_Assessment表id : int AssessmentID
                m_sqlCmd.Parameters.AddWithValue("@AssessmentID",paramAssessmentQuestionEntity.AssessmentID);

                ///题干 : nvarchar(Max) Question
                if (paramAssessmentQuestionEntity.Question != null && "".Equals(paramAssessmentQuestionEntity.Question.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Question", paramAssessmentQuestionEntity.Question);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Question", DBNull.Value);
                }

                ///题干描述 : nvarchar(Max) QuestionDesc
                if (paramAssessmentQuestionEntity.QuestionDesc != null && "".Equals(paramAssessmentQuestionEntity.QuestionDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QuestionDesc", paramAssessmentQuestionEntity.QuestionDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QuestionDesc", DBNull.Value);
                }

                ///题型 对应RH_AssessmentQuestionType表id : int TypeID
                m_sqlCmd.Parameters.AddWithValue("@TypeID",paramAssessmentQuestionEntity.TypeID);

                ///课堂维度：1.课堂教学 2.学习方式 : int Dimensions
                m_sqlCmd.Parameters.AddWithValue("@Dimensions",paramAssessmentQuestionEntity.Dimensions);

                ///排序 : int SortNo
                m_sqlCmd.Parameters.AddWithValue("@SortNo",paramAssessmentQuestionEntity.SortNo);

                ///状态 0.未发布 1.发布 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramAssessmentQuestionEntity.Status);

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
        /// RH_AssessmentQuestion : RH_AssessmentQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionEntity" type="AssessmentQuestionEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, AssessmentQuestionEntity paramAssessmentQuestionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_AssessmentQuestion");
                strBuilder.Append("  set ");
                strBuilder.Append("    AssessmentID=@AssessmentID,");
                strBuilder.Append("    Question=@Question,");
                strBuilder.Append("    QuestionDesc=@QuestionDesc,");
                strBuilder.Append("    TypeID=@TypeID,");
                strBuilder.Append("    Dimensions=@Dimensions,");
                strBuilder.Append("    SortNo=@SortNo,");
                strBuilder.Append("    Status=@Status");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentQuestionEntity.ID);

                ///测评工具id 对应RH_Assessment表id : int AssessmentID
                m_sqlCmd.Parameters.AddWithValue("@AssessmentID",paramAssessmentQuestionEntity.AssessmentID);

                ///题干 : nvarchar(Max) Question
                if (paramAssessmentQuestionEntity.Question != null && "".Equals(paramAssessmentQuestionEntity.Question.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Question", paramAssessmentQuestionEntity.Question);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Question", DBNull.Value);
                }

                ///题干描述 : nvarchar(Max) QuestionDesc
                if (paramAssessmentQuestionEntity.QuestionDesc != null && "".Equals(paramAssessmentQuestionEntity.QuestionDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QuestionDesc", paramAssessmentQuestionEntity.QuestionDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QuestionDesc", DBNull.Value);
                }

                ///题型 对应RH_AssessmentQuestionType表id : int TypeID
                m_sqlCmd.Parameters.AddWithValue("@TypeID",paramAssessmentQuestionEntity.TypeID);

                ///课堂维度：1.课堂教学 2.学习方式 : int Dimensions
                m_sqlCmd.Parameters.AddWithValue("@Dimensions",paramAssessmentQuestionEntity.Dimensions);

                ///排序 : int SortNo
                m_sqlCmd.Parameters.AddWithValue("@SortNo",paramAssessmentQuestionEntity.SortNo);

                ///状态 0.未发布 1.发布 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramAssessmentQuestionEntity.Status);

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
        /// RH_AssessmentQuestion : RH_AssessmentQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionEntity" type="AssessmentQuestionEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, AssessmentQuestionEntity paramAssessmentQuestionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_AssessmentQuestion");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentQuestionEntity.ID);

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
        /// RH_AssessmentQuestion : RH_AssessmentQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionEntity" type="AssessmentQuestionEntity"></param>
        /// <returns type="AssessmentQuestionEntity"></returns>
        public AssessmentQuestionEntity SelectByPK(Object paramConnectionEntity, AssessmentQuestionEntity paramAssessmentQuestionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            AssessmentQuestionEntity assessmentQuestionEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   AssessmentID AS AssessmentID,");
                strBuilder.Append("   Question AS Question,");
                strBuilder.Append("   QuestionDesc AS QuestionDesc,");
                strBuilder.Append("   TypeID AS TypeID,");
                strBuilder.Append("   Dimensions AS Dimensions,");
                strBuilder.Append("   SortNo AS SortNo,");
                strBuilder.Append("   Status AS Status");
                strBuilder.Append(" from RH_AssessmentQuestion");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentQuestionEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        assessmentQuestionEntity = ParseDataRowToEntity(dataRows[0]);
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

            return assessmentQuestionEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_AssessmentQuestion : RH_AssessmentQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionEntity" type="AssessmentQuestionEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllAssessmentQuestionByForeignKeys(Object paramConnectionEntity, AssessmentQuestionEntity paramAssessmentQuestionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable assessmentQuestionEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   AssessmentID AS AssessmentID,");
                strBuilder.Append("   Question AS Question,");
                strBuilder.Append("   QuestionDesc AS QuestionDesc,");
                strBuilder.Append("   TypeID AS TypeID,");
                strBuilder.Append("   Dimensions AS Dimensions,");
                strBuilder.Append("   SortNo AS SortNo,");
                strBuilder.Append("   Status AS Status");
                strBuilder.Append(" from RH_AssessmentQuestion");
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
        /// <returns type="AssessmentQuestionEntity"></returns>
        private AssessmentQuestionEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return AssessmentQuestionMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}