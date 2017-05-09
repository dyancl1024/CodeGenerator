using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingSubSubject ( RH_TrainingSubSubject ) Dao类
    ///</summary>
    public class TrainingSubSubjectDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingSubSubject : RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingSubSubject");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    GradeCode,");
                strBuilder.Append("    SubjectCode,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @GradeCode,");
                strBuilder.Append("    @SubjectCode,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingSubSubjectEntity.ID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingSubSubjectEntity.SubTID);

                ///GradeCode : varchar(50) GradeCode
                if (paramTrainingSubSubjectEntity.GradeCode != null && "".Equals(paramTrainingSubSubjectEntity.GradeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", paramTrainingSubSubjectEntity.GradeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", DBNull.Value);
                }

                ///SubjectCode : varchar(50) SubjectCode
                if (paramTrainingSubSubjectEntity.SubjectCode != null && "".Equals(paramTrainingSubSubjectEntity.SubjectCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", paramTrainingSubSubjectEntity.SubjectCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", DBNull.Value);
                }

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingSubSubjectEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramTrainingSubSubjectEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingSubSubjectEntity.CreateTime);
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
        /// RH_TrainingSubSubject : RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingSubSubject");
                strBuilder.Append("  set ");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    GradeCode=@GradeCode,");
                strBuilder.Append("    SubjectCode=@SubjectCode,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingSubSubjectEntity.ID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingSubSubjectEntity.SubTID);

                ///GradeCode : varchar(50) GradeCode
                if (paramTrainingSubSubjectEntity.GradeCode != null && "".Equals(paramTrainingSubSubjectEntity.GradeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", paramTrainingSubSubjectEntity.GradeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", DBNull.Value);
                }

                ///SubjectCode : varchar(50) SubjectCode
                if (paramTrainingSubSubjectEntity.SubjectCode != null && "".Equals(paramTrainingSubSubjectEntity.SubjectCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", paramTrainingSubSubjectEntity.SubjectCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", DBNull.Value);
                }

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingSubSubjectEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramTrainingSubSubjectEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingSubSubjectEntity.CreateTime);
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
        /// RH_TrainingSubSubject : RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingSubSubject");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingSubSubjectEntity.ID);

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
        /// RH_TrainingSubSubject : RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="TrainingSubSubjectEntity"></returns>
        public TrainingSubSubjectEntity SelectByPK(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingSubSubjectEntity trainingSubSubjectEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   GradeCode AS GradeCode,");
                strBuilder.Append("   SubjectCode AS SubjectCode,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingSubSubject");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingSubSubjectEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingSubSubjectEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingSubSubjectEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingSubSubject : RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingSubSubjectByForeignKeys(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingSubSubjectEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   GradeCode AS GradeCode,");
                strBuilder.Append("   SubjectCode AS SubjectCode,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingSubSubject");
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
        /// <returns type="TrainingSubSubjectEntity"></returns>
        private TrainingSubSubjectEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingSubSubjectMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}