using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using System.Diagnostics;

using Caliburn.Micro;

using Drag_Drop_CalibrunMicro.sampleDatas;
using Drag_Drop_CalibrunMicro.Controls;

namespace Drag_Drop_CalibrunMicro.ViewModels
{

    public class DragDropViewModel : Screen
    {
        private ObservableCollection<Category> _categoryCollectionViewSource;
        public ObservableCollection<Category> categoryCollectionViewSource
        {
            get { return _categoryCollectionViewSource; }
            set
            {
                this.Set(ref _categoryCollectionViewSource, value);
            }
        }
        SampleData sd = new SampleData();
        Book draggedItem;

        public DragDropViewModel()
        {
        
            
        }

        protected override void OnInitialize()
        {
            Debug.WriteLine("OnInitialize");
            categoryCollectionViewSource = sd.GetCategoryDataSource();
        }



        // creates new group in the data source, if end-user drags item to the new group placeholder
        private void gve_BeforeDrop(object sender, BeforeDropItemsEventArgs e)
        {
            if (e.RequestCreateNewGroup)
            {
                // create new group and re-assign datasource 
                //Group group = Group.GetNewGroup();
                //_groups.Insert(e.NewGroupIndex, group);
                //UpdateDataContext();
            }
        }

        // removes empty groups (except the last one)
        private void gve_Drop(object sender, DragEventArgs e)
        {


        }

        /// <summary>
        /// Set column spans depending on group id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gve_PreparingContainerForItem(object sender, PreparingContainerForItemEventArgs e)
        {
        }
    }
}
