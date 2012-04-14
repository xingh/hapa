﻿using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Common;


namespace ActivityLib
{
    /// <summary>
    /// 
    /// Return Registered computer list
    /// </summary>
    public class GetComputersInfo : LeafAction
    {
        protected override void Execute(NativeActivityContext context)
        {
            string commandStr = GetContextValue(context, "command");

            try
            {
                XElement content = (XElement)XElement.Parse(commandStr);
                
                Result r = Common.Result.SuccessResult();
                r.attach(ComputersManager.GetInstance().ToString());
                SetReturnMessage(context, r);
            }
            catch (Exception ex)
            {
                SetReturnMessage(context, Common.Result.ErrorResult(ex));
            }
        }
    }
}