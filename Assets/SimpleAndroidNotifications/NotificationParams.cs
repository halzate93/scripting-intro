using System;
using UnityEngine;

namespace Assets.SimpleAndroidNotifications
{
    public class NotificationParams
    {
        /// <summary>
        /// Use random id for each new notification.
        /// </summary>
        public int Id;
        public TimeSpan Delay;
        public string Title;
        public string Message;
        public string Ticker;
        public bool Sound;
        public bool Vibrate;
        public bool Lights;
        /// <summary>
        /// Use "notification_icon_small" to use build-in image. Use custom value but first place image to "simple-android-notifications.aar/res/". To modify "aar" file just rename it to "zip" and back.
        /// </summary>
        public string SmallIcon;
        /// <summary>
        /// Use "" for simple notification. Use "app_icon" to use app icon. Use custom value but first place image to "simple-android-notifications.aar/res/". To modify "aar" file just rename it to "zip" and back.
        /// </summary>
        public string LargeIcon;
        public Color Color;
        public NotificationExecuteMode Mode;
    }
}