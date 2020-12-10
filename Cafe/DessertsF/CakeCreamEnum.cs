using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Cafe
{
    public enum CakeCreamEnum
    {
        [Description("Vanillia")]
        Vanillia,
        [Description("White chocolate")]
        WhiteChocolate,
        [Description("Dark chocolate")]
        DarkChocolate,
        [Description("Hazelnut")]
        Hazelnut,
        [Description("Strawberry")]
        Strawberry
    }
}
