using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Вернет последний объект коллекции если она не null и количество объектов больше нуля. Так же можно установить условие 
/// и тогда вернет последнее значение, соответствующее условию
/// </summary>
public class Train_Last : BaseTrain
{
    public override void FullWriting()
    {
        oneObject = (from item in list
                     select item
                     ).Last();
    }

    public override void ExtensionWriting()
    {
        oneObject = list.Last(x => x.count < 5);
    }


    public override void ShowExtension()
    {
        base.ShowExtension();
        Debug.Log("ShowExtension " + oneObject.count);
    }

    public override void ShowFull()
    {
        base.ShowFull();
        Debug.Log("ShowFull " + oneObject.count);
    }
}
