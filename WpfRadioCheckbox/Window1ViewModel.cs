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


        List<CnmRole> _roleList;
        public List<CnmRole> RoleList
        {
            get
            {
                return this._roleList;
            }
            set
            {
                this._roleList = value;
                OnPropertyChanged("RoleList");
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
            RoleList = new List<CnmRole>(CnmRole.RoleList);
            MessageText = TopoDataService.DumpRoles();
        }
    }
}
