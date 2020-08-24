using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mockup_Human : IMockup
{
    public int age;
    public int count;

    public void Initialization(int count)
    {
        age = Random.Range(0, 100);
        this.count = count;
    }
}
