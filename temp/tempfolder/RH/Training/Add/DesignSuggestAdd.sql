/*
  RH_DesignSuggest - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignSuggest_Add;
CREATE  PROCEDURE sp_SJ_RH_DesignSuggest_Add
(
   IN i_DesignID int,
   IN i_DSuggest nvarchar(200),
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_DesignSuggest
  (
      DesignID,
      DSuggest,
      Status,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_DesignID,  --  int (DesignID)
      i_DSuggest,  --  nvarchar(200) (DSuggest)
      i_Status,  --  int (1.待审批（对应的动作提交审批） 2.审批中（对应的动作通过、不通过，） 3.已审批（对应的动作立项、不立项） 4.立项（对应的动作分配教务） 5.不立项（对应的动作分配教务）)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime  --  datetime (CreateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
