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
        public Dictionary<ePug, bool> AutoSignupMap;
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

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("ID:{0} Name:{1}\n", Id, Name);
            sb.AppendFormat("    Knows About: ");
            foreach (KeyValuePair<ePug, bool> kv in KnowsAboutMap)
            {
                sb.AppendFormat("{0}:{1}, ", kv.Key, kv.Value);
            }
            foreach (KeyValuePair<ePug, bool> kv in AutoSignupMap)
            {
                sb.AppendFormat("{0}:{1}, ", kv.Key, kv.Value);
            }
            return sb.ToString();
        }
    }
}
