using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 30f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or wasd");
        Debug.Log("Don't bump into objects!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(xValue, yValue, zValue);
    }
}
