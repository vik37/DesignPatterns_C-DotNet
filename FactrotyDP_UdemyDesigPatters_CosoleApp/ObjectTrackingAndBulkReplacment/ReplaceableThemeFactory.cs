using System;
using System.Collections.Generic;
using System.Text;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp.ObjectTrackingAndBulkReplacment
{
    public class ReplaceableThemeFactory
    {
        private readonly List<WeakReference<Ref<ITheme>>> themes
            = new List<WeakReference<Ref<ITheme>>>();
        private ITheme CreaeThemeImpl(bool dark)
        {
            if (dark)
            {
                return new DarkTheam();
            }
            else
            {
                return new LightTeam();
            }
        }
        public Ref<ITheme> CreateTheme(bool dark)
        {
            var r = new Ref<ITheme>(CreaeThemeImpl(dark));
            themes.Add(new WeakReference<Ref<ITheme>>(r));
            return r;
        }
        public void ReplaceTheme(bool dark)
        {
            foreach (var wr in themes)
            {
                if(wr.TryGetTarget(out var reeference))
                {
                    reeference.Value = CreaeThemeImpl(dark);
                }
            }
        }
    }
}
