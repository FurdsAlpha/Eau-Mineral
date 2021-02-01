using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [Header("Vie")]
    public static float _life = 100f;
    public LifeBar _lifeBar;
    public bool _die = false;

    [Header("Mort")]
    public float _fadeOutTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        _life = 100f;
        _die = false;
    }

    // Update is called once per frame
    void Update()
    {
        _lifeBar.SetLife(_life);

        if(_life <= 0)
        {
            _die = true;
            Mourir();
        }
    }

    public void Mourir()
    {
        if(_die == true)
        {
            Deplacement._speed = 0.0f;

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
