using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndieGabo.GLogger
{
    public abstract class GLogger : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] protected bool m_shouldLog = true;

        [Header("Colors")]
        [SerializeField] protected Color m_successColor = Color.green; // Green
        [SerializeField] protected Color m_warningColor = Color.yellow; // Yellow
        [SerializeField] protected Color m_dangerColor = Color.red; // Red

        protected string successHEX => "#" + ColorUtility.ToHtmlStringRGB(m_successColor);
        protected string warningHEX => "#" + ColorUtility.ToHtmlStringRGB(m_warningColor);
        protected string dangerHEX => "#" + ColorUtility.ToHtmlStringRGB(m_dangerColor);
        protected string whiteHEX => "#FFFFFF";

        protected virtual void DoLog(string message, string color = "#FFFFFF", Object sender = null)
        {
            if (!m_shouldLog) return;

            if (sender != null)
            {
                Debug.Log($"<color={color}> {message} </color>", sender);

            }
            else
            {
                Debug.Log($"<color={color}> {message} </color>");
            }
        }
    }
}