/*
  RH_MngUser - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngUser_Add;
CREATE  PROCEDURE sp_SJ_RH_MngUser_Add
(
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

  INSERT INTO RH_MngUser
  (
      UserName,
      Password,
      TrueName,
      RoleID,
      Status,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_UserName,  --  nvarchar(50) (用户名)
      i_Password,  --  nvarchar(50) (Password)
      i_TrueName,  --  nvarchar(50) (真实姓名)
      i_RoleID,  --  int (角色id  角色表)
      i_Status,  --  int (状态：1.正常 2.删除)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (创建时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
