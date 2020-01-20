using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Okay : MonoBehaviour
{
    public Text instructor;

    
    void Start()
    {
        Destroy(gameObject, 2);

        instructor.text = "";
    }


    void Update()
    {
        instructor.text = "Quick! Collect the Pizzas";

    }
}
