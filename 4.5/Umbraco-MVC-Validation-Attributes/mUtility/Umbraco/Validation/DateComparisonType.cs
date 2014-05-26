﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mUtility.Umbraco.Validation
{
    /// <summary>
    /// 
    /// </summary>
    public enum DateComparisonType
    {
        /// <summary>
        /// The greater than
        /// </summary>
        GreaterThan = 0,
        /// <summary>
        /// The greater than or equal 
        /// </summary>
        GreaterThanOrEqual = 1,
        /// <summary>
        /// The lower than or equal
        /// </summary>
        LowerThanOrEqual = 2,
        /// <summary>
        /// The lower than
        /// </summary>
        LowerThan = 3,
        /// <summary>
        /// The equal
        /// </summary>
        Equal = 4
    }
}
