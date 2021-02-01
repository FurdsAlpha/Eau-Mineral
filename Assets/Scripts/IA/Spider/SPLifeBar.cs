using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SPLifeBar : MonoBehaviour
{
    public Slider _sliderSP;

    public void SetMaxLife()
    {
        _sliderSP.maxValue = 100;
        _sliderSP.value = 100;
    }
    public void SetLife(float _lifeSP)
    {
        _sliderSP.value = _lifeSP;
    }
}
