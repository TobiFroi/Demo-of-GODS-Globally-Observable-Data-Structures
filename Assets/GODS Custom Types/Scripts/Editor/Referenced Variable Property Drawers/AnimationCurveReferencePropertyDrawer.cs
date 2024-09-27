
using UnityEditor;
using UnityEngine;

namespace GODSObservables
{
    [CustomPropertyDrawer(typeof(AnimationCurveReference))]
    public class AnimationCurveVariablePropertyDrawer : BaseVariableReferencePropertyDrawer<AnimationCurve, AnimationCurveVariable>
    {
        protected override AnimationCurve DrawField(Rect position, AnimationCurve value)
        {
            return EditorGUI.CurveField(position, value);
        }
    }
}
