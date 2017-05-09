using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingStudyGroup ( RH_TrainingStudyGroup ) Dao类
    ///</summary>
    public class TrainingStudyGroupDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingStudyGroup : RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingStudyGroup");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    StudyGroupName,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    CID,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @StudyGroupName,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @CID,");
                strBuilder.Append("    @Status,");
                strBuilder.Append("    @CreateBy,");
                strBuilder.Append("    @CreateTime,");
                strBuilder.Append("    @UpdateBy,");
                strBuilder.Append("    @UpdateTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupEntity.ID);

                ///学习小组名称 : nvarchar(50) StudyGroupName
                if (paramTrainingStudyGroupEntity.StudyGroupName != null && "".Equals(paramTrainingStudyGroupEntity.StudyGroupName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StudyGroupName", paramTrainingStudyGroupEntity.StudyGroupName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StudyGroupName", DBNull.Value);
                }

                ///阶段项目ID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingStudyGroupEntity.SubTID);

                ///课程ID : int CID
                m_sqlCmd.Parameters.AddWithValue("@CID",paramTrainingStudyGroupEntity.CID);

                ///状态：1.正常2.关闭 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingStudyGroupEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingStudyGroupEntity.CreateBy);

                ///发布时间 : datetime CreateTime
                if (paramTrainingStudyGroupEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingStudyGroupEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingStudyGroupEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingStudyGroupEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingStudyGroupEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
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
        /// RH_TrainingStudyGroup : RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingStudyGroup");
                strBuilder.Append("  set ");
                strBuilder.Append("    StudyGroupName=@StudyGroupName,");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    CID=@CID,");
                strBuilder.Append("    Status=@Status,");
                strBuilder.Append("    CreateBy=@CreateBy,");
                strBuilder.Append("    CreateTime=@CreateTime,");
                strBuilder.Append("    UpdateBy=@UpdateBy,");
                strBuilder.Append("    UpdateTime=@UpdateTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupEntity.ID);

                ///学习小组名称 : nvarchar(50) StudyGroupName
                if (paramTrainingStudyGroupEntity.StudyGroupName != null && "".Equals(paramTrainingStudyGroupEntity.StudyGroupName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StudyGroupName", paramTrainingStudyGroupEntity.StudyGroupName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StudyGroupName", DBNull.Value);
                }

                ///阶段项目ID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingStudyGroupEntity.SubTID);

                ///课程ID : int CID
                m_sqlCmd.Parameters.AddWithValue("@CID",paramTrainingStudyGroupEntity.CID);

                ///状态：1.正常2.关闭 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingStudyGroupEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingStudyGroupEntity.CreateBy);

                ///发布时间 : datetime CreateTime
                if (paramTrainingStudyGroupEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingStudyGroupEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingStudyGroupEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingStudyGroupEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingStudyGroupEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
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
        /// RH_TrainingStudyGroup : RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingStudyGroup");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupEntity.ID);

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
        /// RH_TrainingStudyGroup : RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="TrainingStudyGroupEntity"></returns>
        public TrainingStudyGroupEntity SelectByPK(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingStudyGroupEntity trainingStudyGroupEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   StudyGroupName AS StudyGroupName,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   CID AS CID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingStudyGroup");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingStudyGroupEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingStudyGroupEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingStudyGroup : RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingStudyGroupByForeignKeys(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingStudyGroupEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   StudyGroupName AS StudyGroupName,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   CID AS CID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingStudyGroup");
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
        /// <returns type="TrainingStudyGroupEntity"></returns>
        private TrainingStudyGroupEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingStudyGroupMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}