using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải có dòng này

public class GameOverManager : MonoBehaviour
{
    // Hàm này sẽ gọi khi bấm nút Return
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}