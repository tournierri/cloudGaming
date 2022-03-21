using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void RetryButton()
    {
        Inventory.instance.RemoveCoins();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayerHealth.instance.Respawn();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
