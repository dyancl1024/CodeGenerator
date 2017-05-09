using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TempUser ( RH_TempUser ) Dao类
    ///</summary>
    public class TempUserDao
    {

        /// <summary>
        /// 添加
        /// RH_TempUser : RH_TempUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempUserEntity" type="TempUserEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TempUserEntity paramTempUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TempUser");
                strBuilder.Append("  (");
                strBuilder.Append("    id,");
                strBuilder.Append("    UserName,");
                strBuilder.Append("    Password,");
                strBuilder.Append("    TrueName,");
                strBuilder.Append("    Gender,");
                strBuilder.Append("    PicUrl,");
                strBuilder.Append("    Nation,");
                strBuilder.Append("    IDNO,");
                strBuilder.Append("    ProvinceID,");
                strBuilder.Append("    CityID,");
                strBuilder.Append("    DistrictID,");
                strBuilder.Append("    Mobile,");
                strBuilder.Append("    Email,");
                strBuilder.Append("    QQ,");
                strBuilder.Append("    IPAddr,");
                strBuilder.Append("    IsChange,");
                strBuilder.Append("    UserState,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime,");
                strBuilder.Append("    CUserName,");
                strBuilder.Append("    CPassword,");
                strBuilder.Append("    GradeCode,");
                strBuilder.Append("    SubjectCode,");
                strBuilder.Append("    SchoolID,");
                strBuilder.Append("    SchoolName,");
                strBuilder.Append("    TempRemark,");
                strBuilder.Append("    TempUserID,");
                strBuilder.Append("    TempClassName,");
                strBuilder.Append("    TempClassID");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @id,");
                strBuilder.Append("    @UserName,");
                strBuilder.Append("    @Password,");
                strBuilder.Append("    @TrueName,");
                strBuilder.Append("    @Gender,");
                strBuilder.Append("    @PicUrl,");
                strBuilder.Append("    @Nation,");
                strBuilder.Append("    @IDNO,");
                strBuilder.Append("    @ProvinceID,");
                strBuilder.Append("    @CityID,");
                strBuilder.Append("    @DistrictID,");
                strBuilder.Append("    @Mobile,");
                strBuilder.Append("    @Email,");
                strBuilder.Append("    @QQ,");
                strBuilder.Append("    @IPAddr,");
                strBuilder.Append("    @IsChange,");
                strBuilder.Append("    @UserState,");
                strBuilder.Append("    @CreateBy,");
                strBuilder.Append("    @CreateTime,");
                strBuilder.Append("    @UpdateBy,");
                strBuilder.Append("    @UpdateTime,");
                strBuilder.Append("    @CUserName,");
                strBuilder.Append("    @CPassword,");
                strBuilder.Append("    @GradeCode,");
                strBuilder.Append("    @SubjectCode,");
                strBuilder.Append("    @SchoolID,");
                strBuilder.Append("    @SchoolName,");
                strBuilder.Append("    @TempRemark,");
                strBuilder.Append("    @TempUserID,");
                strBuilder.Append("    @TempClassName,");
                strBuilder.Append("    @TempClassID");
                strBuilder.Append("  )");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///id : int id
                m_sqlCmd.Parameters.AddWithValue("@id",paramTempUserEntity.id);

                ///UserName : varchar(50) UserName
                if (paramTempUserEntity.UserName != null && "".Equals(paramTempUserEntity.UserName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", paramTempUserEntity.UserName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", DBNull.Value);
                }

                ///Password : nvarchar(200) Password
                if (paramTempUserEntity.Password != null && "".Equals(paramTempUserEntity.Password.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", paramTempUserEntity.Password);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", DBNull.Value);
                }

                ///TrueName : nvarchar(50) TrueName
                if (paramTempUserEntity.TrueName != null && "".Equals(paramTempUserEntity.TrueName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", paramTempUserEntity.TrueName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", DBNull.Value);
                }

                ///Gender : nvarchar(50) Gender
                if (paramTempUserEntity.Gender != null && "".Equals(paramTempUserEntity.Gender.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Gender", paramTempUserEntity.Gender);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Gender", DBNull.Value);
                }

                ///PicUrl : nvarchar(200) PicUrl
                if (paramTempUserEntity.PicUrl != null && "".Equals(paramTempUserEntity.PicUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@PicUrl", paramTempUserEntity.PicUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@PicUrl", DBNull.Value);
                }

                ///Nation : int Nation
                m_sqlCmd.Parameters.AddWithValue("@Nation",paramTempUserEntity.Nation);

                ///IDNO : nvarchar(50) IDNO
                if (paramTempUserEntity.IDNO != null && "".Equals(paramTempUserEntity.IDNO.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IDNO", paramTempUserEntity.IDNO);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IDNO", DBNull.Value);
                }

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramTempUserEntity.ProvinceID);

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramTempUserEntity.CityID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramTempUserEntity.DistrictID);

                ///Mobile : varchar(50) Mobile
                if (paramTempUserEntity.Mobile != null && "".Equals(paramTempUserEntity.Mobile.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Mobile", paramTempUserEntity.Mobile);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Mobile", DBNull.Value);
                }

                ///Email : varchar(50) Email
                if (paramTempUserEntity.Email != null && "".Equals(paramTempUserEntity.Email.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Email", paramTempUserEntity.Email);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Email", DBNull.Value);
                }

                ///QQ : varchar(50) QQ
                if (paramTempUserEntity.QQ != null && "".Equals(paramTempUserEntity.QQ.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QQ", paramTempUserEntity.QQ);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QQ", DBNull.Value);
                }

                ///IPAddr : nvarchar(50) IPAddr
                if (paramTempUserEntity.IPAddr != null && "".Equals(paramTempUserEntity.IPAddr.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAddr", paramTempUserEntity.IPAddr);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAddr", DBNull.Value);
                }

                ///IsChange : int IsChange
                m_sqlCmd.Parameters.AddWithValue("@IsChange",paramTempUserEntity.IsChange);

                ///UserState : int UserState
                m_sqlCmd.Parameters.AddWithValue("@UserState",paramTempUserEntity.UserState);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTempUserEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramTempUserEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTempUserEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTempUserEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramTempUserEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTempUserEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                ///CUserName : nvarchar(50) CUserName
                if (paramTempUserEntity.CUserName != null && "".Equals(paramTempUserEntity.CUserName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CUserName", paramTempUserEntity.CUserName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CUserName", DBNull.Value);
                }

                ///CPassword : nvarchar(50) CPassword
                if (paramTempUserEntity.CPassword != null && "".Equals(paramTempUserEntity.CPassword.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPassword", paramTempUserEntity.CPassword);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPassword", DBNull.Value);
                }

                ///GradeCode : varchar(50) GradeCode
                if (paramTempUserEntity.GradeCode != null && "".Equals(paramTempUserEntity.GradeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", paramTempUserEntity.GradeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", DBNull.Value);
                }

                ///SubjectCode : varchar(50) SubjectCode
                if (paramTempUserEntity.SubjectCode != null && "".Equals(paramTempUserEntity.SubjectCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", paramTempUserEntity.SubjectCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", DBNull.Value);
                }

                ///SchoolID : int SchoolID
                m_sqlCmd.Parameters.AddWithValue("@SchoolID",paramTempUserEntity.SchoolID);

                ///SchoolName : nvarchar(50) SchoolName
                if (paramTempUserEntity.SchoolName != null && "".Equals(paramTempUserEntity.SchoolName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SchoolName", paramTempUserEntity.SchoolName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SchoolName", DBNull.Value);
                }

                ///TempRemark : nvarchar(100) TempRemark
                if (paramTempUserEntity.TempRemark != null && "".Equals(paramTempUserEntity.TempRemark.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempRemark", paramTempUserEntity.TempRemark);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempRemark", DBNull.Value);
                }

                ///TempUserID : int TempUserID
                m_sqlCmd.Parameters.AddWithValue("@TempUserID",paramTempUserEntity.TempUserID);

                ///TempClassName : nvarchar(50) TempClassName
                if (paramTempUserEntity.TempClassName != null && "".Equals(paramTempUserEntity.TempClassName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempClassName", paramTempUserEntity.TempClassName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempClassName", DBNull.Value);
                }

                ///TempClassID : int TempClassID
                m_sqlCmd.Parameters.AddWithValue("@TempClassID",paramTempUserEntity.TempClassID);

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
        /// RH_TempUser : RH_TempUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempUserEntity" type="TempUserEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TempUserEntity paramTempUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TempUser");
                strBuilder.Append("  set ");
                strBuilder.Append("    UserName=@UserName,");
                strBuilder.Append("    Password=@Password,");
                strBuilder.Append("    TrueName=@TrueName,");
                strBuilder.Append("    Gender=@Gender,");
                strBuilder.Append("    PicUrl=@PicUrl,");
                strBuilder.Append("    Nation=@Nation,");
                strBuilder.Append("    IDNO=@IDNO,");
                strBuilder.Append("    ProvinceID=@ProvinceID,");
                strBuilder.Append("    CityID=@CityID,");
                strBuilder.Append("    DistrictID=@DistrictID,");
                strBuilder.Append("    Mobile=@Mobile,");
                strBuilder.Append("    Email=@Email,");
                strBuilder.Append("    QQ=@QQ,");
                strBuilder.Append("    IPAddr=@IPAddr,");
                strBuilder.Append("    IsChange=@IsChange,");
                strBuilder.Append("    UserState=@UserState,");
                strBuilder.Append("    CreateBy=@CreateBy,");
                strBuilder.Append("    CreateTime=@CreateTime,");
                strBuilder.Append("    UpdateBy=@UpdateBy,");
                strBuilder.Append("    UpdateTime=@UpdateTime,");
                strBuilder.Append("    CUserName=@CUserName,");
                strBuilder.Append("    CPassword=@CPassword,");
                strBuilder.Append("    GradeCode=@GradeCode,");
                strBuilder.Append("    SubjectCode=@SubjectCode,");
                strBuilder.Append("    SchoolID=@SchoolID,");
                strBuilder.Append("    SchoolName=@SchoolName,");
                strBuilder.Append("    TempRemark=@TempRemark,");
                strBuilder.Append("    TempUserID=@TempUserID,");
                strBuilder.Append("    TempClassName=@TempClassName,");
                strBuilder.Append("    TempClassID=@TempClassID");
                strBuilder.Append("  where ");
                strBuilder.Append("    id=@id");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///id : int id
                m_sqlCmd.Parameters.AddWithValue("@id",paramTempUserEntity.id);

                ///UserName : varchar(50) UserName
                if (paramTempUserEntity.UserName != null && "".Equals(paramTempUserEntity.UserName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", paramTempUserEntity.UserName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", DBNull.Value);
                }

                ///Password : nvarchar(200) Password
                if (paramTempUserEntity.Password != null && "".Equals(paramTempUserEntity.Password.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", paramTempUserEntity.Password);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", DBNull.Value);
                }

                ///TrueName : nvarchar(50) TrueName
                if (paramTempUserEntity.TrueName != null && "".Equals(paramTempUserEntity.TrueName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", paramTempUserEntity.TrueName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", DBNull.Value);
                }

                ///Gender : nvarchar(50) Gender
                if (paramTempUserEntity.Gender != null && "".Equals(paramTempUserEntity.Gender.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Gender", paramTempUserEntity.Gender);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Gender", DBNull.Value);
                }

                ///PicUrl : nvarchar(200) PicUrl
                if (paramTempUserEntity.PicUrl != null && "".Equals(paramTempUserEntity.PicUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@PicUrl", paramTempUserEntity.PicUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@PicUrl", DBNull.Value);
                }

                ///Nation : int Nation
                m_sqlCmd.Parameters.AddWithValue("@Nation",paramTempUserEntity.Nation);

                ///IDNO : nvarchar(50) IDNO
                if (paramTempUserEntity.IDNO != null && "".Equals(paramTempUserEntity.IDNO.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IDNO", paramTempUserEntity.IDNO);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IDNO", DBNull.Value);
                }

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramTempUserEntity.ProvinceID);

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramTempUserEntity.CityID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramTempUserEntity.DistrictID);

                ///Mobile : varchar(50) Mobile
                if (paramTempUserEntity.Mobile != null && "".Equals(paramTempUserEntity.Mobile.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Mobile", paramTempUserEntity.Mobile);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Mobile", DBNull.Value);
                }

                ///Email : varchar(50) Email
                if (paramTempUserEntity.Email != null && "".Equals(paramTempUserEntity.Email.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Email", paramTempUserEntity.Email);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Email", DBNull.Value);
                }

                ///QQ : varchar(50) QQ
                if (paramTempUserEntity.QQ != null && "".Equals(paramTempUserEntity.QQ.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QQ", paramTempUserEntity.QQ);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QQ", DBNull.Value);
                }

                ///IPAddr : nvarchar(50) IPAddr
                if (paramTempUserEntity.IPAddr != null && "".Equals(paramTempUserEntity.IPAddr.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAddr", paramTempUserEntity.IPAddr);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAddr", DBNull.Value);
                }

                ///IsChange : int IsChange
                m_sqlCmd.Parameters.AddWithValue("@IsChange",paramTempUserEntity.IsChange);

                ///UserState : int UserState
                m_sqlCmd.Parameters.AddWithValue("@UserState",paramTempUserEntity.UserState);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTempUserEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramTempUserEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTempUserEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTempUserEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramTempUserEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTempUserEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                ///CUserName : nvarchar(50) CUserName
                if (paramTempUserEntity.CUserName != null && "".Equals(paramTempUserEntity.CUserName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CUserName", paramTempUserEntity.CUserName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CUserName", DBNull.Value);
                }

                ///CPassword : nvarchar(50) CPassword
                if (paramTempUserEntity.CPassword != null && "".Equals(paramTempUserEntity.CPassword.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPassword", paramTempUserEntity.CPassword);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CPassword", DBNull.Value);
                }

                ///GradeCode : varchar(50) GradeCode
                if (paramTempUserEntity.GradeCode != null && "".Equals(paramTempUserEntity.GradeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", paramTempUserEntity.GradeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", DBNull.Value);
                }

                ///SubjectCode : varchar(50) SubjectCode
                if (paramTempUserEntity.SubjectCode != null && "".Equals(paramTempUserEntity.SubjectCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", paramTempUserEntity.SubjectCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", DBNull.Value);
                }

                ///SchoolID : int SchoolID
                m_sqlCmd.Parameters.AddWithValue("@SchoolID",paramTempUserEntity.SchoolID);

                ///SchoolName : nvarchar(50) SchoolName
                if (paramTempUserEntity.SchoolName != null && "".Equals(paramTempUserEntity.SchoolName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SchoolName", paramTempUserEntity.SchoolName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SchoolName", DBNull.Value);
                }

                ///TempRemark : nvarchar(100) TempRemark
                if (paramTempUserEntity.TempRemark != null && "".Equals(paramTempUserEntity.TempRemark.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempRemark", paramTempUserEntity.TempRemark);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempRemark", DBNull.Value);
                }

                ///TempUserID : int TempUserID
                m_sqlCmd.Parameters.AddWithValue("@TempUserID",paramTempUserEntity.TempUserID);

                ///TempClassName : nvarchar(50) TempClassName
                if (paramTempUserEntity.TempClassName != null && "".Equals(paramTempUserEntity.TempClassName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempClassName", paramTempUserEntity.TempClassName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempClassName", DBNull.Value);
                }

                ///TempClassID : int TempClassID
                m_sqlCmd.Parameters.AddWithValue("@TempClassID",paramTempUserEntity.TempClassID);

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
        /// RH_TempUser : RH_TempUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempUserEntity" type="TempUserEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TempUserEntity paramTempUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TempUser");
                strBuilder.Append(" where ");
                strBuilder.Append("    id=@id");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///id : int id
                m_sqlCmd.Parameters.AddWithValue("@id",paramTempUserEntity.id);

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
        /// RH_TempUser : RH_TempUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempUserEntity" type="TempUserEntity"></param>
        /// <returns type="TempUserEntity"></returns>
        public TempUserEntity SelectByPK(Object paramConnectionEntity, TempUserEntity paramTempUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TempUserEntity tempUserEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   id AS id,");
                strBuilder.Append("   UserName AS UserName,");
                strBuilder.Append("   Password AS Password,");
                strBuilder.Append("   TrueName AS TrueName,");
                strBuilder.Append("   Gender AS Gender,");
                strBuilder.Append("   PicUrl AS PicUrl,");
                strBuilder.Append("   Nation AS Nation,");
                strBuilder.Append("   IDNO AS IDNO,");
                strBuilder.Append("   ProvinceID AS ProvinceID,");
                strBuilder.Append("   CityID AS CityID,");
                strBuilder.Append("   DistrictID AS DistrictID,");
                strBuilder.Append("   Mobile AS Mobile,");
                strBuilder.Append("   Email AS Email,");
                strBuilder.Append("   QQ AS QQ,");
                strBuilder.Append("   IPAddr AS IPAddr,");
                strBuilder.Append("   IsChange AS IsChange,");
                strBuilder.Append("   UserState AS UserState,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime,");
                strBuilder.Append("   CUserName AS CUserName,");
                strBuilder.Append("   CPassword AS CPassword,");
                strBuilder.Append("   GradeCode AS GradeCode,");
                strBuilder.Append("   SubjectCode AS SubjectCode,");
                strBuilder.Append("   SchoolID AS SchoolID,");
                strBuilder.Append("   SchoolName AS SchoolName,");
                strBuilder.Append("   TempRemark AS TempRemark,");
                strBuilder.Append("   TempUserID AS TempUserID,");
                strBuilder.Append("   TempClassName AS TempClassName,");
                strBuilder.Append("   TempClassID AS TempClassID");
                strBuilder.Append(" from RH_TempUser");
                strBuilder.Append("   where 1=1 ");
                strBuilder.Append("   AND id=@id ");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///id : int id
                m_sqlCmd.Parameters.AddWithValue("@id",paramTempUserEntity.id);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        tempUserEntity = ParseDataRowToEntity(dataRows[0]);
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

            return tempUserEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TempUser : RH_TempUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempUserEntity" type="TempUserEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTempUserByForeignKeys(Object paramConnectionEntity, TempUserEntity paramTempUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable tempUserEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   id AS id,");
                strBuilder.Append("   UserName AS UserName,");
                strBuilder.Append("   Password AS Password,");
                strBuilder.Append("   TrueName AS TrueName,");
                strBuilder.Append("   Gender AS Gender,");
                strBuilder.Append("   PicUrl AS PicUrl,");
                strBuilder.Append("   Nation AS Nation,");
                strBuilder.Append("   IDNO AS IDNO,");
                strBuilder.Append("   ProvinceID AS ProvinceID,");
                strBuilder.Append("   CityID AS CityID,");
                strBuilder.Append("   DistrictID AS DistrictID,");
                strBuilder.Append("   Mobile AS Mobile,");
                strBuilder.Append("   Email AS Email,");
                strBuilder.Append("   QQ AS QQ,");
                strBuilder.Append("   IPAddr AS IPAddr,");
                strBuilder.Append("   IsChange AS IsChange,");
                strBuilder.Append("   UserState AS UserState,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime,");
                strBuilder.Append("   CUserName AS CUserName,");
                strBuilder.Append("   CPassword AS CPassword,");
                strBuilder.Append("   GradeCode AS GradeCode,");
                strBuilder.Append("   SubjectCode AS SubjectCode,");
                strBuilder.Append("   SchoolID AS SchoolID,");
                strBuilder.Append("   SchoolName AS SchoolName,");
                strBuilder.Append("   TempRemark AS TempRemark,");
                strBuilder.Append("   TempUserID AS TempUserID,");
                strBuilder.Append("   TempClassName AS TempClassName,");
                strBuilder.Append("   TempClassID AS TempClassID");
                strBuilder.Append(" from RH_TempUser");
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
        /// <returns type="TempUserEntity"></returns>
        private TempUserEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TempUserMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}