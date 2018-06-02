using System.Collections;
using Fonet.DataTypes;
using System;
using System.Collections.Generic;

namespace Fonet.Fo.Properties
{
    internal class LeaderPatternWidthMaker : LengthProperty.Maker
    {
        new public static PropertyMaker Maker(string propName)
        {
            return new LeaderPatternWidthMaker(propName);
        }

        protected LeaderPatternWidthMaker(string name) : base(name) { }


        public override bool IsInherited()
        {
            return true;
        }

        public override Property Make(PropertyList propertyList)
        {
            return Make(propertyList, "use-font-metrics", propertyList.getParentFObj());

        }

        private static Dictionary<string, string> s_htKeywords;

        static LeaderPatternWidthMaker()
        {
            s_htKeywords = new Dictionary<string, string>();

            s_htKeywords.Add("use-font-metrics", "0pt");

        }

        protected override string CheckValueKeywords(string keyword)
        {

            string value = s_htKeywords[keyword];
            if (value == null)
            {
                return base.CheckValueKeywords(keyword);
            }
            else
            {
                return value;
            }
        }

        public override IPercentBase GetPercentBase(FObj fo, PropertyList propertyList)
        {
            return new LengthBase(fo, propertyList, LengthBase.CONTAINING_BOX);
        }
    }
}