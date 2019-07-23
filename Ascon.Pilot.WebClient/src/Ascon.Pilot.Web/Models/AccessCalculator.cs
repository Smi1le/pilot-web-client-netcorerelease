using Ascon.Pilot.DataClasses;
using System.Linq;

namespace Ascon.Pilot.Core
{
    public static class AccessCalculator
    {
        public static bool IsForbidden(this DObject obj)
        {
            return obj.TypeId == 0 && obj.Id != DObject.RootId && !obj.Access.Any() && obj.Attributes.Count == 0 && obj.StateInfo.State != ObjectState.DeletedPermanently;
        }
    }
}