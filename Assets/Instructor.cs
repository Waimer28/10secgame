using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructor : MonoBehaviour
{
    public Text instructor;

    public AudioSource musicSource;

    void Start()
    {
        Destroy(gameObject, 2);

        instructor.text = "";
    }


    void Update()
    {
        instructor.text = "Quick! Collect the Pizzas";

        musicSource.Play();

        musicSource.loop = false;
    }
}