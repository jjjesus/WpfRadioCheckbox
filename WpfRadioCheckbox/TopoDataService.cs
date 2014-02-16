using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfRadioCheckbox
{
    public class TopoDataService
    {
        public static void LoadDataService()
        {
            CnmRole.RoleList = new List<CnmRole>();
            CnmRole[] roles = 
            {
                new CnmRole(
                    "Rock_Roll", 
                    1, 
                    new Dictionary<CnmRole.ePug, bool>() { 
                        { CnmRole.ePug.RC_PUG, true },
                        { CnmRole.ePug.DREX_PUG, false },
                        { CnmRole.ePug.RP_PUG, false },
                        { CnmRole.ePug.SP_PUG, false }
                    },
                    new Dictionary<CnmRole.ePug, bool>() { 
                        { CnmRole.ePug.RC_PUG, false },
                        { CnmRole.ePug.DREX_PUG, false },
                        { CnmRole.ePug.RP_PUG, false },
                        { CnmRole.ePug.SP_PUG, false }
                    }
                ),
                new CnmRole(
                    "Soft_Rock_Roll",
                    2,
                    new Dictionary<CnmRole.ePug, bool>() { 
                        { CnmRole.ePug.RC_PUG, false },
                        { CnmRole.ePug.DREX_PUG, false },
                        { CnmRole.ePug.RP_PUG, false },
                        { CnmRole.ePug.SP_PUG, false }
                    },
                    new Dictionary<CnmRole.ePug, bool>() { 
                        { CnmRole.ePug.RC_PUG, false },
                        { CnmRole.ePug.DREX_PUG, false },
                        { CnmRole.ePug.RP_PUG, false },
                        { CnmRole.ePug.SP_PUG, true }
                    }
                ),
                new CnmRole(
                    "Classic_Rock_Roll",
                    3,
                    new Dictionary<CnmRole.ePug, bool>() { 
                        { CnmRole.ePug.RC_PUG, false },
                        { CnmRole.ePug.DREX_PUG, true },
                        { CnmRole.ePug.RP_PUG, false },
                        { CnmRole.ePug.SP_PUG, false }
                    },
                    new Dictionary<CnmRole.ePug, bool>() { 
                        { CnmRole.ePug.RC_PUG, false },
                        { CnmRole.ePug.DREX_PUG, false },
                        { CnmRole.ePug.RP_PUG, false },
                        { CnmRole.ePug.SP_PUG, false }
                    }
                ),
                new CnmRole(
                    "Hard_Rock_Roll",
                    4,
                    new Dictionary<CnmRole.ePug, bool>() { 
                        { CnmRole.ePug.RC_PUG, false },
                        { CnmRole.ePug.DREX_PUG, false },
                        { CnmRole.ePug.RP_PUG, false },
                        { CnmRole.ePug.SP_PUG, false }
                    },
                    new Dictionary<CnmRole.ePug, bool>() { 
                        { CnmRole.ePug.RC_PUG, false },
                        { CnmRole.ePug.DREX_PUG, false },
                        { CnmRole.ePug.RP_PUG, true },
                        { CnmRole.ePug.SP_PUG, false }
                    }
                ),
            };
        }
        public static string DumpRoles()
        {
            StringBuilder sb = new StringBuilder();
            foreach (CnmRole role in CnmRole.RoleList)
            {
                sb.AppendFormat("{0}\n", role.ToString());
            }
            return sb.ToString();
        }
    }
}
