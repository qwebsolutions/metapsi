using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public static class Badge
    {
        private static HashSet<string> alertTags = null;

        public static HashSet<string> AlertTags
        {
            get
            {
                if (alertTags == null)
                {
                    alertTags = new HashSet<string>();
                    alertTags.Add("critical");
                    alertTags.Add("fatal");
                    alertTags.Add("error");
                }

                return alertTags;
            }
        }

        public static void AddAlertBadge(this BlockBuilder b, Var<HyperNode> parent, Var<string> currentTag)
        {
            var lowercase = b.ToLowercase(currentTag);
            var isAlert = b.Get(
                b.Const(Metapsi.Hyperapp.Badge.AlertTags),
                lowercase,
                (alertTags, lowercase) => alertTags.Select(x => x).Contains(lowercase));

            b.If(isAlert, b =>
            {
                var badge = b.Add(parent, b.Badge(b.Const("ALERT")));
                b.AddClass(badge, "bg-rose-600");
            });
        }
    }
}

