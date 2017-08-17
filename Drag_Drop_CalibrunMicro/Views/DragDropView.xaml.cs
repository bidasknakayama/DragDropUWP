using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Caliburn.Micro;
using Drag_Drop_CalibrunMicro.sampleDatas;
using Windows.ApplicationModel.DataTransfer;


using Drag_Drop_CalibrunMicro.DataModel;


// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Drag_Drop_CalibrunMicro.Views
{
    /// </summary>
    public sealed partial class DragDropView : UserControl
    {

        public DragDropView()
        {
            this.InitializeComponent();
        }
    }
}