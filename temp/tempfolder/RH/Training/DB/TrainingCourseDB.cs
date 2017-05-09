using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingCourse ( RH_TrainingCourse ) DB类
    ///</summary>
    public class TrainingCourseDB
    {

        /// <summary>
        /// 添加RH_TrainingCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingCourse(TrainingCourseEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PresetID",info.PresetID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_IfRequired",info.IfRequired);
            param.Add("@i_CPharse",info.CPharse);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingCourse_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingCourse(TrainingCourseEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_PresetID",info.PresetID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_IfRequired",info.IfRequired);
            param.Add("@i_CPharse",info.CPharse);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingCourse_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingCourse(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingCourse_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingCourseInfo GetTrainingCourseDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingCourse_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingCourseInfo)ORMapping.MapSingleObject(typeof(TrainingCourseInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingCourseEntityListResult GetTrainingCourseEntityList(TrainingCourseSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingCourse_List", param, DBConnEnm.TRDBWrite);

            TrainingCourseEntityListResult Result= new TrainingCourseEntityListResult();
            Result.TrainingCourseList = (List<TrainingCourseInfo>)ORMapping.MapListObject(typeof(TrainingCourseInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}