using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{
    public GameObject winPanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f; // Oyunu durdur
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
