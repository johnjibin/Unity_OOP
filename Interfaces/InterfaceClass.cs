using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceClass : MonoBehaviour,test
{
    

    private void Start()
    {
        InterfaceClass obj = new InterfaceClass();
        obj.display();
    }
    public void display()
    {
        Debug.Log("Implementation");
    }

}
