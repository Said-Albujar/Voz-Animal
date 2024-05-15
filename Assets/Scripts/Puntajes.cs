using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Puntajes : MonoBehaviour
{
    public int points = 0;
    public int Maxooints = 0;
    public TextMeshProUGUI pointsText;

    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = " " + points.ToString() + "/" + Maxooints.ToString();
    }
}
