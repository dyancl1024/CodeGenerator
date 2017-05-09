/*
  RH_Banner - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Banner_Add;
CREATE  PROCEDURE sp_SJ_RH_Banner_Add
(
   IN i_ADTitle nvarchar(200),
   IN i_AreaCode varchar(50),
   IN i_ADPhotoUrl nvarchar(200),
   IN i_ADContentType int,
   IN i_ADContentURL nvarchar(200),
   IN i_ADContent nvarchar(Max),
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_Banner
  (
      ADTitle,
      AreaCode,
      ADPhotoUrl,
      ADContentType,
      ADContentURL,
      ADContent,
      Status,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_ADTitle,  --  nvarchar(200) (AD标题)
      i_AreaCode,  --  varchar(50) (区域： 1- 区域1（图片），2-区域2（图片）  3-区域3（图片） 4-区域4....)
      i_ADPhotoUrl,  --  nvarchar(200) (上传广告图片URL(由区域决定是否为图片广告))
      i_ADContentType,  --  int (广告内容形式  1-编辑内容  2-链接URL)
      i_ADContentURL,  --  nvarchar(200) (内容链接URL)
      i_ADContent,  --  nvarchar(Max) (AD内容(存放编辑的内容或链接URL))
      i_Status,  --  int (1-未发布 2-已发布  3-删除)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (创建时间)
      i_UpdateBy,  --  int (修改人)
      i_UpdateTime  --  datetime (修改时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
