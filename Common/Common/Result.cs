﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Result
    {
        public static Result SuccessResult()
        {
            return new Result();
        }

        public static Result ErrorResult(Exception e)
        {
            return new Result();
        }

        public static Result ErrorResult(string e)
        {
            return new Result();
        }

        public void attach(string a)
        {

        }
    }
}