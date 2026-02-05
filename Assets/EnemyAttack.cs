using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth health; // Tham chiếu đến máu của chính mình [cite: 4619]
    public int damage = 1; // Sát thương gây ra cho Player [cite: 4620]

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem va chạm có phải là Player không
        var playerHealth = collision.GetComponent<PlayerHealth>(); // [cite: 4647]

        if (playerHealth != null)
        {
            // Trừ máu Player
            playerHealth.TakeDamage(damage); // [cite: 4660]

            // Kẻ địch tự nhận 1000 sát thương để chết ngay lập tức
            health.TakeDamage(1000); // [cite: 4661]
        }
    }
}