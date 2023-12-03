using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //zorgt er voor dat de audio loopt en niet vernietigd
    public static AudioManager instance;
    //zorgt er voor dat de audio loopt en niet vernietigd wanneer dat je de scene opwekt
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
