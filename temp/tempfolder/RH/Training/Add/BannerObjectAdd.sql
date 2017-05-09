/*
  RH_BannerObject - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_BannerObject_Add;
CREATE  PROCEDURE sp_SJ_RH_BannerObject_Add
(
   IN i_BannerID int,
   IN i_ObjectID int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_BannerObject
  (
      BannerID,
      ObjectID,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_BannerID,  --  int (BannerID)
      i_ObjectID,  --  int (ObjectID)
      i_CreateBy,  --  int (创建人)
      i_CreateTime  --  datetime (创建时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
