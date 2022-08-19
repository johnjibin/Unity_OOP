using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivateModifier : MonoBehaviour
{
   Derived obj;
   class Modifier
    {

        protected int x = 10;
        private int y = 11; // Only be accessed by Member or Friend functions
        public void Display()
        {
            Debug.Log("The value of X is: " + x);
            Debug.Log("The value of Y is: " + y); 
        }
    }

    class Derived:Modifier
    {
        
        public void Display2()
        {
            x += 10;
           //y += 10; ->Inaccessible due to protection
            Debug.Log("The Value inherited from base class is: "+x);
        }
        
    }
    
    

        private void Start()
    {
        Debug.Log("Testing");
        obj = new Derived();
    
        obj.Display();
        obj.Display2();
    }
}
