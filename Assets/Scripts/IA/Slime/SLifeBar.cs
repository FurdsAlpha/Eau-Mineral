using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SLifeBar : MonoBehaviour
{
    public Slider _sliderS;

    public void SetMaxLife()
    {
        _sliderS.maxValue = 100;
        _sliderS.value = 100;
    }
    public void SetLife(float _lifeS)
    {
        _sliderS.value = _lifeS;
    }
}
