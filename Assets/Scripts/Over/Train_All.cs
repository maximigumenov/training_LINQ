using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Проверить, что все в этой коллекции подходят под условия
/// </summary>
public class Train_All : BaseTrain
{

    public override void FullWriting()
    {
        resultBool = (from item in list
                      select item
                      ).All(x => x.count == 50);
    }

    public override void ExtensionWriting()
    {
        resultBool = list.All(x => x.count < 50);
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
