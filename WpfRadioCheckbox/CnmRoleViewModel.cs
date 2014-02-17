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

        // TODO: The radios and checkboxes are not displaying actual values.
        // TODO: Do not wrap raw values in Role.
        //
        public List<CheckboxItem> KnowsAboutChecklist
        {
            get
            {
                List<CheckboxItem> knowsAboutList = ToCheckboxList(_role.KnowsAboutMap);
                return knowsAboutList;
            }
            set
            {
                KnowsAboutChecklist = value;
                OnPropertyChanged("KnowsAboutChecklist");
            }
        }
        public List<CheckboxItem> AutoSignupChecklist
        {
            get
            {
                List<CheckboxItem> autoSignupList = ToCheckboxList(_role.AutoSignupMap);
                return autoSignupList;
            }
            set
            {
                AutoSignupChecklist = value;
                OnPropertyChanged("AutoSignupChecklist");
            }
        }
        public List<CheckboxItem> ToCheckboxList(List<CheckboxItem> dict)
        {
            List<CheckboxItem> checkboxList = new List<CheckboxItem>();
            foreach (CheckboxItem kv in dict)
            {
                checkboxList.Add(new CheckboxItem(
                    kv.Name.Replace("_PUG", String.Empty),
                    kv.IsChecked));
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
