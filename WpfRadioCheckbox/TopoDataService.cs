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
                        new CheckboxItem( "Rock_Roll", "RC_PUG", true ),
                        new CheckboxItem( "Rock_Roll", "DREX_PUG", false ),
                        new CheckboxItem( "Rock_Roll", "RP_PUG", false ),
                        new CheckboxItem( "Rock_Roll", "SP_PUG", false )
                    },
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "Rock_Roll", "RC_PUG", false ),
                        new CheckboxItem( "Rock_Roll", "DREX_PUG", false ),
                        new CheckboxItem( "Rock_Roll", "RP_PUG", false ),
                        new CheckboxItem( "Rock_Roll", "SP_PUG", false )
                    }
                ),
                new CnmRole(
                    "Soft_Rock_Roll",
                    2,
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "Soft_Rock_Roll", "RC_PUG", false ),
                        new CheckboxItem( "Soft_Rock_Roll", "DREX_PUG", false ),
                        new CheckboxItem( "Soft_Rock_Roll", "RP_PUG", false ),
                        new CheckboxItem( "Soft_Rock_Roll", "SP_PUG", false )
                    },
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "Soft_Rock_Roll", "RC_PUG", false ),
                        new CheckboxItem( "Soft_Rock_Roll", "DREX_PUG", false ),
                        new CheckboxItem( "Soft_Rock_Roll", "RP_PUG", false ),
                        new CheckboxItem( "Soft_Rock_Roll", "SP_PUG", true )
                    }
                ),
                new CnmRole(
                    "Classic_Rock_Roll",
                    3,
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "Classic_Rock_Roll", "RC_PUG", false ),
                        new CheckboxItem( "Classic_Rock_Roll", "DREX_PUG", true ),
                        new CheckboxItem( "Classic_Rock_Roll", "RP_PUG", false ),
                        new CheckboxItem( "Classic_Rock_Roll", "SP_PUG", false )
                    },
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "Classic_Rock_Roll", "RC_PUG", false ),
                        new CheckboxItem( "Classic_Rock_Roll", "DREX_PUG", false ),
                        new CheckboxItem( "Classic_Rock_Roll", "RP_PUG", false ),
                        new CheckboxItem( "Classic_Rock_Roll", "SP_PUG", false )
                    }
                ),
                new CnmRole(
                    "Hard_Rock_Roll",
                    4,
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "Hard_Rock_Roll", "RC_PUG", false ),
                        new CheckboxItem( "Hard_Rock_Roll", "DREX_PUG", false ),
                        new CheckboxItem( "Hard_Rock_Roll", "RP_PUG", false ),
                        new CheckboxItem( "Hard_Rock_Roll", "SP_PUG", false )
                    },
                    new List<CheckboxItem>() { 
                        new CheckboxItem( "Hard_Rock_Roll", "RC_PUG", false ),
                        new CheckboxItem( "Hard_Rock_Roll", "DREX_PUG", false ),
                        new CheckboxItem( "Hard_Rock_Roll", "RP_PUG", true ),
                        new CheckboxItem( "Hard_Rock_Roll", "SP_PUG", false )
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
