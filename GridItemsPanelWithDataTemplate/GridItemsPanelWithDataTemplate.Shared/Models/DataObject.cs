using System;
using System.Collections.Generic;
using System.Text;

namespace GridItemsPanelWithDataTemplate.Models
{
    public enum DataObjectType
    {
        Shape = 0,
        Image = 1,
        Text = 2
    }

    public class DataObject : IGridItem
    {
        public DataObjectType Type { get; set; }
        public string ImageSource { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Text { get; set; }
        public int GridRow { get; set; }
        public int GridColumn { get; set; }
        public int GridRowSpan { get; set; }
        public int GridColumnSpan { get; set; }
    }
}
