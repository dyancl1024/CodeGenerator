/*
  RH_DesignSuggest - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignSuggest_Modify;
CREATE  PROCEDURE sp_SJ_RH_DesignSuggest_Modify
(
   IN i_ID int,
   IN i_DesignID int,
   IN i_DSuggest nvarchar(200),
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_DesignSuggest
  SET
      DesignID = i_DesignID,
      DSuggest = i_DSuggest,
      Status = i_Status,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;
