using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public void PlaySound()
    {
        GetComponent<AudioSource>().Play();

    }
}
