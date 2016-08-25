using System;
using UnityEngine;

namespace Assets.SimpleAndroidNotifications
{
    public static class NotificationManager
    {
        #if UNITY_ANDROID && !UNITY_EDITOR

        private const string FullClassName = "com.hippogames.simpleandroidnotifications.Controller";
        private const string MainActivityClassName = "com.unity3d.player.UnityPlayerNativeActivity";

        #endif

        /// <summary>
        /// Schedule simple notification without app icon.
        /// </summary>
        /// <param name="smallIcon">List of build-in small icons: notification_icon_bell (default), notification_icon_clock, notification_icon_heart, notification_icon_message, notification_icon_nut, notification_icon_star, notification_icon_warning.</param>
        public static void Send(TimeSpan delay, string title, string message, Color color, string smallIcon = "notification_icon_bell")
        {
            SendCustom(new NotificationParams
            {
                Id = NotificationIdHandler.GetNotificationId(),
                Delay = delay,
                Title = title,
                Message = message,
                Ticker = message,
                Sound = true,
                Vibrate = true,
                Lights = true,
                SmallIcon = smallIcon,
                LargeIcon = "",
                Color = color,
                Mode = NotificationExecuteMode.Schedule
            });
        }

        /// <summary>
        /// Schedule notification with app icon.
        /// </summary>
        /// <param name="smallIcon">List of build-in small icons: notification_icon_bell (default), notification_icon_clock, notification_icon_heart, notification_icon_message, notification_icon_nut, notification_icon_star, notification_icon_warning.</param>
        public static void SendWithAppIcon(TimeSpan delay, string title, string message, Color color, string smallIcon = "notification_icon_bell")
        {
            SendCustom(new NotificationParams
            {
                Id = NotificationIdHandler.GetNotificationId(),
                Delay = delay,
                Title = title,
                Message = message,
                Ticker = message,
                Sound = true,
                Vibrate = true,
                Lights = true,
                SmallIcon = smallIcon,
                LargeIcon = "app_icon",
                Color = color,
                Mode = NotificationExecuteMode.Schedule
            });
        }

        /// <summary>
        /// Schedule customizable notification.
        /// </summary>
        public static void SendCustom(NotificationParams notificationParams)
        {
            #if UNITY_ANDROID && !UNITY_EDITOR

            var p = notificationParams;
            var color = (Color32) p.Color;
            var delay = (long) p.Delay.TotalMilliseconds;
            var colorInt = color.r * 65536 + color.g * 256 + color.b;

            new AndroidJavaClass(FullClassName).CallStatic("SetNotification", p.Id, delay, p.Title, p.Message, p.Ticker,
                p.Sound ? 1 : 0, p.Vibrate ? 1 : 0, p.Lights ? 1 : 0, p.LargeIcon, p.SmallIcon, colorInt, (int) p.Mode, MainActivityClassName);
            
            NotificationIdHandler.AddScheduledNotificaion(p.Id);

            #else

            Debug.LogWarning("Notifications don't work in editor. Build and play this scene on android device!");

            #endif
        }

        /// <summary>
        /// Cancel notification by id.
        /// </summary>
        public static void Cancel(int id)
        {
            #if UNITY_ANDROID && !UNITY_EDITOR

            new AndroidJavaClass(FullClassName).CallStatic("CancelNotification", id);

            NotificationIdHandler.RemoveScheduledNotificaion(id);

            #endif
        }

        /// <summary>
        /// Cancel all notifications.
        /// </summary>
        public static void CancelAll()
        {
            foreach (var id in NotificationIdHandler.GetScheduledNotificaions())
            {
                Cancel(id);
            }
        }
    }
}