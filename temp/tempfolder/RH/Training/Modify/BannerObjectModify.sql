/*
  RH_BannerObject - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_BannerObject_Modify;
CREATE  PROCEDURE sp_SJ_RH_BannerObject_Modify
(
   IN i_ID int,
   IN i_BannerID int,
   IN i_ObjectID int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_BannerObject
  SET
      BannerID = i_BannerID,
      ObjectID = i_ObjectID,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;
