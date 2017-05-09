using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_User ( RH_User ) Dao类
    ///</summary>
    public class UserDao
    {

        /// <summary>
        /// 添加
        /// RH_User : RH_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserEntity" type="UserEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, UserEntity paramUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_User");
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
                strBuilder.Append("    UpdateTime");
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

                ///id : int id
                m_sqlCmd.Parameters.AddWithValue("@id",paramUserEntity.id);

                ///UserName : varchar(50) UserName
                if (paramUserEntity.UserName != null && "".Equals(paramUserEntity.UserName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", paramUserEntity.UserName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", DBNull.Value);
                }

                ///Password : nvarchar(200) Password
                if (paramUserEntity.Password != null && "".Equals(paramUserEntity.Password.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", paramUserEntity.Password);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", DBNull.Value);
                }

                ///TrueName : nvarchar(50) TrueName
                if (paramUserEntity.TrueName != null && "".Equals(paramUserEntity.TrueName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", paramUserEntity.TrueName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", DBNull.Value);
                }

                ///Gender : nvarchar(50) Gender
                if (paramUserEntity.Gender != null && "".Equals(paramUserEntity.Gender.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Gender", paramUserEntity.Gender);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Gender", DBNull.Value);
                }

                ///PicUrl : nvarchar(200) PicUrl
                if (paramUserEntity.PicUrl != null && "".Equals(paramUserEntity.PicUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@PicUrl", paramUserEntity.PicUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@PicUrl", DBNull.Value);
                }

                ///Nation : int Nation
                m_sqlCmd.Parameters.AddWithValue("@Nation",paramUserEntity.Nation);

                ///IDNO : nvarchar(50) IDNO
                if (paramUserEntity.IDNO != null && "".Equals(paramUserEntity.IDNO.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IDNO", paramUserEntity.IDNO);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IDNO", DBNull.Value);
                }

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramUserEntity.ProvinceID);

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramUserEntity.CityID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramUserEntity.DistrictID);

                ///Mobile : varchar(50) Mobile
                if (paramUserEntity.Mobile != null && "".Equals(paramUserEntity.Mobile.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Mobile", paramUserEntity.Mobile);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Mobile", DBNull.Value);
                }

                ///Email : varchar(50) Email
                if (paramUserEntity.Email != null && "".Equals(paramUserEntity.Email.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Email", paramUserEntity.Email);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Email", DBNull.Value);
                }

                ///QQ : varchar(50) QQ
                if (paramUserEntity.QQ != null && "".Equals(paramUserEntity.QQ.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QQ", paramUserEntity.QQ);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QQ", DBNull.Value);
                }

                ///IPAddr : nvarchar(50) IPAddr
                if (paramUserEntity.IPAddr != null && "".Equals(paramUserEntity.IPAddr.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAddr", paramUserEntity.IPAddr);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAddr", DBNull.Value);
                }

                ///IsChange : int IsChange
                m_sqlCmd.Parameters.AddWithValue("@IsChange",paramUserEntity.IsChange);

                ///UserState : int UserState
                m_sqlCmd.Parameters.AddWithValue("@UserState",paramUserEntity.UserState);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramUserEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramUserEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramUserEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramUserEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramUserEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramUserEntity.UpdateTime);
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
        /// RH_User : RH_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserEntity" type="UserEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, UserEntity paramUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_User");
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
                strBuilder.Append("    UpdateTime=@UpdateTime");
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
                m_sqlCmd.Parameters.AddWithValue("@id",paramUserEntity.id);

                ///UserName : varchar(50) UserName
                if (paramUserEntity.UserName != null && "".Equals(paramUserEntity.UserName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", paramUserEntity.UserName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UserName", DBNull.Value);
                }

                ///Password : nvarchar(200) Password
                if (paramUserEntity.Password != null && "".Equals(paramUserEntity.Password.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", paramUserEntity.Password);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Password", DBNull.Value);
                }

                ///TrueName : nvarchar(50) TrueName
                if (paramUserEntity.TrueName != null && "".Equals(paramUserEntity.TrueName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", paramUserEntity.TrueName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrueName", DBNull.Value);
                }

                ///Gender : nvarchar(50) Gender
                if (paramUserEntity.Gender != null && "".Equals(paramUserEntity.Gender.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Gender", paramUserEntity.Gender);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Gender", DBNull.Value);
                }

                ///PicUrl : nvarchar(200) PicUrl
                if (paramUserEntity.PicUrl != null && "".Equals(paramUserEntity.PicUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@PicUrl", paramUserEntity.PicUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@PicUrl", DBNull.Value);
                }

                ///Nation : int Nation
                m_sqlCmd.Parameters.AddWithValue("@Nation",paramUserEntity.Nation);

                ///IDNO : nvarchar(50) IDNO
                if (paramUserEntity.IDNO != null && "".Equals(paramUserEntity.IDNO.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IDNO", paramUserEntity.IDNO);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IDNO", DBNull.Value);
                }

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramUserEntity.ProvinceID);

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramUserEntity.CityID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramUserEntity.DistrictID);

                ///Mobile : varchar(50) Mobile
                if (paramUserEntity.Mobile != null && "".Equals(paramUserEntity.Mobile.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Mobile", paramUserEntity.Mobile);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Mobile", DBNull.Value);
                }

                ///Email : varchar(50) Email
                if (paramUserEntity.Email != null && "".Equals(paramUserEntity.Email.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Email", paramUserEntity.Email);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Email", DBNull.Value);
                }

                ///QQ : varchar(50) QQ
                if (paramUserEntity.QQ != null && "".Equals(paramUserEntity.QQ.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QQ", paramUserEntity.QQ);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QQ", DBNull.Value);
                }

                ///IPAddr : nvarchar(50) IPAddr
                if (paramUserEntity.IPAddr != null && "".Equals(paramUserEntity.IPAddr.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAddr", paramUserEntity.IPAddr);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAddr", DBNull.Value);
                }

                ///IsChange : int IsChange
                m_sqlCmd.Parameters.AddWithValue("@IsChange",paramUserEntity.IsChange);

                ///UserState : int UserState
                m_sqlCmd.Parameters.AddWithValue("@UserState",paramUserEntity.UserState);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramUserEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramUserEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramUserEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramUserEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramUserEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramUserEntity.UpdateTime);
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
        /// RH_User : RH_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserEntity" type="UserEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, UserEntity paramUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_User");
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
                m_sqlCmd.Parameters.AddWithValue("@id",paramUserEntity.id);

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
        /// RH_User : RH_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserEntity" type="UserEntity"></param>
        /// <returns type="UserEntity"></returns>
        public UserEntity SelectByPK(Object paramConnectionEntity, UserEntity paramUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            UserEntity userEntity = null;

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
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_User");
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
                m_sqlCmd.Parameters.AddWithValue("@id",paramUserEntity.id);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        userEntity = ParseDataRowToEntity(dataRows[0]);
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

            return userEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_User : RH_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserEntity" type="UserEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllUserByForeignKeys(Object paramConnectionEntity, UserEntity paramUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable userEntityList = null;

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
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_User");
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
        /// <returns type="UserEntity"></returns>
        private UserEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return UserMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}