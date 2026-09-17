using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int numOfMusicPlayers = FindObjectsByType<MusicPlayer>(FindObjectsSortMode.None).Length;
        if (numOfMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
