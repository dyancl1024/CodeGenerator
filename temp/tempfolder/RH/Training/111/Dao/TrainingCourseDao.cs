using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingCourse ( RH_TrainingCourse ) Dao类
    ///</summary>
    public class TrainingCourseDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingCourse : RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingCourse");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    PresetID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    CourseID,");
                strBuilder.Append("    IfRequired,");
                strBuilder.Append("    CPharse,");
                strBuilder.Append("    Sort,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @PresetID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @CourseID,");
                strBuilder.Append("    @IfRequired,");
                strBuilder.Append("    @CPharse,");
                strBuilder.Append("    @Sort,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingCourseEntity.ID);

                ///预设ID : int PresetID
                m_sqlCmd.Parameters.AddWithValue("@PresetID",paramTrainingCourseEntity.PresetID);

                ///子项目ID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingCourseEntity.SubTID);

                ///CourseID : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramTrainingCourseEntity.CourseID);

                ///是否必修 1-是 0-否 : int IfRequired
                m_sqlCmd.Parameters.AddWithValue("@IfRequired",paramTrainingCourseEntity.IfRequired);

                ///课程学时 : int CPharse
                m_sqlCmd.Parameters.AddWithValue("@CPharse",paramTrainingCourseEntity.CPharse);

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramTrainingCourseEntity.Sort);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingCourseEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingCourseEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingCourseEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingCourseEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingCourseEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingCourseEntity.UpdateTime);
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
        /// RH_TrainingCourse : RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingCourse");
                strBuilder.Append("  set ");
                strBuilder.Append("    PresetID=@PresetID,");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    CourseID=@CourseID,");
                strBuilder.Append("    IfRequired=@IfRequired,");
                strBuilder.Append("    CPharse=@CPharse,");
                strBuilder.Append("    Sort=@Sort,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingCourseEntity.ID);

                ///预设ID : int PresetID
                m_sqlCmd.Parameters.AddWithValue("@PresetID",paramTrainingCourseEntity.PresetID);

                ///子项目ID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingCourseEntity.SubTID);

                ///CourseID : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramTrainingCourseEntity.CourseID);

                ///是否必修 1-是 0-否 : int IfRequired
                m_sqlCmd.Parameters.AddWithValue("@IfRequired",paramTrainingCourseEntity.IfRequired);

                ///课程学时 : int CPharse
                m_sqlCmd.Parameters.AddWithValue("@CPharse",paramTrainingCourseEntity.CPharse);

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramTrainingCourseEntity.Sort);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingCourseEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingCourseEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingCourseEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingCourseEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingCourseEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingCourseEntity.UpdateTime);
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
        /// RH_TrainingCourse : RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingCourse");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingCourseEntity.ID);

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
        /// RH_TrainingCourse : RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="TrainingCourseEntity"></returns>
        public TrainingCourseEntity SelectByPK(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingCourseEntity trainingCourseEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   PresetID AS PresetID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   CourseID AS CourseID,");
                strBuilder.Append("   IfRequired AS IfRequired,");
                strBuilder.Append("   CPharse AS CPharse,");
                strBuilder.Append("   Sort AS Sort,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingCourse");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingCourseEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingCourseEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingCourseEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingCourse : RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingCourseByForeignKeys(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingCourseEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   PresetID AS PresetID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   CourseID AS CourseID,");
                strBuilder.Append("   IfRequired AS IfRequired,");
                strBuilder.Append("   CPharse AS CPharse,");
                strBuilder.Append("   Sort AS Sort,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingCourse");
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
        /// <returns type="TrainingCourseEntity"></returns>
        private TrainingCourseEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingCourseMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}