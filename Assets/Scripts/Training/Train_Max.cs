using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Train_Max : BaseTrain
{
    public override void FullWriting()
    {
        
    }

    public override void ExtensionWriting()
    {
        oneObject = list.Max()
    }


    public override void ShowExtension()
    {
        base.ShowExtension();
        Debug.Log("ShowExtension " + resultBool.ToString());
    }

    public override void ShowFull()
    {
        base.ShowFull();
        Debug.Log("ShowFull " + resultBool.ToString());
    }
}
