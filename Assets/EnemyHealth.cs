using UnityEngine;

// Thay vì : MonoBehaviour, ta đổi thành : Health
public class EnemyHealth : Health
{
    // Ghi đè hàm Die để thêm log hoặc tính điểm
    protected override void Die()
    {
        base.Die(); // Gọi logic nổ và destroy của cha [cite: 4346]
        Debug.Log("Enemy died"); // [cite: 4347]
    }
}