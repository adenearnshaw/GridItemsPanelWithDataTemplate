using GridItemsPanelWithDataTemplate.Models;
using System;
using System.Collections.ObjectModel;

namespace GridItemsPanelWithDataTemplate.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private ObservableCollection<DataObject> _dataObjectCollection;
        private int _totalRows;
        private int _totalColumns;


        public ObservableCollection<DataObject> DataObjectCollection
        {
            get { return _dataObjectCollection; }
            set
            {
                _dataObjectCollection = value;
                RaisePropertyChanged();
            }
        }
        public int TotalRows
        {
            get { return _totalRows; }
            set
            {
                _totalRows = value;
                RaisePropertyChanged();
            }
        }
        public int TotalColumns
        {
            get { return _totalColumns; }
            set
            {
                _totalColumns = value;
                RaisePropertyChanged();
            }
        }


        public MainPageViewModel()
        {
            DataObjectCollection = new ObservableCollection<DataObject>();

            TotalRows = 4;
            TotalColumns = 6;
            PopulateDataObjects();
        }


        private void PopulateDataObjects()
        {
            DataObjectCollection.Clear();
            
            for (int c = 0; c < 6; c++)
            {
                //Top row
                DataObjectCollection.Add(GetShapeDataObject(0, c));
                //Bottom row
                DataObjectCollection.Add(GetShapeDataObject(3, c));
            }

            DataObjectCollection.Add(GetShapeDataObject(1, 0, false));
            DataObjectCollection.Add(GetShapeDataObject(1, 5, false));
            DataObjectCollection.Add(GetShapeDataObject(2, 0, false));
            DataObjectCollection.Add(GetShapeDataObject(2, 5, false));

            DataObjectCollection.Add(GetImageDataObject(1, 1));
            DataObjectCollection.Add(GetTextDataObject(1, 3));

        }
        private DataObject GetShapeDataObject(int row, int col, bool landscape = true)
        {
            return new DataObject
            {
                GridColumn = col,
                GridRow = row,
                GridRowSpan = 1,
                GridColumnSpan = 1,
                Height = landscape ? 30 : 100,
                Width = landscape ? 100 : 30,
                Type = DataObjectType.Shape,
            };
        }
        private DataObject GetImageDataObject(int row, int col)
        {
            return new DataObject
            {
                GridColumn = col,
                GridRow = row,
                GridRowSpan = 2,
                GridColumnSpan = 2,
                Height = 100,
                Width = 100,
                Type = DataObjectType.Image,
                ImageSource = "ms-appx:///Images/ExampleImage.png"
            };
        }
        private DataObject GetTextDataObject(int row, int col)
        {
            return new DataObject
            {
                GridColumn = col,
                GridRow = row,
                GridRowSpan = 2,
                GridColumnSpan = 2,
                Type = DataObjectType.Text,
                Text = "Bacon ipsum dolor amet pork belly flank short loin leberkas corned beef porchetta. T-bone beef ribs short loin pastrami jerky shankle pork belly ribeye swine."
            };
        }
    }
}
