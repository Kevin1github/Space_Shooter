using UnityEngine;
using UnityEngine.SceneManagement; // Bổ sung thư viện này để load scene

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameWinUI; // Khai báo UI Game Win [cite: 139]
    public PlayerHealth playerHealth;
    public GameObject bgMusic;
    public GameObject winCanvas;

    private void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);  // Ẩn UI Game Win lúc mới vào [cite: 148]
        playerHealth.onDead += OnGameOver;
    }

    void Update()
    {
        // ĐIỀU KIỆN THẮNG: Đã đẻ xong hết các đợt VÀ không còn con quái nào sống sót
        if (EnemySpawner.isAllWavesSpawned == true && GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            if (winCanvas != null)
            {
                winCanvas.SetActive(true);
            }
        }
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
    }

    private void OnGameWin()
    {
        gameWinUI.SetActive(true); 
        bgMusic.SetActive(false);
        playerHealth.gameObject.SetActive(false); // Ẩn máy bay của mình đi [cite: 156]
    }

    // Hàm này sẽ được gán vào nút bấm để quay về Main Menu [cite: 215, 219]
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}