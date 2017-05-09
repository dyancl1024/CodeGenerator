/*
  RH_User - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_User_Add;
CREATE  PROCEDURE sp_SJ_RH_User_Add
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
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_User
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
      UpdateTime
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
      i_UpdateTime  --  datetime (UpdateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
