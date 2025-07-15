using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerRespawn : MonoBehaviour
{
  public void Respawn()
    {
        // Şu anki sahneyi tekrar yükle
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
