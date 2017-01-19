using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using ktv.model;
using Ktv.WebApi.Models;

namespace Ktv.WebApi.Controllers
{
    public class YuDingController : ApiController
    {
        private string LuanHui = "luanhui";
        private string Pwd = "AJ58FLJFDU4390KDSL49S";

        
        [Route("GetAllNotCom")]
        public IHttpActionResult GetAllNotCom(string name, string pwd,string key)
        {

            if (name != LuanHui || pwd != Pwd)
            {
                return new BadRequestResult(new HttpRequestMessage());
            }
            var today = DateTime.Today;
            var tom = today.AddDays(1);
            var sql = "select * from YuDing where Status='" + StatusName.预定未来 + "' and YuDingTime>='"+ today + "' and YuDingTime<'"+tom+"' ";
            if (!string.IsNullOrEmpty(key))
            {
                sql += " and (Code='"+key+ "' or XingMing like '%"+key+ "%' or Phone='"+key+"')";
            }
            sql += " order by Id desc";
            var list = SqlHelper.Query<ktv.model.YuDing>(sql).ToList();
            var dtos = from model in list
                select new YuDingDTO()
                {
                    Id = model.Id.ToString(),
                    Code = model.Code,
                    YuDingTime = model.YuDingTime.ToString("yyyy-MM-dd HH:mm"),
                    XingMing = model.XingMing,
                    Sex = model.Sex,
                    Phone = model.Phone,
                    FangXing = model.FangXing,
                    BaoFangHao = model.BaoFangHao,
                    HuoDongId = (model.HuoDongId ?? 0).ToString(),
                    HuoDongName = model.HuoDongName,
                    Status = model.Status,
                };
            return Ok<List<YuDingDTO>>(dtos.ToList());
        }

        [Route("SetBaoFangHao")]
        [HttpGet]
        public IHttpActionResult SetFangHao(string name, string pwd, long id, string fanghao)
        {
            var sql = "update YuDing set BaoFangHao='" + fanghao + "',Status='" + StatusName.客户已来 + "' where Id=" + id;
            SqlHelper.Execute(sql);
            return Ok();
        }


        //暂时不用
        [Route("GetNeedNotCom")]
        public IHttpActionResult GetNeedNotCom(string name, string pwd, int maxid)
        {
            if (name != LuanHui || pwd != Pwd)
            {
                return new BadRequestResult(new HttpRequestMessage());
            }
            var sql = "select * from YuDing where Status='" + StatusName.预定未来 + "' and Id>'" + maxid + "' order by Id desc";
            var list = SqlHelper.Query<ktv.model.YuDing>(sql).ToList();
            var dtos = from model in list
                       select new YuDingDTO()
                       {
                           Id = model.Id.ToString(),
                           Code = model.Code,
                           YuDingTime = model.YuDingTime.ToString("yyyy-MM-dd HH:mm"),
                           XingMing = model.XingMing,
                           Sex = model.Sex,
                           Phone = model.Phone,
                           FangXing = model.FangXing,
                           BaoFangHao = model.BaoFangHao,
                           HuoDongId = (model.HuoDongId ?? 0).ToString(),
                           HuoDongName = model.HuoDongName,
                           Status = model.Status,
                       };
            return Ok<List<YuDingDTO>>(dtos.ToList());

        }


    }
}
