using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TKDemoMVC.TagHelpers
{
    [TargetElement(Attributes = "demo-repeat")]
    public class RepeatTagHelper : ITagHelper {
        [HtmlAttributeName("count")]
        public int Count { get; set; }
        public int Order {
            get {
                return 1;
            }
        }



        public async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) {
            if (Count <= 0) {
                return;
            }

            for (int i = 0; i < Count; i++) {
                var content = await context.GetChildContentAsync();
                output.Content.Append(content);
            }
        }
    }
}
