using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour,Addition,Subtraction,Multiplicatin,Division
{
    float result1,result2,result3,result4;
    
    public float add(int a, int b)
    {
        return result1 = a + b;
    }
    public float sub(int a, int b)
    {
        return result2 = a - b;
    }
    public float mult(int a, int b)
    {
        return result3 = a*b;
    }
    public float div(int a, int b)
    {
        return result4 = a/b;
    }

    void display()
    {
        Debug.Log("The Sum is :" + result1);
        Debug.Log("The sub is :" + result2);
        Debug.Log("The div is :" + result3);
        Debug.Log("The mul is :" + result4);
    }


    private void Start()
    {
        Calculator calc = new Calculator();
        calc.add(10, 2);
        calc.sub(20, 1);
        calc.mult(10, 2);
        calc.div(20, 1);
        calc.display();


    }
}
