using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Slider _slider;

    public void SetMaxLife()
    {
        _slider.maxValue = 100;
        _slider.value = 100;
    }
    public void SetLife(float _life)
    {
        _slider.value = _life;
    }
}
