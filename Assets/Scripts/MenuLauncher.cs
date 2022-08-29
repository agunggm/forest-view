using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLauncher : MonoBehaviour
{
    [SerializeField] private Button _playAudioButton;
    [SerializeField] private Button _playNoAudioButton;
    // Start is called before the first frame update
    void Start()
    {
        _playAudioButton.onClick.RemoveAllListeners();
        _playNoAudioButton.onClick.RemoveAllListeners();
        _playAudioButton.onClick.AddListener(OnWithAudioButtonClicked);
        _playNoAudioButton.onClick.AddListener(OnWithoutAudioButtonClicked);
    }
    private void OnWithAudioButtonClicked()
        {
            
            AudioManager.Instance.isAudioEnabled = true;
            SceneManager.LoadScene("Game");
        }
        private void OnWithoutAudioButtonClicked()
        {
            
            AudioManager.Instance.isAudioEnabled = false;
            SceneManager.LoadScene("Game");
        }
}
