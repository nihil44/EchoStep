using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Öldün!");
            PlayerRespawn respawn = other.GetComponent<PlayerRespawn>();
            if (respawn != null)
            {
                Invoke(nameof(RestartScene), 2f);
            }
        }
    }

    void RestartScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
