using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace WpfRadioCheckbox
{
    public class CnmRoleViewModel : INotifyPropertyChanged
    {
        public string Name { get { return _role.Name; } }
        public int Id { get { return _role.Id; } }
        CnmRole _role;
        public static List<CnmRoleViewModel> RoleList { get; set; }
        public CnmRole Role
        {
            get { return _role; }
            set { _role = value; }
        }
        static CnmRoleViewModel()
        {
            RoleList = new List<CnmRoleViewModel>();
        }
        public CnmRoleViewModel(CnmRole role)
        {
            this._role = role;
            RoleList.Add(this);
        }

        public class RoleCheckboxItem
        {
            public string Name { get; set; }
            public bool IsChecked { get; set; }
            public RoleCheckboxItem(string name, bool isChecked)
            {
                this.Name = name;
                this.IsChecked = isChecked;
            }
        }


        public List<RoleCheckboxItem> KnowsAboutChecklist
        {
            get
            {
                List<RoleCheckboxItem> knowsAboutList = ToCheckboxList(_role.KnowsAboutMap);
                return knowsAboutList;
            }
            set
            {
                KnowsAboutChecklist = value;
                OnPropertyChanged("KnowsAboutChecklist");
            }
        }
        public List<RoleCheckboxItem> AutoSignupChecklist
        {
            get
            {
                List<RoleCheckboxItem> autoSignupList = ToCheckboxList(_role.AutoSignupMap);
                return autoSignupList;
            }
            set
            {
                AutoSignupChecklist = value;
                OnPropertyChanged("AutoSignupChecklist");
            }
        }
        public List<RoleCheckboxItem> ToCheckboxList(Dictionary<CnmRole.ePug, bool> dict)
        {
            List<RoleCheckboxItem> checkboxList = new List<RoleCheckboxItem>();
            foreach (KeyValuePair<CnmRole.ePug, bool> kv in dict)
            {
                checkboxList.Add(new RoleCheckboxItem(
                    kv.Key.ToString().Replace("_PUG", String.Empty),
                    kv.Value));
            }
            return checkboxList;
        }
        // Create the OnPropertyChanged method to raise the event 
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
