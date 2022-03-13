using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GLog : GLogger
{
    public static GLog I;

    protected virtual void Awake()
    {
        I = this;
    }

    public void Log(string message, Object sender = null)
    {
        DoLog(message, color: whiteHEX, sender: sender);
    }

    public void Success(string message, Object sender = null)
    {
        DoLog(message, successHEX, sender);
    }

    public void Warning(string message, Object sender = null)
    {
        DoLog(message, warningHEX, sender);
    }

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
