/*
  RH_UserInfo - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_UserInfo_Add;
CREATE  PROCEDURE sp_SJ_RH_UserInfo_Add
(
   IN i_UserID int,
   IN i_SchoolID int,
   IN i_CUserName nvarchar(50),
   IN i_CPassword nvarchar(50),
   IN i_CSource int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_UserInfo
  (
      UserID,
      SchoolID,
      CUserName,
      CPassword,
      CSource
  )
  VALUES
  (
      i_UserID,  --  int (人id)
      i_SchoolID,  --  int (学校ID)
      i_CUserName,  --  nvarchar(50) (接口用户名)
      i_CPassword,  --  nvarchar(50) (CPassword)
      i_CSource  --  int (CSource)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
