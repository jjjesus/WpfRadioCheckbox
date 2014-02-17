using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;


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
            KnowsAboutChecklist = new ObservableCollection<CheckboxItem>(_role.KnowsAboutMap);
            AutoSignupChecklist = new ObservableCollection<CheckboxItem>(_role.AutoSignupMap);
        }

        // TODO: The radios and checkboxes are not displaying actual values.
        // TODO: Do not wrap raw values in Role.
        //
        public ObservableCollection<CheckboxItem> KnowsAboutChecklist { get; set; }
        public ObservableCollection<CheckboxItem> AutoSignupChecklist { get; set; }

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
