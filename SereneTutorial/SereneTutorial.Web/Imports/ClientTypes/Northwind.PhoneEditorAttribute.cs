using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SereneTutorial.Northwind
{
    public partial class PhoneEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SereneTutorial.Northwind.PhoneEditor";

        public PhoneEditorAttribute()
            : base(Key)
        {
        }

        public Boolean Multiple
        {
            get { return GetOption<Boolean>("multiple"); }
            set { SetOption("multiple", value); }
        }
    }
}
