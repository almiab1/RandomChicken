using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_controller : MonoBehaviour
{
    public Text bounceText;
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        bounceText.text = gameManager.numberOfBounces.ToString();
    }
}
