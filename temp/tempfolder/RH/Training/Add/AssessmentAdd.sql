/*
  RH_Assessment - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Assessment_Add;
CREATE  PROCEDURE sp_SJ_RH_Assessment_Add
(
   IN i_AName nvarchar(200),
   IN i_ADesc nvarchar(Max),
   IN i_Status int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_Assessment
  (
      AName,
      ADesc,
      Status
  )
  VALUES
  (
      i_AName,  --  nvarchar(200) (测评工具名称)
      i_ADesc,  --  nvarchar(Max) (评测描述)
      i_Status  --  int (0.未发布  1.已发布)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
