using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeirararchicalInheritance : MonoBehaviour
{
     class Parent
    {
        public void ParentDisplay()
        {
            Debug.Log("A and B are My parents");
        }
    }
    class SonA:Parent
    {
        public void FirstSon()
        {
            Debug.Log("I am the First Son SonA");
        }
    }
    class SonB:Parent
    {
        public void SecondSon()
        {
            Debug.Log("I am the Second Son SonB");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        SonA obj1 = new SonA();
        SonB obj2 = new SonB();

        obj1.FirstSon();
        obj1.ParentDisplay();
        obj2.SecondSon();
        obj2.ParentDisplay();
    }

}
