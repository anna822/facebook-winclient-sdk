﻿namespace Facebook.Client.Controls
{
    using System.Linq;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public class GroupTemplateSelector<T> : DataTemplateSelector
    {
        public DataTemplate EmptyGroupTemplate { get; set; }

        public DataTemplate GroupTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var group = item as GroupInfoList<T>;
            if (group != null && group.Any())
            {
                return this.GroupTemplate;
            }

            return this.EmptyGroupTemplate;
        }
    }
}
