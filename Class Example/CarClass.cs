using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarClass
{
    public string brand;
    public string variant;
    public string color;
    public int year;
    public float Max_Speed;

    public void Details()
    {
        Debug.Log("Car brand is : " +brand);
        Debug.Log("The variant is: " +variant);
        Debug.Log("Car Color is : " +color);
        Debug.Log("Year of Manufacture is : " +year);
        Debug.Log("top Speed of the car is : " +Max_Speed);
    }
}
