using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asrfly.Properties;

namespace Asrfly.Code {
    public static class MessageCollections {
        // Message

        public static void ShowEmptyDataMessage() {
            MessageBox.Show(
                Resources.EmptyMessageText,
                Resources.EmptyMessageCaption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        public static void ShowErrorServer() {
            MessageBox.Show(
                Resources.ServerErrorText,
                Resources.ServerErrorCaption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        public static void ShowFieldsRequired() {
            MessageBox.Show(
                Resources.FieldRequiredText,
                Resources.FieldRequiredCaption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        public static void ShowRequiredDeleteRow() {
            MessageBox.Show(
                Resources.ShowDeleteRequiredText,
                Resources.ShowDeleteRequiredCaption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        // Dialog

        public static bool ShowDeleteDialog() {
            var result = MessageBox.Show(
                Resources.DeleteDialogText,
                Resources.DeleteDialogCaption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes) {
                return true;
            } else {
                return false;
            }
        }

        // Notifications 

        public static void ShowAddNotification() {
            Gui.GuiNotification.NotificationForm notificationForm = new Gui.GuiNotification.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية الاضافة بنجاح";
            notificationForm.Show();
        }

        public static void ShowUpdateNotification() {
            Gui.GuiNotification.NotificationForm notificationForm = new Gui.GuiNotification.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية التعديل بنجاح";
            notificationForm.Show();
        }

        public static void ShowDeleteNotification() {
            Gui.GuiNotification.NotificationForm notificationForm = new Gui.GuiNotification.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية الحذف بنجاح";
            notificationForm.Show();
        }


    }
}
