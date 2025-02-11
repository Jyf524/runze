﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.Appraise
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtAppriseID.Text.Trim().Length==0)
			{
				strErr+="AppriseID不能为空！\\n";	
			}
			if(this.txtUserID.Text.Trim().Length==0)
			{
				strErr+="UserID不能为空！\\n";	
			}
			if(this.txtCommodityID.Text.Trim().Length==0)
			{
				strErr+="CommodityID不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string AppriseID=this.txtAppriseID.Text;
			string UserID=this.txtUserID.Text;
			string CommodityID=this.txtCommodityID.Text;

			Maticsoft.Model.Appraise model=new Maticsoft.Model.Appraise();
			model.AppriseID=AppriseID;
			model.UserID=UserID;
			model.CommodityID=CommodityID;

			Maticsoft.BLL.Appraise bll=new Maticsoft.BLL.Appraise();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
