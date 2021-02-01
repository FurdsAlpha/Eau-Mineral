using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobelinLife : MonoBehaviour
{
    [Header("Vie")]
    public static float _lifeG = 10f;
    public GLifeBar _lifeBarG;
    public bool _dieG = false;

    [Header("Mort")]
    public float _fadeOutTime = 1.0f;
    public int _scoreG = 5;

    // Start is called before the first frame update
    void Start()
    {
        _lifeG = 10f;
        _dieG = false;
    }

    // Update is called once per frame
    void Update()
    {
        _lifeBarG.SetLife(_lifeG);

        if(_lifeG <= 0)
        {
            _dieG = true;
        }
    }

    public void MourirG()
    {
        if(_dieG == true)
        {
            Deplacement._speed = 0.0f;

            Score._score = Score._score + _scoreG;

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
