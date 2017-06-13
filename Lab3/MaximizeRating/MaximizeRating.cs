using System;
using Lab3Plugins;
using Lab3Plugins.Data;

namespace GroupActionPlugins
{
    public class MaximizeRating : IGroupActionPlugin
    {
        public string ActionText { get; private set; } =
            "Повысить всем рейтинг";

        public void ApplyTo(Group group)
        {
            foreach (var member in group)
            {
                if (member.GetAttributeValue("Rating") != null)
                {
                    member.SetAttributeValue("Rating", "100");
                }
            }
        }
    }
}
