using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimmer : MonoBehaviour {
    [SerializeField] private Light _light;
    [SerializeField] private float _speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _light.intensity = Mathf.Lerp(_light.intensity, 0, (float)_speed/100);
        //print(_light.intensity);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Coin")
        {
            StartCoroutine(FadeIn());
            Destroy(collision.gameObject);
        }
    }

    private IEnumerator FadeIn()
    {
        for (int i = 0; i < 800 * _speed / 3; i++)
        {
            _light.intensity += (float)_speed / 100 * 2;
            yield return new WaitForEndOfFrame();
        }
        yield return null;
    }
}
