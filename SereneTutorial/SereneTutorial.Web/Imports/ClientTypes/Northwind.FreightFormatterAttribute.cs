using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SereneTutorial.Northwind
{
    public partial class FreightFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "SereneTutorial.Northwind.FreightFormatter";

        public FreightFormatterAttribute()
            : base(Key)
        {
        }
    }
}
