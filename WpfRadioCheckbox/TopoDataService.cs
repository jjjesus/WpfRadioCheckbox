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
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "RC_PUG", true ),
                        new CheckboxItem( "DREX_PUG", false ),
                        new CheckboxItem( "RP_PUG", false ),
                        new CheckboxItem( "SP_PUG", false )
                    },
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "RC_PUG", false ),
                        new CheckboxItem( "DREX_PUG", false ),
                        new CheckboxItem( "RP_PUG", false ),
                        new CheckboxItem( "SP_PUG", false )
                    }
                ),
                new CnmRole(
                    "Soft_Rock_Roll",
                    2,
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "RC_PUG", false ),
                        new CheckboxItem( "DREX_PUG", false ),
                        new CheckboxItem( "RP_PUG", false ),
                        new CheckboxItem( "SP_PUG", false )
                    },
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "RC_PUG", false ),
                        new CheckboxItem( "DREX_PUG", false ),
                        new CheckboxItem( "RP_PUG", false ),
                        new CheckboxItem( "SP_PUG", true )
                    }
                ),
                new CnmRole(
                    "Classic_Rock_Roll",
                    3,
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "RC_PUG", false ),
                        new CheckboxItem( "DREX_PUG", true ),
                        new CheckboxItem( "RP_PUG", false ),
                        new CheckboxItem( "SP_PUG", false )
                    },
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "RC_PUG", false ),
                        new CheckboxItem( "DREX_PUG", false ),
                        new CheckboxItem( "RP_PUG", false ),
                        new CheckboxItem( "SP_PUG", false )
                    }
                ),
                new CnmRole(
                    "Hard_Rock_Roll",
                    4,
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "RC_PUG", false ),
                        new CheckboxItem( "DREX_PUG", false ),
                        new CheckboxItem( "RP_PUG", false ),
                        new CheckboxItem( "SP_PUG", false )
                    },
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "RC_PUG", false ),
                        new CheckboxItem( "DREX_PUG", false ),
                        new CheckboxItem( "RP_PUG", true ),
                        new CheckboxItem( "SP_PUG", false )
                    }
                )
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
