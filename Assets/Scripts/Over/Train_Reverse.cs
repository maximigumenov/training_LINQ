using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Можно развернуть любой список или массив
/// </summary>
public class Train_Reverse : IBase_LINQ
{
    public Mockup_Human[] list = new Mockup_Human[15];
    public Mockup_Human[] result;

    public void FullWriting()
    {
        var _result = (from item in list
                       select item
                      ).AsEnumerable().Reverse();
        result = _result.ToArray();
    }

    public void ExtensionWriting()
    {
        var _result = list.Reverse();
        result = _result.ToArray();
    }

    

    public void InitializationMockups()
    {
        list = new Mockup_Human[15];

        for (int i = 0; i < list.Length; i++)
        {
            list[i] = new Mockup_Human();
            list[i].Initialization(i);
        }
    }

    public void Show()
    {
        for (int i = 0; i < result.Length; i++)
        {
            Debug.Log(result[i].count);
        }


    }

    public void CheckWays()
    {
        InitializationMockups();
        result = list;
        Show();
        InitializationMockups();
        FullWriting();
        Show();
        InitializationMockups();
        ExtensionWriting();
        Show();
    }

}
