using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public int numberOfBounces = 0;
    public GameObject img1000Bounces;

    private void Update()
    {
        if (numberOfBounces == 1000)
        {
            activateImage(img1000Bounces);
            StartCoroutine(hideImage(img1000Bounces));

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Cursor.visible == false)
            {
                Cursor.visible = true;
            }
            else
            {
                Cursor.visible = false;
            }
            Debug.Log(Cursor.visible);
        }
    }
    private void Start()
    {
        Cursor.visible = false;
    }

    private void activateImage(GameObject imageToActivate)
    {
        imageToActivate.SetActive(true);
    }

    private IEnumerator hideImage(GameObject imageTOHide)
    {
        yield return new WaitForSeconds(4f);
        imageTOHide.SetActive(false);

    }
}
