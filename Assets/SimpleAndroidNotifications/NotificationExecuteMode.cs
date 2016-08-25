namespace Assets.SimpleAndroidNotifications
{
    public enum NotificationExecuteMode
    {
        /// <summary>
        /// Schedule an alarm.
        /// </summary>
        Schedule = 0, // Schedule an alarm.
        /// <summary>
        /// Schedule an alarm to be delivered precisely at the stated time.
        /// </summary>
        Exact = 1,
        /// <summary>
        /// Like Exact, but this alarm will be allowed to execute even when the system is in low-power idle modes.
        /// </summary>
        ExactAndAllowWhileIdle = 2
    }
}
