using UnityEngine;

public class PlayerHealth : Health
{
    // Khai báo một biến để chứa màn hình Game Over
    public GameObject gameOverCanvas;

    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died");

        // Bật màn hình Game Over lên khi chết
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true);
        }
    }
}