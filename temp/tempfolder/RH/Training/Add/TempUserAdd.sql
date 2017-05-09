/*
  RH_TempUser - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TempUser_Add;
CREATE  PROCEDURE sp_SJ_RH_TempUser_Add
(
   IN i_UserName varchar(50),
   IN i_Password nvarchar(200),
   IN i_TrueName nvarchar(50),
   IN i_Gender nvarchar(50),
   IN i_PicUrl nvarchar(200),
   IN i_Nation int,
   IN i_IDNO nvarchar(50),
   IN i_ProvinceID int,
   IN i_CityID int,
   IN i_DistrictID int,
   IN i_Mobile varchar(50),
   IN i_Email varchar(50),
   IN i_QQ varchar(50),
   IN i_IPAddr nvarchar(50),
   IN i_IsChange int,
   IN i_UserState int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   IN i_CUserName nvarchar(50),
   IN i_CPassword nvarchar(50),
   IN i_GradeCode varchar(50),
   IN i_SubjectCode varchar(50),
   IN i_SchoolID int,
   IN i_SchoolName nvarchar(50),
   IN i_TempRemark nvarchar(100),
   IN i_TempUserID int,
   IN i_TempClassName nvarchar(50),
   IN i_TempClassID int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TempUser
  (
      UserName,
      Password,
      TrueName,
      Gender,
      PicUrl,
      Nation,
      IDNO,
      ProvinceID,
      CityID,
      DistrictID,
      Mobile,
      Email,
      QQ,
      IPAddr,
      IsChange,
      UserState,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime,
      CUserName,
      CPassword,
      GradeCode,
      SubjectCode,
      SchoolID,
      SchoolName,
      TempRemark,
      TempUserID,
      TempClassName,
      TempClassID
  )
  VALUES
  (
      i_UserName,  --  varchar(50) (UserName)
      i_Password,  --  nvarchar(200) (Password)
      i_TrueName,  --  nvarchar(50) (TrueName)
      i_Gender,  --  nvarchar(50) (Gender)
      i_PicUrl,  --  nvarchar(200) (PicUrl)
      i_Nation,  --  int (Nation)
      i_IDNO,  --  nvarchar(50) (IDNO)
      i_ProvinceID,  --  int (ProvinceID)
      i_CityID,  --  int (CityID)
      i_DistrictID,  --  int (DistrictID)
      i_Mobile,  --  varchar(50) (Mobile)
      i_Email,  --  varchar(50) (Email)
      i_QQ,  --  varchar(50) (QQ)
      i_IPAddr,  --  nvarchar(50) (IPAddr)
      i_IsChange,  --  int (IsChange)
      i_UserState,  --  int (UserState)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime,  --  datetime (CreateTime)
      i_UpdateBy,  --  int (UpdateBy)
      i_UpdateTime,  --  datetime (UpdateTime)
      i_CUserName,  --  nvarchar(50) (CUserName)
      i_CPassword,  --  nvarchar(50) (CPassword)
      i_GradeCode,  --  varchar(50) (GradeCode)
      i_SubjectCode,  --  varchar(50) (SubjectCode)
      i_SchoolID,  --  int (SchoolID)
      i_SchoolName,  --  nvarchar(50) (SchoolName)
      i_TempRemark,  --  nvarchar(100) (TempRemark)
      i_TempUserID,  --  int (TempUserID)
      i_TempClassName,  --  nvarchar(50) (TempClassName)
      i_TempClassID  --  int (TempClassID)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
