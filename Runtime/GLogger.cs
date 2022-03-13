using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Extend from this class to create your custom GLogger
/// and use its utillities
/// </summary>
public abstract class GLogger : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] protected bool m_shouldLog = true;

    [Header("Colors")]
    [SerializeField] protected Color m_successColor = Color.green; // Green
    [SerializeField] protected Color m_warningColor = Color.yellow; // Yellow
    [SerializeField] protected Color m_dangerColor = Color.red; // Red

    /// <summary>
    /// The success color's Hexadecimal code
    /// </summary>
    /// <returns> The hex code string </returns>
    protected string successHEX => "#" + ColorUtility.ToHtmlStringRGB(m_successColor);

    /// <summary>
    /// The warning color's Hexadecimal code
    /// </summary>
    /// <returns> The hex code string </returns>
    protected string warningHEX => "#" + ColorUtility.ToHtmlStringRGB(m_warningColor);

    /// <summary>
    /// The danger color's Hexadecimal code
    /// </summary>
    /// <returns> The hex code string </returns>
    protected string dangerHEX => "#" + ColorUtility.ToHtmlStringRGB(m_dangerColor);

    /// <summary>
    /// The white color's Hexadecimal code
    /// </summary>
    /// <returns> The hex code string </returns>
    protected string whiteHEX => "#FFFFFF";

    /// <summary>
    /// The GLogger's root method for logging. Use this if you are creating a custom 
    /// GLogger.
    /// </summary>
    /// <param name="message">The message to be logged</param>
    /// <param name="color">The hex code of the color your logged text shoul have</param>
    /// <param name="sender">The object where the log is comming from if any</param>
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