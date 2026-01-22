using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f; // Tốc độ bay (PDF để 5 nhưng 10 bắn mới sướng)

    void Update()
    {
        // Lấy vị trí hiện tại
        Vector3 pos = transform.position;

        // Cộng thêm quãng đường theo trục Y (hướng lên)
        // Time.deltaTime giúp đạn bay đều trên mọi cấu hình máy
        pos.y += flySpeed * Time.deltaTime;

        // Gán lại vị trí mới
        transform.position = pos;

        // [Mẹo thêm của chuyên gia]
        // Tự hủy sau 2 giây để đỡ nặng máy (nếu bay khỏi màn hình)
        Destroy(gameObject, 2f);
    }
}