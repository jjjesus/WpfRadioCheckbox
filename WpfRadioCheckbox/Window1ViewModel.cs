using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WpfRadioCheckbox
{
    public class Window1ViewModel : INotifyPropertyChanged
    {
        public Window1ViewModel()
        {
            _messageText = "Click Load to get the Roles.";
        }


        List<CnmRoleViewModel> _roleViewModelList;
        public List<CnmRoleViewModel> RoleViewModelList
        {
            get
            {
                return this._roleViewModelList;
            }
            set
            {
                this._roleViewModelList = value;
                OnPropertyChanged("RoleViewModelList");
            }
        }

        string _messageText;
        public string MessageText
        {
            get
            {
                return this._messageText;
            }
            set
            {
                this._messageText = value;
                OnPropertyChanged("MessageText");
            }
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
        public void Load()
        {
            TopoDataService.LoadDataService();

            RoleViewModelList = new List<CnmRoleViewModel>();
            foreach (CnmRole role in CnmRole.RoleList)
            {
                RoleViewModelList.Add(new CnmRoleViewModel(role));
            }
            MessageText = TopoDataService.DumpRoles();
        }
    }
}
