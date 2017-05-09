using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Temp_BasicData_TrainingSub ( RH_Temp_BasicData_TrainingSub ) Dao类
    ///</summary>
    public class Temp_BasicData_TrainingSubDao
    {

        /// <summary>
        /// 添加
        /// RH_Temp_BasicData_TrainingSub : RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Temp_BasicData_TrainingSub");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    tid,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    TeacherNum,");
                strBuilder.Append("    ClassNum,");
                strBuilder.Append("    FinishedNum,");
                strBuilder.Append("    StudyNum,");
                strBuilder.Append("    UserNum,");
                strBuilder.Append("    FinishedRate,");
                strBuilder.Append("    StudyRate");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @tid,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @TeacherNum,");
                strBuilder.Append("    @ClassNum,");
                strBuilder.Append("    @FinishedNum,");
                strBuilder.Append("    @StudyNum,");
                strBuilder.Append("    @UserNum,");
                strBuilder.Append("    @FinishedRate,");
                strBuilder.Append("    @StudyRate");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_TrainingSubEntity.ID);

                ///tid : int tid
                m_sqlCmd.Parameters.AddWithValue("@tid",paramTemp_BasicData_TrainingSubEntity.tid);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTemp_BasicData_TrainingSubEntity.SubTID);

                ///TeacherNum : int TeacherNum
                m_sqlCmd.Parameters.AddWithValue("@TeacherNum",paramTemp_BasicData_TrainingSubEntity.TeacherNum);

                ///班级数量 : int ClassNum
                m_sqlCmd.Parameters.AddWithValue("@ClassNum",paramTemp_BasicData_TrainingSubEntity.ClassNum);

                ///合格人数 : int FinishedNum
                m_sqlCmd.Parameters.AddWithValue("@FinishedNum",paramTemp_BasicData_TrainingSubEntity.FinishedNum);

                ///学习人数 : int StudyNum
                m_sqlCmd.Parameters.AddWithValue("@StudyNum",paramTemp_BasicData_TrainingSubEntity.StudyNum);

                ///学员总数 : int UserNum
                m_sqlCmd.Parameters.AddWithValue("@UserNum",paramTemp_BasicData_TrainingSubEntity.UserNum);

                ///合格率 : decimal(6,2) FinishedRate
                m_sqlCmd.Parameters.AddWithValue("@FinishedRate",paramTemp_BasicData_TrainingSubEntity.FinishedRate);

                ///学习率 : decimal(6,2) StudyRate
                m_sqlCmd.Parameters.AddWithValue("@StudyRate",paramTemp_BasicData_TrainingSubEntity.StudyRate);

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
        /// RH_Temp_BasicData_TrainingSub : RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Temp_BasicData_TrainingSub");
                strBuilder.Append("  set ");
                strBuilder.Append("    tid=@tid,");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    TeacherNum=@TeacherNum,");
                strBuilder.Append("    ClassNum=@ClassNum,");
                strBuilder.Append("    FinishedNum=@FinishedNum,");
                strBuilder.Append("    StudyNum=@StudyNum,");
                strBuilder.Append("    UserNum=@UserNum,");
                strBuilder.Append("    FinishedRate=@FinishedRate,");
                strBuilder.Append("    StudyRate=@StudyRate");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_TrainingSubEntity.ID);

                ///tid : int tid
                m_sqlCmd.Parameters.AddWithValue("@tid",paramTemp_BasicData_TrainingSubEntity.tid);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTemp_BasicData_TrainingSubEntity.SubTID);

                ///TeacherNum : int TeacherNum
                m_sqlCmd.Parameters.AddWithValue("@TeacherNum",paramTemp_BasicData_TrainingSubEntity.TeacherNum);

                ///班级数量 : int ClassNum
                m_sqlCmd.Parameters.AddWithValue("@ClassNum",paramTemp_BasicData_TrainingSubEntity.ClassNum);

                ///合格人数 : int FinishedNum
                m_sqlCmd.Parameters.AddWithValue("@FinishedNum",paramTemp_BasicData_TrainingSubEntity.FinishedNum);

                ///学习人数 : int StudyNum
                m_sqlCmd.Parameters.AddWithValue("@StudyNum",paramTemp_BasicData_TrainingSubEntity.StudyNum);

                ///学员总数 : int UserNum
                m_sqlCmd.Parameters.AddWithValue("@UserNum",paramTemp_BasicData_TrainingSubEntity.UserNum);

                ///合格率 : decimal(6,2) FinishedRate
                m_sqlCmd.Parameters.AddWithValue("@FinishedRate",paramTemp_BasicData_TrainingSubEntity.FinishedRate);

                ///学习率 : decimal(6,2) StudyRate
                m_sqlCmd.Parameters.AddWithValue("@StudyRate",paramTemp_BasicData_TrainingSubEntity.StudyRate);

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
        /// RH_Temp_BasicData_TrainingSub : RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Temp_BasicData_TrainingSub");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_TrainingSubEntity.ID);

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
        /// RH_Temp_BasicData_TrainingSub : RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="Temp_BasicData_TrainingSubEntity"></returns>
        public Temp_BasicData_TrainingSubEntity SelectByPK(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            Temp_BasicData_TrainingSubEntity temp_BasicData_TrainingSubEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   tid AS tid,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   TeacherNum AS TeacherNum,");
                strBuilder.Append("   ClassNum AS ClassNum,");
                strBuilder.Append("   FinishedNum AS FinishedNum,");
                strBuilder.Append("   StudyNum AS StudyNum,");
                strBuilder.Append("   UserNum AS UserNum,");
                strBuilder.Append("   FinishedRate AS FinishedRate,");
                strBuilder.Append("   StudyRate AS StudyRate");
                strBuilder.Append(" from RH_Temp_BasicData_TrainingSub");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_TrainingSubEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        temp_BasicData_TrainingSubEntity = ParseDataRowToEntity(dataRows[0]);
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

            return temp_BasicData_TrainingSubEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Temp_BasicData_TrainingSub : RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTemp_BasicData_TrainingSubByForeignKeys(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable temp_BasicData_TrainingSubEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   tid AS tid,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   TeacherNum AS TeacherNum,");
                strBuilder.Append("   ClassNum AS ClassNum,");
                strBuilder.Append("   FinishedNum AS FinishedNum,");
                strBuilder.Append("   StudyNum AS StudyNum,");
                strBuilder.Append("   UserNum AS UserNum,");
                strBuilder.Append("   FinishedRate AS FinishedRate,");
                strBuilder.Append("   StudyRate AS StudyRate");
                strBuilder.Append(" from RH_Temp_BasicData_TrainingSub");
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
        /// <returns type="Temp_BasicData_TrainingSubEntity"></returns>
        private Temp_BasicData_TrainingSubEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return Temp_BasicData_TrainingSubMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}