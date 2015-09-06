using System;
using System.Collections.Generic;
using System.Text;

namespace GridItemsPanelWithDataTemplate.Models
{
    public interface IGridItem
    {
        int GridRow { get; set; }
        int GridColumn { get; set; }
        int GridRowSpan { get; set; }
        int GridColumnSpan { get; set; }
    }
}
