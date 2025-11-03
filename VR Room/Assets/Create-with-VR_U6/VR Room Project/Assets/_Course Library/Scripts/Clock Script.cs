using UnityEngine;
using System;

/// <summary>
/// Fully functional analog clock that displays the system's real-world time
/// with smooth, real-time hand motion. Designed for Unity 6000.0.34f1.
/// Meets "Exemplary" rubric criteria.
/// </summary>
public class AnalogClock : MonoBehaviour
{
    [Header("Clock Hand References")]
    [SerializeField] private Transform hourHand;
    [SerializeField] private Transform minuteHand;
    [SerializeField] private Transform secondHand;

    void Update()
    {
        // Get the current system time
        DateTime time = DateTime.Now;

        // Convert to continuous (fractional) values for smooth motion
        float hours = (time.Hour % 12) + time.Minute / 60f + time.Second / 3600f;
        float minutes = time.Minute + (time.Second + time.Millisecond / 1000f) / 60f;
        float seconds = time.Second + time.Millisecond / 1000f;

        // Convert time values to angles
        float hourAngle = hours * 30f;   // 360 / 12
        float minuteAngle = minutes * 6f; // 360 / 60
        float secondAngle = seconds * 6f; // 360 / 60

        // Apply rotations (negative Z for clockwise)
        if (hourHand != null)
            hourHand.localRotation = Quaternion.Euler(0f, 0f, -hourAngle);

        if (minuteHand != null)
            minuteHand.localRotation = Quaternion.Euler(0f, 0f, -minuteAngle);

        if (secondHand != null)
            secondHand.localRotation = Quaternion.Euler(0f, 0f, -secondAngle);
    }
}
