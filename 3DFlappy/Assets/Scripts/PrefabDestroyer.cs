using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDestroyer : MonoBehaviour
{
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            print("Coin");
        }
        Destroy(other.gameObject);
    }
}
