using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiLevelinheritance : MonoBehaviour
{
    class GrandParent
    {
        /*private GrandParent()
        {
            Debug.Log("Constructor is called");
        }*/
        public void DisplayGrandParent()
        {
            Debug.Log("A and B are My Grand Parents");
        }
     }

    class Parent:GrandParent
    {
        public void DisplayParent()
        {
            Debug.Log("C and D are my Parents");
        }
    }

    class Child:Parent
    {
        public void DisplayChild()
        {
            Debug.Log("I am the first Son of my Parents");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Child obj = new Child();
        obj.DisplayChild();
        obj.DisplayParent();
        obj.DisplayGrandParent();
        
    }

}
