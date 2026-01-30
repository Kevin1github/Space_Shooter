using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab; // Hiệu ứng nổ

    // Hàm này tự động chạy khi có vật thể (Is Trigger) bay vào
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    private void Die()
    {
        // 1. Tạo ra hiệu ứng nổ tại vị trí máy bay địch
        if (explosionPrefab != null)
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);

            // 2. Quan trọng: Hủy vụ nổ sau 1 giây (nếu không rác sẽ đầy game)
            Destroy(explosion, 1f);
        }

        // 3. Hủy máy bay địch
        Destroy(gameObject);
    }
}