using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_AssessmentAnswerBak ( RH_AssessmentAnswerBak ) Dao类
    ///</summary>
    public class AssessmentAnswerBakDao
    {

        /// <summary>
        /// 添加
        /// RH_AssessmentAnswerBak : RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerBakEntity" type="AssessmentAnswerBakEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, AssessmentAnswerBakEntity paramAssessmentAnswerBakEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_AssessmentAnswerBak");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    UserID,");
                strBuilder.Append("    QID,");
                strBuilder.Append("    QType,");
                strBuilder.Append("    OptionID,");
                strBuilder.Append("    Score");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @UserID,");
                strBuilder.Append("    @QID,");
                strBuilder.Append("    @QType,");
                strBuilder.Append("    @OptionID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentAnswerBakEntity.ID);

                ///项目id : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramAssessmentAnswerBakEntity.SubTID);

                ///用户id : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramAssessmentAnswerBakEntity.UserID);

                ///问题id : int QID
                m_sqlCmd.Parameters.AddWithValue("@QID",paramAssessmentAnswerBakEntity.QID);

                ///问题类型 问题类型  RH_AssessmentQuestionType表id : int QType
                m_sqlCmd.Parameters.AddWithValue("@QType",paramAssessmentAnswerBakEntity.QType);

                ///选项id  RH_AssessmentOptions表id : int OptionID
                m_sqlCmd.Parameters.AddWithValue("@OptionID",paramAssessmentAnswerBakEntity.OptionID);

                ///得分 : int Score
                m_sqlCmd.Parameters.AddWithValue("@Score",paramAssessmentAnswerBakEntity.Score);

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
        /// RH_AssessmentAnswerBak : RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerBakEntity" type="AssessmentAnswerBakEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, AssessmentAnswerBakEntity paramAssessmentAnswerBakEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_AssessmentAnswerBak");
                strBuilder.Append("  set ");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    UserID=@UserID,");
                strBuilder.Append("    QID=@QID,");
                strBuilder.Append("    QType=@QType,");
                strBuilder.Append("    OptionID=@OptionID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentAnswerBakEntity.ID);

                ///项目id : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramAssessmentAnswerBakEntity.SubTID);

                ///用户id : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramAssessmentAnswerBakEntity.UserID);

                ///问题id : int QID
                m_sqlCmd.Parameters.AddWithValue("@QID",paramAssessmentAnswerBakEntity.QID);

                ///问题类型 问题类型  RH_AssessmentQuestionType表id : int QType
                m_sqlCmd.Parameters.AddWithValue("@QType",paramAssessmentAnswerBakEntity.QType);

                ///选项id  RH_AssessmentOptions表id : int OptionID
                m_sqlCmd.Parameters.AddWithValue("@OptionID",paramAssessmentAnswerBakEntity.OptionID);

                ///得分 : int Score
                m_sqlCmd.Parameters.AddWithValue("@Score",paramAssessmentAnswerBakEntity.Score);

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
        /// RH_AssessmentAnswerBak : RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerBakEntity" type="AssessmentAnswerBakEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, AssessmentAnswerBakEntity paramAssessmentAnswerBakEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_AssessmentAnswerBak");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentAnswerBakEntity.ID);

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
        /// RH_AssessmentAnswerBak : RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerBakEntity" type="AssessmentAnswerBakEntity"></param>
        /// <returns type="AssessmentAnswerBakEntity"></returns>
        public AssessmentAnswerBakEntity SelectByPK(Object paramConnectionEntity, AssessmentAnswerBakEntity paramAssessmentAnswerBakEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            AssessmentAnswerBakEntity assessmentAnswerBakEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   QID AS QID,");
                strBuilder.Append("   QType AS QType,");
                strBuilder.Append("   OptionID AS OptionID,");
                strBuilder.Append("   Score AS Score");
                strBuilder.Append(" from RH_AssessmentAnswerBak");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentAnswerBakEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        assessmentAnswerBakEntity = ParseDataRowToEntity(dataRows[0]);
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

            return assessmentAnswerBakEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_AssessmentAnswerBak : RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerBakEntity" type="AssessmentAnswerBakEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllAssessmentAnswerBakByForeignKeys(Object paramConnectionEntity, AssessmentAnswerBakEntity paramAssessmentAnswerBakEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable assessmentAnswerBakEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   QID AS QID,");
                strBuilder.Append("   QType AS QType,");
                strBuilder.Append("   OptionID AS OptionID,");
                strBuilder.Append("   Score AS Score");
                strBuilder.Append(" from RH_AssessmentAnswerBak");
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
        /// <returns type="AssessmentAnswerBakEntity"></returns>
        private AssessmentAnswerBakEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return AssessmentAnswerBakMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}