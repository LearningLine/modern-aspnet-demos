using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ButtonHelper.Controllers
{
    public static class ButtonHelpers
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string content)
        {
            TagBuilder tagBuilder1 = new TagBuilder("input");
            tagBuilder1.Attributes.Add("type", "button");
            tagBuilder1.Attributes.Add("value", content + "!!!");
            return MvcHtmlString.Create(tagBuilder1.ToString(TagRenderMode.Normal));
        }
    }
}