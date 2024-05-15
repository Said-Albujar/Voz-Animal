using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mascotas : MonoBehaviour
{
    public Slider fillImage;
    public float fillSpeed = 0.5f;
    public float maxFillAmount = 1.0f;
    public GameObject Mascota;

    private float currentFillAmount = 0.0f;
    private bool isFilling = false;
    private bool point = false;


    private Puntajes puntajes;

    void Start()
    {
        puntajes = FindObjectOfType<Puntajes>();
        currentFillAmount = 0.0f; // Empezamos desde cero
        fillImage.value = currentFillAmount; // Actualizamos la imagen
        isFilling = true; // Empezamos a llenar la imagen
    }

    void Update()
    {
        if (isFilling && currentFillAmount < maxFillAmount)
        {
            currentFillAmount += fillSpeed * Time.deltaTime;
            fillImage.value = Mathf.Clamp01(currentFillAmount);
        }

        if(fillImage.value == 1 && !point)
        {
            puntajes.points++;
            point = true;
            Destroy(gameObject);
            Destroy(Mascota);
        }
    }
}
