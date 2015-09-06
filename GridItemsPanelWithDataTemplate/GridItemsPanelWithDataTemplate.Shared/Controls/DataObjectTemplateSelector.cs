using GridItemsPanelWithDataTemplate.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace GridItemsPanelWithDataTemplate.Controls
{
    public class DataObjectTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ShapeTemplate { get; set; }
        public DataTemplate ImageTemplate { get; set; }
        public DataTemplate TextTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var listItem = item as DataObject;
            var uiElement = container as FrameworkElement;

            if (listItem == null)
                return TextTemplate;

            Grid.SetColumn(uiElement, listItem.GridColumn);
            Grid.SetRow(uiElement, listItem.GridRow);
            Grid.SetColumnSpan(uiElement, listItem.GridColumnSpan);
            Grid.SetRowSpan(uiElement, listItem.GridRowSpan);


            switch (listItem.Type)
            {
                case DataObjectType.Shape:
                    return ShapeTemplate;
                case DataObjectType.Image:
                    return ImageTemplate;
                case DataObjectType.Text:
                    return TextTemplate;
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}
