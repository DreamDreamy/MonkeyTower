using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T m_Instance; // Stock Object
    public static T Instance { get { return m_Instance; } } // Return the current object

    protected virtual void Awake()
    { // Start on Awake load
        if (m_Instance == null) // Check if Instance is null
            m_Instance = (T)this; // put this on the Instance
    }

    protected virtual void OnDestroy()
    { // For destroy the object
        if (m_Instance == this) // Checked if the instance is this
            m_Instance = null; // Put null on instance
    }
}
