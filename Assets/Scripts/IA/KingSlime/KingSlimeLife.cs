using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingSlimeLife : MonoBehaviour
{
    [Header("Vie")]
    public static float _lifeKS = 50f;
    public KSLifeBar _lifeBarKS;
    public bool _dieKS = false;

    [Header("Mort")]
    public float _fadeOutTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        _lifeKS = 50f;
        _dieKS = false;
    }

    // Update is called once per frame
    void Update()
    {
        _lifeBarKS.SetLife(_lifeKS);

        if(_lifeKS <= 0)
        {
            _dieKS = true;
        }
    }

    public void MourirKS()
    {
        if(_dieKS == true)
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
