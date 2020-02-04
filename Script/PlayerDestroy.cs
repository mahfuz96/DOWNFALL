using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
            SoundManager.instance.DeathSound();
        SceneManager.LoadScene(2);
    }
}
