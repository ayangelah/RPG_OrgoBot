using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintRecharge : MonoBehaviour
{
    [SerializeField] GameObject neutral;
    [SerializeField] GameObject eyes;

    [SerializeField] public const float cooldownTime = 15;
    [SerializeField] private float timePast = 0f;
    [SerializeField] private Slider slider;
    [SerializeField] private Gradient batteryGradient;
    [SerializeField] private Image fill;
    public bool hintReady;

    private void Update()
    {
        slider.value = CalculateSliderValue();

        if (slider.value == 1)
        {
            //stop the count
            //Debug.Log("cooldown done.");
            fill.color = batteryGradient.Evaluate(1f);
            gameObject.SetActive(false);
            neutral.SetActive(true);
            eyes.SetActive(true);
            hintReady = true;
        }
        else if (timePast < cooldownTime)
        {
            hintReady = false;
            timePast += Time.deltaTime;
            fill.color = batteryGradient.Evaluate(slider.value);
        }
    }

    float CalculateSliderValue()
    {
        return (timePast / cooldownTime);
    }
}
