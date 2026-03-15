using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public RectTransform mask; // Chứa thanh màu vàng cần thu nhỏ
    public Health health;      // Chứa thông tin máu của Player
    private float originalWidth;

    void Start()
    {
        // Lưu lại chiều dài ban đầu của thanh máu
        originalWidth = mask.sizeDelta.x;
        
        UpdateHealthValue();
        // Đăng ký: Mỗi khi máu đổi, hãy chạy hàm UpdateHealthValue
        health.onHealthChanged += UpdateHealthValue; 
    }

    private void UpdateHealthValue()
    {
        // Tính tỷ lệ % máu còn lại
        float scale = (float)health.healthPoint / health.defaultHealthPoint;
        // Chỉnh lại chiều dài của thanh màu vàng theo tỷ lệ
        mask.sizeDelta = new Vector2(scale * originalWidth, mask.sizeDelta.y);
    }
}