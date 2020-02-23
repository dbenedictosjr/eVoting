using OSPI.Infrastructure.Models;
using System;
using System.Linq;
using System.Security.Claims;

namespace OSPI.eVoting.Helpers
{
    public class UserClaimsHelper
    {
        public static bool CanDoAction(ClaimsPrincipal User, string type)
        {
            var claim = User.Claims.FirstOrDefault(x => x.Type == type);
            if (claim != null && claim.Value == Boolean.TrueString) return true;

            return false;
        }
        public static bool CanDoAnyActions(ClaimsPrincipal User, string module)
        {
            return (CanDoAction(User, module + UserClaims.CanAdd) ||
                    CanDoAction(User, module + UserClaims.CanView) ||
                    CanDoAction(User, module + UserClaims.CanEdit) ||
                    CanDoAction(User, module + UserClaims.CanDelete) ||
                    CanDoAction(User, module + UserClaims.CanPrint));
        }
    }
}