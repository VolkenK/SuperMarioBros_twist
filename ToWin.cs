using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToWin : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "win")
        {
            SceneManager.LoadScene(2);
        }
    }
}
