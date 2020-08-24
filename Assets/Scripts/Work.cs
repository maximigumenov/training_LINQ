using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : MonoBehaviour
{
    private IBase_LINQ example = new Train_LastOrDefault();
    // Start is called before the first frame update

    void Start()
    {
        example.CheckWays();
    }

    
}
