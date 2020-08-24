using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTrain : IBase_LINQ
{

    public Mockup_Human[] list = new Mockup_Human[15];
    public Mockup_Human[] result;
    public bool resultBool;

    public virtual void InitializationMockups() {
        list = new Mockup_Human[15];

        for (int i = 0; i < list.Length; i++)
        {
            list[i] = new Mockup_Human();
            list[i].Initialization(i);
        }
    }



    public virtual void CheckWays() {
        InitializationMockups();
        result = list;
        ShowBase();
        InitializationMockups();
        FullWriting();
        ShowFull();
        InitializationMockups();
        ExtensionWriting();
        ShowExtension();
    }

    public virtual void ShowBase()
    {

    }

    public virtual void ShowFull()
    {
        
    }

    public virtual void ShowExtension()
    {
        
    }

    public virtual void FullWriting()
    {
        
    }

    public virtual void ExtensionWriting()
    {
        
    }
}
