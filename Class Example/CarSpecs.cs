using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpecs : MonoBehaviour
{
    CarClass c1;
    CarClass c2;
    CarClass c3;
    CarClass c4;

    public void Start()
    {

        Debug.Log("Accessing CarClass from Classes script");
        c1 = new CarClass();
        c2 = new CarClass();
        c3 = new CarClass();
        c4 = new CarClass();

        c1.brand = "Lamborghini";
        c1.variant = "Hurracane";
        c1.color = "Red";
        c1.year = 2021;
        c1.Max_Speed = 350.0f;

        c2.brand = "Ferrari";
        c2.variant = "SF90 Stradale";
        c2.color = "yellow";
        c2.year = 2022;
        c2.Max_Speed = 350.0f;

        c3.brand = "Ford";
        c3.variant = "Mustang";
        c3.color = "Blue";
        c3.year = 2022;
        c3.Max_Speed = 400.0f;

        c4.brand = "Aston Martin";
        c4.variant = "DB9 V12";
        c4.color = "Black";
        c4.year = 2020;
        c4.Max_Speed = 300.0f;

        //Call detail function
        c1.Details();
        c2.Details();
        c3.Details();
        c4.Details();
    }
}
