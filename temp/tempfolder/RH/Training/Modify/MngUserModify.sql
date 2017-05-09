/*
  RH_MngUser - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngUser_Modify;
CREATE  PROCEDURE sp_SJ_RH_MngUser_Modify
(
   IN i_ID int,
   IN i_UserName nvarchar(50),
   IN i_Password nvarchar(50),
   IN i_TrueName nvarchar(50),
   IN i_RoleID int,
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_MngUser
  SET
      UserName = i_UserName,
      Password = i_Password,
      TrueName = i_TrueName,
      RoleID = i_RoleID,
      Status = i_Status,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;
