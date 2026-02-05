using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;
    public int damage = 1; // Sát thương của đạn [cite: 4390]

    void Update()
    {
        // Code bay cũ giữ nguyên...
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Tìm xem vật va chạm có máu không (Cụ thể là EnemyHealth)
        var enemy = collision.GetComponent<EnemyHealth>(); // [cite: 4393]

        if (enemy != null)
        {
            enemy.TakeDamage(damage); // Trừ máu [cite: 4396]
        }

        // Hủy viên đạn sau khi va chạm
        Destroy(gameObject); // [cite: 4398]
    }
}