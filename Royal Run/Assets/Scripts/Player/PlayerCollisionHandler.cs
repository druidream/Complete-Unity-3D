using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] float collisionCooldown = 1f;
    [SerializeField] float adjustChangeMoveSpeedAmount = -2f;
    LevelGenerator levelGenerator;

    const string hitString = "Hit";

    float cooldownTimer = 0f;

    void Start()
    {
        levelGenerator = FindFirstObjectByType<LevelGenerator>();
    }

    void Update()
    {
        cooldownTimer += Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (cooldownTimer < collisionCooldown) return;

        // Debug.Log(collision.gameObject.name);
        animator.SetTrigger(hitString);
        cooldownTimer = 0f;

        levelGenerator.ChangeChunkMoveSpeed(adjustChangeMoveSpeedAmount);
    }
}
