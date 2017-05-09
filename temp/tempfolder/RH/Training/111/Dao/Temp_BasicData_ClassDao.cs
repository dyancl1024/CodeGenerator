using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Temp_BasicData_Class ( RH_Temp_BasicData_Class ) Dao类
    ///</summary>
    public class Temp_BasicData_ClassDao
    {

        /// <summary>
        /// 添加
        /// RH_Temp_BasicData_Class : RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_ClassEntity" type="Temp_BasicData_ClassEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, Temp_BasicData_ClassEntity paramTemp_BasicData_ClassEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Temp_BasicData_Class");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    ClassID,");
                strBuilder.Append("    YX_HW,");
                strBuilder.Append("    TJ_HW,");
                strBuilder.Append("    StudyNum,");
                strBuilder.Append("    FinishedNum,");
                strBuilder.Append("    UserNum,");
                strBuilder.Append("    ClassRate,");
                strBuilder.Append("    HG_HW,");
                strBuilder.Append("    No_Num");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @ClassID,");
                strBuilder.Append("    @YX_HW,");
                strBuilder.Append("    @TJ_HW,");
                strBuilder.Append("    @StudyNum,");
                strBuilder.Append("    @FinishedNum,");
                strBuilder.Append("    @UserNum,");
                strBuilder.Append("    @ClassRate,");
                strBuilder.Append("    @HG_HW,");
                strBuilder.Append("    @No_Num");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_ClassEntity.ID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTemp_BasicData_ClassEntity.SubTID);

                ///ClassID : int ClassID
                m_sqlCmd.Parameters.AddWithValue("@ClassID",paramTemp_BasicData_ClassEntity.ClassID);

                ///优秀作业数量 : int YX_HW
                m_sqlCmd.Parameters.AddWithValue("@YX_HW",paramTemp_BasicData_ClassEntity.YX_HW);

                ///提交作业数量 : int TJ_HW
                m_sqlCmd.Parameters.AddWithValue("@TJ_HW",paramTemp_BasicData_ClassEntity.TJ_HW);

                ///学习人数 : int StudyNum
                m_sqlCmd.Parameters.AddWithValue("@StudyNum",paramTemp_BasicData_ClassEntity.StudyNum);

                ///合格的人数 : int FinishedNum
                m_sqlCmd.Parameters.AddWithValue("@FinishedNum",paramTemp_BasicData_ClassEntity.FinishedNum);

                ///班级人数 : int UserNum
                m_sqlCmd.Parameters.AddWithValue("@UserNum",paramTemp_BasicData_ClassEntity.UserNum);

                ///班级合格率 : decimal(7,3) ClassRate
                m_sqlCmd.Parameters.AddWithValue("@ClassRate",paramTemp_BasicData_ClassEntity.ClassRate);

                ///合格作业数量（审批状态为合格和优秀） : int HG_HW
                m_sqlCmd.Parameters.AddWithValue("@HG_HW",paramTemp_BasicData_ClassEntity.HG_HW);

                ///未审批作业数 : int No_Num
                m_sqlCmd.Parameters.AddWithValue("@No_Num",paramTemp_BasicData_ClassEntity.No_Num);

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
        /// RH_Temp_BasicData_Class : RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_ClassEntity" type="Temp_BasicData_ClassEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, Temp_BasicData_ClassEntity paramTemp_BasicData_ClassEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Temp_BasicData_Class");
                strBuilder.Append("  set ");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    ClassID=@ClassID,");
                strBuilder.Append("    YX_HW=@YX_HW,");
                strBuilder.Append("    TJ_HW=@TJ_HW,");
                strBuilder.Append("    StudyNum=@StudyNum,");
                strBuilder.Append("    FinishedNum=@FinishedNum,");
                strBuilder.Append("    UserNum=@UserNum,");
                strBuilder.Append("    ClassRate=@ClassRate,");
                strBuilder.Append("    HG_HW=@HG_HW,");
                strBuilder.Append("    No_Num=@No_Num");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_ClassEntity.ID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTemp_BasicData_ClassEntity.SubTID);

                ///ClassID : int ClassID
                m_sqlCmd.Parameters.AddWithValue("@ClassID",paramTemp_BasicData_ClassEntity.ClassID);

                ///优秀作业数量 : int YX_HW
                m_sqlCmd.Parameters.AddWithValue("@YX_HW",paramTemp_BasicData_ClassEntity.YX_HW);

                ///提交作业数量 : int TJ_HW
                m_sqlCmd.Parameters.AddWithValue("@TJ_HW",paramTemp_BasicData_ClassEntity.TJ_HW);

                ///学习人数 : int StudyNum
                m_sqlCmd.Parameters.AddWithValue("@StudyNum",paramTemp_BasicData_ClassEntity.StudyNum);

                ///合格的人数 : int FinishedNum
                m_sqlCmd.Parameters.AddWithValue("@FinishedNum",paramTemp_BasicData_ClassEntity.FinishedNum);

                ///班级人数 : int UserNum
                m_sqlCmd.Parameters.AddWithValue("@UserNum",paramTemp_BasicData_ClassEntity.UserNum);

                ///班级合格率 : decimal(7,3) ClassRate
                m_sqlCmd.Parameters.AddWithValue("@ClassRate",paramTemp_BasicData_ClassEntity.ClassRate);

                ///合格作业数量（审批状态为合格和优秀） : int HG_HW
                m_sqlCmd.Parameters.AddWithValue("@HG_HW",paramTemp_BasicData_ClassEntity.HG_HW);

                ///未审批作业数 : int No_Num
                m_sqlCmd.Parameters.AddWithValue("@No_Num",paramTemp_BasicData_ClassEntity.No_Num);

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
        /// RH_Temp_BasicData_Class : RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_ClassEntity" type="Temp_BasicData_ClassEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, Temp_BasicData_ClassEntity paramTemp_BasicData_ClassEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Temp_BasicData_Class");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_ClassEntity.ID);

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
        /// RH_Temp_BasicData_Class : RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_ClassEntity" type="Temp_BasicData_ClassEntity"></param>
        /// <returns type="Temp_BasicData_ClassEntity"></returns>
        public Temp_BasicData_ClassEntity SelectByPK(Object paramConnectionEntity, Temp_BasicData_ClassEntity paramTemp_BasicData_ClassEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            Temp_BasicData_ClassEntity temp_BasicData_ClassEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   ClassID AS ClassID,");
                strBuilder.Append("   YX_HW AS YX_HW,");
                strBuilder.Append("   TJ_HW AS TJ_HW,");
                strBuilder.Append("   StudyNum AS StudyNum,");
                strBuilder.Append("   FinishedNum AS FinishedNum,");
                strBuilder.Append("   UserNum AS UserNum,");
                strBuilder.Append("   ClassRate AS ClassRate,");
                strBuilder.Append("   HG_HW AS HG_HW,");
                strBuilder.Append("   No_Num AS No_Num");
                strBuilder.Append(" from RH_Temp_BasicData_Class");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_ClassEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        temp_BasicData_ClassEntity = ParseDataRowToEntity(dataRows[0]);
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

            return temp_BasicData_ClassEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Temp_BasicData_Class : RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_ClassEntity" type="Temp_BasicData_ClassEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTemp_BasicData_ClassByForeignKeys(Object paramConnectionEntity, Temp_BasicData_ClassEntity paramTemp_BasicData_ClassEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable temp_BasicData_ClassEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   ClassID AS ClassID,");
                strBuilder.Append("   YX_HW AS YX_HW,");
                strBuilder.Append("   TJ_HW AS TJ_HW,");
                strBuilder.Append("   StudyNum AS StudyNum,");
                strBuilder.Append("   FinishedNum AS FinishedNum,");
                strBuilder.Append("   UserNum AS UserNum,");
                strBuilder.Append("   ClassRate AS ClassRate,");
                strBuilder.Append("   HG_HW AS HG_HW,");
                strBuilder.Append("   No_Num AS No_Num");
                strBuilder.Append(" from RH_Temp_BasicData_Class");
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
        /// <returns type="Temp_BasicData_ClassEntity"></returns>
        private Temp_BasicData_ClassEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return Temp_BasicData_ClassMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}