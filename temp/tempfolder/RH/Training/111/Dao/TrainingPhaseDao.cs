using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingPhase ( RH_TrainingPhase ) Dao类
    ///</summary>
    public class TrainingPhaseDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingPhase : RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingPhase");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    PType,");
                strBuilder.Append("    HomeName,");
                strBuilder.Append("    HomeWorkDesc,");
                strBuilder.Append("    HomeWorkCode,");
                strBuilder.Append("    Phase,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @PType,");
                strBuilder.Append("    @HomeName,");
                strBuilder.Append("    @HomeWorkDesc,");
                strBuilder.Append("    @HomeWorkCode,");
                strBuilder.Append("    @Phase,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingPhaseEntity.ID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingPhaseEntity.SubTID);

                ///1 课程学时 2.作业学时 : int PType
                m_sqlCmd.Parameters.AddWithValue("@PType",paramTrainingPhaseEntity.PType);

                ///作业名称 : nvarchar(50) HomeName
                if (paramTrainingPhaseEntity.HomeName != null && "".Equals(paramTrainingPhaseEntity.HomeName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeName", paramTrainingPhaseEntity.HomeName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeName", DBNull.Value);
                }

                ///作业描述 : nvarchar(200) HomeWorkDesc
                if (paramTrainingPhaseEntity.HomeWorkDesc != null && "".Equals(paramTrainingPhaseEntity.HomeWorkDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkDesc", paramTrainingPhaseEntity.HomeWorkDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkDesc", DBNull.Value);
                }

                ///作业类型：表RH_TrainingHomeWorkType : varchar(50) HomeWorkCode
                if (paramTrainingPhaseEntity.HomeWorkCode != null && "".Equals(paramTrainingPhaseEntity.HomeWorkCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkCode", paramTrainingPhaseEntity.HomeWorkCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkCode", DBNull.Value);
                }

                ///Phase : int Phase
                m_sqlCmd.Parameters.AddWithValue("@Phase",paramTrainingPhaseEntity.Phase);

                ///导入人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingPhaseEntity.CreateBy);

                ///导入时间 : datetime CreateTime
                if (paramTrainingPhaseEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingPhaseEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingPhaseEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingPhaseEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingPhaseEntity.UpdateTime);
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
        /// RH_TrainingPhase : RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingPhase");
                strBuilder.Append("  set ");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    PType=@PType,");
                strBuilder.Append("    HomeName=@HomeName,");
                strBuilder.Append("    HomeWorkDesc=@HomeWorkDesc,");
                strBuilder.Append("    HomeWorkCode=@HomeWorkCode,");
                strBuilder.Append("    Phase=@Phase,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingPhaseEntity.ID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingPhaseEntity.SubTID);

                ///1 课程学时 2.作业学时 : int PType
                m_sqlCmd.Parameters.AddWithValue("@PType",paramTrainingPhaseEntity.PType);

                ///作业名称 : nvarchar(50) HomeName
                if (paramTrainingPhaseEntity.HomeName != null && "".Equals(paramTrainingPhaseEntity.HomeName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeName", paramTrainingPhaseEntity.HomeName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeName", DBNull.Value);
                }

                ///作业描述 : nvarchar(200) HomeWorkDesc
                if (paramTrainingPhaseEntity.HomeWorkDesc != null && "".Equals(paramTrainingPhaseEntity.HomeWorkDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkDesc", paramTrainingPhaseEntity.HomeWorkDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkDesc", DBNull.Value);
                }

                ///作业类型：表RH_TrainingHomeWorkType : varchar(50) HomeWorkCode
                if (paramTrainingPhaseEntity.HomeWorkCode != null && "".Equals(paramTrainingPhaseEntity.HomeWorkCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkCode", paramTrainingPhaseEntity.HomeWorkCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@HomeWorkCode", DBNull.Value);
                }

                ///Phase : int Phase
                m_sqlCmd.Parameters.AddWithValue("@Phase",paramTrainingPhaseEntity.Phase);

                ///导入人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingPhaseEntity.CreateBy);

                ///导入时间 : datetime CreateTime
                if (paramTrainingPhaseEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingPhaseEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingPhaseEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingPhaseEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingPhaseEntity.UpdateTime);
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
        /// RH_TrainingPhase : RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingPhase");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingPhaseEntity.ID);

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
        /// RH_TrainingPhase : RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="TrainingPhaseEntity"></returns>
        public TrainingPhaseEntity SelectByPK(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingPhaseEntity trainingPhaseEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   PType AS PType,");
                strBuilder.Append("   HomeName AS HomeName,");
                strBuilder.Append("   HomeWorkDesc AS HomeWorkDesc,");
                strBuilder.Append("   HomeWorkCode AS HomeWorkCode,");
                strBuilder.Append("   Phase AS Phase,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingPhase");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingPhaseEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingPhaseEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingPhaseEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingPhase : RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingPhaseByForeignKeys(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingPhaseEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   PType AS PType,");
                strBuilder.Append("   HomeName AS HomeName,");
                strBuilder.Append("   HomeWorkDesc AS HomeWorkDesc,");
                strBuilder.Append("   HomeWorkCode AS HomeWorkCode,");
                strBuilder.Append("   Phase AS Phase,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingPhase");
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
        /// <returns type="TrainingPhaseEntity"></returns>
        private TrainingPhaseEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingPhaseMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}