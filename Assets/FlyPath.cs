using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints;

    // Hàm Reset sẽ tự động tìm tất cả các Waypoint con và gom vào danh sách
    private void Reset() => waypoints = GetComponentsInChildren<Waypoint>();
}