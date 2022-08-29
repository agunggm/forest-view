using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _bgmAudioSource;
    public bool isAudioEnabled = false;
     private static AudioManager _instance;

    public static AudioManager Instance { get { return _instance; } }
    private void Awake() 
    {   
       if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
            DontDestroyOnLoad(this);
        }
    }
    public void PlayBgm()
    {
        _bgmAudioSource[Random.Range(0, _bgmAudioSource.Count)].Play();
    }
}
