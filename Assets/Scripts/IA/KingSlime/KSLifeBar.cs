using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KSLifeBar : MonoBehaviour
{
    public Slider _sliderKS;

    public void SetMaxLife()
    {
        _sliderKS.maxValue = 100;
        _sliderKS.value = 100;
    }
    public void SetLife(float _lifeKS)
    {
        _sliderKS.value = _lifeKS;
    }
}
