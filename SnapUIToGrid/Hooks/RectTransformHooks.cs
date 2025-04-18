using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace SnapUIToGrid.Hooks
{
    [HarmonyPatch(typeof(UIDraggable), "OnDrag")]
    public class RectTransformHooks
    {
        private static void Postfix(UIDraggable __instance)
        {
            var component = __instance.transform.GetComponent<RectTransform>();
            var anchoredPosition = component.anchoredPosition;
            component.anchoredPosition =
                new Vector2(GetNearestMultiple(anchoredPosition.x, Globals.SnapAmount),
                    GetNearestMultiple(anchoredPosition.y, Globals.SnapAmount));
        }

        private static float GetNearestMultiple(float number, float multiple)
        {
            return (float)(Math.Round(number / multiple) * multiple);
        }
    }
}