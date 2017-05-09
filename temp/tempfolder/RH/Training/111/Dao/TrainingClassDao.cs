using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingClass ( RH_TrainingClass ) Dao类
    ///</summary>
    public class TrainingClassDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingClass : RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingClass");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    ClassNO,");
                strBuilder.Append("    CName,");
                strBuilder.Append("    SubjectCode,");
                strBuilder.Append("    GradeCode,");
                strBuilder.Append("    StaticUrl,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @ClassNO,");
                strBuilder.Append("    @CName,");
                strBuilder.Append("    @SubjectCode,");
                strBuilder.Append("    @GradeCode,");
                strBuilder.Append("    @StaticUrl,");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingClassEntity.ID);

                ///项目id : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingClassEntity.SubTID);

                ///班号 : int ClassNO
                m_sqlCmd.Parameters.AddWithValue("@ClassNO",paramTrainingClassEntity.ClassNO);

                ///班级名称 : nvarchar(50) CName
                if (paramTrainingClassEntity.CName != null && "".Equals(paramTrainingClassEntity.CName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CName", paramTrainingClassEntity.CName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CName", DBNull.Value);
                }

                ///学科id : varchar(50) SubjectCode
                if (paramTrainingClassEntity.SubjectCode != null && "".Equals(paramTrainingClassEntity.SubjectCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", paramTrainingClassEntity.SubjectCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", DBNull.Value);
                }

                ///学段id : varchar(50) GradeCode
                if (paramTrainingClassEntity.GradeCode != null && "".Equals(paramTrainingClassEntity.GradeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", paramTrainingClassEntity.GradeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", DBNull.Value);
                }

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramTrainingClassEntity.StaticUrl != null && "".Equals(paramTrainingClassEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingClassEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingClassEntity.CreateBy);

                ///发布时间 : datetime CreateTime
                if (paramTrainingClassEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingClassEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingClassEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingClassEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingClassEntity.UpdateTime);
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
        /// RH_TrainingClass : RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingClass");
                strBuilder.Append("  set ");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    ClassNO=@ClassNO,");
                strBuilder.Append("    CName=@CName,");
                strBuilder.Append("    SubjectCode=@SubjectCode,");
                strBuilder.Append("    GradeCode=@GradeCode,");
                strBuilder.Append("    StaticUrl=@StaticUrl,");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingClassEntity.ID);

                ///项目id : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingClassEntity.SubTID);

                ///班号 : int ClassNO
                m_sqlCmd.Parameters.AddWithValue("@ClassNO",paramTrainingClassEntity.ClassNO);

                ///班级名称 : nvarchar(50) CName
                if (paramTrainingClassEntity.CName != null && "".Equals(paramTrainingClassEntity.CName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CName", paramTrainingClassEntity.CName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CName", DBNull.Value);
                }

                ///学科id : varchar(50) SubjectCode
                if (paramTrainingClassEntity.SubjectCode != null && "".Equals(paramTrainingClassEntity.SubjectCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", paramTrainingClassEntity.SubjectCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", DBNull.Value);
                }

                ///学段id : varchar(50) GradeCode
                if (paramTrainingClassEntity.GradeCode != null && "".Equals(paramTrainingClassEntity.GradeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", paramTrainingClassEntity.GradeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", DBNull.Value);
                }

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramTrainingClassEntity.StaticUrl != null && "".Equals(paramTrainingClassEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingClassEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingClassEntity.CreateBy);

                ///发布时间 : datetime CreateTime
                if (paramTrainingClassEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingClassEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingClassEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingClassEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingClassEntity.UpdateTime);
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
        /// RH_TrainingClass : RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingClass");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingClassEntity.ID);

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
        /// RH_TrainingClass : RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="TrainingClassEntity"></returns>
        public TrainingClassEntity SelectByPK(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingClassEntity trainingClassEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   ClassNO AS ClassNO,");
                strBuilder.Append("   CName AS CName,");
                strBuilder.Append("   SubjectCode AS SubjectCode,");
                strBuilder.Append("   GradeCode AS GradeCode,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingClass");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingClassEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingClassEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingClassEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingClass : RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingClassByForeignKeys(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingClassEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   ClassNO AS ClassNO,");
                strBuilder.Append("   CName AS CName,");
                strBuilder.Append("   SubjectCode AS SubjectCode,");
                strBuilder.Append("   GradeCode AS GradeCode,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingClass");
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
        /// <returns type="TrainingClassEntity"></returns>
        private TrainingClassEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingClassMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}