using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Temp_BasicData_User ( RH_Temp_BasicData_User ) Dao类
    ///</summary>
    public class Temp_BasicData_UserDao
    {

        /// <summary>
        /// 添加
        /// RH_Temp_BasicData_User : RH_Temp_BasicData_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_UserEntity" type="Temp_BasicData_UserEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, Temp_BasicData_UserEntity paramTemp_BasicData_UserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Temp_BasicData_User");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    ClassID,");
                strBuilder.Append("    UserID,");
                strBuilder.Append("    Phase,");
                strBuilder.Append("    Q_jxfs,");
                strBuilder.Append("    T_jxfs,");
                strBuilder.Append("    F_jxfs,");
                strBuilder.Append("    E_jxfs,");
                strBuilder.Append("    Q_jxcl,");
                strBuilder.Append("    T_jxcl,");
                strBuilder.Append("    F_jxcl,");
                strBuilder.Append("    E_jxcl,");
                strBuilder.Append("    Q_xxxd,");
                strBuilder.Append("    T_xxxd,");
                strBuilder.Append("    F_xxxd,");
                strBuilder.Append("    E_xxxd,");
                strBuilder.Append("    Q_wtfx,");
                strBuilder.Append("    T_wtfx,");
                strBuilder.Append("    F_wtfx,");
                strBuilder.Append("    E_wtfx,");
                strBuilder.Append("    Q_yxrz,");
                strBuilder.Append("    T_yxrz,");
                strBuilder.Append("    F_yxrz,");
                strBuilder.Append("    E_yxrz,");
                strBuilder.Append("    Q_pxzj,");
                strBuilder.Append("    T_pxzj,");
                strBuilder.Append("    F_pxzj,");
                strBuilder.Append("    E_pxzj,");
                strBuilder.Append("    Finished,");
                strBuilder.Append("    GetCoursePhase,");
                strBuilder.Append("    CoursePhase,");
                strBuilder.Append("    StatusName,");
                strBuilder.Append("    IsStudy,");
                strBuilder.Append("    HomeWorkPhase");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @ClassID,");
                strBuilder.Append("    @UserID,");
                strBuilder.Append("    @Phase,");
                strBuilder.Append("    @Q_jxfs,");
                strBuilder.Append("    @T_jxfs,");
                strBuilder.Append("    @F_jxfs,");
                strBuilder.Append("    @E_jxfs,");
                strBuilder.Append("    @Q_jxcl,");
                strBuilder.Append("    @T_jxcl,");
                strBuilder.Append("    @F_jxcl,");
                strBuilder.Append("    @E_jxcl,");
                strBuilder.Append("    @Q_xxxd,");
                strBuilder.Append("    @T_xxxd,");
                strBuilder.Append("    @F_xxxd,");
                strBuilder.Append("    @E_xxxd,");
                strBuilder.Append("    @Q_wtfx,");
                strBuilder.Append("    @T_wtfx,");
                strBuilder.Append("    @F_wtfx,");
                strBuilder.Append("    @E_wtfx,");
                strBuilder.Append("    @Q_yxrz,");
                strBuilder.Append("    @T_yxrz,");
                strBuilder.Append("    @F_yxrz,");
                strBuilder.Append("    @E_yxrz,");
                strBuilder.Append("    @Q_pxzj,");
                strBuilder.Append("    @T_pxzj,");
                strBuilder.Append("    @F_pxzj,");
                strBuilder.Append("    @E_pxzj,");
                strBuilder.Append("    @Finished,");
                strBuilder.Append("    @GetCoursePhase,");
                strBuilder.Append("    @CoursePhase,");
                strBuilder.Append("    @StatusName,");
                strBuilder.Append("    @IsStudy,");
                strBuilder.Append("    @HomeWorkPhase");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_UserEntity.ID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTemp_BasicData_UserEntity.SubTID);

                ///ClassID : int ClassID
                m_sqlCmd.Parameters.AddWithValue("@ClassID",paramTemp_BasicData_UserEntity.ClassID);

                ///UserID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTemp_BasicData_UserEntity.UserID);

                ///获得作业学时 : int Phase
                m_sqlCmd.Parameters.AddWithValue("@Phase",paramTemp_BasicData_UserEntity.Phase);

                ///Q_jxfs : int Q_jxfs
                m_sqlCmd.Parameters.AddWithValue("@Q_jxfs",paramTemp_BasicData_UserEntity.Q_jxfs);

                ///T_jxfs : int T_jxfs
                m_sqlCmd.Parameters.AddWithValue("@T_jxfs",paramTemp_BasicData_UserEntity.T_jxfs);

                ///F_jxfs : int F_jxfs
                m_sqlCmd.Parameters.AddWithValue("@F_jxfs",paramTemp_BasicData_UserEntity.F_jxfs);

                ///E_jxfs : int E_jxfs
                m_sqlCmd.Parameters.AddWithValue("@E_jxfs",paramTemp_BasicData_UserEntity.E_jxfs);

                ///Q_jxcl : int Q_jxcl
                m_sqlCmd.Parameters.AddWithValue("@Q_jxcl",paramTemp_BasicData_UserEntity.Q_jxcl);

                ///T_jxcl : int T_jxcl
                m_sqlCmd.Parameters.AddWithValue("@T_jxcl",paramTemp_BasicData_UserEntity.T_jxcl);

                ///F_jxcl : int F_jxcl
                m_sqlCmd.Parameters.AddWithValue("@F_jxcl",paramTemp_BasicData_UserEntity.F_jxcl);

                ///E_jxcl : int E_jxcl
                m_sqlCmd.Parameters.AddWithValue("@E_jxcl",paramTemp_BasicData_UserEntity.E_jxcl);

                ///Q_xxxd : int Q_xxxd
                m_sqlCmd.Parameters.AddWithValue("@Q_xxxd",paramTemp_BasicData_UserEntity.Q_xxxd);

                ///T_xxxd : int T_xxxd
                m_sqlCmd.Parameters.AddWithValue("@T_xxxd",paramTemp_BasicData_UserEntity.T_xxxd);

                ///F_xxxd : int F_xxxd
                m_sqlCmd.Parameters.AddWithValue("@F_xxxd",paramTemp_BasicData_UserEntity.F_xxxd);

                ///E_xxxd : int E_xxxd
                m_sqlCmd.Parameters.AddWithValue("@E_xxxd",paramTemp_BasicData_UserEntity.E_xxxd);

                ///Q_wtfx : int Q_wtfx
                m_sqlCmd.Parameters.AddWithValue("@Q_wtfx",paramTemp_BasicData_UserEntity.Q_wtfx);

                ///T_wtfx : int T_wtfx
                m_sqlCmd.Parameters.AddWithValue("@T_wtfx",paramTemp_BasicData_UserEntity.T_wtfx);

                ///F_wtfx : int F_wtfx
                m_sqlCmd.Parameters.AddWithValue("@F_wtfx",paramTemp_BasicData_UserEntity.F_wtfx);

                ///E_wtfx : int E_wtfx
                m_sqlCmd.Parameters.AddWithValue("@E_wtfx",paramTemp_BasicData_UserEntity.E_wtfx);

                ///Q_yxrz : int Q_yxrz
                m_sqlCmd.Parameters.AddWithValue("@Q_yxrz",paramTemp_BasicData_UserEntity.Q_yxrz);

                ///T_yxrz : int T_yxrz
                m_sqlCmd.Parameters.AddWithValue("@T_yxrz",paramTemp_BasicData_UserEntity.T_yxrz);

                ///F_yxrz : int F_yxrz
                m_sqlCmd.Parameters.AddWithValue("@F_yxrz",paramTemp_BasicData_UserEntity.F_yxrz);

                ///E_yxrz : int E_yxrz
                m_sqlCmd.Parameters.AddWithValue("@E_yxrz",paramTemp_BasicData_UserEntity.E_yxrz);

                ///Q_pxzj : int Q_pxzj
                m_sqlCmd.Parameters.AddWithValue("@Q_pxzj",paramTemp_BasicData_UserEntity.Q_pxzj);

                ///T_pxzj : int T_pxzj
                m_sqlCmd.Parameters.AddWithValue("@T_pxzj",paramTemp_BasicData_UserEntity.T_pxzj);

                ///F_pxzj : int F_pxzj
                m_sqlCmd.Parameters.AddWithValue("@F_pxzj",paramTemp_BasicData_UserEntity.F_pxzj);

                ///E_pxzj : int E_pxzj
                m_sqlCmd.Parameters.AddWithValue("@E_pxzj",paramTemp_BasicData_UserEntity.E_pxzj);

                ///作业是否完成 : int Finished
                m_sqlCmd.Parameters.AddWithValue("@Finished",paramTemp_BasicData_UserEntity.Finished);

                ///获得课程学时 : int GetCoursePhase
                m_sqlCmd.Parameters.AddWithValue("@GetCoursePhase",paramTemp_BasicData_UserEntity.GetCoursePhase);

                ///课程总学时 : int CoursePhase
                m_sqlCmd.Parameters.AddWithValue("@CoursePhase",paramTemp_BasicData_UserEntity.CoursePhase);

                ///培训状态 : nvarchar(10) StatusName
                if (paramTemp_BasicData_UserEntity.StatusName != null && "".Equals(paramTemp_BasicData_UserEntity.StatusName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StatusName", paramTemp_BasicData_UserEntity.StatusName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StatusName", DBNull.Value);
                }

                ///是否学习 : int IsStudy
                m_sqlCmd.Parameters.AddWithValue("@IsStudy",paramTemp_BasicData_UserEntity.IsStudy);

                ///作业总学时 : int HomeWorkPhase
                m_sqlCmd.Parameters.AddWithValue("@HomeWorkPhase",paramTemp_BasicData_UserEntity.HomeWorkPhase);

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
        /// RH_Temp_BasicData_User : RH_Temp_BasicData_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_UserEntity" type="Temp_BasicData_UserEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, Temp_BasicData_UserEntity paramTemp_BasicData_UserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Temp_BasicData_User");
                strBuilder.Append("  set ");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    ClassID=@ClassID,");
                strBuilder.Append("    UserID=@UserID,");
                strBuilder.Append("    Phase=@Phase,");
                strBuilder.Append("    Q_jxfs=@Q_jxfs,");
                strBuilder.Append("    T_jxfs=@T_jxfs,");
                strBuilder.Append("    F_jxfs=@F_jxfs,");
                strBuilder.Append("    E_jxfs=@E_jxfs,");
                strBuilder.Append("    Q_jxcl=@Q_jxcl,");
                strBuilder.Append("    T_jxcl=@T_jxcl,");
                strBuilder.Append("    F_jxcl=@F_jxcl,");
                strBuilder.Append("    E_jxcl=@E_jxcl,");
                strBuilder.Append("    Q_xxxd=@Q_xxxd,");
                strBuilder.Append("    T_xxxd=@T_xxxd,");
                strBuilder.Append("    F_xxxd=@F_xxxd,");
                strBuilder.Append("    E_xxxd=@E_xxxd,");
                strBuilder.Append("    Q_wtfx=@Q_wtfx,");
                strBuilder.Append("    T_wtfx=@T_wtfx,");
                strBuilder.Append("    F_wtfx=@F_wtfx,");
                strBuilder.Append("    E_wtfx=@E_wtfx,");
                strBuilder.Append("    Q_yxrz=@Q_yxrz,");
                strBuilder.Append("    T_yxrz=@T_yxrz,");
                strBuilder.Append("    F_yxrz=@F_yxrz,");
                strBuilder.Append("    E_yxrz=@E_yxrz,");
                strBuilder.Append("    Q_pxzj=@Q_pxzj,");
                strBuilder.Append("    T_pxzj=@T_pxzj,");
                strBuilder.Append("    F_pxzj=@F_pxzj,");
                strBuilder.Append("    E_pxzj=@E_pxzj,");
                strBuilder.Append("    Finished=@Finished,");
                strBuilder.Append("    GetCoursePhase=@GetCoursePhase,");
                strBuilder.Append("    CoursePhase=@CoursePhase,");
                strBuilder.Append("    StatusName=@StatusName,");
                strBuilder.Append("    IsStudy=@IsStudy,");
                strBuilder.Append("    HomeWorkPhase=@HomeWorkPhase");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_UserEntity.ID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTemp_BasicData_UserEntity.SubTID);

                ///ClassID : int ClassID
                m_sqlCmd.Parameters.AddWithValue("@ClassID",paramTemp_BasicData_UserEntity.ClassID);

                ///UserID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTemp_BasicData_UserEntity.UserID);

                ///获得作业学时 : int Phase
                m_sqlCmd.Parameters.AddWithValue("@Phase",paramTemp_BasicData_UserEntity.Phase);

                ///Q_jxfs : int Q_jxfs
                m_sqlCmd.Parameters.AddWithValue("@Q_jxfs",paramTemp_BasicData_UserEntity.Q_jxfs);

                ///T_jxfs : int T_jxfs
                m_sqlCmd.Parameters.AddWithValue("@T_jxfs",paramTemp_BasicData_UserEntity.T_jxfs);

                ///F_jxfs : int F_jxfs
                m_sqlCmd.Parameters.AddWithValue("@F_jxfs",paramTemp_BasicData_UserEntity.F_jxfs);

                ///E_jxfs : int E_jxfs
                m_sqlCmd.Parameters.AddWithValue("@E_jxfs",paramTemp_BasicData_UserEntity.E_jxfs);

                ///Q_jxcl : int Q_jxcl
                m_sqlCmd.Parameters.AddWithValue("@Q_jxcl",paramTemp_BasicData_UserEntity.Q_jxcl);

                ///T_jxcl : int T_jxcl
                m_sqlCmd.Parameters.AddWithValue("@T_jxcl",paramTemp_BasicData_UserEntity.T_jxcl);

                ///F_jxcl : int F_jxcl
                m_sqlCmd.Parameters.AddWithValue("@F_jxcl",paramTemp_BasicData_UserEntity.F_jxcl);

                ///E_jxcl : int E_jxcl
                m_sqlCmd.Parameters.AddWithValue("@E_jxcl",paramTemp_BasicData_UserEntity.E_jxcl);

                ///Q_xxxd : int Q_xxxd
                m_sqlCmd.Parameters.AddWithValue("@Q_xxxd",paramTemp_BasicData_UserEntity.Q_xxxd);

                ///T_xxxd : int T_xxxd
                m_sqlCmd.Parameters.AddWithValue("@T_xxxd",paramTemp_BasicData_UserEntity.T_xxxd);

                ///F_xxxd : int F_xxxd
                m_sqlCmd.Parameters.AddWithValue("@F_xxxd",paramTemp_BasicData_UserEntity.F_xxxd);

                ///E_xxxd : int E_xxxd
                m_sqlCmd.Parameters.AddWithValue("@E_xxxd",paramTemp_BasicData_UserEntity.E_xxxd);

                ///Q_wtfx : int Q_wtfx
                m_sqlCmd.Parameters.AddWithValue("@Q_wtfx",paramTemp_BasicData_UserEntity.Q_wtfx);

                ///T_wtfx : int T_wtfx
                m_sqlCmd.Parameters.AddWithValue("@T_wtfx",paramTemp_BasicData_UserEntity.T_wtfx);

                ///F_wtfx : int F_wtfx
                m_sqlCmd.Parameters.AddWithValue("@F_wtfx",paramTemp_BasicData_UserEntity.F_wtfx);

                ///E_wtfx : int E_wtfx
                m_sqlCmd.Parameters.AddWithValue("@E_wtfx",paramTemp_BasicData_UserEntity.E_wtfx);

                ///Q_yxrz : int Q_yxrz
                m_sqlCmd.Parameters.AddWithValue("@Q_yxrz",paramTemp_BasicData_UserEntity.Q_yxrz);

                ///T_yxrz : int T_yxrz
                m_sqlCmd.Parameters.AddWithValue("@T_yxrz",paramTemp_BasicData_UserEntity.T_yxrz);

                ///F_yxrz : int F_yxrz
                m_sqlCmd.Parameters.AddWithValue("@F_yxrz",paramTemp_BasicData_UserEntity.F_yxrz);

                ///E_yxrz : int E_yxrz
                m_sqlCmd.Parameters.AddWithValue("@E_yxrz",paramTemp_BasicData_UserEntity.E_yxrz);

                ///Q_pxzj : int Q_pxzj
                m_sqlCmd.Parameters.AddWithValue("@Q_pxzj",paramTemp_BasicData_UserEntity.Q_pxzj);

                ///T_pxzj : int T_pxzj
                m_sqlCmd.Parameters.AddWithValue("@T_pxzj",paramTemp_BasicData_UserEntity.T_pxzj);

                ///F_pxzj : int F_pxzj
                m_sqlCmd.Parameters.AddWithValue("@F_pxzj",paramTemp_BasicData_UserEntity.F_pxzj);

                ///E_pxzj : int E_pxzj
                m_sqlCmd.Parameters.AddWithValue("@E_pxzj",paramTemp_BasicData_UserEntity.E_pxzj);

                ///作业是否完成 : int Finished
                m_sqlCmd.Parameters.AddWithValue("@Finished",paramTemp_BasicData_UserEntity.Finished);

                ///获得课程学时 : int GetCoursePhase
                m_sqlCmd.Parameters.AddWithValue("@GetCoursePhase",paramTemp_BasicData_UserEntity.GetCoursePhase);

                ///课程总学时 : int CoursePhase
                m_sqlCmd.Parameters.AddWithValue("@CoursePhase",paramTemp_BasicData_UserEntity.CoursePhase);

                ///培训状态 : nvarchar(10) StatusName
                if (paramTemp_BasicData_UserEntity.StatusName != null && "".Equals(paramTemp_BasicData_UserEntity.StatusName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StatusName", paramTemp_BasicData_UserEntity.StatusName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StatusName", DBNull.Value);
                }

                ///是否学习 : int IsStudy
                m_sqlCmd.Parameters.AddWithValue("@IsStudy",paramTemp_BasicData_UserEntity.IsStudy);

                ///作业总学时 : int HomeWorkPhase
                m_sqlCmd.Parameters.AddWithValue("@HomeWorkPhase",paramTemp_BasicData_UserEntity.HomeWorkPhase);

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
        /// RH_Temp_BasicData_User : RH_Temp_BasicData_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_UserEntity" type="Temp_BasicData_UserEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, Temp_BasicData_UserEntity paramTemp_BasicData_UserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Temp_BasicData_User");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_UserEntity.ID);

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
        /// RH_Temp_BasicData_User : RH_Temp_BasicData_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_UserEntity" type="Temp_BasicData_UserEntity"></param>
        /// <returns type="Temp_BasicData_UserEntity"></returns>
        public Temp_BasicData_UserEntity SelectByPK(Object paramConnectionEntity, Temp_BasicData_UserEntity paramTemp_BasicData_UserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            Temp_BasicData_UserEntity temp_BasicData_UserEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   ClassID AS ClassID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   Phase AS Phase,");
                strBuilder.Append("   Q_jxfs AS Q_jxfs,");
                strBuilder.Append("   T_jxfs AS T_jxfs,");
                strBuilder.Append("   F_jxfs AS F_jxfs,");
                strBuilder.Append("   E_jxfs AS E_jxfs,");
                strBuilder.Append("   Q_jxcl AS Q_jxcl,");
                strBuilder.Append("   T_jxcl AS T_jxcl,");
                strBuilder.Append("   F_jxcl AS F_jxcl,");
                strBuilder.Append("   E_jxcl AS E_jxcl,");
                strBuilder.Append("   Q_xxxd AS Q_xxxd,");
                strBuilder.Append("   T_xxxd AS T_xxxd,");
                strBuilder.Append("   F_xxxd AS F_xxxd,");
                strBuilder.Append("   E_xxxd AS E_xxxd,");
                strBuilder.Append("   Q_wtfx AS Q_wtfx,");
                strBuilder.Append("   T_wtfx AS T_wtfx,");
                strBuilder.Append("   F_wtfx AS F_wtfx,");
                strBuilder.Append("   E_wtfx AS E_wtfx,");
                strBuilder.Append("   Q_yxrz AS Q_yxrz,");
                strBuilder.Append("   T_yxrz AS T_yxrz,");
                strBuilder.Append("   F_yxrz AS F_yxrz,");
                strBuilder.Append("   E_yxrz AS E_yxrz,");
                strBuilder.Append("   Q_pxzj AS Q_pxzj,");
                strBuilder.Append("   T_pxzj AS T_pxzj,");
                strBuilder.Append("   F_pxzj AS F_pxzj,");
                strBuilder.Append("   E_pxzj AS E_pxzj,");
                strBuilder.Append("   Finished AS Finished,");
                strBuilder.Append("   GetCoursePhase AS GetCoursePhase,");
                strBuilder.Append("   CoursePhase AS CoursePhase,");
                strBuilder.Append("   StatusName AS StatusName,");
                strBuilder.Append("   IsStudy AS IsStudy,");
                strBuilder.Append("   HomeWorkPhase AS HomeWorkPhase");
                strBuilder.Append(" from RH_Temp_BasicData_User");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTemp_BasicData_UserEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        temp_BasicData_UserEntity = ParseDataRowToEntity(dataRows[0]);
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

            return temp_BasicData_UserEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Temp_BasicData_User : RH_Temp_BasicData_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_UserEntity" type="Temp_BasicData_UserEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTemp_BasicData_UserByForeignKeys(Object paramConnectionEntity, Temp_BasicData_UserEntity paramTemp_BasicData_UserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable temp_BasicData_UserEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   ClassID AS ClassID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   Phase AS Phase,");
                strBuilder.Append("   Q_jxfs AS Q_jxfs,");
                strBuilder.Append("   T_jxfs AS T_jxfs,");
                strBuilder.Append("   F_jxfs AS F_jxfs,");
                strBuilder.Append("   E_jxfs AS E_jxfs,");
                strBuilder.Append("   Q_jxcl AS Q_jxcl,");
                strBuilder.Append("   T_jxcl AS T_jxcl,");
                strBuilder.Append("   F_jxcl AS F_jxcl,");
                strBuilder.Append("   E_jxcl AS E_jxcl,");
                strBuilder.Append("   Q_xxxd AS Q_xxxd,");
                strBuilder.Append("   T_xxxd AS T_xxxd,");
                strBuilder.Append("   F_xxxd AS F_xxxd,");
                strBuilder.Append("   E_xxxd AS E_xxxd,");
                strBuilder.Append("   Q_wtfx AS Q_wtfx,");
                strBuilder.Append("   T_wtfx AS T_wtfx,");
                strBuilder.Append("   F_wtfx AS F_wtfx,");
                strBuilder.Append("   E_wtfx AS E_wtfx,");
                strBuilder.Append("   Q_yxrz AS Q_yxrz,");
                strBuilder.Append("   T_yxrz AS T_yxrz,");
                strBuilder.Append("   F_yxrz AS F_yxrz,");
                strBuilder.Append("   E_yxrz AS E_yxrz,");
                strBuilder.Append("   Q_pxzj AS Q_pxzj,");
                strBuilder.Append("   T_pxzj AS T_pxzj,");
                strBuilder.Append("   F_pxzj AS F_pxzj,");
                strBuilder.Append("   E_pxzj AS E_pxzj,");
                strBuilder.Append("   Finished AS Finished,");
                strBuilder.Append("   GetCoursePhase AS GetCoursePhase,");
                strBuilder.Append("   CoursePhase AS CoursePhase,");
                strBuilder.Append("   StatusName AS StatusName,");
                strBuilder.Append("   IsStudy AS IsStudy,");
                strBuilder.Append("   HomeWorkPhase AS HomeWorkPhase");
                strBuilder.Append(" from RH_Temp_BasicData_User");
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
        /// <returns type="Temp_BasicData_UserEntity"></returns>
        private Temp_BasicData_UserEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return Temp_BasicData_UserMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}