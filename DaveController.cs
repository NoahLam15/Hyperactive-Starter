using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaveController : MonoBehaviour
{
    public float speed = 4.0f;
    
    public int maxScore = 10;
    
    int currentScore;
    public int score { get { return currentScore; }}
    
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }

    public void ChangeScore(int amount)
    {
        currentScore = Mathf.Clamp(currentScore + amount, 0, maxScore);
        Debug.Log(currentScore + "/" + maxScore);
    }
}
