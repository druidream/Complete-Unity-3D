using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;

    GameSceneManager gameSceneManager;

    private void Start()
    {
        gameSceneManager = FindFirstObjectByType<GameSceneManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Hit: " + other.name);
        // Debug.Log($"Hit: {other.name}");
        gameSceneManager.ReloadLevel();
        Instantiate(destroyedVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
