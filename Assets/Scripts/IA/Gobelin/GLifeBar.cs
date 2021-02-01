using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GLifeBar : MonoBehaviour
{
    public Slider _sliderG;

    public void SetMaxLife()
    {
        _sliderG.maxValue = 100;
        _sliderG.value = 100;
    }
    public void SetLife(float _lifeG)
    {
        _sliderG.value = _lifeG;
    }
}
