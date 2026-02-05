using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died"); // [cite: 4336]
        // Sau này có thể thêm logic Game Over ở đây
    }
}