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
        public List<CheckboxItem> KnowsAboutMap;
        public List<CheckboxItem> AutoSignupMap;
        public string Name { get; set; }
        public int Id { get; set; }

        static CnmRole()
        {
            RoleList = new List<CnmRole>();
        }

        public CnmRole(
            string name,
            int id,
            List<CheckboxItem> knowsAboutMap,
            List<CheckboxItem> autoSignupMap)
        {
            this.Name = name;
            this.Id = id;
            this.KnowsAboutMap = knowsAboutMap;
            this.AutoSignupMap = autoSignupMap;
            RoleList.Add(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("ID:{0} Name:{1}\n", Id, Name);
            sb.AppendFormat("    Knows About: ");

            foreach (var item in KnowsAboutMap)
            {
                sb.AppendFormat("{0}:{1}, ", item.Name, item.IsChecked);
            }

            sb.Append("\n");
            sb.AppendFormat("    Auto Signup On: ");
            foreach (var item in AutoSignupMap)
            {
                sb.AppendFormat("{0}:{1}, ", item.Name, item.IsChecked);
            }
            return sb.ToString();
        }
    }
}
