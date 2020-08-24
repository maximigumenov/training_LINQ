using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Хоть один из объктов коллекции попадает под условие
/// </summary>
public class Train_Any : BaseTrain
{

    public override void FullWriting()
    {
        resultBool = (from item in list
                      select item
                      ).Any(x => x.count == 100);
    }

    public override void ExtensionWriting()
    {
        resultBool = list.Any(x => x.count == 1);
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
