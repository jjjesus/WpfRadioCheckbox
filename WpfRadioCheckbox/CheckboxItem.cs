using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfRadioCheckbox
{
    public class CheckboxItem
    {
        public string Name { get; set; }
        public bool IsChecked { get; set; }

        public CheckboxItem(string name, bool isChecked)
        {
            this.Name = name;
            this.IsChecked = isChecked;
        }
    }
}
