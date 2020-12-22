using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public class MainFlow : MonoBehaviour
{
    Dictionary<string, MethodInfo> methodDict = new Dictionary<string, MethodInfo>();

    void Start()
    {
        System.Type ourType = this.GetType();

        MethodInfo[] mi = ourType.GetMethods();

        foreach (MethodInfo item in mi)
        {
            item.Invoke(this, null);
        }
    }

    public void Move()
    {
        Debug.Log("moving...");
    }

    public void Speak()
    {
        Debug.Log("speaking...");
    }
}
