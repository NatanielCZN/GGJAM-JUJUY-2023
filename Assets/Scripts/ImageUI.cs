using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageUI : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
        }
    }
}
