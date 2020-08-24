using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Можно развернуть любой список или массив
/// </summary>
public class Train_Reverse : BaseTrain, IBase_LINQ
{

    public override void FullWriting()
    {
        var _result = (from item in list
                       select item
                      ).AsEnumerable().Reverse();
        result = _result.ToArray();
    }

    public override void ExtensionWriting()
    {
        var _result = list.Reverse();
        result = _result.ToArray();
    }

    public override void ShowBase()
    {
        base.ShowBase();
        Debug.Log("Базовое состояние");
        for (int i = 0; i < result.Length; i++)
        {
            Debug.Log(result[i].count);
        }
    }

    public override void ShowFull()
    {
        base.ShowFull();
        Debug.Log("ShowFull");
        for (int i = 0; i < result.Length; i++)
        {
            Debug.Log(result[i].count);
        }
    }

    public override void ShowExtension()
    {
        base.ShowExtension();
        Debug.Log("ShowExtension");
        for (int i = 0; i < result.Length; i++)
        {
            Debug.Log(result[i].count);
        }
    }
}
