using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Course ( RH_Course ) Dao类
    ///</summary>
    public class CourseDao
    {

        /// <summary>
        /// 添加
        /// RH_Course : RH_Course
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseEntity" type="CourseEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, CourseEntity paramCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Course");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    CourseName,");
                strBuilder.Append("    CoursePharse,");
                strBuilder.Append("    CourseCategoryCode,");
                strBuilder.Append("    CourseDesc,");
                strBuilder.Append("    CourseUrl,");
                strBuilder.Append("    TeacherDesc,");
                strBuilder.Append("    TeacherName,");
                strBuilder.Append("    TeacherTitle,");
                strBuilder.Append("    CourseLabel,");
                strBuilder.Append("    CourseCode,");
                strBuilder.Append("    IsPractice,");
                strBuilder.Append("    CourseCompany,");
                strBuilder.Append("    CourseStyle,");
                strBuilder.Append("    IsSpecialTeacher,");
                strBuilder.Append("    VideoDuration,");
                strBuilder.Append("    IsApp,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @CourseName,");
                strBuilder.Append("    @CoursePharse,");
                strBuilder.Append("    @CourseCategoryCode,");
                strBuilder.Append("    @CourseDesc,");
                strBuilder.Append("    @CourseUrl,");
                strBuilder.Append("    @TeacherDesc,");
                strBuilder.Append("    @TeacherName,");
                strBuilder.Append("    @TeacherTitle,");
                strBuilder.Append("    @CourseLabel,");
                strBuilder.Append("    @CourseCode,");
                strBuilder.Append("    @IsPractice,");
                strBuilder.Append("    @CourseCompany,");
                strBuilder.Append("    @CourseStyle,");
                strBuilder.Append("    @IsSpecialTeacher,");
                strBuilder.Append("    @VideoDuration,");
                strBuilder.Append("    @IsApp,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseEntity.ID);

                ///课程名称 : nvarchar(200) CourseName
                if (paramCourseEntity.CourseName != null && "".Equals(paramCourseEntity.CourseName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseName", paramCourseEntity.CourseName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseName", DBNull.Value);
                }

                ///课程学时 : int CoursePharse
                m_sqlCmd.Parameters.AddWithValue("@CoursePharse",paramCourseEntity.CoursePharse);

                ///1-通识 2-专业 3-技术 4-科研 5-教研 : varchar(50) CourseCategoryCode
                if (paramCourseEntity.CourseCategoryCode != null && "".Equals(paramCourseEntity.CourseCategoryCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCategoryCode", paramCourseEntity.CourseCategoryCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCategoryCode", DBNull.Value);
                }

                ///CourseDesc : nvarchar(Max) CourseDesc
                if (paramCourseEntity.CourseDesc != null && "".Equals(paramCourseEntity.CourseDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseDesc", paramCourseEntity.CourseDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseDesc", DBNull.Value);
                }

                ///记录课程文件路径 : nvarchar(200) CourseUrl
                if (paramCourseEntity.CourseUrl != null && "".Equals(paramCourseEntity.CourseUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseUrl", paramCourseEntity.CourseUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseUrl", DBNull.Value);
                }

                ///讲师简介 : nvarchar(Max) TeacherDesc
                if (paramCourseEntity.TeacherDesc != null && "".Equals(paramCourseEntity.TeacherDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherDesc", paramCourseEntity.TeacherDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherDesc", DBNull.Value);
                }

                ///讲师姓名 : nvarchar(200) TeacherName
                if (paramCourseEntity.TeacherName != null && "".Equals(paramCourseEntity.TeacherName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherName", paramCourseEntity.TeacherName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherName", DBNull.Value);
                }

                ///讲师职称 : nvarchar(200) TeacherTitle
                if (paramCourseEntity.TeacherTitle != null && "".Equals(paramCourseEntity.TeacherTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherTitle", paramCourseEntity.TeacherTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherTitle", DBNull.Value);
                }

                ///课程标签 : nvarchar(50) CourseLabel
                if (paramCourseEntity.CourseLabel != null && "".Equals(paramCourseEntity.CourseLabel.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseLabel", paramCourseEntity.CourseLabel);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseLabel", DBNull.Value);
                }

                ///课程代码 : nvarchar(50) CourseCode
                if (paramCourseEntity.CourseCode != null && "".Equals(paramCourseEntity.CourseCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCode", paramCourseEntity.CourseCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCode", DBNull.Value);
                }

                ///是否为实践性课程：1.是 2.否 : int IsPractice
                m_sqlCmd.Parameters.AddWithValue("@IsPractice",paramCourseEntity.IsPractice);

                ///课程单位 : nvarchar(200) CourseCompany
                if (paramCourseEntity.CourseCompany != null && "".Equals(paramCourseEntity.CourseCompany.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCompany", paramCourseEntity.CourseCompany);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCompany", DBNull.Value);
                }

                ///课程形式 : nvarchar(200) CourseStyle
                if (paramCourseEntity.CourseStyle != null && "".Equals(paramCourseEntity.CourseStyle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseStyle", paramCourseEntity.CourseStyle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseStyle", DBNull.Value);
                }

                ///是否为一线教师教研员：1.是 2.否 : int IsSpecialTeacher
                m_sqlCmd.Parameters.AddWithValue("@IsSpecialTeacher",paramCourseEntity.IsSpecialTeacher);

                ///学习时长 : int VideoDuration
                m_sqlCmd.Parameters.AddWithValue("@VideoDuration",paramCourseEntity.VideoDuration);

                ///是否App： 1.是2.否 : int IsApp
                m_sqlCmd.Parameters.AddWithValue("@IsApp",paramCourseEntity.IsApp);

                ///状态 1-未发布 2-已发布 3-删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramCourseEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramCourseEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramCourseEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramCourseEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramCourseEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramCourseEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramCourseEntity.UpdateTime);
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
        /// RH_Course : RH_Course
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseEntity" type="CourseEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, CourseEntity paramCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Course");
                strBuilder.Append("  set ");
                strBuilder.Append("    CourseName=@CourseName,");
                strBuilder.Append("    CoursePharse=@CoursePharse,");
                strBuilder.Append("    CourseCategoryCode=@CourseCategoryCode,");
                strBuilder.Append("    CourseDesc=@CourseDesc,");
                strBuilder.Append("    CourseUrl=@CourseUrl,");
                strBuilder.Append("    TeacherDesc=@TeacherDesc,");
                strBuilder.Append("    TeacherName=@TeacherName,");
                strBuilder.Append("    TeacherTitle=@TeacherTitle,");
                strBuilder.Append("    CourseLabel=@CourseLabel,");
                strBuilder.Append("    CourseCode=@CourseCode,");
                strBuilder.Append("    IsPractice=@IsPractice,");
                strBuilder.Append("    CourseCompany=@CourseCompany,");
                strBuilder.Append("    CourseStyle=@CourseStyle,");
                strBuilder.Append("    IsSpecialTeacher=@IsSpecialTeacher,");
                strBuilder.Append("    VideoDuration=@VideoDuration,");
                strBuilder.Append("    IsApp=@IsApp,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseEntity.ID);

                ///课程名称 : nvarchar(200) CourseName
                if (paramCourseEntity.CourseName != null && "".Equals(paramCourseEntity.CourseName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseName", paramCourseEntity.CourseName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseName", DBNull.Value);
                }

                ///课程学时 : int CoursePharse
                m_sqlCmd.Parameters.AddWithValue("@CoursePharse",paramCourseEntity.CoursePharse);

                ///1-通识 2-专业 3-技术 4-科研 5-教研 : varchar(50) CourseCategoryCode
                if (paramCourseEntity.CourseCategoryCode != null && "".Equals(paramCourseEntity.CourseCategoryCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCategoryCode", paramCourseEntity.CourseCategoryCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCategoryCode", DBNull.Value);
                }

                ///CourseDesc : nvarchar(Max) CourseDesc
                if (paramCourseEntity.CourseDesc != null && "".Equals(paramCourseEntity.CourseDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseDesc", paramCourseEntity.CourseDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseDesc", DBNull.Value);
                }

                ///记录课程文件路径 : nvarchar(200) CourseUrl
                if (paramCourseEntity.CourseUrl != null && "".Equals(paramCourseEntity.CourseUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseUrl", paramCourseEntity.CourseUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseUrl", DBNull.Value);
                }

                ///讲师简介 : nvarchar(Max) TeacherDesc
                if (paramCourseEntity.TeacherDesc != null && "".Equals(paramCourseEntity.TeacherDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherDesc", paramCourseEntity.TeacherDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherDesc", DBNull.Value);
                }

                ///讲师姓名 : nvarchar(200) TeacherName
                if (paramCourseEntity.TeacherName != null && "".Equals(paramCourseEntity.TeacherName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherName", paramCourseEntity.TeacherName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherName", DBNull.Value);
                }

                ///讲师职称 : nvarchar(200) TeacherTitle
                if (paramCourseEntity.TeacherTitle != null && "".Equals(paramCourseEntity.TeacherTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherTitle", paramCourseEntity.TeacherTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherTitle", DBNull.Value);
                }

                ///课程标签 : nvarchar(50) CourseLabel
                if (paramCourseEntity.CourseLabel != null && "".Equals(paramCourseEntity.CourseLabel.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseLabel", paramCourseEntity.CourseLabel);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseLabel", DBNull.Value);
                }

                ///课程代码 : nvarchar(50) CourseCode
                if (paramCourseEntity.CourseCode != null && "".Equals(paramCourseEntity.CourseCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCode", paramCourseEntity.CourseCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCode", DBNull.Value);
                }

                ///是否为实践性课程：1.是 2.否 : int IsPractice
                m_sqlCmd.Parameters.AddWithValue("@IsPractice",paramCourseEntity.IsPractice);

                ///课程单位 : nvarchar(200) CourseCompany
                if (paramCourseEntity.CourseCompany != null && "".Equals(paramCourseEntity.CourseCompany.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCompany", paramCourseEntity.CourseCompany);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseCompany", DBNull.Value);
                }

                ///课程形式 : nvarchar(200) CourseStyle
                if (paramCourseEntity.CourseStyle != null && "".Equals(paramCourseEntity.CourseStyle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseStyle", paramCourseEntity.CourseStyle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseStyle", DBNull.Value);
                }

                ///是否为一线教师教研员：1.是 2.否 : int IsSpecialTeacher
                m_sqlCmd.Parameters.AddWithValue("@IsSpecialTeacher",paramCourseEntity.IsSpecialTeacher);

                ///学习时长 : int VideoDuration
                m_sqlCmd.Parameters.AddWithValue("@VideoDuration",paramCourseEntity.VideoDuration);

                ///是否App： 1.是2.否 : int IsApp
                m_sqlCmd.Parameters.AddWithValue("@IsApp",paramCourseEntity.IsApp);

                ///状态 1-未发布 2-已发布 3-删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramCourseEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramCourseEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramCourseEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramCourseEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramCourseEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramCourseEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramCourseEntity.UpdateTime);
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
        /// RH_Course : RH_Course
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseEntity" type="CourseEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, CourseEntity paramCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Course");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseEntity.ID);

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
        /// RH_Course : RH_Course
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseEntity" type="CourseEntity"></param>
        /// <returns type="CourseEntity"></returns>
        public CourseEntity SelectByPK(Object paramConnectionEntity, CourseEntity paramCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            CourseEntity courseEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   CourseName AS CourseName,");
                strBuilder.Append("   CoursePharse AS CoursePharse,");
                strBuilder.Append("   CourseCategoryCode AS CourseCategoryCode,");
                strBuilder.Append("   CourseDesc AS CourseDesc,");
                strBuilder.Append("   CourseUrl AS CourseUrl,");
                strBuilder.Append("   TeacherDesc AS TeacherDesc,");
                strBuilder.Append("   TeacherName AS TeacherName,");
                strBuilder.Append("   TeacherTitle AS TeacherTitle,");
                strBuilder.Append("   CourseLabel AS CourseLabel,");
                strBuilder.Append("   CourseCode AS CourseCode,");
                strBuilder.Append("   IsPractice AS IsPractice,");
                strBuilder.Append("   CourseCompany AS CourseCompany,");
                strBuilder.Append("   CourseStyle AS CourseStyle,");
                strBuilder.Append("   IsSpecialTeacher AS IsSpecialTeacher,");
                strBuilder.Append("   VideoDuration AS VideoDuration,");
                strBuilder.Append("   IsApp AS IsApp,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_Course");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        courseEntity = ParseDataRowToEntity(dataRows[0]);
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

            return courseEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Course : RH_Course
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseEntity" type="CourseEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllCourseByForeignKeys(Object paramConnectionEntity, CourseEntity paramCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable courseEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   CourseName AS CourseName,");
                strBuilder.Append("   CoursePharse AS CoursePharse,");
                strBuilder.Append("   CourseCategoryCode AS CourseCategoryCode,");
                strBuilder.Append("   CourseDesc AS CourseDesc,");
                strBuilder.Append("   CourseUrl AS CourseUrl,");
                strBuilder.Append("   TeacherDesc AS TeacherDesc,");
                strBuilder.Append("   TeacherName AS TeacherName,");
                strBuilder.Append("   TeacherTitle AS TeacherTitle,");
                strBuilder.Append("   CourseLabel AS CourseLabel,");
                strBuilder.Append("   CourseCode AS CourseCode,");
                strBuilder.Append("   IsPractice AS IsPractice,");
                strBuilder.Append("   CourseCompany AS CourseCompany,");
                strBuilder.Append("   CourseStyle AS CourseStyle,");
                strBuilder.Append("   IsSpecialTeacher AS IsSpecialTeacher,");
                strBuilder.Append("   VideoDuration AS VideoDuration,");
                strBuilder.Append("   IsApp AS IsApp,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_Course");
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
        /// <returns type="CourseEntity"></returns>
        private CourseEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return CourseMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}