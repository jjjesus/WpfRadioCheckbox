using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfRadioCheckbox
{
    public class CheckboxItem
    {
        public string GroupName { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }

        public CheckboxItem(string groupName, string name, bool isChecked)
        {
            this.GroupName = groupName;
            this.Name = name;
            this.IsChecked = isChecked;
        }
    }
}
