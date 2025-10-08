using UnityEngine;

public class Finished : MonoBehaviour
{
    public GameObject UICanvas;

    private void OnTriggerEnter(Collider other)
    {
        UICanvas.SetActive(true);
    }
}
