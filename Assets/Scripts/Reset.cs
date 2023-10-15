using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Reset : MonoBehaviour
{
    public GameObject  Trap;

    public void OnTriggerEnter(Collider col)
    {
        
        if (col.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
