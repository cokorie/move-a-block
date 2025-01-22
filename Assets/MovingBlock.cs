using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;

    float startingYPosition;
    public static int Score;
    public static int HighScore;

    void Start()
    {
        startingYPosition = transform.position.y;
        Score = 0;
    } 

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        if(transform.position.x <= -10)
        {
            transform.position += Vector3.right * 30f;
            float newY = startingYPosition + UnityEngine.Random.Range(-2f, 2f);
            transform.position = new Vector3(transform.position.x, newY, 0f);
            Score++;
            if (Score > HighScore)
            {
                HighScore = Score;
            }
        }
    }
}
