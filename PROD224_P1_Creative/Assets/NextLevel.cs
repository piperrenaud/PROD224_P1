using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject UI;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        UI.SetActive(true);

        yield return new WaitForSeconds(2.5f);

        if (other.CompareTag("Player"))
        {
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentIndex + 1);
        }
    }
}
