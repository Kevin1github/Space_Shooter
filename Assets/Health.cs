using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab; // [cite: 4354]
    public int defaultHealthPoint = 3; // Máu mặc định [cite: 4369]
    private int healthPoint;

    // Start gán máu ban đầu
    private void Start()
    {
        healthPoint = defaultHealthPoint; // [cite: 4371]
    }

    // Hàm nhận sát thương
    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;

        if (healthPoint <= 0)
        {
            Die(); // [cite: 4376]
        }
    }

    // Hàm xử lý va chạm (dùng chung cho cả Player và Enemy)
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Logic va chạm sẽ xử lý ở các script khác (Bullet/EnemyAttack)
        // Nhưng nếu muốn chết ngay khi chạm thì gọi Die() ở đây
    }

    // Hàm chết (cho phép lớp con ghi đè - virtual)
    protected virtual void Die()
    {
        // Tạo hiệu ứng nổ
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f); // [cite: 4360]
        }

        // Hủy đối tượng
        Destroy(gameObject); // [cite: 4361]
    }
}