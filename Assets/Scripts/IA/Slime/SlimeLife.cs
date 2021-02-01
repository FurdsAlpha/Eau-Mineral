using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeLife : MonoBehaviour
{
    [Header("Vie")]
    public static float _lifeS = 5f;
    public SLifeBar _lifeBarS;
    public bool _dieS = false;

    [Header("Mort")]
    public float _fadeOutTime = 1.0f;
    public int _scoreS = 1;

    // Start is called before the first frame update
    void Start()
    {
        _lifeS = 10f;
        _dieS = false;
    }

    // Update is called once per frame
    void Update()
    {
        _lifeBarS.SetLife(_lifeS);

        if(_lifeS <= 0)
        {
            _dieS = true;
        }
    }

    public void MourirS()
    {
        if(_dieS == true)
        {
            Deplacement._speed = 0.0f;
            Score._score = Score._score + _scoreS;

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
