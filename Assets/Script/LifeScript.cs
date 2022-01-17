using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LifeScript : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        //fill.color=gradient.Evaluate(1f);
    }
    public void SetHealth(int health)
    {
        slider.value = health;
        //Debug.Log("체력 세팅");
        //fill.color = gradient.Evaluate(slider.normalizedValue);
        //Debug.Log(slider.normalizedValue);
    }
}
