using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreForms
{
    [HtmlTargetElement(Attributes="runat")]
    public class RunAtTagHelper : TagHelper
    {
        public string RunAt { get; set; }

        public override void Init(TagHelperContext context)
        {
            if (string.Compare(RunAt, "server", System.StringComparison.OrdinalIgnoreCase) != 0)
                throw new ParseException();

            base.Init(context);
        }
    }
}
