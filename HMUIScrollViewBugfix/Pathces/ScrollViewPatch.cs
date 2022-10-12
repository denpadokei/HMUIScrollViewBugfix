using HarmonyLib;
using HMUI;
using UnityEngine;

namespace HMUIScrollViewBugfix.Pathces
{
    [HarmonyPatch(typeof(ScrollView), "contentSize", MethodType.Getter)]
    internal class ScrollViewget_contentSizePatch
    {
        public static bool Prefix(RectTransform ____contentRectTransform, ref float __result)
        {
            try {
                if (____contentRectTransform == null || ____contentRectTransform.rect == null) {
                    __result = 0f;
                    return false;
                }
            }
            catch (System.Exception e) {
                Plugin.Log.Error(e);
                __result = 0f;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(ScrollView), "scrollPageSize", MethodType.Getter)]
    internal class ScrollViewget_scrollPageSizePatch
    {
        public static bool Prefix(RectTransform ____viewport, ref float __result)
        {
            try {
                if (____viewport == null || ____viewport.rect == null) {
                    __result = 0f;
                    return false;
                }
            }
            catch (System.Exception e) {
                Plugin.Log.Error(e);
                __result = 0f;
                return false;
            }
            return true;
        }
    }
}
