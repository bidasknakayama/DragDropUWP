using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Windows.UI;

namespace Drag_Drop_CalibrunMicro.DataModel
{
    public class Item
    {
        static List<Windows.UI.Color> colors = typeof(Windows.UI.Colors)
          .GetRuntimeProperties()
          .Select((x) => (Windows.UI.Color)x.GetValue(null)).ToList<Windows.UI.Color>();

        public int Id { get; set; }
        public int GroupId { get; set; }
        public Windows.UI.Color GroupColor
        {
            get
            {
                int index = GroupId;
                while (index > colors.Count - 1)
                {
                    index -= colors.Count;
                }
                Color c = colors[index];
                if (c.R == 0 && c.G == 0 && c.B == 0)
                {
                    // don't use Black
                    c = Color.FromArgb(255, 60, 60, 60);
                    colors[index] = c;
                }
                return c;
            }
        }
    }

    public class Group
    {
        // static integer which should be used as group Id for the new group
        private static int newGroupId = 1;

        private int _id;

        public static Group GetNewGroup()
        {
            Group gr = new Group();
            gr.Id = newGroupId;
            return gr;
        }

        private Group()
        {
            Items = new ObservableCollection<Item>();
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                if (newGroupId <= _id)
                {
                    // update newGroupId so that Id is unique
                    newGroupId = _id + 1;
                }
            }
        }
        public ObservableCollection<Item> Items { get; set; }
    }
}
