/*
  RH_User - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_User_Modify;
CREATE  PROCEDURE sp_SJ_RH_User_Modify
(
   IN i_id int,
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

  UPDATE RH_User
  SET
      UserName = i_UserName,
      Password = i_Password,
      TrueName = i_TrueName,
      Gender = i_Gender,
      PicUrl = i_PicUrl,
      Nation = i_Nation,
      IDNO = i_IDNO,
      ProvinceID = i_ProvinceID,
      CityID = i_CityID,
      DistrictID = i_DistrictID,
      Mobile = i_Mobile,
      Email = i_Email,
      QQ = i_QQ,
      IPAddr = i_IPAddr,
      IsChange = i_IsChange,
      UserState = i_UserState,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE id = i_id ;

  SELECT ROW_COUNT() INTO o_Result;

END;
