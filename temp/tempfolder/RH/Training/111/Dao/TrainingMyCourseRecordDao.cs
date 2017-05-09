using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingMyCourseRecord ( RH_TrainingMyCourseRecord ) Dao类
    ///</summary>
    public class TrainingMyCourseRecordDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingMyCourseRecord : RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingMyCourseRecord");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    UserID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    PCID,");
                strBuilder.Append("    CourseID,");
                strBuilder.Append("    WatchTime,");
                strBuilder.Append("    TotalWatchTime,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @UserID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @PCID,");
                strBuilder.Append("    @CourseID,");
                strBuilder.Append("    @WatchTime,");
                strBuilder.Append("    @TotalWatchTime,");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyCourseRecordEntity.ID);

                ///人员ID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTrainingMyCourseRecordEntity.UserID);

                ///项目id : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingMyCourseRecordEntity.SubTID);

                ///套餐ID : int PCID
                m_sqlCmd.Parameters.AddWithValue("@PCID",paramTrainingMyCourseRecordEntity.PCID);

                ///课程id : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramTrainingMyCourseRecordEntity.CourseID);

                ///当前已观看时间 : int WatchTime
                m_sqlCmd.Parameters.AddWithValue("@WatchTime",paramTrainingMyCourseRecordEntity.WatchTime);

                ///总共观看时间 : int TotalWatchTime
                m_sqlCmd.Parameters.AddWithValue("@TotalWatchTime",paramTrainingMyCourseRecordEntity.TotalWatchTime);

                ///CreateTime : datetime CreateTime
                if (paramTrainingMyCourseRecordEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingMyCourseRecordEntity.CreateTime);
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
        /// RH_TrainingMyCourseRecord : RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingMyCourseRecord");
                strBuilder.Append("  set ");
                strBuilder.Append("    UserID=@UserID,");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    PCID=@PCID,");
                strBuilder.Append("    CourseID=@CourseID,");
                strBuilder.Append("    WatchTime=@WatchTime,");
                strBuilder.Append("    TotalWatchTime=@TotalWatchTime,");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyCourseRecordEntity.ID);

                ///人员ID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTrainingMyCourseRecordEntity.UserID);

                ///项目id : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingMyCourseRecordEntity.SubTID);

                ///套餐ID : int PCID
                m_sqlCmd.Parameters.AddWithValue("@PCID",paramTrainingMyCourseRecordEntity.PCID);

                ///课程id : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramTrainingMyCourseRecordEntity.CourseID);

                ///当前已观看时间 : int WatchTime
                m_sqlCmd.Parameters.AddWithValue("@WatchTime",paramTrainingMyCourseRecordEntity.WatchTime);

                ///总共观看时间 : int TotalWatchTime
                m_sqlCmd.Parameters.AddWithValue("@TotalWatchTime",paramTrainingMyCourseRecordEntity.TotalWatchTime);

                ///CreateTime : datetime CreateTime
                if (paramTrainingMyCourseRecordEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingMyCourseRecordEntity.CreateTime);
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
        /// RH_TrainingMyCourseRecord : RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingMyCourseRecord");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyCourseRecordEntity.ID);

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
        /// RH_TrainingMyCourseRecord : RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="TrainingMyCourseRecordEntity"></returns>
        public TrainingMyCourseRecordEntity SelectByPK(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingMyCourseRecordEntity trainingMyCourseRecordEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   PCID AS PCID,");
                strBuilder.Append("   CourseID AS CourseID,");
                strBuilder.Append("   WatchTime AS WatchTime,");
                strBuilder.Append("   TotalWatchTime AS TotalWatchTime,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingMyCourseRecord");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyCourseRecordEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingMyCourseRecordEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingMyCourseRecordEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingMyCourseRecord : RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingMyCourseRecordByForeignKeys(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingMyCourseRecordEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   PCID AS PCID,");
                strBuilder.Append("   CourseID AS CourseID,");
                strBuilder.Append("   WatchTime AS WatchTime,");
                strBuilder.Append("   TotalWatchTime AS TotalWatchTime,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingMyCourseRecord");
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
        /// <returns type="TrainingMyCourseRecordEntity"></returns>
        private TrainingMyCourseRecordEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingMyCourseRecordMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}