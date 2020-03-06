using OSPI.Infrastructure.Models;
using System;
using System.Linq;
using System.Security.Claims;

namespace OSPI.Voting.Helpers
{
    public class UserClaimsHelper
    {
        public static bool CanDoAction(ClaimsPrincipal user, string type)
        {
            var claim = user.Claims.FirstOrDefault(x => x.Type == type);
            if (claim != null && claim.Value == Boolean.TrueString) return true;

            return false;
        }
        public static bool CanDoAnyActions(ClaimsPrincipal user, string module)
        {
            return (CanDoAction(user, module + UserClaims.CanAdd) ||
                    CanDoAction(user, module + UserClaims.CanView) ||
                    CanDoAction(user, module + UserClaims.CanEdit) ||
                    CanDoAction(user, module + UserClaims.CanDelete) ||
                    CanDoAction(user, module + UserClaims.CanPrint));
        }
    }
}