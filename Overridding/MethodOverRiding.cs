using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverRiding : MonoBehaviour
{

    class Animal
    {
        public virtual void eat()
        {
            Debug.Log("I can Eat");
        }
        public void walk()
        {
            Debug.Log("I hae either 2 or four legs");
        }
    }

    class Cow : Animal
    {
        public override void eat()
        {
            Debug.Log("I eat grass");
        }
        public void walk()
        {
            Debug.Log("I have four legs");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Cow jersey = new Cow();
        jersey.eat();
        Animal type = jersey;
        type.walk();
        jersey.walk();
        
    }

    
}
