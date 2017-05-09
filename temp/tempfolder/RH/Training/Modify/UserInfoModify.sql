/*
  RH_UserInfo - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_UserInfo_Modify;
CREATE  PROCEDURE sp_SJ_RH_UserInfo_Modify
(
   IN i_ID int,
   IN i_UserID int,
   IN i_SchoolID int,
   IN i_CUserName nvarchar(50),
   IN i_CPassword nvarchar(50),
   IN i_CSource int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_UserInfo
  SET
      UserID = i_UserID,
      SchoolID = i_SchoolID,
      CUserName = i_CUserName,
      CPassword = i_CPassword,
      CSource = i_CSource
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;
