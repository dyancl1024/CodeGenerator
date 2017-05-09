using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingMyHomeWork ( RH_TrainingMyHomeWork ) Dao类
    ///</summary>
    public class TrainingMyHomeWorkDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingMyHomeWork : RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyHomeWorkEntity" type="TrainingMyHomeWorkEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingMyHomeWorkEntity paramTrainingMyHomeWorkEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingMyHomeWork");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    HomeWorkTitle,");
                strBuilder.Append("    HomeWorkContent,");
                strBuilder.Append("    HomeWorkPhaseID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @HomeWorkTitle,");
                strBuilder.Append("    @HomeWorkContent,");
                strBuilder.Append("    @HomeWorkPhaseID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @Status,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyHomeWorkEntity.ID);

                ///作业标题 : nvarchar(50) HomeWorkTitle
                if (paramTrainingMyHomeWorkEntity.HomeWorkTitle != null && "".Equals(paramTrainingMyHomeWorkEntity.HomeWorkTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkTitle", paramTrainingMyHomeWorkEntity.HomeWorkTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkTitle", DBNull.Value);
                }

                ///作业内容 : nvarchar(Max) HomeWorkContent
                if (paramTrainingMyHomeWorkEntity.HomeWorkContent != null && "".Equals(paramTrainingMyHomeWorkEntity.HomeWorkContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkContent", paramTrainingMyHomeWorkEntity.HomeWorkContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkContent", DBNull.Value);
                }

                ///作业指标ID  RH_TrainingPhase : int HomeWorkPhaseID
                m_sqlCmd.Parameters.AddWithValue("@HomeWorkPhaseID",paramTrainingMyHomeWorkEntity.HomeWorkPhaseID);

                ///阶段项目ID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingMyHomeWorkEntity.SubTID);

                ///作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交） : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingMyHomeWorkEntity.Status);

                ///导入人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingMyHomeWorkEntity.CreateBy);

                ///导入时间 : datetime CreateTime
                if (paramTrainingMyHomeWorkEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingMyHomeWorkEntity.CreateTime);
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
        /// RH_TrainingMyHomeWork : RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyHomeWorkEntity" type="TrainingMyHomeWorkEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingMyHomeWorkEntity paramTrainingMyHomeWorkEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingMyHomeWork");
                strBuilder.Append("  set ");
                strBuilder.Append("    HomeWorkTitle=@HomeWorkTitle,");
                strBuilder.Append("    HomeWorkContent=@HomeWorkContent,");
                strBuilder.Append("    HomeWorkPhaseID=@HomeWorkPhaseID,");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    Status=@Status,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyHomeWorkEntity.ID);

                ///作业标题 : nvarchar(50) HomeWorkTitle
                if (paramTrainingMyHomeWorkEntity.HomeWorkTitle != null && "".Equals(paramTrainingMyHomeWorkEntity.HomeWorkTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkTitle", paramTrainingMyHomeWorkEntity.HomeWorkTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkTitle", DBNull.Value);
                }

                ///作业内容 : nvarchar(Max) HomeWorkContent
                if (paramTrainingMyHomeWorkEntity.HomeWorkContent != null && "".Equals(paramTrainingMyHomeWorkEntity.HomeWorkContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkContent", paramTrainingMyHomeWorkEntity.HomeWorkContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkContent", DBNull.Value);
                }

                ///作业指标ID  RH_TrainingPhase : int HomeWorkPhaseID
                m_sqlCmd.Parameters.AddWithValue("@HomeWorkPhaseID",paramTrainingMyHomeWorkEntity.HomeWorkPhaseID);

                ///阶段项目ID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingMyHomeWorkEntity.SubTID);

                ///作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交） : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingMyHomeWorkEntity.Status);

                ///导入人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingMyHomeWorkEntity.CreateBy);

                ///导入时间 : datetime CreateTime
                if (paramTrainingMyHomeWorkEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingMyHomeWorkEntity.CreateTime);
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
        /// RH_TrainingMyHomeWork : RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyHomeWorkEntity" type="TrainingMyHomeWorkEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingMyHomeWorkEntity paramTrainingMyHomeWorkEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingMyHomeWork");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyHomeWorkEntity.ID);

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
        /// RH_TrainingMyHomeWork : RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyHomeWorkEntity" type="TrainingMyHomeWorkEntity"></param>
        /// <returns type="TrainingMyHomeWorkEntity"></returns>
        public TrainingMyHomeWorkEntity SelectByPK(Object paramConnectionEntity, TrainingMyHomeWorkEntity paramTrainingMyHomeWorkEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingMyHomeWorkEntity trainingMyHomeWorkEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   HomeWorkTitle AS HomeWorkTitle,");
                strBuilder.Append("   HomeWorkContent AS HomeWorkContent,");
                strBuilder.Append("   HomeWorkPhaseID AS HomeWorkPhaseID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingMyHomeWork");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyHomeWorkEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingMyHomeWorkEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingMyHomeWorkEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingMyHomeWork : RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyHomeWorkEntity" type="TrainingMyHomeWorkEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingMyHomeWorkByForeignKeys(Object paramConnectionEntity, TrainingMyHomeWorkEntity paramTrainingMyHomeWorkEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingMyHomeWorkEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   HomeWorkTitle AS HomeWorkTitle,");
                strBuilder.Append("   HomeWorkContent AS HomeWorkContent,");
                strBuilder.Append("   HomeWorkPhaseID AS HomeWorkPhaseID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingMyHomeWork");
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
        /// <returns type="TrainingMyHomeWorkEntity"></returns>
        private TrainingMyHomeWorkEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingMyHomeWorkMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}