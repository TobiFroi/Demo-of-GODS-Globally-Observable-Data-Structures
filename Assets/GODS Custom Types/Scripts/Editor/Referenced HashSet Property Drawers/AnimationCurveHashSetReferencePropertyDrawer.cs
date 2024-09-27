
using UnityEditor;
using UnityEngine;

namespace GODSObservables
{
    [CustomPropertyDrawer(typeof(AnimationCurveHashSetReference))]
    public class AnimationCurveHashSetPropertyDrawer : BaseHashSetReferencePropertyDrawer<AnimationCurve, AnimationCurveHashSet>
    {
        
    }
}
