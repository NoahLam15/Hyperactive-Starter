using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        DaveController controller = other.GetComponent<DaveController>();

        if (controller != null)
        {
            if(controller.score  < controller.maxScore)
            {
                controller.ChangeScore(1);
                Destroy(gameObject);
            }
        }
    }
}