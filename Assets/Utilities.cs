using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilitiesPack
{
    public class Utilities : MonoBehaviour
    {
        public static float SmoothTransitionFloat(float startFloat, float endFloat, float time = 0)
        {
            float result = 0;
            if (time == 0) time = Time.deltaTime;
            if (Mathf.Abs(startFloat - endFloat) < 0.01f) result = endFloat;
            else result = Mathf.Lerp(startFloat, endFloat, time);
            return result;
        }
    }
}
