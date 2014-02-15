using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfRadioCheckbox
{
    public class CnmRole
    {
        public static List<CnmRole> RoleList { get; set; }
        public enum ePug {
            RC_PUG,
            DREX_PUG,
            RP_PUG,
            SP_PUG
        }
        public Dictionary<ePug, bool> KnowsAboutMap;
        public List<RoleCheckboxItem> KnowsAboutChecklist
        {
            get
            {
                List<RoleCheckboxItem> knowsAboutList = ToCheckboxList(KnowsAboutMap);
                return knowsAboutList;
            }
        }
        public Dictionary<ePug, bool> AutoSignupMap;
        public List<RoleCheckboxItem> AutoSignupChecklist
        {
            get
            {
                List<RoleCheckboxItem> autoSignupList= ToCheckboxList(AutoSignupMap);
                return autoSignupList;
            }
        }
        public string Name { get; set; }
        public int Id { get; set; }

        static CnmRole()
        {
            RoleList = new List<CnmRole>();
        }

        public CnmRole(
            string name,
            int id,
            Dictionary<ePug, bool> knowsAboutMap,
            Dictionary<ePug, bool> autoSignupMap)
        {
            this.Name = name;
            this.Id = id;
            this.KnowsAboutMap = knowsAboutMap;
            this.AutoSignupMap = autoSignupMap;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("ID:{0} Name:{1}\n", Id, Name);
            sb.AppendFormat("    Knows About: ");

            List<RoleCheckboxItem> knowsAboutList = ToCheckboxList(KnowsAboutMap);
            foreach (var item in knowsAboutList)
            {
                sb.AppendFormat("{0}:{1}, ", item.Name, item.IsChecked);
            }

            sb.Append("\n");
            sb.AppendFormat("    Auto Signup On: ");
            List<RoleCheckboxItem> autoSignupList = ToCheckboxList(AutoSignupMap);
            foreach (var item in autoSignupList)
            {
                sb.AppendFormat("{0}:{1}, ", item.Name, item.IsChecked);
            }
            return sb.ToString();
        }
        public List<RoleCheckboxItem> ToCheckboxList(Dictionary<ePug, bool> dict)
        {
            List<RoleCheckboxItem> checkboxList = new List<RoleCheckboxItem>();
            foreach (KeyValuePair<ePug, bool> kv in dict)
            {
                checkboxList.Add(new RoleCheckboxItem(
                    kv.Key.ToString().Replace("_PUG",String.Empty),
                    kv.Value));
            }
            return checkboxList;
        }
    }
}
