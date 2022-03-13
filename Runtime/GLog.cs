using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// The default GLogger. 
/// </summary>
public class GLog : GLogger
{

    /// <summary>
    /// The GLog instance to be accessed statically
    /// </summary>    
    public static GLog I;

    protected virtual void Awake()
    {
        I = this; // Defining itself as the instance. Kinda like a Singleton.
    }

    /// <summary>
    /// The GLoggers default Log message
    /// </summary>
    /// <param name="message"> The message to be logged </param>
    /// <param name="sender"> Optional: The object the log message is comming from </param>
    public void Log(string message, Object sender = null)
    {
        DoLog(message, color: whiteHEX, sender: sender);
    }

    /// <summary>
    /// The success colored Log message
    /// </summary>
    /// <param name="message"> The message to be logged </param>
    /// <param name="sender"> Optional: The object the log message is comming from </param>
    public void Success(string message, Object sender = null)
    {
        DoLog(message, successHEX, sender);
    }

    /// <summary>
    /// The warning colored Log message
    /// </summary>
    /// <param name="message"> The message to be logged </param>
    /// <param name="sender"> Optional: The object the log message is comming from </param>
    public void Warning(string message, Object sender = null)
    {
        DoLog(message, warningHEX, sender);
    }

    /// <summary>
    /// The danger colored Log message
    /// </summary>
    /// <param name="message"> The message to be logged </param>
    /// <param name="sender"> Optional: The object the log message is comming from </param>
    public void Danger(string message, Object sender = null)
    {
        DoLog(message, dangerHEX, sender);
    }

    [MenuItem("GameObject/GLogger/GLog")]
    public static void CreateSeparator(MenuCommand menuCommand)
    {
        GameObject logger = new GameObject("GLog");
        logger.AddComponent<GLog>();
        GameObjectUtility.SetParentAndAlign(logger, menuCommand.context as GameObject);
        Undo.RegisterCreatedObjectUndo(logger, "Create " + logger.name);
        Selection.activeObject = logger;
    }
}
