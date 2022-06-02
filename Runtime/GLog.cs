using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// The default GLogger. 
/// </summary>
public class GLog : GLogger
{
    private static GLog _log;

    /// <summary>
    /// Instantiate a new GLog if it does not already exists.
    /// Returns the GLog instance to be accessed statically.
    /// </summary>    
    public static GLog I {
        get
        {
            if (!m_logger) { FindOrInstantiate<GLog>(); }

            _log = m_logger.GetComponent<GLog>();
            if (!_log) { m_logger.AddComponent<GLog>(); }
            return _log;
        }
    }

    protected virtual void Awake()
    {
        // If the GLog is beeing instantiated manually, 
        // Defining itself as the instance. Kinda like a Singleton.
        _log = this;
    }

    /// <summary>
    /// The GLoggers default Log message
    /// </summary>
    /// <param name="message"> The message to be logged </param>
    /// <param name="sender"> Optional: The object the log message is comming from </param>
    public static void Log(string message, Object sender = null) => I.DoLog(message, I.whiteHEX, sender: sender);

    /// <summary>
    /// The success colored Log message
    /// </summary>
    /// <param name="message"> The message to be logged </param>
    /// <param name="sender"> Optional: The object the log message is comming from </param>
    public static void Success(string message, Object sender = null) => I.DoLog(message, I.successHEX, sender);

    /// <summary>
    /// The warning colored Log message
    /// </summary>
    /// <param name="message"> The message to be logged </param>
    /// <param name="sender"> Optional: The object the log message is comming from </param>
    public static void Warning(string message, Object sender = null) => I.DoLog(message, I.warningHEX, sender);

    /// <summary>
    /// The danger colored Log message
    /// </summary>
    /// <param name="message"> The message to be logged </param>
    /// <param name="sender"> Optional: The object the log message is comming from </param>
    public static void Danger(string message, Object sender = null) => I.DoLog(message, I.dangerHEX, sender);


    public static void Configure(bool shouldLog, Color success, Color warning, Color danger)
    {
        Configure(shouldLog);
        Configure(success, warning, danger);
    }

    public static void Configure()
    {
        I.m_shouldLog = true;
        I.m_successColor = Color.green;
        I.m_warningColor = Color.yellow;
        I.m_dangerColor = Color.red;
    }

    public static void Configure(bool shouldLog)
    {
        I.m_shouldLog = shouldLog;
    }

    public static void Configure(Color success, Color warning, Color danger)
    {
        if (success != null) I.m_successColor = success;
        if (warning != null) I.m_warningColor = warning;
        if (danger != null) I.m_dangerColor = danger;
    }


    [MenuItem("GameObject/GLogger/GLog")]
    public static void CreateSeparator(MenuCommand menuCommand)
    {
        GameObject logger = new GameObject(typeof(GLog).Name);
        logger.AddComponent<GLog>();
        GameObjectUtility.SetParentAndAlign(logger, menuCommand.context as GameObject);
        Undo.RegisterCreatedObjectUndo(logger, "Create " + logger.name);
        Selection.activeObject = logger;
    }
}
