using System;
using System.Collections.Generic;
using System.Text;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp.ObjectTrackingAndBulkReplacment
{
    public class TrackingThemeFactory
    {
        private readonly List<WeakReference<ITheme>> themes = new List<WeakReference<ITheme>>();
        public ITheme CreateTheme(bool dark)
        {
            ITheme theme;
            if (dark)
            {
                theme = new LightTeam();
            }
            else
            {
                theme = new DarkTheam();
            }
            themes.Add(new WeakReference<ITheme>(theme));
            return theme;
        }
        public string Info
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var reference in themes)
                {
                    if(reference.TryGetTarget(out var theme))
                    {
                        bool dark = theme is DarkTheam;
                        sb.Append(dark ? "Dark" : "Light")
                            .AppendLine(" theme");
                    }
                }
                return sb.ToString();
            }
        }
    }
}
