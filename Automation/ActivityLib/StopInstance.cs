﻿using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Common;


namespace ActivityLib
{
    public class StopInstance : LeafAction
    {
        protected override void Execute(NativeActivityContext context)
        {
            
            try
            {
                string id = GetContextValue(context, Const.AttributeId);
                InstanceManager.GetInstance().GetTestInstance(id).Stop();

                SetReturnMessage(context, Common.Result.SuccessResult());
            }
            catch (Exception ex)
            {
                SetReturnMessage(context, Common.Result.ErrorResult(ex));
            }
        }
    }
}