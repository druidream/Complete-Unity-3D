using System.Diagnostics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    [SerializeField] int hitPoints = 3;
    [SerializeField] int scoreValue = 10;

    Scoreboard scoreboard;

    private void Start()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        hitPoints--;

        if (hitPoints <= 0)
        {
            scoreboard.IncreaseScore(scoreValue);
            Instantiate(destroyedVFX, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
