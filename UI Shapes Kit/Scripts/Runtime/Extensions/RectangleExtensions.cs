using UnityEngine;
using System.Collections;
using System.Reflection;

namespace ThisOtherThing.UI.Shapes
{
    public struct RoundedRadiuses
    {
        public float TL, TR, BL, BR;

        public RoundedRadiuses(float tl, float tr, float bl, float br)
        {
            TL = tl;
            TR = tr;
            BL = bl;
            BR = br;
        }
    }

	public static class RectangleExtensions
	{
        public static void SetRoundedRadiuses(this Rectangle rectangle, float tl, float tr, float bl, float br)
            => SetRoundedRadiuses(rectangle, tl, tr, bl, br);

        public static void SetRoundedRadiuses(this Rectangle rectangle, RoundedRadiuses roundedRadiuses)
        {
            rectangle.RoundedProperties.TLRadius = roundedRadiuses.TL;
            rectangle.RoundedProperties.TRRadius = roundedRadiuses.TR;
            rectangle.RoundedProperties.BLRadius = roundedRadiuses.BL;
            rectangle.RoundedProperties.BRRadius = roundedRadiuses.BR;

            rectangle.SetVerticesDirty();
        }
	}
}