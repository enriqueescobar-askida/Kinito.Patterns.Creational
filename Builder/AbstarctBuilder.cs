﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Creat.Builder
{
    /// <summary>
    /// 
    /// </summary>
    abstract class AbstarctBuilder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
}
