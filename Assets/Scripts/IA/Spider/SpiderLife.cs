using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderLife : MonoBehaviour
{
    [Header("Vie")]
    public static float _lifeSP = 20f;
    public SPLifeBar _lifeBarSP;
    public bool _dieSP = false;

    [Header("Mort")]
    public float _fadeOutTime = 1.0f;
    public int _scoreSP = 20;

    // Start is called before the first frame update
    void Start()
    {
        _lifeSP = 10f;
        _dieSP = false;
    }

    // Update is called once per frame
    void Update()
    {
        _lifeBarSP.SetLife(_lifeSP);

        if(_lifeSP <= 0)
        {
            _dieSP = true;
            MourirSP();
        }
    }

    public void MourirSP()
    {
        if(_dieSP == true)
        {
            Deplacement._speed = 0.0f;
            Score._score = Score._score + _scoreSP;

            StartCoroutine(SpriteFadeOut (GetComponent<SpriteRenderer>()));

            IEnumerator SpriteFadeOut(SpriteRenderer _sprite)
            {
                Color _fadeColor = _sprite.color;

                while(_fadeColor.a > 0f)
                {
                    _fadeColor.a -= Time.deltaTime / _fadeOutTime;
                    _sprite.color = _fadeColor;

                    if(_fadeColor.a <= 0f)
                    {
                        _fadeColor.a = 0f;
                    }

                    yield return null;
                }

                _sprite.color = _fadeColor;
            }

            Destroy(this.gameObject);
        }
    }
}
