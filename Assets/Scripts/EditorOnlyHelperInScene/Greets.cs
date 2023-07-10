using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greets : MonoBehaviour
{
    [TextArea(3, 10)]
    [SerializeField] private string message;

    private void Awake()
    {
        Debug.LogError($"Message : {message}");
    }
}
