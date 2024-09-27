
using UnityEditor;
using UnityEngine;

namespace GODSObservables
{
    [CustomPropertyDrawer(typeof(AnimationCurveListReference))]
    public class AnimationCurveListPropertyDrawer : BaseListReferencePropertyDrawer<AnimationCurve, AnimationCurveList>
    {
        
    }
}
