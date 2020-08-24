using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Вернет последнее значение в коллекции или последнее значение, соответствующее условию.
/// Если это невозможно (особенно полезно с условием) выдаст по умолчанию. Для ссылочных типов это null
/// </summary>
public class Train_LastOrDefault : BaseTrain
{
    public override void FullWriting()
    {
        
        oneObject = (from item in list
                     select item
                     ).LastOrDefault();
    }

    public override void ExtensionWriting()
    {
        oneObject = list.LastOrDefault(x => x.count > 100);
        
    }


    public override void ShowExtension()
    {
        base.ShowExtension();
        Debug.Log(oneObject);
    }

    public override void ShowFull()
    {
        base.ShowFull();
        Debug.Log("ShowFull " + oneObject.count);
    }
}
