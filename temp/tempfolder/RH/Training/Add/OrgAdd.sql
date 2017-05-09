/*
  RH_Org - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Org_Add;
CREATE  PROCEDURE sp_SJ_RH_Org_Add
(
   IN i_Name nvarchar(50),
   IN i_Code varchar(50),
   IN i_Sort int,
   IN i_Status int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_Org
  (
      Name,
      Code,
      Sort,
      Status
  )
  VALUES
  (
      i_Name,  --  nvarchar(50) (承担机构名称)
      i_Code,  --  varchar(50) (机构状态 1-正常 0-删除)
      i_Sort,  --  int (Sort)
      i_Status  --  int (1:正常 2.删除)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
